using CvDayNightClassifier.Core.DTO;
using Emgu.CV.CvEnum;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace CvDayNightClassifier.Core.Classifiers
{
    public class DayNightClassifier
    {
        private int _blurValue = 13;

        private int _dilateHightlightSize = 11;

        private int _highlightThreshold = 250;

        private int _darkTimeThreshold = 100;

        public DayNightClassifierResultDTO ClassifyImage(string pathToImage)
        {
            Mat grayMat = new Mat(pathToImage, ImreadModes.Grayscale);

            Mat blurMat = new Mat();
            CvInvoke.MedianBlur(grayMat, blurMat, _blurValue);

            Mat highlightBinaryMask = GetHighlightBinaryMask(blurMat);

            Mat removedHighlightMat = new Mat();
            CvInvoke.BitwiseAnd(blurMat, blurMat, removedHighlightMat, highlightBinaryMask);

            Mat hsvMat = ConvertGrayToHSV(grayMat);
            var result = GetClassifierResult(hsvMat);

            return result;
        }

        private DayNightClassifierResultDTO GetClassifierResult(Mat hsvMat)
        {
            Mat[] channels = hsvMat.Split();

            MCvScalar channelsMeanValues = CvInvoke.Mean(hsvMat);
            var result = new DayNightClassifierResultDTO();
            result.HueValue = channelsMeanValues.V0;
            result.SaturationValue = channelsMeanValues.V1;
            result.BrightnessValue = channelsMeanValues.V2;
            result.DayNightClassification = result.BrightnessValue > _darkTimeThreshold
                ? DayNightClassification.DAY
                : DayNightClassification.NIGHT;

            return result;
        }

        private Mat ConvertGrayToHSV(Mat grayMat)
        {
            Mat bgrMat = new Mat();
            CvInvoke.CvtColor(grayMat, bgrMat, ColorConversion.Gray2Bgr);

            Mat hsvMat = new Mat();
            CvInvoke.CvtColor(bgrMat, hsvMat, ColorConversion.Bgr2Hsv);

            return hsvMat;
        }

        private Mat GetHighlightBinaryMask(Mat srcMat)
        {
            var highlightBinaryMask = new Mat();
            CvInvoke.Threshold(srcMat, highlightBinaryMask, _highlightThreshold, 255, ThresholdType.Binary);

            var dilateCore = CvInvoke.GetStructuringElement(ElementShape.Rectangle,
                new Size(_dilateHightlightSize, _dilateHightlightSize), 
                new Point(2, 2));

            Mat dilatedMat = new Mat();
            CvInvoke.Dilate(highlightBinaryMask, dilatedMat, dilateCore,
                new Point(-1, -1), 1, BorderType.Default, new MCvScalar(255, 255, 255));

            CvInvoke.Imshow("dil", dilatedMat);

            Mat invertedMask = new Mat();
            CvInvoke.BitwiseNot(dilatedMat, invertedMask);

            return invertedMask;
        }
    }
}

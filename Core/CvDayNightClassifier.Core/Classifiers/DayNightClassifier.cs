using CvDayNightClassifier.Core.DTO;
using Emgu.CV.CvEnum;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace CvDayNightClassifier.Core.Classifiers
{
    public class DayNightClassifier
    {
        private int _blurValue = 11;

        private int _dilateHightlightSize = 15;

        private int _highlightThreshold = 250;

        private int _darkTimeThreshold = 50;

        public DayNightClassifierResultDTO ClassifyImage(string pathToImage)
        {
            Mat grayMat = new Mat(pathToImage, ImreadModes.Grayscale);

            Mat removedHighlightMat = RemoveHighlight(grayMat);

            Mat hsvMat = ConvertGrayToHSV(removedHighlightMat);

            var result = GetClassifierResult(hsvMat);

            return result;
        }

        private DayNightClassifierResultDTO GetClassifierResult(Mat hsvMat)
        {
            Mat[] channels = hsvMat.Split();

            MCvScalar channelsMeanValues = CvInvoke.Mean(hsvMat);
            var result = new DayNightClassifierResultDTO();
            result.HueValue        = channelsMeanValues.V0;
            result.SaturationValue = channelsMeanValues.V1;
            result.BrightnessValue = channelsMeanValues.V2;
            result.DayNightClassification = result.BrightnessValue > _darkTimeThreshold
                ? DayNightClassification.DAY
                : DayNightClassification.NIGHT;

            Mat bgrHighlighMask = new Mat();
            CvInvoke.CvtColor(hsvMat, bgrHighlighMask, ColorConversion.Hsv2Bgr);

            result.HighlightMask = bgrHighlighMask;

            return result;
        }

        private Mat RemoveHighlight(Mat srcMat)
        {
            Mat blurMat = new Mat();
            CvInvoke.MedianBlur(srcMat, blurMat, _blurValue);

            Mat highlightBinaryMask = GetHighlightBinaryMask(blurMat);
            Mat darkTimeMask        = GetDarkTimeMask(blurMat);

            Mat overlayedMat = new Mat();
            CvInvoke.BitwiseAnd(blurMat, darkTimeMask, overlayedMat, highlightBinaryMask);

            return overlayedMat;
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

            var dilateCore = CvInvoke.GetStructuringElement(ElementShape.Ellipse,
                new Size(_dilateHightlightSize, _dilateHightlightSize), 
                new Point(2, 2));

            Mat dilatedMat = new Mat();
            CvInvoke.Dilate(highlightBinaryMask, dilatedMat, dilateCore,
                new Point(-1, -1), 3, BorderType.Default, new MCvScalar(255, 255, 255));

            Mat invertedMask = new Mat();
            CvInvoke.BitwiseNot(dilatedMat, invertedMask);

            return invertedMask;
        }

        private Mat GetDarkTimeMask(Mat srcMat)
        {
            Mat darkTimeMask = new Mat();
            CvInvoke.Threshold(srcMat, darkTimeMask, _darkTimeThreshold, 255, ThresholdType.Binary);
            return darkTimeMask;
        }
    }
}

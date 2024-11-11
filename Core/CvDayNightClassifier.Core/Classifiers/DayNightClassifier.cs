using CvDayNightClassifier.Core.DTO;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using System.IO;
using System.Threading.Tasks;

namespace CvDayNightClassifier.Core.Classifiers
{
    public class DayNightClassifier
    {
        private int _dilationCoreSize = 7;

        private int _medianBlurKsize = 23;

        private int _binaryThreshold = 250;

        private int _darkTimeThreshold = 100;

        public DayNightClassifierResultDTO ClassifyImage(string pathToImage)
        {
            var result = new DayNightClassifierResultDTO();

            Mat mat = new(pathToImage, ImreadModes.Grayscale);
            Mat blurMat = new();

            CvInvoke.MedianBlur(mat, blurMat, _medianBlurKsize);

            Mat otsuMask = GetBinaryMask(blurMat, _binaryThreshold, ThresholdType.Otsu); // too illuminated areas
            Mat darkTimeMask = GetBinaryMask(blurMat, _darkTimeThreshold, ThresholdType.Binary);

            Mat resultMask = new Mat();
            CvInvoke.BitwiseOr(otsuMask, darkTimeMask, resultMask);

            Mat resultMat = new Mat();

            CvInvoke.BitwiseAnd(mat, mat, resultMat, resultMask);
            CvInvoke.Imshow("result", resultMat);

            Mat hsv = new Mat();

            CvInvoke.CvtColor(resultMat, resultMat, ColorConversion.Gray2Bgr);
            CvInvoke.CvtColor(resultMat, hsv, ColorConversion.Bgr2Hsv);

            Mat[] channels = hsv.Split();

            MCvScalar mean = CvInvoke.Mean(hsv);

            result.HueValue = mean.V0;
            result.SaturationValue = mean.V1;
            result.BrightnessValue = mean.V2;
            result.DayNightClassification = result.BrightnessValue > _darkTimeThreshold 
                ? DayNightClassification.DAY 
                : DayNightClassification.NIGHT;

            return result;
        }

        private Mat GetBinaryMask(Mat mat, int threshold, ThresholdType thresholdType)
        {
            var grayMat = mat;

            var binaryMat = new Mat();
            CvInvoke.Threshold(grayMat, binaryMat, threshold,
                255, thresholdType);

            return binaryMat;
        }
    }
}

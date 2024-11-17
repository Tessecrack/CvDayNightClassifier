using CvDayNightClassifier.Core.DTO;
using Emgu.CV.CvEnum;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace CvDayNightClassifier.Core.Classifiers
{
    public class DayNightClassifier
    {
        /// <summary>
        /// Размер ядра медианного блюра.
        /// </summary>
        private readonly int _blurValue = 11; // ТОЛЬКО НЕЧЕТНЫЕ

        /// <summary>
        /// Размер ядра дилатации для применения на бинарной маске засветов.
        /// </summary>
        private readonly int _dilateHightlightSize = 15;

        /// <summary>
        /// Высокий порог бинаризации (предполагаемые засветы).
        /// </summary>
        private readonly int _highlightThreshold = 250;

        /// <summary>
        /// Низкий порог бинаризации (предполагаемая ночь).
        /// </summary>
        private readonly int _darkTimeThreshold = 50;

        /// <summary>
        /// Значение классификации день/ночь. Меньше - ночь, больше - день.
        /// </summary>
        private readonly int _darkTimeClassifyValue = 65;

        /// <summary>
        /// Метод классификации день/ночь по изображению.
        /// </summary>
        /// <param name="pathToImage">Путь к изображению.</param>
        /// <returns>Объект, содержащий результат классификации, значение яркости, итоговую маску засветов.</returns>
        public DayNightClassifierResultDTO ClassifyImage(string pathToImage)
        {
            Mat grayMat = new Mat(pathToImage, ImreadModes.Grayscale);

            return ClassifyImageImpl(grayMat);
        }

        private DayNightClassifierResultDTO ClassifyImageImpl(Mat grayMat)
        {
            Mat bluredMat = new Mat();
            CvInvoke.MedianBlur(grayMat, bluredMat, 3);
            Mat removedHighlightsMat = RemoveHighlights(bluredMat);

            var result = GetClassifierResult(removedHighlightsMat);

            return result;
        }

        private Mat RemoveHighlights(Mat grayMat)
        {
            Mat binaryMat = new Mat();

            CvInvoke.Threshold(grayMat, binaryMat, _darkTimeThreshold, 255, ThresholdType.Binary);

            CvInvoke.Imshow("bin", binaryMat);

            return binaryMat;
        }

        private DayNightClassifierResultDTO GetClassifierResult(Mat removedHighlighsMat)
        {
            var result = new DayNightClassifierResultDTO();

            result.DayNightClassification = DayNightClassification.DAY;
            result.RemovedHighlightImage = removedHighlighsMat;

            return result;
        }
    }
}

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
            Mat removedHighlightsMat = RemoveHighlights(grayMat);

            var result = GetClassifierResult(removedHighlightsMat);

            return result;
        }

        /// <summary>
        /// Классифицирует входную матрицу в оттенках серого.
        /// </summary>
        /// <param name="grayMat">Матрица в оттенках серого.</param>
        /// <returns>Объект, содержащий результат классификации, значение яркости, итоговую маску засветов.</returns>
        private DayNightClassifierResultDTO GetClassifierResult(Mat grayMat)
        {
            MCvScalar channelsMeanValues = CvInvoke.Mean(grayMat);
            var result = new DayNightClassifierResultDTO();
            result.BrightnessValue = channelsMeanValues.V0;
            result.DayNightClassification = result.BrightnessValue > _darkTimeClassifyValue
                ? DayNightClassification.DAY
                : DayNightClassification.NIGHT;

            result.RemovedHighlightImage = grayMat;

            return result;
        }

        /// <summary>
        /// Удаление засветов.
        /// </summary>
        /// <param name="srcMat">Изображение в оттенках серого.</param>
        /// <returns>Матрица без засветов.</returns>
        private Mat RemoveHighlights(Mat srcMat)
        {
            Mat blurMat = new Mat();
            CvInvoke.MedianBlur(srcMat, blurMat, _blurValue);

            // получение маски засветов (черное - засвет)
            Mat highlightsBinaryMask = GetHighlightBinaryMask(blurMat);

            // маска с низким порогом (_darkTimeThreshold) бинаризации
            // (белое - предполагаемый день, черное - предполагаемая ночь)
            Mat darkTimeMask         = GetDarkTimeMask(blurMat);

            Mat overlayedMat = new Mat();

            // наложение масок на блюр изображение
            CvInvoke.BitwiseAnd(blurMat, darkTimeMask, overlayedMat, highlightsBinaryMask);

            return overlayedMat;
        }

        /// <summary>
        /// Выявление диллатированой бинарной маски засветов.
        /// </summary>
        /// <param name="srcMat">Изображение в оттенках серого.</param>
        /// <returns>Бинарная маска засветов (черное - засвет).</returns>
        private Mat GetHighlightBinaryMask(Mat srcMat)
        {
            var highlightBinaryMask = new Mat();

            // предполагаемый засвет: белое - засвет для дальнейшей дилатации
            CvInvoke.Threshold(srcMat, highlightBinaryMask, _highlightThreshold, 255, ThresholdType.Binary);

            var dilateCore = CvInvoke.GetStructuringElement(ElementShape.Ellipse,
                new Size(_dilateHightlightSize, _dilateHightlightSize), 
                new Point(2, 2));

            Mat dilatedMat = new Mat();

            // дилатация с 3-мя итерациями
            CvInvoke.Dilate(highlightBinaryMask, dilatedMat, dilateCore,
                new Point(-1, -1), 3, BorderType.Default, new MCvScalar(255, 255, 255));

            Mat invertedMask = new Mat();

            // инвертируем маску: черное - засвет для дальнейшего "наложения" на изображение
            CvInvoke.BitwiseNot(dilatedMat, invertedMask);

            return invertedMask;
        }

        /// <summary>
        /// Получение маски с низким порогом бинаризации (_darkTimeThreshold).
        /// </summary>
        /// <param name="srcMat">Изображение в оттенках серого.</param>
        /// <returns>Маска с низким порогом бинаризации.</returns>
        private Mat GetDarkTimeMask(Mat srcMat)
        {
            Mat darkTimeMask = new Mat();
            CvInvoke.Threshold(srcMat, darkTimeMask, _darkTimeThreshold, 255, ThresholdType.Binary);
            return darkTimeMask;
        }
    }
}

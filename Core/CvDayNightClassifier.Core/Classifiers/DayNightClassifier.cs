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
        private readonly int _medianBlurValue = 11;

        /// <summary>
        /// Размер ядра дилатации для применения на бинарной маске засветов.
        /// </summary>
        private readonly int _dilateHightlightSize = 15;

        /// <summary>
        /// Высокий порог бинаризации (предполагаемые засветы).
        /// </summary>
        private readonly int _upperThreshold = 250;

        /// <summary>
        /// Низкий порог бинаризации (предполагаемая ночь).
        /// </summary>
        private readonly int _lowerThreshold = 50;

        /// <summary>
        /// Значение классификации день/ночь. Меньше - ночь, больше - день.
        /// </summary>
        private readonly float _darkTimeClassifyValue = 0.7f;

        /// <summary>
        /// Метод классификации день/ночь по изображению.
        /// </summary>
        /// <param name="pathToImage">Путь к изображению.</param>
        /// <returns>Объект, содержащий результат классификации, значение яркости, итоговую маску классификации.</returns>
        public DayNightClassifierResultDTO ClassifyImage(string pathToImage)
        {
            Mat grayMat = new Mat(pathToImage, ImreadModes.Grayscale);

            return ClassifyImageImpl(grayMat);
        }

        private DayNightClassifierResultDTO ClassifyImageImpl(Mat grayMat)
        {
            Mat removedHighlightsMat = GetMaskClassificationWithoutHighlights(grayMat);

            var result = GetClassifierResult(removedHighlightsMat);

            return result;
        }

        /// <summary>
        /// Классифицирует входную бинарную матрицу классификации.
        /// </summary>
        /// <param name="binaryRemovedHighlightsMat">Бинарная матрица классификации.</param>
        /// <returns>Объект, содержащий результат классификации, значение яркости, итоговую маску классификации.</returns>
        private DayNightClassifierResultDTO GetClassifierResult(Mat binaryRemovedHighlightsMat)
        {
            var result = new DayNightClassifierResultDTO();

            var whitePixels = CvInvoke.CountNonZero(binaryRemovedHighlightsMat);

            result.ClassificationValue = (float)whitePixels / (float)(binaryRemovedHighlightsMat.Width * binaryRemovedHighlightsMat.Height);

            result.DayNightClassification = result.ClassificationValue > _darkTimeClassifyValue
                ? DayNightClassification.DAY
                : DayNightClassification.NIGHT;

            result.ClassificationMask = binaryRemovedHighlightsMat;

            return result;
        }

        /// <summary>
        /// Удаление засветов.
        /// </summary>
        /// <param name="srcMat">Изображение в оттенках серого.</param>
        /// <returns>Матрица без засветов.</returns>
        private Mat GetMaskClassificationWithoutHighlights(Mat srcMat)
        {
            Mat blurMat = new Mat();
            CvInvoke.MedianBlur(srcMat, blurMat, _medianBlurValue);

            // маска с высоким порогом (_upperThreshold)
            // получение маски засветов (черное - засвет)
            Mat upperThresholdBinaryMask = GetHighlightBinaryMask(blurMat);

            // маска с низким порогом (_lowerThreshold) бинаризации
            // (белое - предполагаемый день, черное - предполагаемая ночь)
            Mat lowerThresholdBinaryMask         = GetLowerThresholdMask(blurMat);

            Mat overlayedMat = new Mat();

            // наложение масок для получения маски классификации
            CvInvoke.BitwiseAnd(upperThresholdBinaryMask, lowerThresholdBinaryMask, overlayedMat);

            //CvInvoke.Imshow("g", overlayedMat);

            return overlayedMat;
        }

        /// <summary>
        /// Выявление диллатированной бинарной маски засветов.
        /// </summary>
        /// <param name="srcMat">Изображение с блюром в оттенках серого.</param>
        /// <returns>Бинарная маска засветов (черное - засвет).</returns>
        private Mat GetHighlightBinaryMask(Mat srcMat)
        {
            var highlightBinaryMask = new Mat();

            // предполагаемый засвет: белое - засвет для дальнейшей дилатации
            CvInvoke.Threshold(srcMat, highlightBinaryMask, _upperThreshold, 255, ThresholdType.Binary);

            var dilateCore = CvInvoke.GetStructuringElement(ElementShape.Ellipse,
                new Size(_dilateHightlightSize, _dilateHightlightSize), 
                new Point(-1, -1));

            Mat dilatedMat = new Mat();

            // дилатация для "увеличения" засветов
            CvInvoke.Dilate(highlightBinaryMask, dilatedMat, dilateCore,
                new Point(-1, -1), 10, BorderType.Default, new MCvScalar(255, 255, 255));

            Mat invertedMask = new Mat();

            // инвертируем маску: черное - засвет для дальнейшего "наложения" на изображение
            CvInvoke.BitwiseNot(dilatedMat, invertedMask);

            return invertedMask;
        }

        /// <summary>
        /// Получение маски с низким порогом бинаризации (_lowerThreshold).
        /// </summary>
        /// <param name="srcMat">Изображение с блюром в оттенках серого.</param>
        /// <returns>Маска с низким порогом бинаризации.</returns>
        private Mat GetLowerThresholdMask(Mat srcMat)
        {
            Mat lowerThresholdMask = new Mat();
            CvInvoke.Threshold(srcMat, lowerThresholdMask, _lowerThreshold, 255, ThresholdType.Binary);
            return lowerThresholdMask;
        }
    }
}

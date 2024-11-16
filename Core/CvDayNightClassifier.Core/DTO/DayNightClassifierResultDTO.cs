﻿using CvDayNightClassifier.Core.Classifiers;
using Emgu.CV;

namespace CvDayNightClassifier.Core.DTO
{
    public class DayNightClassifierResultDTO
    {
        /// <summary>
        /// Классификация день/ночь.
        /// </summary>
        public DayNightClassification DayNightClassification { get; set; }

        /// <summary>
        /// Изображение без засветов.
        /// </summary>
        public Mat RemovedHighlightImage { get; set; }

        /// <summary>
        /// Яркость изображения RemovedHighlightImage.
        /// </summary>
        public double BrightnessValue { get; set; }
    }
}

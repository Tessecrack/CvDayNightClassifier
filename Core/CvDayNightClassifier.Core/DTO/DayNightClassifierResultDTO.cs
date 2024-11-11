using CvDayNightClassifier.Core.Classifiers;

namespace CvDayNightClassifier.Core.DTO
{
    public class DayNightClassifierResultDTO
    {
        public DayNightClassification DayNightClassification { get; set; }

        public byte[] HighlightMask { get; set; }

        public double HueValue { get; set; }

        public double SaturationValue { get; set; }

        public double BrightnessValue { get; set; }
    }
}

using CvDayNightClassifier.Core.Classifiers;

namespace CvDayNightClassfier.UI.WinForms;

public partial class DayNightClassifierForm : Form
{
    private DayNightClassifier _classifier = new DayNightClassifier();

    public DayNightClassifierForm()
    {
        InitializeComponent();
        openFileDialog.Filter = "Image Files | *.jpg; *.jpeg; *.png";
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                pictureBoxSourceImage.Image = new Bitmap(openFileDialog.FileName);
                var result = _classifier.ClassifyImage(openFileDialog.FileName);

                lblResultClassificationValue.Text = result.DayNightClassification.ToString();
                lblHueValue.Text        = result.HueValue.ToString();
                lblSatValue.Text        = result.SaturationValue.ToString();
                lblBrightnessValue.Text = result.BrightnessValue.ToString();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}

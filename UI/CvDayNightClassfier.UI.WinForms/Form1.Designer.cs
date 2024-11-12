using System.Windows.Forms;

namespace CvDayNightClassfier.UI.WinForms;

partial class DayNightClassifierForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        tableLayoutPanelMain = new TableLayoutPanel();
        groupBoxSourceImage = new GroupBox();
        pictureBoxSourceImage = new PictureBox();
        tableLayoutPanelAdditionalInfo = new TableLayoutPanel();
        groupBoxInfo = new GroupBox();
        tableLayoutPanelInfo = new TableLayoutPanel();
        lblResultText = new Label();
        lblHueText = new Label();
        lblSaturationText = new Label();
        lblValueText = new Label();
        lblResultClassificationValue = new Label();
        lblHueValue = new Label();
        lblSatValue = new Label();
        lblBrightnessValue = new Label();
        groupBoxImageProcess = new GroupBox();
        pictureBoxHighlightMask = new PictureBox();
        btnClose = new Button();
        openFileDialog = new OpenFileDialog();
        menuStrip.SuspendLayout();
        tableLayoutPanelMain.SuspendLayout();
        groupBoxSourceImage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxSourceImage).BeginInit();
        tableLayoutPanelAdditionalInfo.SuspendLayout();
        groupBoxInfo.SuspendLayout();
        tableLayoutPanelInfo.SuspendLayout();
        groupBoxImageProcess.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxHighlightMask).BeginInit();
        SuspendLayout();
        // 
        // menuStrip
        // 
        menuStrip.ImageScalingSize = new Size(20, 20);
        menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(800, 28);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(46, 24);
        fileToolStripMenuItem.Text = "File";
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.Size = new Size(128, 26);
        openToolStripMenuItem.Text = "Open";
        openToolStripMenuItem.Click += openToolStripMenuItem_Click;
        // 
        // tableLayoutPanelMain
        // 
        tableLayoutPanelMain.ColumnCount = 2;
        tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanelMain.Controls.Add(groupBoxSourceImage, 0, 0);
        tableLayoutPanelMain.Controls.Add(tableLayoutPanelAdditionalInfo, 1, 0);
        tableLayoutPanelMain.Dock = DockStyle.Fill;
        tableLayoutPanelMain.Location = new Point(0, 28);
        tableLayoutPanelMain.Name = "tableLayoutPanelMain";
        tableLayoutPanelMain.RowCount = 1;
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 83.41232F));
        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.587677F));
        tableLayoutPanelMain.Size = new Size(800, 422);
        tableLayoutPanelMain.TabIndex = 1;
        // 
        // groupBoxSourceImage
        // 
        groupBoxSourceImage.Controls.Add(pictureBoxSourceImage);
        groupBoxSourceImage.Dock = DockStyle.Fill;
        groupBoxSourceImage.Location = new Point(3, 3);
        groupBoxSourceImage.Name = "groupBoxSourceImage";
        groupBoxSourceImage.Size = new Size(394, 416);
        groupBoxSourceImage.TabIndex = 0;
        groupBoxSourceImage.TabStop = false;
        groupBoxSourceImage.Text = "Source image";
        // 
        // pictureBoxSourceImage
        // 
        pictureBoxSourceImage.Dock = DockStyle.Fill;
        pictureBoxSourceImage.Location = new Point(3, 23);
        pictureBoxSourceImage.Name = "pictureBoxSourceImage";
        pictureBoxSourceImage.Size = new Size(388, 390);
        pictureBoxSourceImage.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxSourceImage.TabIndex = 0;
        pictureBoxSourceImage.TabStop = false;
        // 
        // tableLayoutPanelAdditionalInfo
        // 
        tableLayoutPanelAdditionalInfo.ColumnCount = 1;
        tableLayoutPanelAdditionalInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanelAdditionalInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanelAdditionalInfo.Controls.Add(groupBoxInfo, 0, 0);
        tableLayoutPanelAdditionalInfo.Controls.Add(groupBoxImageProcess, 0, 1);
        tableLayoutPanelAdditionalInfo.Controls.Add(btnClose, 0, 2);
        tableLayoutPanelAdditionalInfo.Dock = DockStyle.Fill;
        tableLayoutPanelAdditionalInfo.Location = new Point(403, 3);
        tableLayoutPanelAdditionalInfo.Name = "tableLayoutPanelAdditionalInfo";
        tableLayoutPanelAdditionalInfo.RowCount = 3;
        tableLayoutPanelAdditionalInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
        tableLayoutPanelAdditionalInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanelAdditionalInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanelAdditionalInfo.Size = new Size(394, 416);
        tableLayoutPanelAdditionalInfo.TabIndex = 1;
        // 
        // groupBoxInfo
        // 
        groupBoxInfo.Controls.Add(tableLayoutPanelInfo);
        groupBoxInfo.Dock = DockStyle.Top;
        groupBoxInfo.Location = new Point(3, 3);
        groupBoxInfo.Name = "groupBoxInfo";
        groupBoxInfo.Size = new Size(388, 183);
        groupBoxInfo.TabIndex = 0;
        groupBoxInfo.TabStop = false;
        groupBoxInfo.Text = "Info";
        // 
        // tableLayoutPanelInfo
        // 
        tableLayoutPanelInfo.AutoSize = true;
        tableLayoutPanelInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        tableLayoutPanelInfo.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        tableLayoutPanelInfo.ColumnCount = 2;
        tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanelInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanelInfo.Controls.Add(lblResultText, 0, 0);
        tableLayoutPanelInfo.Controls.Add(lblHueText, 0, 1);
        tableLayoutPanelInfo.Controls.Add(lblSaturationText, 0, 2);
        tableLayoutPanelInfo.Controls.Add(lblValueText, 0, 3);
        tableLayoutPanelInfo.Controls.Add(lblResultClassificationValue, 1, 0);
        tableLayoutPanelInfo.Controls.Add(lblHueValue, 1, 1);
        tableLayoutPanelInfo.Controls.Add(lblSatValue, 1, 2);
        tableLayoutPanelInfo.Controls.Add(lblBrightnessValue, 1, 3);
        tableLayoutPanelInfo.Dock = DockStyle.Fill;
        tableLayoutPanelInfo.Location = new Point(3, 23);
        tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
        tableLayoutPanelInfo.RowCount = 4;
        tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 48.05195F));
        tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 51.94805F));
        tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        tableLayoutPanelInfo.Size = new Size(382, 157);
        tableLayoutPanelInfo.TabIndex = 0;
        // 
        // lblResultText
        // 
        lblResultText.AutoSize = true;
        lblResultText.Dock = DockStyle.Fill;
        lblResultText.Location = new Point(4, 1);
        lblResultText.Name = "lblResultText";
        lblResultText.Size = new Size(183, 36);
        lblResultText.TabIndex = 0;
        lblResultText.Text = "Classification result";
        lblResultText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblHueText
        // 
        lblHueText.AutoSize = true;
        lblHueText.Dock = DockStyle.Fill;
        lblHueText.Location = new Point(4, 38);
        lblHueText.Name = "lblHueText";
        lblHueText.Size = new Size(183, 39);
        lblHueText.TabIndex = 1;
        lblHueText.Text = "Hue";
        lblHueText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSaturationText
        // 
        lblSaturationText.AutoSize = true;
        lblSaturationText.Dock = DockStyle.Fill;
        lblSaturationText.Location = new Point(4, 78);
        lblSaturationText.Name = "lblSaturationText";
        lblSaturationText.Size = new Size(183, 38);
        lblSaturationText.TabIndex = 2;
        lblSaturationText.Text = "Saturation";
        lblSaturationText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblValueText
        // 
        lblValueText.AutoSize = true;
        lblValueText.Dock = DockStyle.Fill;
        lblValueText.Location = new Point(4, 117);
        lblValueText.Name = "lblValueText";
        lblValueText.Size = new Size(183, 39);
        lblValueText.TabIndex = 3;
        lblValueText.Text = "Value";
        lblValueText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblResultClassificationValue
        // 
        lblResultClassificationValue.AutoSize = true;
        lblResultClassificationValue.Dock = DockStyle.Fill;
        lblResultClassificationValue.Location = new Point(194, 1);
        lblResultClassificationValue.Name = "lblResultClassificationValue";
        lblResultClassificationValue.Size = new Size(184, 36);
        lblResultClassificationValue.TabIndex = 4;
        lblResultClassificationValue.Text = "-";
        lblResultClassificationValue.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblHueValue
        // 
        lblHueValue.AutoSize = true;
        lblHueValue.Dock = DockStyle.Fill;
        lblHueValue.Location = new Point(194, 38);
        lblHueValue.Name = "lblHueValue";
        lblHueValue.Size = new Size(184, 39);
        lblHueValue.TabIndex = 5;
        lblHueValue.Text = "-";
        lblHueValue.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSatValue
        // 
        lblSatValue.AutoSize = true;
        lblSatValue.Dock = DockStyle.Fill;
        lblSatValue.Location = new Point(194, 78);
        lblSatValue.Name = "lblSatValue";
        lblSatValue.Size = new Size(184, 38);
        lblSatValue.TabIndex = 6;
        lblSatValue.Text = "-";
        lblSatValue.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblBrightnessValue
        // 
        lblBrightnessValue.AutoSize = true;
        lblBrightnessValue.Dock = DockStyle.Fill;
        lblBrightnessValue.Location = new Point(194, 117);
        lblBrightnessValue.Name = "lblBrightnessValue";
        lblBrightnessValue.Size = new Size(184, 39);
        lblBrightnessValue.TabIndex = 7;
        lblBrightnessValue.Text = "-";
        lblBrightnessValue.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // groupBoxImageProcess
        // 
        groupBoxImageProcess.Controls.Add(pictureBoxHighlightMask);
        groupBoxImageProcess.Dock = DockStyle.Fill;
        groupBoxImageProcess.Location = new Point(3, 203);
        groupBoxImageProcess.Name = "groupBoxImageProcess";
        groupBoxImageProcess.Size = new Size(388, 170);
        groupBoxImageProcess.TabIndex = 1;
        groupBoxImageProcess.TabStop = false;
        groupBoxImageProcess.Text = "Highlight mask";
        // 
        // pictureBoxHighlightMask
        // 
        pictureBoxHighlightMask.Dock = DockStyle.Fill;
        pictureBoxHighlightMask.Location = new Point(3, 23);
        pictureBoxHighlightMask.Name = "pictureBoxHighlightMask";
        pictureBoxHighlightMask.Size = new Size(382, 144);
        pictureBoxHighlightMask.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxHighlightMask.TabIndex = 0;
        pictureBoxHighlightMask.TabStop = false;
        // 
        // btnClose
        // 
        btnClose.Dock = DockStyle.Right;
        btnClose.Location = new Point(297, 379);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(94, 34);
        btnClose.TabIndex = 2;
        btnClose.Text = "Close";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // DayNightClassifierForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tableLayoutPanelMain);
        Controls.Add(menuStrip);
        Name = "DayNightClassifierForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "DayNightClassifier";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        tableLayoutPanelMain.ResumeLayout(false);
        groupBoxSourceImage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxSourceImage).EndInit();
        tableLayoutPanelAdditionalInfo.ResumeLayout(false);
        groupBoxInfo.ResumeLayout(false);
        groupBoxInfo.PerformLayout();
        tableLayoutPanelInfo.ResumeLayout(false);
        tableLayoutPanelInfo.PerformLayout();
        groupBoxImageProcess.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxHighlightMask).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private TableLayoutPanel tableLayoutPanelMain;
    private GroupBox groupBoxSourceImage;
    private PictureBox pictureBoxSourceImage;
    private TableLayoutPanel tableLayoutPanelAdditionalInfo;
    private GroupBox groupBoxInfo;
    private GroupBox groupBoxImageProcess;
    private TableLayoutPanel tableLayoutPanelInfo;
    private Label lblResultText;
    private Label lblHueText;
    private Label lblSaturationText;
    private Label lblValueText;
    private Button btnClose;
    private OpenFileDialog openFileDialog;
    private Label lblResultClassificationValue;
    private Label lblHueValue;
    private Label lblSatValue;
    private Label lblBrightnessValue;
    private PictureBox pictureBoxHighlightMask;
}

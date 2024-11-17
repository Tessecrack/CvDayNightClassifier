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
        lblBrightnessValue = new Label();
        lblClassificationText = new Label();
        lblResultText = new Label();
        lblResultClassificationValue = new Label();
        groupBoxImageProcess = new GroupBox();
        pictureBoxClassificationMask = new PictureBox();
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
        ((System.ComponentModel.ISupportInitialize)pictureBoxClassificationMask).BeginInit();
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
        tableLayoutPanelAdditionalInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
        tableLayoutPanelAdditionalInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanelAdditionalInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanelAdditionalInfo.Size = new Size(394, 416);
        tableLayoutPanelAdditionalInfo.TabIndex = 1;
        // 
        // groupBoxInfo
        // 
        groupBoxInfo.Controls.Add(tableLayoutPanelInfo);
        groupBoxInfo.Dock = DockStyle.Fill;
        groupBoxInfo.Location = new Point(3, 3);
        groupBoxInfo.Name = "groupBoxInfo";
        groupBoxInfo.Size = new Size(388, 114);
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
        tableLayoutPanelInfo.Controls.Add(lblBrightnessValue, 1, 1);
        tableLayoutPanelInfo.Controls.Add(lblClassificationText, 0, 1);
        tableLayoutPanelInfo.Controls.Add(lblResultText, 0, 0);
        tableLayoutPanelInfo.Controls.Add(lblResultClassificationValue, 1, 0);
        tableLayoutPanelInfo.Dock = DockStyle.Fill;
        tableLayoutPanelInfo.Location = new Point(3, 23);
        tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
        tableLayoutPanelInfo.RowCount = 2;
        tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        tableLayoutPanelInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
        tableLayoutPanelInfo.Size = new Size(382, 88);
        tableLayoutPanelInfo.TabIndex = 0;
        // 
        // lblBrightnessValue
        // 
        lblBrightnessValue.AutoSize = true;
        lblBrightnessValue.Dock = DockStyle.Fill;
        lblBrightnessValue.Location = new Point(194, 47);
        lblBrightnessValue.Name = "lblBrightnessValue";
        lblBrightnessValue.Size = new Size(184, 40);
        lblBrightnessValue.TabIndex = 9;
        lblBrightnessValue.Text = "-";
        lblBrightnessValue.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblClassificationText
        // 
        lblClassificationText.AutoSize = true;
        lblClassificationText.Dock = DockStyle.Fill;
        lblClassificationText.Location = new Point(4, 47);
        lblClassificationText.Name = "lblClassificationText";
        lblClassificationText.Size = new Size(183, 40);
        lblClassificationText.TabIndex = 8;
        lblClassificationText.Text = "Classification value";
        lblClassificationText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblResultText
        // 
        lblResultText.AutoSize = true;
        lblResultText.Dock = DockStyle.Fill;
        lblResultText.Location = new Point(4, 1);
        lblResultText.Name = "lblResultText";
        lblResultText.Size = new Size(183, 45);
        lblResultText.TabIndex = 0;
        lblResultText.Text = "Classification result";
        lblResultText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblResultClassificationValue
        // 
        lblResultClassificationValue.AutoSize = true;
        lblResultClassificationValue.Dock = DockStyle.Fill;
        lblResultClassificationValue.Location = new Point(194, 1);
        lblResultClassificationValue.Name = "lblResultClassificationValue";
        lblResultClassificationValue.Size = new Size(184, 45);
        lblResultClassificationValue.TabIndex = 4;
        lblResultClassificationValue.Text = "DAY/NIGHT";
        lblResultClassificationValue.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // groupBoxImageProcess
        // 
        groupBoxImageProcess.Controls.Add(pictureBoxClassificationMask);
        groupBoxImageProcess.Dock = DockStyle.Fill;
        groupBoxImageProcess.Location = new Point(3, 123);
        groupBoxImageProcess.Name = "groupBoxImageProcess";
        groupBoxImageProcess.Size = new Size(388, 250);
        groupBoxImageProcess.TabIndex = 1;
        groupBoxImageProcess.TabStop = false;
        groupBoxImageProcess.Text = "Classification mask";
        // 
        // pictureBoxClassificationMask
        // 
        pictureBoxClassificationMask.Dock = DockStyle.Fill;
        pictureBoxClassificationMask.Location = new Point(3, 23);
        pictureBoxClassificationMask.Name = "pictureBoxClassificationMask";
        pictureBoxClassificationMask.Size = new Size(382, 224);
        pictureBoxClassificationMask.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxClassificationMask.TabIndex = 0;
        pictureBoxClassificationMask.TabStop = false;
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
        ((System.ComponentModel.ISupportInitialize)pictureBoxClassificationMask).EndInit();
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
    private Button btnClose;
    private OpenFileDialog openFileDialog;
    private Label lblResultClassificationValue;
    private PictureBox pictureBoxClassificationMask;
    private Label lblBrightnessValue;
    private Label lblClassificationText;
}

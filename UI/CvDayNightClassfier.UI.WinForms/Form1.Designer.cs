﻿using System.Windows.Forms;

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
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        tableLayoutPanelMain = new TableLayoutPanel();
        groupBoxSourceImage = new GroupBox();
        pictureBox1 = new PictureBox();
        tableLayoutPanelAdditionalInfo = new TableLayoutPanel();
        groupBoxInfo = new GroupBox();
        tableLayoutPanelInfo = new TableLayoutPanel();
        lblResultText = new Label();
        lblHueText = new Label();
        lblSaturationText = new Label();
        lblValueText = new Label();
        groupBoxImageProcess = new GroupBox();
        btnClose = new Button();
        menuStrip1.SuspendLayout();
        tableLayoutPanelMain.SuspendLayout();
        groupBoxSourceImage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        tableLayoutPanelAdditionalInfo.SuspendLayout();
        groupBoxInfo.SuspendLayout();
        tableLayoutPanelInfo.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
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
        groupBoxSourceImage.Controls.Add(pictureBox1);
        groupBoxSourceImage.Dock = DockStyle.Fill;
        groupBoxSourceImage.Location = new Point(3, 3);
        groupBoxSourceImage.Name = "groupBoxSourceImage";
        groupBoxSourceImage.Size = new Size(394, 416);
        groupBoxSourceImage.TabIndex = 0;
        groupBoxSourceImage.TabStop = false;
        groupBoxSourceImage.Text = "Source image";
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Location = new Point(3, 23);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(388, 390);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
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
        tableLayoutPanelAdditionalInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanelAdditionalInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanelAdditionalInfo.Size = new Size(394, 416);
        tableLayoutPanelAdditionalInfo.TabIndex = 1;
        tableLayoutPanelAdditionalInfo.RowStyles[0].SizeType = SizeType.Absolute;
        tableLayoutPanelAdditionalInfo.RowStyles[0].Height = 200;
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
        lblResultText.Text = "Result";
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
        // groupBoxImageProcess
        // 
        groupBoxImageProcess.Dock = DockStyle.Fill;
        groupBoxImageProcess.Location = new Point(3, 192);
        groupBoxImageProcess.Name = "groupBoxImageProcess";
        groupBoxImageProcess.Size = new Size(388, 183);
        groupBoxImageProcess.TabIndex = 1;
        groupBoxImageProcess.TabStop = false;
        groupBoxImageProcess.Text = "Image process";
        // 
        // btnClose
        // 
        btnClose.Dock = DockStyle.Right;
        btnClose.Location = new Point(297, 381);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(94, 32);
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
        Controls.Add(menuStrip1);
        Name = "DayNightClassifierForm";
        Text = "DayNightClassifier";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        tableLayoutPanelMain.ResumeLayout(false);
        groupBoxSourceImage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        tableLayoutPanelAdditionalInfo.ResumeLayout(false);
        groupBoxInfo.ResumeLayout(false);
        groupBoxInfo.PerformLayout();
        tableLayoutPanelInfo.ResumeLayout(false);
        tableLayoutPanelInfo.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private TableLayoutPanel tableLayoutPanelMain;
    private GroupBox groupBoxSourceImage;
    private PictureBox pictureBox1;
    private TableLayoutPanel tableLayoutPanelAdditionalInfo;
    private GroupBox groupBoxInfo;
    private GroupBox groupBoxImageProcess;
    private TableLayoutPanel tableLayoutPanelInfo;
    private Label lblResultText;
    private Label lblHueText;
    private Label lblSaturationText;
    private Label lblValueText;
    private Button btnClose;
}
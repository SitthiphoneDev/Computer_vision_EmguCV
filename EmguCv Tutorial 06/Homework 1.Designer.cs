namespace EmguCv_Tutorial_06
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imginput = new Emgu.CV.UI.ImageBox();
            this.imgOutput = new Emgu.CV.UI.ImageBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioR = new System.Windows.Forms.RadioButton();
            this.radioG = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imginput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imginput
            // 
            this.imginput.Location = new System.Drawing.Point(12, 12);
            this.imginput.Name = "imginput";
            this.imginput.Size = new System.Drawing.Size(303, 285);
            this.imginput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imginput.TabIndex = 2;
            this.imginput.TabStop = false;
            // 
            // imgOutput
            // 
            this.imgOutput.Location = new System.Drawing.Point(12, 303);
            this.imgOutput.Name = "imgOutput";
            this.imgOutput.Size = new System.Drawing.Size(303, 285);
            this.imgOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOutput.TabIndex = 3;
            this.imgOutput.TabStop = false;
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(333, 15);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(614, 572);
            this.histogramBox1.TabIndex = 6;
            this.histogramBox1.Load += new System.EventHandler(this.histogramBox1_Load);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(980, 15);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(130, 48);
            this.btnLoadImage.TabIndex = 7;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioB);
            this.groupBox1.Controls.Add(this.radioG);
            this.groupBox1.Controls.Add(this.radioR);
            this.groupBox1.Location = new System.Drawing.Point(980, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 133);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histogram";
            // 
            // radioR
            // 
            this.radioR.AutoSize = true;
            this.radioR.Location = new System.Drawing.Point(27, 32);
            this.radioR.Name = "radioR";
            this.radioR.Size = new System.Drawing.Size(54, 20);
            this.radioR.TabIndex = 0;
            this.radioR.TabStop = true;
            this.radioR.Text = "Red";
            this.radioR.UseVisualStyleBackColor = true;
            this.radioR.CheckedChanged += new System.EventHandler(this.radioR_CheckedChanged);
            // 
            // radioG
            // 
            this.radioG.AutoSize = true;
            this.radioG.Location = new System.Drawing.Point(27, 68);
            this.radioG.Name = "radioG";
            this.radioG.Size = new System.Drawing.Size(65, 20);
            this.radioG.TabIndex = 1;
            this.radioG.TabStop = true;
            this.radioG.Text = "Green";
            this.radioG.UseVisualStyleBackColor = true;
            this.radioG.CheckedChanged += new System.EventHandler(this.radioG_CheckedChanged);
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(27, 107);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(55, 20);
            this.radioB.TabIndex = 2;
            this.radioB.TabStop = true;
            this.radioB.Text = "Blue";
            this.radioB.UseVisualStyleBackColor = true;
            this.radioB.CheckedChanged += new System.EventHandler(this.radioB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(980, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 139);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ເລືອກແມ່ສີ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(11, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.imgOutput);
            this.Controls.Add(this.imginput);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imginput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOutput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imginput;
        private Emgu.CV.UI.ImageBox imgOutput;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioG;
        private System.Windows.Forms.RadioButton radioR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}
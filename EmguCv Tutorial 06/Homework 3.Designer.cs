namespace EmguCv_Tutorial_06
{
    partial class Homework_3
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
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnGuassian = new System.Windows.Forms.Button();
            this.btnEqualization = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.ImgBoxOutput = new Emgu.CV.UI.ImageBox();
            this.htgAfterE = new Emgu.CV.UI.HistogramBox();
            this.htgBeforeE = new Emgu.CV.UI.HistogramBox();
            this.imgBoxInput = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(330, 530);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(541, 251);
            this.histogramBox1.TabIndex = 26;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(4, 528);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(268, 251);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 25;
            this.imageBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(927, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 35);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(927, 278);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(127, 35);
            this.btnSaveImage.TabIndex = 23;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Location = new System.Drawing.Point(927, 224);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(127, 35);
            this.btnMedian.TabIndex = 22;
            this.btnMedian.Text = "Median Filter";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btnGuassian
            // 
            this.btnGuassian.Location = new System.Drawing.Point(927, 170);
            this.btnGuassian.Name = "btnGuassian";
            this.btnGuassian.Size = new System.Drawing.Size(127, 35);
            this.btnGuassian.TabIndex = 21;
            this.btnGuassian.Text = "Guassian Filter";
            this.btnGuassian.UseVisualStyleBackColor = true;
            this.btnGuassian.Click += new System.EventHandler(this.btnGuassian_Click);
            // 
            // btnEqualization
            // 
            this.btnEqualization.Location = new System.Drawing.Point(927, 97);
            this.btnEqualization.Name = "btnEqualization";
            this.btnEqualization.Size = new System.Drawing.Size(127, 58);
            this.btnEqualization.TabIndex = 20;
            this.btnEqualization.Text = "Histogram Equalization";
            this.btnEqualization.UseVisualStyleBackColor = true;
            this.btnEqualization.Click += new System.EventHandler(this.btnEqualization_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(927, 44);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(127, 35);
            this.btnLoadImage.TabIndex = 19;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // ImgBoxOutput
            // 
            this.ImgBoxOutput.Location = new System.Drawing.Point(4, 271);
            this.ImgBoxOutput.Name = "ImgBoxOutput";
            this.ImgBoxOutput.Size = new System.Drawing.Size(268, 251);
            this.ImgBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBoxOutput.TabIndex = 18;
            this.ImgBoxOutput.TabStop = false;
            // 
            // htgAfterE
            // 
            this.htgAfterE.Location = new System.Drawing.Point(330, 271);
            this.htgAfterE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgAfterE.Name = "htgAfterE";
            this.htgAfterE.Size = new System.Drawing.Size(541, 251);
            this.htgAfterE.TabIndex = 17;
            // 
            // htgBeforeE
            // 
            this.htgBeforeE.Location = new System.Drawing.Point(330, 13);
            this.htgBeforeE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgBeforeE.Name = "htgBeforeE";
            this.htgBeforeE.Size = new System.Drawing.Size(541, 251);
            this.htgBeforeE.TabIndex = 16;
            // 
            // imgBoxInput
            // 
            this.imgBoxInput.Location = new System.Drawing.Point(4, 13);
            this.imgBoxInput.Name = "imgBoxInput";
            this.imgBoxInput.Size = new System.Drawing.Size(268, 252);
            this.imgBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoxInput.TabIndex = 15;
            this.imgBoxInput.TabStop = false;
            // 
            // Homework_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 785);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnGuassian);
            this.Controls.Add(this.btnEqualization);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.ImgBoxOutput);
            this.Controls.Add(this.htgAfterE);
            this.Controls.Add(this.htgBeforeE);
            this.Controls.Add(this.imgBoxInput);
            this.Name = "Homework_3";
            this.Text = "Homework_3";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnGuassian;
        private System.Windows.Forms.Button btnEqualization;
        private System.Windows.Forms.Button btnLoadImage;
        private Emgu.CV.UI.ImageBox ImgBoxOutput;
        private Emgu.CV.UI.HistogramBox htgAfterE;
        private Emgu.CV.UI.HistogramBox htgBeforeE;
        private Emgu.CV.UI.ImageBox imgBoxInput;
    }
}
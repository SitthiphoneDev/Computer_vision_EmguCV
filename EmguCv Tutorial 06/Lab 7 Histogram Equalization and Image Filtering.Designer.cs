namespace EmguCv_Tutorial_06
{
    partial class Lab_7_Histogram_Equalization_and_Image_Filtering
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
            this.imgBoxInput = new Emgu.CV.UI.ImageBox();
            this.htgBeforeE = new Emgu.CV.UI.HistogramBox();
            this.htgAfterE = new Emgu.CV.UI.HistogramBox();
            this.ImgBoxOutput = new Emgu.CV.UI.ImageBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnEqualization = new System.Windows.Forms.Button();
            this.btnGuassian = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBoxInput
            // 
            this.imgBoxInput.Location = new System.Drawing.Point(12, 12);
            this.imgBoxInput.Name = "imgBoxInput";
            this.imgBoxInput.Size = new System.Drawing.Size(337, 324);
            this.imgBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoxInput.TabIndex = 2;
            this.imgBoxInput.TabStop = false;
            // 
            // htgBeforeE
            // 
            this.htgBeforeE.Location = new System.Drawing.Point(373, 13);
            this.htgBeforeE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgBeforeE.Name = "htgBeforeE";
            this.htgBeforeE.Size = new System.Drawing.Size(541, 323);
            this.htgBeforeE.TabIndex = 4;
            // 
            // htgAfterE
            // 
            this.htgAfterE.Location = new System.Drawing.Point(373, 344);
            this.htgAfterE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htgAfterE.Name = "htgAfterE";
            this.htgAfterE.Size = new System.Drawing.Size(526, 322);
            this.htgAfterE.TabIndex = 5;
            // 
            // ImgBoxOutput
            // 
            this.ImgBoxOutput.Location = new System.Drawing.Point(12, 342);
            this.ImgBoxOutput.Name = "ImgBoxOutput";
            this.ImgBoxOutput.Size = new System.Drawing.Size(337, 324);
            this.ImgBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBoxOutput.TabIndex = 6;
            this.ImgBoxOutput.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(935, 43);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(127, 35);
            this.btnLoadImage.TabIndex = 7;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnEqualization
            // 
            this.btnEqualization.Location = new System.Drawing.Point(935, 96);
            this.btnEqualization.Name = "btnEqualization";
            this.btnEqualization.Size = new System.Drawing.Size(127, 58);
            this.btnEqualization.TabIndex = 8;
            this.btnEqualization.Text = "Histogram Equalization";
            this.btnEqualization.UseVisualStyleBackColor = true;
            this.btnEqualization.Click += new System.EventHandler(this.btnEqualization_Click);
            // 
            // btnGuassian
            // 
            this.btnGuassian.Location = new System.Drawing.Point(935, 169);
            this.btnGuassian.Name = "btnGuassian";
            this.btnGuassian.Size = new System.Drawing.Size(127, 35);
            this.btnGuassian.TabIndex = 9;
            this.btnGuassian.Text = "Guassian Filter";
            this.btnGuassian.UseVisualStyleBackColor = true;
            this.btnGuassian.Click += new System.EventHandler(this.btnGuassian_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Location = new System.Drawing.Point(935, 223);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(127, 35);
            this.btnMedian.TabIndex = 10;
            this.btnMedian.Text = "Median Filter";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(935, 277);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(127, 35);
            this.btnSaveImage.TabIndex = 11;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(935, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 35);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab_7_Histogram_Equalization_and_Image_Filtering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 672);
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
            this.Name = "Lab_7_Histogram_Equalization_and_Image_Filtering";
            this.Text = "Lab_7_Histogram_Equalization_and_Image_Filtering";
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBoxOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBoxInput;
        private Emgu.CV.UI.HistogramBox htgBeforeE;
        private Emgu.CV.UI.HistogramBox htgAfterE;
        private Emgu.CV.UI.ImageBox ImgBoxOutput;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnEqualization;
        private System.Windows.Forms.Button btnGuassian;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnExit;
    }
}
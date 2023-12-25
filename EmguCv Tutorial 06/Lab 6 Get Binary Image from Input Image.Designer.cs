namespace EmguCv_Tutorial_06
{
    partial class Lab_6_Get_Binary_Image_from_Input_Image
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
            this.imgInput = new Emgu.CV.UI.ImageBox();
            this.imgGray = new Emgu.CV.UI.ImageBox();
            this.imgBinary = new Emgu.CV.UI.ImageBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgInput
            // 
            this.imgInput.Location = new System.Drawing.Point(36, 23);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(290, 248);
            this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInput.TabIndex = 2;
            this.imgInput.TabStop = false;
            this.imgInput.Click += new System.EventHandler(this.imgInput_Click);
            // 
            // imgGray
            // 
            this.imgGray.Location = new System.Drawing.Point(36, 277);
            this.imgGray.Name = "imgGray";
            this.imgGray.Size = new System.Drawing.Size(290, 248);
            this.imgGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGray.TabIndex = 3;
            this.imgGray.TabStop = false;
            // 
            // imgBinary
            // 
            this.imgBinary.Location = new System.Drawing.Point(345, 23);
            this.imgBinary.Name = "imgBinary";
            this.imgBinary.Size = new System.Drawing.Size(290, 248);
            this.imgBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBinary.TabIndex = 4;
            this.imgBinary.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(345, 306);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 37);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(447, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(549, 306);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(345, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thresholding";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Binary",
            "Binary Invert",
            "OT\'Su",
            "Guassian",
            "Mean"});
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Lab_6_Get_Binary_Image_from_Input_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.imgBinary);
            this.Controls.Add(this.imgGray);
            this.Controls.Add(this.imgInput);
            this.Name = "Lab_6_Get_Binary_Image_from_Input_Image";
            this.Text = "Lab_6_Get_Binary_Image_from_Input_Image";
            this.Load += new System.EventHandler(this.Lab_6_Get_Binary_Image_from_Input_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgInput;
        private Emgu.CV.UI.ImageBox imgGray;
        private Emgu.CV.UI.ImageBox imgBinary;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
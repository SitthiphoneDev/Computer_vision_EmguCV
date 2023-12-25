namespace EmguCv_Tutorial_06
{
    partial class Homework_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.imgBinary = new Emgu.CV.UI.ImageBox();
            this.imgGray = new Emgu.CV.UI.ImageBox();
            this.imgInput = new Emgu.CV.UI.ImageBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtBlocksize = new System.Windows.Forms.TextBox();
            this.txtGraymaxvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(328, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 64);
            this.groupBox1.TabIndex = 21;
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(532, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(430, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(328, 281);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 37);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // imgBinary
            // 
            this.imgBinary.Location = new System.Drawing.Point(328, 12);
            this.imgBinary.Name = "imgBinary";
            this.imgBinary.Size = new System.Drawing.Size(290, 248);
            this.imgBinary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBinary.TabIndex = 17;
            this.imgBinary.TabStop = false;
            // 
            // imgGray
            // 
            this.imgGray.Location = new System.Drawing.Point(19, 266);
            this.imgGray.Name = "imgGray";
            this.imgGray.Size = new System.Drawing.Size(290, 248);
            this.imgGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGray.TabIndex = 16;
            this.imgGray.TabStop = false;
            // 
            // imgInput
            // 
            this.imgInput.Location = new System.Drawing.Point(19, 12);
            this.imgInput.Name = "imgInput";
            this.imgInput.Size = new System.Drawing.Size(290, 248);
            this.imgInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInput.TabIndex = 15;
            this.imgInput.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(555, 459);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 22);
            this.numericUpDown1.TabIndex = 27;
            // 
            // txtBlocksize
            // 
            this.txtBlocksize.Location = new System.Drawing.Point(406, 458);
            this.txtBlocksize.Name = "txtBlocksize";
            this.txtBlocksize.Size = new System.Drawing.Size(80, 22);
            this.txtBlocksize.TabIndex = 26;
            this.txtBlocksize.Text = "9";
            // 
            // txtGraymaxvalue
            // 
            this.txtGraymaxvalue.Location = new System.Drawing.Point(440, 413);
            this.txtGraymaxvalue.Name = "txtGraymaxvalue";
            this.txtGraymaxvalue.Size = new System.Drawing.Size(108, 22);
            this.txtGraymaxvalue.TabIndex = 25;
            this.txtGraymaxvalue.Text = "255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Param1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Blocksize:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Gray MaxValue:";
            // 
            // Homework_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.imgBinary);
            this.Controls.Add(this.imgGray);
            this.Controls.Add(this.imgInput);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtBlocksize);
            this.Controls.Add(this.txtGraymaxvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Homework_2";
            this.Text = "Homework_2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBinary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private Emgu.CV.UI.ImageBox imgBinary;
        private Emgu.CV.UI.ImageBox imgGray;
        private Emgu.CV.UI.ImageBox imgInput;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtBlocksize;
        private System.Windows.Forms.TextBox txtGraymaxvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
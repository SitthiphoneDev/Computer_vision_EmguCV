namespace EmguCv_Tutorial_06
{
    partial class Lab_5_Image_Binarization
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleThresoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptiveThresoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryInvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guassianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.simpleThresoldToolStripMenuItem,
            this.adaptiveThresoldToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // simpleThresoldToolStripMenuItem
            // 
            this.simpleThresoldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.binaryInvertToolStripMenuItem,
            this.oTSuToolStripMenuItem});
            this.simpleThresoldToolStripMenuItem.Name = "simpleThresoldToolStripMenuItem";
            this.simpleThresoldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.simpleThresoldToolStripMenuItem.Text = "Simple Thresold";
            // 
            // adaptiveThresoldToolStripMenuItem
            // 
            this.adaptiveThresoldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guassianToolStripMenuItem,
            this.meanToolStripMenuItem});
            this.adaptiveThresoldToolStripMenuItem.Name = "adaptiveThresoldToolStripMenuItem";
            this.adaptiveThresoldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adaptiveThresoldToolStripMenuItem.Text = "Adaptive Thresold";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // binaryInvertToolStripMenuItem
            // 
            this.binaryInvertToolStripMenuItem.Name = "binaryInvertToolStripMenuItem";
            this.binaryInvertToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.binaryInvertToolStripMenuItem.Text = "Binary Invert";
            this.binaryInvertToolStripMenuItem.Click += new System.EventHandler(this.binaryInvertToolStripMenuItem_Click);
            // 
            // oTSuToolStripMenuItem
            // 
            this.oTSuToolStripMenuItem.Name = "oTSuToolStripMenuItem";
            this.oTSuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oTSuToolStripMenuItem.Text = "OT’Su";
            this.oTSuToolStripMenuItem.Click += new System.EventHandler(this.oTSuToolStripMenuItem_Click);
            // 
            // guassianToolStripMenuItem
            // 
            this.guassianToolStripMenuItem.Name = "guassianToolStripMenuItem";
            this.guassianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guassianToolStripMenuItem.Text = "Guassian";
            this.guassianToolStripMenuItem.Click += new System.EventHandler(this.guassianToolStripMenuItem_Click);
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.meanToolStripMenuItem.Text = "Mean";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.Location = new System.Drawing.Point(22, 47);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(387, 384);
            this.pictureBoxOrigin.TabIndex = 2;
            this.pictureBoxOrigin.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Location = new System.Drawing.Point(437, 47);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(387, 384);
            this.pictureBoxOutput.TabIndex = 3;
            this.pictureBoxOutput.TabStop = false;
            // 
            // Lab_5_Image_Binarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 468);
            this.Controls.Add(this.pictureBoxOutput);
            this.Controls.Add(this.pictureBoxOrigin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab_5_Image_Binarization";
            this.Text = "Lab_5_Image_Binarization";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleThresoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryInvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaptiveThresoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guassianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
    }
}
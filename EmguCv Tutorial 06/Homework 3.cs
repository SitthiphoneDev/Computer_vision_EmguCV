using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCv_Tutorial_06
{
    public partial class Homework_3 : Form
    {
        public Homework_3()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> imgBeforeE;
        Image<Gray, byte> imgFilter, imgAfterE;

         private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imgBeforeE = new Image<Bgr, byte>(opf.FileName);
                imgBoxInput.Image = imgBeforeE;
                htgBeforeE.GenerateHistograms(imgBeforeE, 255);
                htgBeforeE.Refresh();
            }

        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog savef = new SaveFileDialog();
            savef.Title = "Image Equalization and Filtering";
            string imageName = "My image";
            savef.FileName = imageName;
            savef.Filter = "Jpeg Files(*.jpg)|*.jpg|Bitmap Files(*.bmp)|*.bmp";
            if (savef.ShowDialog() == DialogResult.OK)
            {
                ImgBoxOutput.Image.Save(savef.FileName);
                MessageBox.Show("Saving Complete");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            imgFilter = new Image<Gray, byte>(imgAfterE.Width, imgAfterE.Height);
            CvInvoke.MedianBlur(imgAfterE, imgFilter, 7);
            ImgBoxOutput.Image = imgFilter;
            ImgBoxOutput.Refresh();
            htgAfterE.ClearHistogram();
            htgAfterE.GenerateHistograms(imgFilter, 255);
            htgAfterE.Refresh();
        }

        private void btnGuassian_Click(object sender, EventArgs e)
        {
            imgFilter = new Image<Gray, byte>(imgAfterE.Width, imgAfterE.Height);
            CvInvoke.GaussianBlur(imgAfterE, imgFilter, new Size(7, 7), 0, 0, BorderType.Default);

            ImgBoxOutput.Image = imgFilter;
            ImgBoxOutput.Refresh();
            htgAfterE.ClearHistogram();
            htgAfterE.GenerateHistograms(imgFilter, 255);
            htgAfterE.Refresh();

        }

        private void btnEqualization_Click(object sender, EventArgs e)
        {
            imgAfterE = new Image<Gray, byte>(imgBeforeE.Width, imgBeforeE.Height);
            CvInvoke.EqualizeHist(imgBeforeE, imgAfterE);
            ImgBoxOutput.Image = imgAfterE;
            htgAfterE.ClearHistogram();
            htgAfterE.GenerateHistograms(imgAfterE, 255);
            htgAfterE.Refresh();
        }
    }
}

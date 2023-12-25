using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.CvEnum;

namespace EmguCv_Tutorial_06
{
    public partial class lab5_Image_Binarization : Form
    {
        public lab5_Image_Binarization()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> imageInput;
        Image<Gray, byte> imageGray;
        Image<Gray, byte> imageBinarize;


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageInput = new Image<Bgr, byte>(openFile.FileName);
                pictureBoxOrigin.Image = imageInput.ToBitmap();

            }
        }

        private void binaryInvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            // Binarization Simple Thresholding (Inverted)
            imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));

            CvInvoke.Threshold(imageGray, imageBinarize, 100, 255, ThresholdType.BinaryInv);
            pictureBoxOutput.Image = imageBinarize.ToBitmap();
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            // Binarization Simple Thresholding
            imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));

            CvInvoke.Threshold(imageGray, imageBinarize, 100, 255, ThresholdType.Binary);
            pictureBoxOutput.Image = imageBinarize.ToBitmap();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oTSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            // Binarization using Otsu Thresholding
            imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));

            CvInvoke.Threshold(imageGray, imageBinarize, 0, 255, ThresholdType.Otsu);
            pictureBoxOutput.Image = imageBinarize.ToBitmap();
        }

        private void guassianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            // Binarization using Adaptive Thresholding (Gaussian)
            imageBinarize = imageGray.ThresholdAdaptive(new Gray(255.0),
                AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 3, new Gray(0.0));

            pictureBoxOutput.Image = imageBinarize.ToBitmap();
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBoxOrigin.Image = imageGray.ToBitmap();

            // Binarization using Adaptive Thresholding (Mean)
            imageBinarize = imageGray.ThresholdAdaptive(new Gray(255.0),
                AdaptiveThresholdType.MeanC, ThresholdType.Binary, 3, new Gray(0.0));

            pictureBoxOutput.Image = imageBinarize.ToBitmap();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

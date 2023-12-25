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

        Image<Bgr, byte> imgBeforeE, imgFilterC;
        Image<Gray, byte> imgFilter, imgAfterE, imgGray;

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

                imgGray = new Image<Gray, byte>(opf.FileName);
                imgBoxGray.Image = imgGray;
                htgGray.GenerateHistograms(imgGray, 255);
                htgGray.Refresh();
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
            if (radioBgr.Checked)
            {
                if (int.TryParse(txtksize.Text, out int ksize) && ksize > 0 && ksize % 2 == 1)
                {
                    // สร้างภาพสี (BGR) ใหม่
                    imgFilterC = new Image<Bgr, byte>(imgAfterE.Width, imgAfterE.Height);

                    // ทำการลบ noise ด้วย Median Filter
                    CvInvoke.MedianBlur(imgAfterE, imgFilterC, ksize);

                    // แสดงผลลัพธ์
                    ImgBoxOutput.Image = imgFilterC;
                    ImgBoxOutput.Refresh();

                    // ทำการล้าง Histogram และสร้างใหม่
                    htgAfterE.ClearHistogram();
                    htgAfterE.GenerateHistograms(imgFilterC, 255);
                    htgAfterE.Refresh();
                }
                else
                {
                    MessageBox.Show("Please enter a valid odd integer for ksize greater than 1.");
                }
            }
            else if (radioGray.Checked)
            {
                if (int.TryParse(txtksize.Text, out int ksize) && ksize > 0 && ksize % 2 == 1)
                {
                    // สร้างภาพสีเทาใหม่
                    imgFilter = new Image<Gray, byte>(imgAfterE.Width, imgAfterE.Height);

                    // ทำการลบ noise ด้วย Median Filter
                    CvInvoke.MedianBlur(imgAfterE, imgFilter, ksize);

                    // แสดงผลลัพธ์
                    ImgBoxOutput.Image = imgFilter;
                    ImgBoxOutput.Refresh();

                    // ทำการล้าง Histogram และสร้างใหม่
                    htgAfterE.ClearHistogram();
                    htgAfterE.GenerateHistograms(imgFilter, 255);
                    htgAfterE.Refresh();
                }
                else
                {
                    MessageBox.Show("Please enter a valid odd integer for ksize greater than 1.");
                }
            }
        }

        private void btnGuassian_Click(object sender, EventArgs e)
        {
            if (radioBgr.Checked)
            {
                if (int.TryParse(txtksize.Text, out int ksize) && ksize > 0 && ksize % 2 == 1)
                {
                    // สร้างภาพสี (BGR) ใหม่
                    imgFilterC = new Image<Bgr, byte>(imgBeforeE.Width, imgBeforeE.Height);

                    // ทำการลบ noise ด้วย Gaussian Filter
                    CvInvoke.GaussianBlur(imgBeforeE, imgFilterC, new Size(3, 3), 0, 0, BorderType.Default);

                    // แสดงผลลัพธ์
                    ImgBoxOutput.Image = imgFilterC;
                    ImgBoxOutput.Refresh();

                    // ทำการล้าง Histogram และสร้างใหม่
                    htgAfterE.ClearHistogram();
                    htgAfterE.GenerateHistograms(imgFilterC, 255);
                    htgAfterE.Refresh();
                }
                else
                {
                    MessageBox.Show("Please enter a valid odd integer for ksize greater than 1.");
                }
            }
            else if (radioGray.Checked)
            {
                if (int.TryParse(txtksize.Text, out int ksize) && ksize > 0 && ksize % 2 == 1)
                {
                    // สร้างภาพเทาใหม่
                    imgFilter = new Image<Gray, byte>(imgAfterE.Width, imgAfterE.Height);

                    // ทำการลบ noise ด้วย Gaussian Filter
                    CvInvoke.GaussianBlur(imgAfterE, imgFilter, new Size(ksize, ksize), 0, 0, BorderType.Default);

                    // แสดงผลลัพธ์
                    ImgBoxOutput.Image = imgFilter;
                    ImgBoxOutput.Refresh();

                    // ทำการล้าง Histogram และสร้างใหม่
                    htgAfterE.ClearHistogram();
                    htgAfterE.GenerateHistograms(imgFilter, 255);
                    htgAfterE.Refresh();
                }
                else
                {
                    MessageBox.Show("Please enter a valid odd integer for ksize greater than 1.");
                }
            }
        }




        private void btnEqualization_Click(object sender, EventArgs e)
        {
            imgAfterE = new Image<Gray, byte>(imgBeforeE.Width, imgBeforeE.Height);
            CvInvoke.EqualizeHist(imgGray, imgAfterE);
            ImgBoxOutput.Image = imgAfterE;
            htgAfterE.ClearHistogram();
            htgAfterE.GenerateHistograms(imgAfterE, 255);
            htgAfterE.Refresh();
        }
    }
}

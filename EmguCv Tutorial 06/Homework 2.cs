using Emgu.CV.CvEnum;
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

namespace EmguCv_Tutorial_06
{
    public partial class Homework_2 : Form
    {
        public Homework_2()
        {
            InitializeComponent();
        }



        Image<Bgr, byte> oriImage;
        Image<Gray, byte> grayImage, binaryImage;


        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(opf.FileName);
                imgInput.Image = oriImage;
                grayImage = oriImage.Convert<Gray, byte>();
                imgGray.Image = grayImage;
                imgBinary.Image = null;
                comboBox1.SelectedText = "ເລືອກຮູບແບບພາບຂາວດຳ";
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (double.TryParse(txtGraymaxvalue.Text, out double maxValue))
                {
                    binaryImage = grayImage.ThresholdBinary(new Gray(100), new Gray(maxValue));
                    imgBinary.Image = binaryImage;
                }
                else
                {
                    MessageBox.Show("Invalid input for max value.");
                }
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                if (double.TryParse(txtGraymaxvalue.Text, out double maxValue))
                {
                    binaryImage = grayImage.ThresholdBinaryInv(new Gray(100), new Gray(maxValue));
                    imgBinary.Image = binaryImage;
                }
                else
                {
                    MessageBox.Show("Invalid input for max value.");
                }
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                binaryImage = grayImage.ThresholdToZero(new Gray(100));
                imgBinary.Image = binaryImage;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                int blocksize = 0;

                // ตรวจสอบความถูกต้องของค่าที่ป้อนเข้ามาใน TextBox
                if (int.TryParse(txtBlocksize.Text, out blocksize) && blocksize % 2 == 1 && blocksize > 1)
                {
                    double param1 = decimal.ToDouble(numericUpDown1.Value);

                    binaryImage = grayImage.ThresholdAdaptive(new Gray(256),
                        AdaptiveThresholdType.GaussianC, ThresholdType.Binary, blocksize, new Gray(param1));
                    imgBinary.Image = binaryImage;
                }
                else
                {
                    MessageBox.Show("Invalid input for blocksize. It should be an odd number greater than 1.");
                }
            }
            
            else if (comboBox1.SelectedIndex == 4)
            {
                int blocksize = 0;

                // ตรวจสอบความถูกต้องของค่าที่ป้อนเข้ามาใน TextBox
                if (int.TryParse(txtBlocksize.Text, out blocksize) && blocksize % 2 == 1 && blocksize > 1)
                {
                    double param1 = decimal.ToDouble(numericUpDown1.Value);

                    binaryImage = grayImage.ThresholdAdaptive(new Gray(256),
                        AdaptiveThresholdType.MeanC, ThresholdType.Binary, blocksize, new Gray(param1));
                    imgBinary.Image = binaryImage;
                }
                else
                {
                    MessageBox.Show("Invalid input for blocksize. It should be an odd number greater than 1.");
                }
            }

            else
            {
                MessageBox.Show("Invalid selection.");
            }
        }

        private void txtGraymaxvalue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (imgInput.Image == null)
            {
                MessageBox.Show("Please load an image first.");
            }
            else if (imgBinary.Image == null)
            {
                MessageBox.Show("Please convert the image to grayscale first.");
            }
            else
            {
                using (SaveFileDialog saveImage = new SaveFileDialog())
                {
                    saveImage.Title = "Save Gray Image";
                    string imageName = "My image";

                    // Set the file name
                    saveImage.FileName = imageName;
                    saveImage.DefaultExt = "*.jpg";
                    saveImage.Filter = "JPEG Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|BMP files(*.bmp)|*.bmp";

                    if (saveImage.ShowDialog() == DialogResult.OK)
                    {
                        // ตรวจสอบจำนวน channels ของภาพ
                        if (imgBinary.Image is Image<Gray, byte> grayImage)
                        {
                            // บันทึกภาพเป็นไฟล์
                            grayImage.Save(saveImage.FileName);
                            MessageBox.Show("Saving Complete");
                        }
                        else
                        {
                            MessageBox.Show("Invalid image format. Please convert the image to grayscale first.");
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

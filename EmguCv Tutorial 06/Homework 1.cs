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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            if (histogramBox1 == null)
            {
                histogramBox1 = new Emgu.CV.UI.HistogramBox();
                this.Controls.Add(histogramBox1);
            }
        }




        Image<Bgr, byte> oriImage;
        Image<Gray, byte> R, G, B;

        private void radioR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioR.Checked)
            {
                imgOutput.Image = R;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(R, 256);
                histogramBox1.Refresh();
                MessageBox.Show("Gray is from Red Channel");
            }
        }

        private void radioG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioG.Checked)
            {
                imgOutput.Image = G;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(G, 256);
                histogramBox1.Refresh();
                MessageBox.Show("Gray is from Green Channel");
            }
        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioB.Checked)
            {
                imgOutput.Image = B;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(B, 256);
                histogramBox1.Refresh();
                MessageBox.Show("Gray is from Blue Channel");
            }
        }

        private void histogramBox1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                imgOutput.Image = R;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(R, 256);
                histogramBox1.Refresh();
                MessageBox.Show("Gray is from Red Channel");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                imgOutput.Image = G;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(G, 256);
                histogramBox1.Refresh();
                MessageBox.Show("Gray is from Green Channel");
            }

            else
            {
                imgOutput.Image = B;
                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(B, 256);
                histogramBox1.Refresh();
                MessageBox.Show("Gray is from Blue Channel");

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                oriImage = new Image<Bgr, byte>(opf.FileName);
                R = oriImage[0];
                G = oriImage[1];
                B = oriImage[2];
                imginput.Image = oriImage;
                radioB.Checked = true;
                if (radioR.Checked)
                {
                    imgOutput.Image = R;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(R, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show("Gray is from Red Channel");
                }

                else if (radioG.Checked)
                {
                    imgOutput.Image = G;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(G, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show("Gray is from Green Channel");
                }

                else
                {
                    imgOutput.Image = B;
                    histogramBox1.ClearHistogram();
                    histogramBox1.GenerateHistograms(B, 256);
                    histogramBox1.Refresh();
                    MessageBox.Show("Gray is from Blue Channel");
                }

            }
        }
    }
}

using Emgu.CV;
using System;
using System.Windows.Forms;
using Emgu.CV.Structure;

namespace EmguCv_Tutorial_06
{
    public partial class Lab10_WebCam : Form
    {
        Image<Gray, byte> grayVDO, binaryVDO;
        VideoCapture capture;
        Mat frame;
        bool turn_on;

        public Lab10_WebCam()
        {
            InitializeComponent();
        }

        private void Lab10_WebCam_Load(object sender, EventArgs e)
        {
            turn_on = false;
            capture = new VideoCapture(0);
            frame = new Mat();
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capture.Retrieve(frame);
                imgBoxVDO.Image = frame.ToImage<Bgr, byte>().ToBitmap();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            turn_on = false;
            Application.Idle -= Application_Idle;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            turn_on = true;
            imgCapture.Image = null;
            Application.Idle += Application_Idle;
        }

        private void Application_Idle1(object sender, EventArgs e)
        {
            grayVDO = frame.ToImage<Gray, byte>();
            imgBoxVDO.Image = grayVDO.ToBitmap();
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (turn_on == true)
                Application.Idle += Application_Idle1;
            else
                MessageBox.Show("Please Start the WebCam");
        }

        private void Application_Idle2(object sender, EventArgs e)
        {
            grayVDO = frame.ToImage<Gray, byte>();
            binaryVDO = grayVDO.ThresholdBinary(new Gray(150), new Gray(255));
            imgBoxVDO.Image = binaryVDO.ToBitmap();
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (turn_on == true)
                Application.Idle += Application_Idle2;
            else
                MessageBox.Show("Please Start the WebCam");
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            imgCapture.Image = imgBoxVDO.Image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Title = "Save Capture Image";
            svf.DefaultExt = "*.Jpg";
            svf.Filter = "Jpeg Files (*.jpg)|*.jpg";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                imgCapture.Image.Save(svf.FileName);
            }
        }

        private void ImgBoxVDO_Click(object sender, EventArgs e)
        {
            // Your click event code here
        }
    }
}

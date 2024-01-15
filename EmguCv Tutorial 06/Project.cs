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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab_5_Image_Binarization lab5Form = new Lab_5_Image_Binarization();
            lab5Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab_6_Get_Binary_Image_from_Input_Image lab6Form = new Lab_6_Get_Binary_Image_from_Input_Image();
            lab6Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab_7_Histogram_Equalization_and_Image_Filtering lab7Form = new Lab_7_Histogram_Equalization_and_Image_Filtering();
            lab7Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Homework_1 Homework_1 = new Homework_1();
            Homework_1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Homework_2 Homework_2 = new Homework_2();
            Homework_2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homework_3 Homework_3 = new Homework_3();
            Homework_3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab_8_Edge_Detection lab8Form = new Lab_8_Edge_Detection();
            lab8Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Morphology lab9Form = new Morphology();
            lab9Form.Show();
        }
    }
}

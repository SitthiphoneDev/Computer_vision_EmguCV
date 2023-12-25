using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCv_Tutorial_06
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Lab_5_Image_Binarization());
            //Application.Run(new Lab_6_Get_Binary_Image_from_Input_Image());
            //Application.Run(new Homework_2());
            Application.Run(new Lab_7_Histogram_Equalization_and_Image_Filtering());
           // Application.Run(new Homework_2());


        }
    }
}

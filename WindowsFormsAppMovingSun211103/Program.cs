using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMovingSun211103
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

            Form1 form1 = new Form1();
            form1.Text = "Moving Sun";
            form1.Width = 1400;
            form1.Height = 800;

            PictureBox pictureBox = new PictureBox();
            Sun sun = new Sun();
            sun.Move();
            sun.Move();

            pictureBox.Image = sun.image;
            pictureBox.Top = sun.top;
            pictureBox.Left = sun.left;
            pictureBox.Parent = form1;
            
            Application.Run(form1);
        }
    }
}
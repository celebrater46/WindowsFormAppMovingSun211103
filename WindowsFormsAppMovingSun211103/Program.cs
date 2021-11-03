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
            
            Dictionary<string, int> margin = new Dictionary<string, int>()
            {
                {"top", 10},
                {"right", 10},
                {"bottom", 10},
                {"left", 10},
                {"lineHeight", 25}
            };

            Form1 form1 = new Form1();
            form1.Text = "Moving Sun";
            form1.Width = 1400;
            form1.Height = 800;

            Label label = new Label();
            label.Top = margin["top"] + 160;
            label.Left = margin["left"];
            label.Width = 200;

            PictureBox pictureBox = new PictureBox();
            PictureBox pictureBox2 = new PictureBox();
            
            // Sun sun = new Sun();
            // Sun sun2 = new Sun();
            // sun.Move(20, 20);
            // sun2.Move(100, 100);

            Sun[] suns = new Sun[3];
            suns[0] = new Sun();
            suns[1] = new BlueSun();
            suns[2] = new Sun();
            suns[0].Move(20, 20);
            suns[1].Move(100, 100);
            suns[1].ChangeImage();
            suns[2].Move(100, 100);

            label.Text = Sun.CountSuns();
            label.Parent = form1;

            // pictureBox.Image = sun.image;
            // pictureBox.Top = sun.top;
            // pictureBox.Left = sun.left;
            
            // pictureBox.Image = sun.GetImage();
            // pictureBox.Top = sun.Top;
            // pictureBox.Left = sun.Left;
            // pictureBox.Parent = form1;
            //
            // pictureBox2.Image = sun2.GetImage();
            // pictureBox2.Top = sun2.Top;
            // pictureBox2.Left = sun2.Left;
            // pictureBox2.Parent = form1;

            PictureBox[] pictureBoxes = new PictureBox[3];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i] = new PictureBox();
                pictureBoxes[i].Parent = form1;
                pictureBoxes[i].Image = suns[i].GetImage();
                pictureBoxes[i].Top = suns[i].Top;
                pictureBoxes[i].Left = suns[i].Left;
            }

            Application.Run(form1);
        }
    }
}
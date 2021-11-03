using System;
using System.Drawing;

namespace WindowsFormsAppMovingSun211103
{
    public class Sun
    {
        protected Image image;
        protected int top;
        protected int left;
        public static int Count = 0;

        public Sun()
        {
            image = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppMovingSun211103\\WindowsFormsAppMovingSun211103\\img\\sunSymbol3.png");
            top = 0;
            left = 0;
            Count++;
        }

        public static string CountSuns()
        {
            return string.Format("太陽は {0} つあります。", Count.ToString());
        }

        public virtual void Move(int x, int y)
        {
            top += y;
            left += x;
        }

        public void SetImage(Image i)
        {
            image = i;
        }
        
        public Image GetImage()
        {
            return image;
        }
        
        public void ChangeImage()
        {
            image = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppMovingSun211103\\WindowsFormsAppMovingSun211103\\img\\sunSymbol4.png");
        }

        public int Top
        {
            set { top = value; }
            get { return top; }
        }

        public int Left
        {
            set { left = value; }
            get { return left; }
        }
    }
}
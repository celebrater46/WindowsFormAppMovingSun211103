using System.Drawing;

namespace WindowsFormsAppMovingSun211103
{
    public class Sun
    {
        private Image image;
        private int top;
        private int left;

        public Sun()
        {
            image = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppMovingSun211103\\WindowsFormsAppMovingSun211103\\img\\sunSymbol3.png");
            top = 0;
            left = 0;
        }

        public void Move()
        {
            top += 10;
            left += 10;
        }

        public void SetImage(Image i)
        {
            image = i;
        }
        
        public Image GetImage()
        {
            return image;
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
using System.Drawing;

namespace WindowsFormsAppMovingSun211103
{
    public class Sun
    {
        public Image image;
        public int top;
        public int left;

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
    }
}
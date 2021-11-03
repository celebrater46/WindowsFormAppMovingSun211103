using System.Drawing;

namespace WindowsFormsAppMovingSun211103
{
    public class BlueSun : Sun
    {
        public override void Move(int x, int y)
        {
            top += y;
            left += x + 200;
        }
    }
}
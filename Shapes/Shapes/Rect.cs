using System.Drawing;

namespace Shapes
{
    internal class Rect : Shape
    {
        private Rectangle rectangle;
        public Rect(Graphics g, Rectangle rect) : base("Rectangle", g)
        {
            rectangle = rect;
        }
        public override void Draw()
        {
          GraphicCanvas.DrawRectangle(pen,rectangle);

        }
    }
}
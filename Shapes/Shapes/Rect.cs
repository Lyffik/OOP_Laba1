using System.Drawing;

namespace Shapes
{
    class Rect:Shape
    {
        private Rectangle rect = new Rectangle(40, 40, 100, 150);
        public Rect(Graphics g) : base("Rectangle",g) { }

        public override void Draw()
        {
          GraphicCanvas.DrawRectangle(pen,rect);

        }
    }
}
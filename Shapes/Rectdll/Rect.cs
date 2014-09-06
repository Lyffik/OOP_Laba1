using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapedll;

namespace Rectdll
{
   public class Rect : Shape
    {
        private Rectangle rectangle;
        public Rect(Rectangle rect) : base( "Rectangle")
        {
            rectangle = rect;
        }
        public override void Draw(Graphics graphics)
        {
            pen = new Pen(Color.Red);
            graphics.DrawRectangle(pen, rectangle);
            pen.Dispose();

        }
    }
}

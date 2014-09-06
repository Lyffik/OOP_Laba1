using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapedll;

namespace Eclipsedll
{
    public class Eclipse : Shape
    {
         private Rectangle rectangle;

        public Eclipse(Rectangle rectF) : base("Circle")
        {
            rectangle = rectF;
        }
        public override void Draw(Graphics graphics)
        {
            pen = new Pen(Color.Black);
            graphics.DrawEllipse(pen, rectangle);
            pen.Dispose();
        }
    }
}

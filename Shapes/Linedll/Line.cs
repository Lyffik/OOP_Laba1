using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapedll;

namespace Linedll
{
    public class Line : Shape
    {
        private Point point1, point2;

        public Line(Point p1, Point p2)
            : base("Line")
        {
            point1 = p1;
            point2 = p2;
        }
        public override void Draw(Graphics graphics)
        {
            pen = new Pen(Color.Red);
            graphics.DrawLine(pen, point1, point2);
            pen.Dispose();
        }
    }
}

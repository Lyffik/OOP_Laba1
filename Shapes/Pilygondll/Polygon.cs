using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapedll;

namespace Pilygondll
{
    public class Polygon : Shape
    {
        protected Point[] points;

        public Polygon (Point[] p) : base("Polygon")
        {
            points = p;
        }

        public override void Draw(Graphics graphics)
        {
            pen = new Pen(Color.DarkBlue);
            graphics.DrawPolygon(pen, points);
            pen.Dispose();
        }
    }
}

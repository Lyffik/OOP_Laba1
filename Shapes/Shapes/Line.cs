using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
     class Line:Shape
     {
         private Point[] points=new Point[2];
         public void SetPoint(Point p1, Point p2)
         {
             points[0] = p1;
             points[1] = p2;
         }
         public Line(Graphics g) : base("Line",g) { }
         public override void Draw()
         {
             GraphicCanvas.DrawLine(pen, points[0], points[1]);
         }
    }
}
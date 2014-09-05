using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
     class Line:Shape
     {
         private Point point1, point2;

         public Line(Graphics g, Point p1, Point p2) : base("Line", g)
         {
             point1 = p1;
             point2 = p2;
         }
         public override void Draw()
         {
             GraphicCanvas.DrawLine(pen, point1, point2);
         }
    }
}
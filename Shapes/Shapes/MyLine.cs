using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
     class MyLine:Shape
     {
         private Point point1, point2;

         public MyLine(Graphics g, Point p1, Point p2) : base("Line", g)
         {
             point1 = p1;
             point2 = p2;
         }
         public override void Draw()
         {
             pen = new Pen(Color.Red);
             GraphicCanvas.DrawLine(pen, point1, point2);
             pen.Dispose();
         }
    }
}
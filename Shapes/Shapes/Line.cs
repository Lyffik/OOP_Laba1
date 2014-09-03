using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shapes
{
     class Line:Shape
    {
         public Line(Graphics g) : base("Line",g) { }
         public override void Draw(List<Point> plist)
         {

         }
    }
}
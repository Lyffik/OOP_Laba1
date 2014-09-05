using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapesList
    {
        private  List<Shape> shapes=new List<Shape>();

        public void AddShape(Shape sh)
        {
            shapes.Add(sh);
        }

        public void DrawListOfShapes()
        {
            foreach (Shape sh in shapes)
            {
                sh.Draw();
            }
        }
        
    }
}

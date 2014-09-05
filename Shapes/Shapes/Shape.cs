using System;
using System.Collections.Generic;
using System.Drawing;

namespace Shapes
{
  abstract class Shape
  {
      protected Pen pen;

      public Graphics GraphicCanvas { get; set; }
      public string ShapeName { get; set; }
      protected Shape(string name,Graphics g)
      {
          ShapeName = name;
          GraphicCanvas = g;
          pen = new Pen(Color.Black);
      }
      public abstract void Draw();
  }
}
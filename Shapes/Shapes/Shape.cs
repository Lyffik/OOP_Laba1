using System;
using System.Collections.Generic;
using System.Drawing;

namespace Shapes
{
  abstract class Shape
  {
      protected Pen pen;

      protected Graphics GraphicCanvas;
      public string ShapeName { get; set; }
      protected Shape(string name,Graphics g)
      {
          ShapeName = name;
          GraphicCanvas = g;
      }
      public abstract void Draw();
  }
}
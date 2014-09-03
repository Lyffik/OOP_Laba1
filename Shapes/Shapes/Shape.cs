using System;
using System.Collections.Generic;
using System.Drawing;

namespace Shapes
{
  abstract class Shape
  {
      protected Pen pen;
      protected List<Point> pointsList;
      public Color penColor
      {
          get { return pen.Color; }
          set { pen.Color = value; }
      }
      public Graphics GraphicCanvas { get; set; }
      public string ShapeName { get; set; }
      public Shape(string name,Graphics g)
      {
          ShapeName = name;
          GraphicCanvas = g;
          penColor = Color.DarkBlue;
          pen=new Pen(penColor);
      }
      public virtual void Draw(List<Point> plist )
      {
      }
    }
}
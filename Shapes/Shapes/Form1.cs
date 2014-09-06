using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eclipsedll;
using Linedll;
using Pilygondll;
using Rectdll;
using Shapedll;
using ShapeListdll;

namespace Shapes
{
    public partial class Shape : Form
    {
        public Shape()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics graphics;
            graphics = pictureBox.CreateGraphics();
            graphics.Clear(Color.White);
            ShapesList shapes=new ShapesList();
            shapes.AddShape(new Line(new Point(20, 5), new Point(70, 300)));
            shapes.AddShape(new Eclipse( new Rectangle(70, 25, 100, 200)));
            shapes.AddShape(new Rect(new Rectangle(180, 25, 150, 200)));
            shapes.AddShape(new Polygon( new Point[] { new Point(350, 25), new Point(410, 40), new Point(370, 100), new Point(400, 300), new Point(340, 320) }));
            shapes.DrawListOfShapes(graphics);
            graphics.Dispose();
        }
    }
}

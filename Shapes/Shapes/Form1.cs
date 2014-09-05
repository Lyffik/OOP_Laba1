using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
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
            graphics = pictureBox1.CreateGraphics();
            ShapesList shapes=new ShapesList();
            shapes.AddShape(new MyLine(graphics, new Point(20, 5), new Point(70, 300)));
            shapes.AddShape(new MyElipse(graphics, new Rectangle(70, 25, 100, 200)));
            shapes.AddShape(new MyRectangle(graphics, new Rectangle(180, 25, 150, 200)));
            shapes.AddShape(new MyPolygon(graphics, new Point[] { new Point(350, 25), new Point(410, 40), new Point(370, 100), new Point(400, 300), new Point(340, 320) }));
            shapes.DrawListOfShapes();
            graphics.Dispose();
        }
    }
}

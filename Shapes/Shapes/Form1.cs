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
            shapes.AddShape(new Line(graphics, new Point(1, 1), new Point(100, 100)));
            shapes.AddShape(new Elipse(graphics, new RectangleF(50, 60, 100, 110)));
            shapes.AddShape(new Rect(graphics, new Rectangle(50, 60, 100, 110)));
            graphics.Dispose();
        }
    }
}

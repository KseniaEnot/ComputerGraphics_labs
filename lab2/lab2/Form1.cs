using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Magenta, 3);
        Pen pen2 = new Pen(Color.RosyBrown, 5);
        int crunch = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            
            List<Point> input_points = new List<Point>(); // введённые точки
            input_points.Add(new Point((int)x1.Value, (int)y1.Value));
            input_points.Add(new Point((int)x2.Value, (int)y2.Value));
            input_points.Add(new Point((int)x3.Value, (int)y3.Value));
            input_points.Add(new Point((int)x4.Value, (int)y4.Value));

            for (int i = 0; i < 3; i++)
            {
                e.Graphics.DrawLine(pen, input_points[i], input_points[i + 1]);
            }

            if (crunch == 1)
            {
                e.Graphics.DrawBezier(pen2, input_points[0], input_points[1], input_points[2], input_points[3]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(BackColor);
            crunch = 0;
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(BackColor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            crunch = 1;
            pictureBox1.Refresh();
        }
    }
}

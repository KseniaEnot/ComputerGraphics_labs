using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        static int size = 100;
        static Size diameter = new Size(size * 2, size * 2);
        Pen pen = new Pen(Color.Magenta, 10);
        Color background = Color.AntiqueWhite;
        bool f = false;
        static Point point = new Point(0, 0);
        Rectangle rect = new Rectangle(point, diameter);

        static bool isNumber(String s)
        {

            for(int i = 0; i < s.Length; i++)
            {
                if ((s[i] != '0') || (s[i] != '1') || (s[i] != '2') || (s[i] != '3') || (s[i] != '4') ||
                    (s[i] != '5') || (s[i] != '6') || (s[i] != '7') || (s[i] != '8') || (s[i] != '9'))
                    return false;
            }
            return true;
        }

        static bool isDouble(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] != '0') || (s[i] != '1') || (s[i] != '2') || (s[i] != '3') || (s[i] != '4') ||
                    (s[i] != '5') || (s[i] != '6') || (s[i] != '7') || (s[i] != '8') || (s[i] != '9') 
                    || (s[i] != '.') || (s[i] != ','))
                    return false;
            }
            return true;
        }

        static Point RotatePoint(Point pointToRotate, Point centerPoint, double angleInDegrees)
        { // По часовой +, против часовой -
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            return new Point
            {
                X =
                    (int)
                    (cosTheta * (pointToRotate.X - centerPoint.X) -
                    sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X),
                Y =
                    (int)
                    (sinTheta * (pointToRotate.X - centerPoint.X) +
                    cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y)
            };
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Кручу-верчу";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = true;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(BackColor);
            pictureBox1.Refresh();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            if (f)
            {
                String x = textBox2.Text.Trim();
                String y = textBox1.Text;
                String a = textBox3.Text;
                int ix, iy; double ia;
                if (int.TryParse(x, out ix) && int.TryParse(y, out iy) && double.TryParse(a, out ia))
                {
                    Point point1 = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                    point = RotatePoint(point, point1, Convert.ToDouble(a));
                    rect = new Rectangle(point, diameter);
                    e.Graphics.DrawEllipse(pen, rect);
                    rect = new Rectangle(point1, new Size(10, 10));
                    e.Graphics.DrawEllipse(pen, rect);
                }
            }
            else
            {
                e.Graphics.DrawEllipse(pen, rect);
            }
        }
    }
}

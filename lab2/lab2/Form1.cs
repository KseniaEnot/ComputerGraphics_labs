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

        public Form1()
        {
            InitializeComponent();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            List<PointF> input_points = new List<PointF>(); // введённые точки
            input_points.Add(new PointF((float)x1.Value, (float)y1.Value));
            input_points.Add(new PointF((float)x2.Value, (float)y2.Value));
            input_points.Add(new PointF((float)x3.Value, (float)y3.Value));
            input_points.Add(new PointF((float)x4.Value, (float)y4.Value));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(BackColor);
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(BackColor);
        }
    }

    class BSplineCurve
    {
        int Degree; //порядок сплайна
        int Resolution; //количество точек сплайна
        List<float> Knots = new List<float>(); //узлы сплайна
        List<PointF> ControlPoints = new List<PointF>();

        //Получить текущий интервал
        private int getInterval(float currentPosition)
        {
            for (int whichInterval = 0; whichInterval < Knots.Count - 1; whichInterval++)
            {
                if (Knots[whichInterval] <= currentPosition && currentPosition < Knots[whichInterval + 1]) return whichInterval;
            }
            return 0;
        }
        //Расчет текущей точки
        private void calcCurrentPoint(float currentPosition, int whichInterval, ref PointF pnt)
        {
            List<PointF> A = new List<PointF>();
            int i, j, r;
            float d1, d2;

            for (j = 0; j < Degree; j++)
                A.Add(ControlPoints[whichInterval - Degree + 1 + j]);

            for (r = 1; r < Degree; r++)
            {
                for (j = Degree - 1; j >= r; j--)
                {
                    i = whichInterval - Degree + 1 + j;
                    d1 = (currentPosition - Knots[i]); d2 = (Knots[i + Degree - r] - currentPosition);
                    PointF newPoint = new PointF((d1 * A[j].X + d2 * A[j - 1].X) / (d1 + d2), (d1 * A[j].Y + d2 * A[j - 1].Y) / (d1 + d2));
                    A[j] = newPoint;
                }
            }
            pnt.X = A[Degree - 1].X;
            pnt.Y = A[Degree - 1].Y;
        }

        public List<PointF> points = new List<PointF>(); // точки для кривой

        /*
        * t - порядок сплайна (степень кривой),
        * Control - контрольные точки,
        * knots - узлы сплайна
        */
        public BSplineCurve(int t, ref List<PointF> Control, ref List<float> knots)
        {
            Degree = t; //степень сплайна
            Resolution = 200;

            for (int i = 0; i < Control.Count; i++) ControlPoints.Add(Control[i]);

            for (int i = 0; i < knots.Count; i++) Knots.Add(knots[i]);

            float currentPosition = 0;
            float step = (float)(1.0 / Resolution);
            PointF PNT = new PointF();

            for (int j = 0; j < Resolution; j++)
            {
                int whichInterval = getInterval(currentPosition);

                calcCurrentPoint(currentPosition, whichInterval, ref PNT);

                points.Add(PNT);
                currentPosition += step;
            }
        }
    }
}

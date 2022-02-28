using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        Pen pen = new Pen(Color.Magenta, 3);
        Point[] points = { new Point(5, 5), new Point(90, 10), new Point(55, 49) };

        static Point[] RotatePoint(Point[] pointToRotate, Point centerPoint, double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            double[,] matrix1 = { {pointToRotate[0].X, pointToRotate[0].Y, 1 }, { pointToRotate[1].X, pointToRotate[1].Y, 1 }, { pointToRotate[2].X, pointToRotate[2].Y, 1 } };
            double[,] matrix2 = { {1, 0 , 0 },{0, 1, 0 },{-centerPoint.X, -centerPoint.Y, 1 } };
            double[,] matrix3 = { { cosTheta, sinTheta , 0 },{-sinTheta, cosTheta, 0 },{0, 0, 1 } };
            double[,] matrix4 = { { 1, 0, 0 }, { 0, 1, 0 }, { centerPoint.X, centerPoint.Y, 1 } };
            double[,] matrixRes = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matrixRes[i,j] = 0;
                    for (int k = 0; k < 3; k++)
                        matrixRes[i, j] += matrix1[i,k] * matrix2[k,j];
                }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                        matrix1[i, j] += matrixRes[i, k] * matrix3[k, j];
                }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matrixRes[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                        matrixRes[i, j] += matrix1[i, k] * matrix4[k, j];
                }

            Point[] points = { new Point((int)matrixRes[0, 0], (int)matrixRes[0, 1]), new Point((int)matrixRes[1, 0], (int)matrixRes[1, 1]),new Point((int)matrixRes[2, 0], (int)matrixRes[2, 1])};
            return points;
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
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(BackColor);
            pictureBox1.Refresh();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Red, 3), points[0], points[1]);
            e.Graphics.DrawLine(new Pen(Color.Red, 3), points[0], points[2]);
            e.Graphics.DrawLine(new Pen(Color.Red, 3), points[2], points[1]);
            String x = textBox2.Text.Trim();
            String y = textBox1.Text;
            String a = textBox3.Text;
            int ix, iy; double ia;
            if (int.TryParse(x, out ix) && int.TryParse(y, out iy) && double.TryParse(a, out ia))
            {
                Point point1 = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                Point[] newPoints = RotatePoint(points, point1, Convert.ToDouble(a));
                e.Graphics.DrawLine(pen, newPoints[0], newPoints[1]);
                e.Graphics.DrawLine(pen, newPoints[0], newPoints[2]);
                e.Graphics.DrawLine(pen, newPoints[2], newPoints[1]);
                points[0] = newPoints[0];
                points[1] = newPoints[1];
                points[2] = newPoints[2];
                e.Graphics.DrawEllipse(pen, new Rectangle(point1, new Size(10, 10)));
            }
        }
    }
}

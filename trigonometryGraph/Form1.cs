using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trigonometryGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw_Coordinate()
        {
            Graphics gr = pictureBox1.CreateGraphics();
            Point startx = new Point(20,100);
            Point endx = new Point(472, 100);

            Point starty = new Point(20,0);
            Point endy = new Point(20,214);

            Point y_05 = new Point(0, 50);
            Point y_1 = new Point(10, 0);
            Point y__05 = new Point(0, 130);
            Point y__1 = new Point(5, 185);

            Point x_0 = new Point(105, 105);
            Point x_1 = new Point(185, 105);
            Point x_2 = new Point(280, 105);
            Point x_3 = new Point(360, 105);


            Font a = new Font("Arial", 9);
            Brush brush = Brushes.Black;

            gr.DrawString("0.5", a, brush, y_05);
            gr.DrawString("1",a, brush, y_1);
            gr.DrawString("-0.5", a, brush, y__05);
            gr.DrawString("-1", a, brush, y__1);

            gr.DrawString("90",a,brush,x_0);
            gr.DrawString("180", a, brush, x_1);
            gr.DrawString("270", a, brush, x_2);
            gr.DrawString("360", a, brush, x_3);

            gr.DrawLine(Pens.Red, startx, endx);
            gr.DrawLine(Pens.Red, endy, starty);   
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Draw_Coordinate();
            int start = Convert.ToInt32(textBox1.Text);
            int end = Convert.ToInt32(textBox2.Text);

            if (start < end)
            {
                if (start < 360)
                {
                    Point[] points = new Point[end - start];

                    int x = 0;
                    for (int i = start; i < end; i++)
                    {
                        points[x] = new Point(i + 20, (int)(Math.Cos(i * Math.PI / 180) * (-100) + 100));
                        x++;
                    }
                    g.DrawCurve(Pens.Blue, points);
                }
                else
                {
                    start %= 360;
                    end %= 360;

                    if (end == 0)
                    {
                        end = 360;
                    }

                    Point[] points = new Point[end - start];

                    int x = 0;
                    for (int i = start; i < end; i++)
                    {
                        points[x] = new Point(i + 20, (int)(Math.Cos(i * Math.PI / 180) * (-100) + 100));
                        x++;
                    }
                    g.DrawCurve(Pens.Blue, points);
                }
            }

            else
            {
                MessageBox.Show("The starting value cannot be greater than the end value.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Draw_Coordinate();
            int start = Convert.ToInt32(textBox1.Text);
            int end = Convert.ToInt32(textBox2.Text);

            if (start < end)
            {
                Point[] points = new Point[end - start];

                if (start < 360)
                {
                    int x = 0;
                    for (int i = start; i < end; i++)
                    {
                        points[x] = new Point(i + 20, (int)(Math.Sin(i * Math.PI / 180) * (-100) + 100));
                        x++;
                    }
                    g.DrawCurve(Pens.Blue, points);
                }
                else
                {
                    start %= 360;
                    end %= 360;

                    if (end == 0)
                    {
                        end = 360;
                    }

                    int x = 0;
                    for (int i = start; i < end; i++)
                    {
                        points[x] = new Point(i + 20, (int)(Math.Sin(i * Math.PI / 180) * (-100) + 100));
                        x++;
                    }
                    g.DrawCurve(Pens.Blue, points);
                }
            }

            else
            {
                MessageBox.Show("The starting value cannot be greater than the end value.");
            }
        }
    }
}

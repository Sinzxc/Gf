using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GF
{

    public partial class Form1 : Form
    {
        double x, y;
        int size = 5;
        double a = 0.1;
        int b = 3;
        int pos =-1;
        double of = 0.01;
        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
            a = (double)numericUpDown2.Value;
            of = (double)numericUpDown2.Value;
            Invalidate();
        }

        private void numericUpDown3_ValueChanged_1(object sender, EventArgs e)
        {
            //b = Convert.ToInt32(numericUpDown3.Value);
            //a = b / 3;
            Invalidate();
        }
        void HideP()
        {
            panel4.Visible = false;
            panel5.Visible = false;
        }
        void ShowP()
        {
            panel4.Visible = true;
            panel5.Visible = true;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = Convert.ToInt32(trackBar1.Value);
            label2.Text = size.ToString();
            Invalidate();
        }

        private void простыеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void параболаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 0;
            Invalidate();
            
            HideP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void линейныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 1;
            Invalidate();
            ShowP();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideP();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void гиперболаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 3;
            Invalidate();
            ShowP();
            panel5.Visible = false;
        }

        private void параболакубToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 4;
            Invalidate();
            HideP();
        }

        private void ветвьПараболыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 5;
            Invalidate();
            HideP();
        }

        private void sinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 6;
            Invalidate();
            HideP();
            panel4.Visible = true;
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 7;
            Invalidate();
            HideP();
            panel4.Visible = true;
        }

        private void tanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 8;
            Invalidate();
            HideP();
            panel4.Visible = true;
        }

        private void aTanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 9;
            Invalidate();
            HideP();
            panel4.Visible = true;
        }

        private void кардиоидаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 10;
            Invalidate();
            ShowP();
        }

        private void спиральToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 11;
            Invalidate();
            ShowP();
        }

        private void декартовЛистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 12;
            Invalidate();
            ShowP();
        }

        private void фигураЛиссажуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 13;
            Invalidate();
            ShowP();
        }

        private void розаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 14;
            Invalidate();
            ShowP();
        }

        private void эллипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = 15;
            Invalidate();
            ShowP();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            int px = Width / 2;
            int py = Height / 2;
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, 0, py, Width, py);
            g.DrawLine(p, px, 0, px, Height);
            if (pos == 0)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    y = x * x;
                    g.FillEllipse(Brushes.Red, px + (float)x * size, -(float)y + py, 5, 5);
                }
            }
            if (pos == 1)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    y = (int)numericUpDown3.Value * x+ (int)numericUpDown4.Value;
                    g.FillEllipse(Brushes.Red, px + (float)x * size, -(float)y + py, 5, 5);
                }
            }
            if (pos == 2)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    y = (int)numericUpDown3.Value * x + (int)numericUpDown4.Value;
                    g.FillEllipse(Brushes.Red, px + (float)x * size, -(float)y + py, 5, 5);
                }
            }
            if (pos == 3)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    if (x > 0.000001 || x < -0.000001)
                    {
                        y = (int)numericUpDown3.Value / x;
                        g.FillEllipse(Brushes.Red, px + (float)x * size, -(float)y + py, 5, 5);
                    }

                }
            }
            if (pos == 4)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    y = Math.Pow(x, 3);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, -(float)y + py, 5, 5);


                }
            }
            if (pos == 5)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    y = Math.Sqrt(x)*5;
                    g.FillEllipse(Brushes.Red, px + (float)x * size, -(float)y + py, 5, 5);


                }
            }
            if (pos == 6)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    y = Math.Sin(x);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, (-(float)y * (int)numericUpDown3.Value + py), 5, 5);


                }
            }
            if (pos == 7)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    y = Math.Cos(x);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, (-(float)y * (int)numericUpDown3.Value + py), 5, 5);


                }
            }
            if (pos == 8)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    y = Math.Tan(x);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, (-(float)y * (int)numericUpDown3.Value + py), 5, 5);


                }
            }
            if (pos == 9)
            {
                for (double x = -Width; x < Width; x += a)
                {
                    y = Math.Atan(x);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, (-(float)y * (int)numericUpDown3.Value + py), 5, 5);


                }
            }
            if (pos == 10)
            {
                panel5.Visible = false;
                if(numericUpDown3.Value<3) numericUpDown3.Value = 3;
                b = (int)numericUpDown3.Value;
                a = b / 3;
                for (double f = 0; f < 2 * Math.PI; f += of)
                {
                    x = (a + b) * Math.Cos(f) - a * Math.Cos((a + b) * f / a);
                    y = (a + b) * Math.Sin(f) - a * Math.Sin((a + b) * f / a);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, size * (float)y + py, 5, 5);
                }
            }
            if (pos == 11)
            {
                panel5.Visible = false;
                double a = 0.2;
                double n = 5;
                double b = 0.15;
                double r;
                a = (double)numericUpDown3.Value;
                for (double f = 0; f < 100; f += of)
                {
                    r = a * Math.Exp(b * f);
                    x = r * Math.Cos(f);
                    y = r * Math.Sin(f);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, size * (float)y + py, 5, 5);
                }
            }
            if (pos == 12)
            {
                double a = 4, r;
                panel5.Visible=false;
                a = Convert.ToInt32(numericUpDown3.Value);
                for (double f = 0; f < 2 * Math.PI; f += of)
                {

                    r = 3 * a * Math.Cos(f) * Math.Sin(f) / (Math.Pow(Math.Cos(f), 3) + Math.Pow(Math.Sin(f), 3));

                    x = r * Math.Cos(f);

                    y = r * Math.Sin(f);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, size * (float)y + py, 5, 5);
                }
            }
            if (pos == 13)
            {
                double i, j;
                i= (double)(numericUpDown4.Value);
                j = (double)(numericUpDown4.Value);
                double r = (double)(numericUpDown3.Value);
                for (double f = -Math.PI; f < Math.PI; f += of)
                {
                    x = r * Math.Cos(i * f);

                    y = r * Math.Sin(3 * f);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, size * (float)y + py, 5, 5);
                }
            }
            if (pos == 14)
            {
                panel5.Visible = false;
                double r;
                int k = (int)numericUpDown3.Value;
                for (double f = -Math.PI; f < Math.PI; f += of)
                {
                    r = Math.Sin(k * f);

                    x = 10 * r * Math.Cos(f);

                    y = 10 * r * Math.Sin(f);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, size * (float)y + py, 5, 5);
                }
            }
            if (pos == 15)
            {
                double i, j;
                i = (double)(numericUpDown4.Value);
                j = (double)(numericUpDown4.Value);
                double r = (double)(numericUpDown3.Value);
                for (double f = -Math.PI; f < Math.PI; f += of)
                {
                    x = r * Math.Cos(i * f);

                    y = r * Math.Sin(i+j * f);
                    g.FillEllipse(Brushes.Red, px + (float)x * size, size * (float)y + py, 5, 5);
                }
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testík
{
    public partial class Form1 : Form
    {
        int uhelZamerovani = -90;
        int vzdalenostX, vzdalenostY = 0;
        float rychlost = 5;
        float smerX, smerY = 0;
        float zajicekX = 350;
        float zajicekY = 200;

        float rychlostStrely = 10;
        float smerStrelyX;
        float smerStrelyY;

        public Form1()
        {
            InitializeComponent();
            noveVajicko();
        }

        private void timerZajicek_Tick(object sender, EventArgs e)
        {
            zajicekX += smerX * rychlost;
            zajicekY += smerY * rychlost;

            zajicek.Left = (int)zajicekX;
            zajicek.Top = (int)zajicekY;

            if (VzdalenostZajicekVajicko() < 50)
            {
                noveVajicko();
            }
        }

        private void strela_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.FillEllipse(Brushes.DarkGray,1,1,18,18);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                uhelZamerovani -= 2;
                Zamerovani();
            }
            if (e.KeyCode == Keys.Right)
            {
                uhelZamerovani += 2;
                Zamerovani();
            }
            if (e.KeyCode == Keys.Space)
            {
                if (!strela.Visible)
                {
                    strela.Left = delo.Left + delo.Width / 2 - strela.Width / 2;
                    strela.Top = delo.Top + delo.Height / 2 - strela.Height / 2;

                    smerStrelyX = (float)Math.Cos(uhelZamerovani * Math.PI / 180) * rychlostStrely;
                    smerStrelyY = (float)Math.Sin(uhelZamerovani * Math.PI / 180) * rychlostStrely;

                    strela.Visible = true;
                }
            }
        }

        void Zamerovani()
        {
            Graphics g = CreateGraphics();

            g.Clear(SystemColors.Control);

            int delkaZamerovani = 80;
            int x = delo.Left + delo.Width / 2 + (int)(Math.Cos(uhelZamerovani * Math.PI / 180) * delkaZamerovani);
            int y = delo.Top + delo.Height / 2 + (int)(Math.Sin(uhelZamerovani * Math.PI / 180) * delkaZamerovani);

            g.DrawLine(new Pen(Color.Black, 8), delo.Left + delo.Width / 2, delo.Top + delo.Height / 2, x, y);
        }

        private void timerStrela_Tick(object sender, EventArgs e)
        {
            if (strela.Visible)
            {
                strela.Left += (int)smerStrelyX;
                strela.Top += (int)smerStrelyY;
            }
        }

        void noveVajicko() 
        {
            Random rnd = new Random();
            int x = rnd.Next(30,Width - vajicko.Width  -30);
            int y = rnd.Next(30,Height- vajicko.Height -80);

            vajicko.Location = new Point(x, y);

            vzdalenostX = vajicko.Location.X - zajicek.Location.X;
            vzdalenostY = vajicko.Location.Y - zajicek.Location.Y;

            double vzdalenost = VzdalenostZajicekVajicko();

            smerX = (float)(vzdalenostX / vzdalenost);
            smerY = (float)(vzdalenostY / vzdalenost);

            if (smerX > 0)
            {
                zajicek.BackgroundImage = Properties.Resources.zajicek1;
            }
            else
            {
                zajicek.BackgroundImage = Properties.Resources.zajicek;
            }
        }

        double VzdalenostZajicekVajicko()
        {
            int x = vajicko.Location.X - zajicek.Location.X;
            int y = vajicko.Location.Y - zajicek.Location.Y;

            return Math.Sqrt(x * x + y * y);
        }
    }
}

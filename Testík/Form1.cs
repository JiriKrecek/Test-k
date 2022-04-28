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
        int vzdalenostX, vzdalenostY = 0;
        float rychlost = 5;
        float smerX, smerY = 0;
        float zajicekX = 350;
        float zajicekY = 200;

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

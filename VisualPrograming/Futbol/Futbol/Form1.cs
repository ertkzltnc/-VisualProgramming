using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbol
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        int xTop, yTop ,skor=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcbTop.Location =new Point (rnd.Next(400, 750), rnd.Next(20, 450));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            xTop = pcbTop.Location.X;
            yTop = pcbTop.Location.Y;
            if (e.KeyCode==Keys.Right)
            {
                if (xTop>10 && xTop<780)
                {
                    xTop += rnd.Next(1, 50);
                }
                pcbTop.Location = new Point(xTop, yTop);
            }
            if (e.KeyCode == Keys.Left)
            {
                if (xTop > 10 && xTop < 780)
                {
                    xTop -= rnd.Next(1, 50);
                }
                pcbTop.Location = new Point(xTop, yTop);
            }
            if (e.KeyCode == Keys.Up)
            {
                if (yTop > 10 && yTop < 480)
                {
                    yTop -= rnd.Next(1, 50);
                }
                pcbTop.Location = new Point(xTop, yTop);
            }
            if (e.KeyCode == Keys.Down)
            {
                if (yTop > 10 && yTop < 780)
                {
                    yTop += rnd.Next(1, 50);
                }
                pcbTop.Location = new Point(xTop, yTop);

            }
            if (xTop <= 8 && yTop>155 && yTop<250) {
                skor++;
                lblGol.Text = "GOOOOOOL" + " " + "SKOR:" + skor;
                pcbTop.Location = new Point(rnd.Next(400, 750), rnd.Next(20, 450));

            }
            if (xTop >= 780 || yTop <= 20 || yTop >= 450) {
                lblGol.Text = "Top Dısarida";

                pcbTop.Location = new Point(rnd.Next(400, 750), rnd.Next(20, 450));

            };
            if(e.KeyCode==Keys.F) lblGol.Text = "";


        }
    }
}

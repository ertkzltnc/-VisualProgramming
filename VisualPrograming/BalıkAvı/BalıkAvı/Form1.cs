using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalıkAvı
{  // yeme kısmı eksik bakilacak
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int xTimsah = pcBTimsah.Location.X;
            int yTimsah = pcBTimsah.Location.Y;
            int xB1= pcb1.Location.X;
            int yB1 = pcb1.Location.Y;
            int xB2 = pcb2.Location.X;
            int yB2 = pcb2.Location.Y;
            int xB3 = pcb3.Location.X;
            int yB3 = pcb3.Location.Y;
            try
            {
                if (e.KeyCode == Keys.Right && xTimsah < 800)
                {
                    xTimsah += 1;
                }
                else if (e.KeyCode == Keys.Left && xTimsah > 0)
                {
                    xTimsah -= 1;

                }
                else if (e.KeyCode == Keys.Up && yTimsah > 0)
                {
                    yTimsah -= 1;

                }
                else if (e.KeyCode == Keys.Down && yTimsah < 400)
                {
                    yTimsah += 1;

                }


                pcBTimsah.Location = new Point(xTimsah, yTimsah);
                if (pcBTimsah.Location==pcb1.Location)
                {
                    pcb1.Visible = false;
                }
                if (xTimsah < (xB2 - 3) || xTimsah > (xB2 + 3) || yTimsah < (yB2 - 3) || yTimsah < (yB2 + 3))
                {
                    pcb2.Visible = false;
                }
                if (xTimsah < (xB3 - 3) || xTimsah > (xB3 + 3) || yTimsah < (yB3 - 3) || yTimsah < (yB3 + 3))
                {
                    pcb3.Visible = false;
                }

            }
            catch (Exception ex)
            {
               // lblSonuc.Text = "HATA!!";

            }
        }
    }
}

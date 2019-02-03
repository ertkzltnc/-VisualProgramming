using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuvarCarpma
{
    public partial class Form1 : Form
    {
        int px, py, vx = 10, vy = 10;
        int counter = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // seffa olma 
            //this.BackColor = Color.White;
            //this.TransparencyKey = Color.White; 
            //pictureBox1.BackColor = Color.White;

            Random rnd = new Random();
            px = rnd.Next(0, 800);
            py = rnd.Next(0, 550);
            pictureBox1.Location = new Point(px, py);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(px += vx, py += vy);
            if (pictureBox1.Left <= Form1.ActiveForm.Left)
            {
                vx = -1 * vx; counter++;
            }
            if (pictureBox1.Top <= Form1.ActiveForm.Top)
            {
                vy = -1 * vy; counter++;
            }
            if (pictureBox1.Right >= Form1.ActiveForm.Right)
            {
                vx = -1 * vx; counter++;
            }
            if (pictureBox1.Bottom >= Form1.ActiveForm.Bottom)
            {
                vy = -1 * vy; counter++;
            }
            if (counter == 10)
            {
                timer1.Stop();
            }
        }
    }
}

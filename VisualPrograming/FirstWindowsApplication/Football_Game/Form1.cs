using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int y = pictureBox1.Location.Y;
            int x = pictureBox1.Location.X;
            Random rnd = new Random();

            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Location = new Point(x, (y-rnd.Next(5,40)));

            }
            else if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Location = new Point(x, (rnd.Next(5, 40) + y));
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Location = new Point((rnd.Next(5, 40) + x), y);
            }
            else if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Location = new Point(x-(rnd.Next(5, 40)), y);
            }

        if(pictureBox1.Location.X > 580  && pictureBox1.Location.Y <174 && pictureBox1.Location.Y>152)
            {
                MessageBox.Show("Goooooolllll....");
                pictureBox1.Location = new Point(rnd.Next(50, 400), rnd.Next(50, 400));
            }
       
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crocodile_Fish
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


            if (e.KeyCode == Keys.Up)
            {
               
                pictureBox1.Location = new Point(x, y-1);

                Image flipImage = pictureBox1.Image;
                flipImage.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox1.Image = flipImage;

            }
            else if(e.KeyCode == Keys.Down)
            {
                pictureBox1.Location = new Point(x, y +1);
            }
            else if(e.KeyCode == Keys.Right)
            {
                pictureBox1.Location = new Point(x+1, y);
            }
            else if(e.KeyCode == Keys.Left){
                pictureBox1.Location = new Point(x-1,y);
            }
            else
            {

            }

            if(pictureBox1.Location.X == pictureBox7.Location.X && pictureBox1.Location.Y == pictureBox7.Location.Y)
            {
                pictureBox7.Visible = false;
            }

        }
    }
}

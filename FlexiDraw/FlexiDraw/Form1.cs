using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexiDraw
{
    public partial class Form1 : Form
    {
        Graphics graf;
        Pen pen;
        int size;

        public Form1()
        {
            InitializeComponent();
            graf = panel2.CreateGraphics();
            pen = new Pen(Color.Black,5);
        }
        int x = 0;
        int y = 0;

        private void panel2_Paint(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, MouseEventArgs e)
        {

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen.Color = Color.AliceBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Aquamarine;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pen.Color = Color.LightGreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pen.Color = Color.DarkViolet;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pen.Color = Color.DarkGray;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            pen.Color = Color.LightGray;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                graf.DrawLine(pen, x, y, e.X, e.Y);
            x = e.X;
            y = e.Y;
        }
    }
}

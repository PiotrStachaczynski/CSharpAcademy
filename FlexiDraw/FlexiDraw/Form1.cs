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
        bool NEW_TEXT;
        bool textclicked;
        Drawable draw = new Drawable();
        MouseEventArgs w;
 

        public Form1()
        {
            InitializeComponent();
            graf = panel2.CreateGraphics();
            pen = new Pen(Color.Black, size);
        }
        int x = 0, y = 0;

        public void test(MouseEventArgs e)
        {
            if (NEW_TEXT == true)
            {
                Label text = new Label();
                Panel DockText = new Panel();
                DockText.Location = new Point(e.X, e.Y - 25);
                DockText.Size = new Size(100, 20);
                DockText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                RichTextBox write = new RichTextBox();
                text.Location = new Point(e.X, e.Y);
                text.Text = "Tekst";
                Cursor.Current = Cursors.Default;
                textclicked = false;
                panel2.Controls.Add(text);
                panel2.Controls.Add(DockText);
                DockText.Controls.Add(write);
            }
        }

      

        private void panel2_Paint(object sender, MouseEventArgs e)
        {
             RichTextBox text = new RichTextBox();
            text.Location = new Point(MousePosition.X, MousePosition.Y);

        }

        private void panel1_Paint(object sender, MouseEventArgs e)
        {
            if (textclicked == true)
            {
                Cursor.Current = Cursors.Hand;
                if (e.Button == MouseButtons.Left)
                {
                    RichTextBox text = new RichTextBox();
                    text.Location = new Point(e.X, e.Y);
                    Cursor.Current = Cursors.Default;
                    textclicked = false;
                    this.Controls.Add(text);
                }
            }
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
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
            pen.Color = Color.Honeydew;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            draw.SetPenSize(trackBar1, size, pen);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textclicked = true;   
        }

       public void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textclicked == true)
            {
                
                Cursor.Current = Cursors.Hand;
                if (e.Button == MouseButtons.Left)
                {
                    test(e);
                //        
                }
            }
        }
      
     




        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
               
                graf.DrawLine(pen, x, y-3, e.X, e.Y+3);
                graf.DrawLine(pen, x, y + 3, e.X, e.Y - 3);
            }
            x = e.X;
            y = e.Y;

        }
    }
}

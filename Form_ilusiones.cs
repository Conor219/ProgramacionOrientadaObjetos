using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaObjetos
{
    public partial class Form_ilusiones : Form
    {
        Pen rojo = new Pen(Color.Red);
        Pen yellow = new Pen(Color.Yellow);
        Pen green = new Pen(Color.Green);
        Pen blue = new Pen(Color.Blue);
        Pen fuchsia = new Pen(Color.Fuchsia);
        Pen aqua = new Pen(Color.Aqua);
        Pen sienna = new Pen(Color.Sienna);
        Pen brown = new Pen(Color.Brown);
        public Form_ilusiones()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            e.Graphics.DrawLine(rojo, 0, 0, w, h);
            
            e.Graphics.DrawLine(fuchsia, 0, h/2, w/2, 0);

            e.Graphics.DrawLine(yellow, 0, h, w, 0);
            
            e.Graphics.DrawLine(sienna, 0, h/2, w/2, h);

            e.Graphics.DrawLine(green, w/2, 0, w/2, h);
            
            e.Graphics.DrawLine(brown, w/2, 0, w, h/2);

            e.Graphics.DrawLine(blue, 0, h/2, w, h/2);
            
            e.Graphics.DrawLine(aqua, w/2, h, w, h/2);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox2.Width;
            int h = pictureBox2.Height;

            for (int i = 0; i < w; i += 10)
            {

            e.Graphics.DrawLine(rojo, i, 0, i, h);
            
            }

        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {

            int w = pictureBox3.Width;
            int h = pictureBox3.Height;

            for (int i = 0; i < w; i += 10)
            {

                e.Graphics.DrawLine(rojo, 0, i, w, i);

            }

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {

            int w = pictureBox4.Width;
            int h = pictureBox4.Height;

            for (int i = 0; i < w; i += 10)
            {

                e.Graphics.DrawLine(rojo, 0, i, w, i);
                e.Graphics.DrawLine(rojo, i, 0, i, h);

            }

        }
    }
}

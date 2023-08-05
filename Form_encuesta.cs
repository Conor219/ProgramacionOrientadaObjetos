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
    public partial class Form_encuesta : Form
    {
        public Form_encuesta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procesando Encuesta...", "Procesando...");
            richTextBox1.Text = "Bienvenido " + textBox1.Text + " " +
                textBox2.Text + " " + textBox3.Text + "\n" + "Tu fecha de nacimiento es: " + dateTimePicker1.Text;
        }
    }
}

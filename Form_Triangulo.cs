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
    public partial class Form_Triangulo : Form
    {
        public Form_Triangulo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("El triágulo es:");
            //MessageBox.Show(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            //MessageBox.Show(textBox1.Text + textBox2.Text + textBox3.Text);
            try
            {
                int lado1 = Convert.ToInt32(textBox1.Text);
                int lado2 = Convert.ToInt32(textBox2.Text);
                int lado3 = Convert.ToInt32(textBox3.Text);
                MessageBox.Show((lado1 + lado2 + lado3).ToString(), "Resultado");
            }catch(Exception Error) {
                MessageBox.Show("Error", "Errorsito", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            
           }

        }

        private void Form_Triangulo_Load(object sender, EventArgs e)
        {

        }
    }
}

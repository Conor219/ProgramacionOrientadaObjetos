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
    public partial class Form_catalogo : Form
    {
        public Form_catalogo()
        {
            InitializeComponent();
        }

        private void Form_catalogo_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            }
            else
            {
                MessageBox.Show("Faltan datos para añadir nuevo producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }
    }
}

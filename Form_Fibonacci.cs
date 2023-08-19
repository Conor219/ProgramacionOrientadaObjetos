using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramacionOrientadaObjetos
{
    public partial class Form_Fibonacci : Form
    {
        public Form_Fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int limite = Convert.ToInt32(textBox1.Text);
                int num1 = 0;
                int num2 = 1;
                int fibonacci;

                richTextBox1.Text = "Fibonacci = " + num1 + ", " + num2;

                for (int i = 2; num1 + num2 <= limite; i++)
                {
                    fibonacci = num1 + num2;
                    richTextBox1.Text += ", " + fibonacci;

                    num1 = num2;
                    num2 = fibonacci;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error", "Errorsito", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
        }
    }
}

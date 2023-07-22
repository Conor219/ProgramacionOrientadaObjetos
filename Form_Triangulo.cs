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
                float lado1 = float.Parse(textBox1.Text);
                float lado2 = float.Parse(textBox2.Text);
                float lado3 = float.Parse(textBox3.Text);
                //MessageBox.Show((lado1 + lado2 + lado3).ToString(), "Resultado");
                if (lado1 > 0 && lado2 > 0 && lado3 > 0)
                {
                    float mayor = lado1;

                    if (mayor < lado2) mayor = lado2;


                    if (mayor < lado3) mayor = lado3;
                    

                    if (mayor <= (lado1 + lado2 + lado3 - mayor))
                    {
                        //MessageBox.Show("Con estas medidas SÍ es posible formar un triángulo");
                        
                        if (lado1 == lado2 && lado1 == lado3)
                        {
                            //MessageBox.Show("Es un triángulo equilátero", "Equilátero");
                            label5.Text = "Es un triángulo equilátero";
                        }

                        else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
                        {
                            //MessageBox.Show("Es un triángulo escaleno", "Escaleno");
                            label5.Text = "Es un triángulo escaleno";
                        }   
                        else
                        {
                            //MessageBox.Show("Es un triángulo isosceles", "Isosceles");
                            label5.Text = "Es un triángulo isosceles";
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Con estas medidas NO es posible formar un triágunlo");
                        label5.Text = "Con estas medidas NO es posible formar un triágunlo";
                    }
                    
                }
                else
                {
                    //MessageBox.Show("Con esas medidas NO es posible formar un triángulo", "Error");
                    label5.Text = "Con estas medidas NO es posible formar un triágunlo";
                }
            }catch(Exception Error) {
                MessageBox.Show("Error", "Errorsito", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            
           }

        }

        private void Form_Triangulo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

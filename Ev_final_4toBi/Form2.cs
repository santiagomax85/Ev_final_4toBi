using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(TextVar1.Text);
            int n2 = int.Parse(TextVar2.Text);
            int n3 = 1; 

            while (n3 != n2)
            {
                Potencia = Potencia * n1;
                n3 = n2 + 1; 

            }
            MessageBox.Show("el resultado de la potencia es " + BtnPotencia); 
        }

        private void Btnproducto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int producto = num1 * num2;
            MessageBox.Show("el resultado es producto " + producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int suma = num1 + num2;

            MessageBox.Show("El resultado es de la suma es " + suma); 
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(TextVar1.Text);
            float num2 = float.Parse(TextVar2.Text);
            
            if (num2 > 0)
            {
                float division = num1 / num2;

                MessageBox.Show("El resultado es " + division);
            }
            else
            {
                MessageBox.Show("La division es indefinida"); 
            }
        }
    }
}

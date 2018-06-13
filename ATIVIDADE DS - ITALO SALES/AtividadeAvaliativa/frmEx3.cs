using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmEx3 : Form
    {
        /*
         * Ler 3 números, os possíveis lados de um triângulo, e imprimir a classificação de acordo com tamanho dos lados. 
            a. (Triangulo Equilátero – possui os três lados com medidas iguais) 
            b. (Triangulo Isósceles – possui dois lados com medidas iguais) 
            c. (Triangulo Escaleno – possui os três lados com medidas diferentes.) (usar if)
         * */

        public frmEx3()
        {
            InitializeComponent();
        }

        private void frmEx3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "";

            double num1 = System.Convert.ToDouble(txbNum1.Text);
            double num2 = System.Convert.ToDouble(txbNum2.Text);
            double num3 = System.Convert.ToDouble(txbNum3.Text);
            double val12 = val1 + val2;
            double val13 = val1 + val3;
            double val23 = val2 + val3;
            if (val12 <= val3 || val13 <= val2 || val23 <= val1)
            {
                lblResult.Text = "Os lados digitados não formam um triângulo";
            }
            else
            {

                if (val1 == val2 && val2 == val3)
                {
                    lblResult.Text = "OTriângulo é Equilátero";
                }

                else if (val1 == val2 || val2 == val3 || val1 == val3)
                {
                    lblResult.Text = "O Triângulo é Isósceles";
                }

                else
                {
                    lblResult.Text = "O Triângulo é Escaleno";
                }
            }



            if (num1 == num2 && num2 == num3)
            {
                txbResultado.Text = "Triangulo Equilátero – possui os três lados com medidas iguais";
            }
            if (num1 == num2 && num1 != num3 || num1 != num2 && num1 == num3 || num1 != num3 && num2 == num3)
            {
                txbResultado.Text = "Triangulo Isósceles – possui dois lados com medidas iguais";
            }
            if (num1 != num2 && num2 != num3 && num1 != num3)
            {
                txbResultado.Text = "Triangulo Escaleno – possui os três lados com medidas diferentes";
            }

        }


        /*
        private void txbNum1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbNum1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txbResultado.Text = txbResultado.Text.Remove(txbResultado.Text.Length - 1);
            }
        }
        */
    }
}

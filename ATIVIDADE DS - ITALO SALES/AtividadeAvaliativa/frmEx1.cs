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
    public partial class frmEx1 : Form
    {
        /*
         * Construir um programa que leia 2 números e efetue a adição. 
         * Caso o valor somado seja maior que 20, este deverá ser apresentada somando-se a ele mais 8; 
         * caso o valor somado seja menor ou igual a 20, este deverá ser apresentado subtraindo-se 5. (usar o if) 
         * */

        public frmEx1()
        {
            InitializeComponent();
        }

        private void frmEx1_FormClosing(object sender, FormClosingEventArgs e)
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
            double resultado = num1 + num2;

            if (resultado > 20)
            {
                resultado += 8;
                txbResultado.Text = resultado.ToString();
            }
            else
            {
                resultado -= 5;
                txbResultado.Text = resultado.ToString();
            }
        }

        private void frmEx1_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmEx5 : Form
    {
        /*
         * Criar um algoritmos que leia um número até 50 e imprima todos os número 
         * de 1 até o número digitado. (Usar Loop – For / While / Do While) 
         * */

        public frmEx5()
        {
            InitializeComponent();
        }

        private void frmEx5_FormClosing(object sender, FormClosingEventArgs e)
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

            if (System.Text.RegularExpressions.Regex.IsMatch(txbNum.Text, "[^0-9]"))
            {
                txbResultado.Text = "Digite apenas números.";
            }
            else
            {
                double num = System.Convert.ToDouble(txbNum.Text);

                if (num <= 50)
                {
                    for (int i = 1; i < num; i++)
                    {
                        txbResultado.Text += i + ", ";
                    }

                    txbResultado.Text += num + ".";
                }
            }
        }

        private void txbNum_TextChanged(object sender, EventArgs e)
        {
            txbResultado.Text = "";

            if (System.Text.RegularExpressions.Regex.IsMatch(txbNum.Text, "[^0-9]"))
            {
                txbResultado.Text = "Digite apenas números.";
            }
        }
    }
}

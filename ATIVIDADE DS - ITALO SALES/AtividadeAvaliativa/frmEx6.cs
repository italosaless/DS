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
    public partial class frmEx6 : Form
    {
        /*
         * Entrar com o número de vezes que se deseja imprimir a palavra “Brasil”. 
         * (Usar Loop – For / While / Do While) 
         * */

        public frmEx6()
        {
            InitializeComponent();
        }

        private void frmEx6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txbNum_TextChanged(object sender, EventArgs e)
        {
            txbResultado.Text = "";

            if (System.Text.RegularExpressions.Regex.IsMatch(txbNum.Text, "[^0-9]"))
            {
                txbResultado.Text = "Apenas números de 1 até 12";
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            txbResultado.Text = "";

            if (System.Text.RegularExpressions.Regex.IsMatch(txbNum.Text, "[^0-9]"))
            {
                txbResultado.Text = "Apenas números de 1 até 12";
            }
            else
            {
                double num = System.Convert.ToDouble(txbNum.Text);

                txbResultado.Text = "Brasil";
                for (int i = 1; i < num; i++)
                {
                    txbResultado.Text += " Brasil";
                }
            }
        }

    }
}

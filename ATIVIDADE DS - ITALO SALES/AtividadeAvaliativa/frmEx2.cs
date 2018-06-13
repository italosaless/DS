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
    public partial class frmEx2 : Form
    {
        /*
         * Entrar com um número e informar se ele é divisível por 10, 
         * por 5, por 2 ou se não é divisível por nenhum destes.
         * (usar mod = exemplo 4%2). 
         * */

        public frmEx2()
        {
            InitializeComponent();
        }

        private void frmEx2_FormClosing(object sender, FormClosingEventArgs e)
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

            if (System.Convert.ToDouble(txbNum.Text) % 2 == 0 || System.Convert.ToDouble(txbNum.Text) % 5 == 0 || System.Convert.ToDouble(txbNum.Text) % 10 == 0)
            {
                txbResultado.Text = "É divisível por ";
            }
            else
            {
                txbResultado.Text = "Não é divisível por 2, 5 e 10";
            }
           
            if (System.Convert.ToDouble(txbNum.Text) % 2 == 0)
            {
                txbResultado.Text += "2 ";
            }
            if (System.Convert.ToDouble(txbNum.Text) % 5 == 0)
            {
                txbResultado.Text += "5 ";
            }
            if (System.Convert.ToDouble(txbNum.Text) % 10 == 0)
            {
                txbResultado.Text += "10 ";
            }
        }
    }
}

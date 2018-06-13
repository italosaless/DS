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
    public partial class frmEx4 : Form
    {
        /*
         * Ler um número inteiro entre 1 e 12 e escrever o mês correspondente. 
         * Caso o número seja fora desse intervalo, informar que não existe mês com este número. (usar if) 
         * */

        public frmEx4()
        {
            InitializeComponent();
        }

        private void frmEx4_FormClosing(object sender, FormClosingEventArgs e)
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
            if (txbNum.Text == "1")
            {
                txbNum.Text = "Janeiro";
            }
            if (txbNum.Text == "2")
            {
                txbResultado.Text = "Fevereiro";
            }
            if (txbNum.Text == "3")
            {
                txbResultado.Text = "Março";
            }
            if (txbNum.Text == "4")
            {
                txbResultado.Text = "Abril";
            }
            if (txbNum.Text == "5")
            {
                txbResultado.Text = "Maio";
            }
            if (txbNum.Text == "6")
            {
                txbResultado.Text = "Junho";
            }
            if (txbNum.Text == "7")
            {
                txbResultado.Text = "Julho";
            }
            if (txbNum.Text == "8")
            {
                txbResultado.Text = "Agosto";
            }

            if (txbNum.Text == "9")
            {
                txbResultado.Text = "Setembro";
            }

            if (txbNum.Text == "10")
            {
                txbResultado.Text = "Outubro";
            }

            if (txbNum.Text == "11")
            {
                txbResultado.Text = "Novembro";
            }

            if (txbNum.Text == "12")
            {
                txbResultado.Text = "Dezembro";
            }
        }
    }
}

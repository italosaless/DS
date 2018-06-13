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
    public partial class frmEx7 : Form
    {
        /*
         * Arlindo tem 1,50m e cresce 2 centímetros por ano, enquanto Manoel tem 1,10m e cresce 3 
         * centímetros por ano. Construir um algoritmos que calcule e imprima quantos anos serão 
         * necessários para que Manoel seja maior que Arlindo. (Usar Loop – For / While / Do While) 
         * */

        public frmEx7()
        {
            InitializeComponent();
        }
        
        private void frmEx7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmEx7_Load(object sender, EventArgs e)
        {
            double arlindo = 1.50, manoel = 1.10;
            int i = 0;

            while (arlindo > manoel)
            {
                arlindo += 0.02;
                manoel += 0.03;
                i++;
            }
            txbResultado.Text = i.ToString();
        }
    }
}

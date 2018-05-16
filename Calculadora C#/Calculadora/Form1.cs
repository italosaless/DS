using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalc : Form
    {
        Double vResult = 0;
        String vOpera = "";
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbResult.Text = txbResult.Text + 0;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
   
            if (vOpera == "-")
            {
                vResult = vResult - System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "/")
            {
                vResult = vResult / System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "*")
            {
                vResult = vResult * System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else {
                vOpera = "+";
                vResult = vResult + System.Convert.ToDouble(txbResult.Text);
            }
            
            lblPrevia.Text = lblPrevia.Text + txbResult.Text + " + ";
            txbResult.Text = "";
            vOpera = "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double R = 0;
            if (vOpera == "+") {
                R = System.Convert.ToDouble(txbResult.Text) + vResult;
                txbResult.Text = "" + R;
                
            }else if(vOpera == "-"){
                R = vResult - System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + R;
            
            }else if(vOpera == "/"){
                if (System.Convert.ToDouble(txbResult.Text) == 0) {
                    txbResult.Text = "Impossivel dividir por 0";
                }else
                {
                    R = vResult / System.Convert.ToDouble(txbResult.Text);
                    txbResult.Text = "" + R;
                     
                    }
            }else if(vOpera == "*"){
                R = vResult * System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + R;
               
            }
            vOpera = "=";
            vResult = 0;
            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

            if (vOpera == "+") {
                vResult = vResult + System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            } else if(vOpera == "/"){
                vResult = vResult / System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            } else if(vOpera == "*"){
                vResult = vResult * System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = ""+vResult;
            }
            else if (vResult == 0)
            {
                vResult = System.Convert.ToDouble(txbResult.Text);
            }
            else
            {
                vOpera = "-";
                vResult = vResult - System.Convert.ToDouble(txbResult.Text);
            }
           
            lblPrevia.Text = lblPrevia.Text + txbResult.Text + " - ";
            txbResult.Text = "";
            vOpera = "-";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (vOpera == "+")
            {
                vResult = vResult + System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "-")
            {
                vResult = vResult / System.Convert.ToDouble(txbResult.Text) ; 
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "*")
            {
                vResult = vResult * System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vResult == 0)
            {
                vResult = System.Convert.ToDouble(txbResult.Text);
            }
            else
            {
                vOpera = "/";
                vResult = vResult / System.Convert.ToDouble(txbResult.Text);
            }

            
            lblPrevia.Text = lblPrevia.Text + txbResult.Text + " / ";
            txbResult.Text = "";
            vOpera = "/";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (vOpera == "+")
            {
                vResult = vResult + System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "/")
            {
                vResult = vResult / System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vOpera == "-")
            {
                vResult = vResult - System.Convert.ToDouble(txbResult.Text);
                txbResult.Text = "" + vResult;
            }
            else if (vResult == 0) {
                vResult = System.Convert.ToDouble(txbResult.Text);
            }
            else
            {
                vOpera = "*";
                vResult = vResult * System.Convert.ToDouble(txbResult.Text);
            }

            
            lblPrevia.Text = lblPrevia.Text + txbResult.Text + " * ";
            txbResult.Text = "";
            vOpera = "*";
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txbResult.Clear();
            lblPrevia.Text = "";


        }

       

    }
}

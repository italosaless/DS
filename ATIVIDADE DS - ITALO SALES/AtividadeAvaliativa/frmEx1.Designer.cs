namespace WindowsFormsApplication1
{
    partial class frmEx1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(12, 9);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(57, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "1º Número";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(12, 33);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(57, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "2º Número";
            // 
            // txbNum1
            // 
            this.txbNum1.Location = new System.Drawing.Point(75, 6);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(197, 20);
            this.txbNum1.TabIndex = 2;
            // 
            // txbNum2
            // 
            this.txbNum2.Location = new System.Drawing.Point(75, 30);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(197, 20);
            this.txbNum2.TabIndex = 3;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ama;
            this.btnExecutar.Location = new System.Drawing.Point(15, 56);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(257, 23);
            this.btnExecutar.TabIndex = 4;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultado";
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(15, 120);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(257, 20);
            this.txbResultado.TabIndex = 6;
            // 
            // frmEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ama;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.txbNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "frmEx1";
            this.Text = "Exercicio 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEx1_FormClosing);
            this.Load += new System.EventHandler(this.frmEx1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txbNum1;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbResultado;
    }
}
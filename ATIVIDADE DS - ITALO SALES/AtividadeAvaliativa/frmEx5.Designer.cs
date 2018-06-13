namespace WindowsFormsApplication1
{
    partial class frmEx5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(62, 6);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(210, 20);
            this.txbNum.TabIndex = 1;
            this.txbNum.TextChanged += new System.EventHandler(this.txbNum_TextChanged);
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ama1;
            this.btnExecutar.Location = new System.Drawing.Point(12, 32);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(260, 23);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txbResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbResultado.Location = new System.Drawing.Point(12, 61);
            this.txbResultado.Multiline = true;
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(260, 156);
            this.txbResultado.TabIndex = 3;
            // 
            // frmEx5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ama;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.label1);
            this.Name = "frmEx5";
            this.Text = "Exercicio 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEx5_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txbResultado;
    }
}
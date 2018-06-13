namespace WindowsFormsApplication1
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividade1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividade1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividade1ToolStripMenuItem
            // 
            this.atividade1ToolStripMenuItem.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ama;
            this.atividade1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividade1ToolStripMenuItem1,
            this.atividade2ToolStripMenuItem,
            this.atividade3ToolStripMenuItem,
            this.atividade4ToolStripMenuItem,
            this.atividade5ToolStripMenuItem,
            this.atividade6ToolStripMenuItem,
            this.atividade7ToolStripMenuItem});
            this.atividade1ToolStripMenuItem.Name = "atividade1ToolStripMenuItem";
            this.atividade1ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.atividade1ToolStripMenuItem.Text = "Exercicios";
            // 
            // atividade1ToolStripMenuItem1
            // 
            this.atividade1ToolStripMenuItem1.Name = "atividade1ToolStripMenuItem1";
            this.atividade1ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.atividade1ToolStripMenuItem1.Text = "Ex 1";
            this.atividade1ToolStripMenuItem1.Click += new System.EventHandler(this.atividade1ToolStripMenuItem1_Click);
            // 
            // atividade2ToolStripMenuItem
            // 
            this.atividade2ToolStripMenuItem.Name = "atividade2ToolStripMenuItem";
            this.atividade2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atividade2ToolStripMenuItem.Text = "Ex 2";
            this.atividade2ToolStripMenuItem.Click += new System.EventHandler(this.atividade2ToolStripMenuItem_Click);
            // 
            // atividade3ToolStripMenuItem
            // 
            this.atividade3ToolStripMenuItem.Name = "atividade3ToolStripMenuItem";
            this.atividade3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atividade3ToolStripMenuItem.Text = "Ex 3";
            this.atividade3ToolStripMenuItem.Click += new System.EventHandler(this.atividade3ToolStripMenuItem_Click);
            // 
            // atividade4ToolStripMenuItem
            // 
            this.atividade4ToolStripMenuItem.Name = "atividade4ToolStripMenuItem";
            this.atividade4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atividade4ToolStripMenuItem.Text = "Ex 4";
            this.atividade4ToolStripMenuItem.Click += new System.EventHandler(this.atividade4ToolStripMenuItem_Click);
            // 
            // atividade5ToolStripMenuItem
            // 
            this.atividade5ToolStripMenuItem.Name = "atividade5ToolStripMenuItem";
            this.atividade5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atividade5ToolStripMenuItem.Text = "Ex 5";
            this.atividade5ToolStripMenuItem.Click += new System.EventHandler(this.atividade5ToolStripMenuItem_Click);
            // 
            // atividade6ToolStripMenuItem
            // 
            this.atividade6ToolStripMenuItem.Name = "atividade6ToolStripMenuItem";
            this.atividade6ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atividade6ToolStripMenuItem.Text = "Ex 6";
            this.atividade6ToolStripMenuItem.Click += new System.EventHandler(this.atividade6ToolStripMenuItem_Click);
            // 
            // atividade7ToolStripMenuItem
            // 
            this.atividade7ToolStripMenuItem.Name = "atividade7ToolStripMenuItem";
            this.atividade7ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atividade7ToolStripMenuItem.Text = "Ex 7";
            this.atividade7ToolStripMenuItem.Click += new System.EventHandler(this.atividade7ToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ama;
            this.ClientSize = new System.Drawing.Size(658, 405);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Atividades";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividade1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atividade2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade7ToolStripMenuItem;
    }
}


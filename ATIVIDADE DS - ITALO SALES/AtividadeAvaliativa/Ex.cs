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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void atividade1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEx1 Ex = new frmEx1();
            Ex.MdiParent = this;
            Ex.Show();
        }

        private void atividade2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx2 Ex = new frmEx2();
            Ex.MdiParent = this;
            Ex.Show();
        }

        private void atividade3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx3 Ex = new frmEx3();
            Ex.MdiParent = this;
            Ex.Show();
        }

        private void atividade4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx4 Ex = new frmEx4();
            Ex.MdiParent = this;
            Ex.Show();
        }

        private void atividade5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx5 Ex = new frmEx5();
            Ex.MdiParent = this;
            Ex.Show();
        }

        private void atividade6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx6 Ex = new frmEx6();
            Ex.MdiParent = this;
            Ex.Show();
        }

        private void atividade7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx7 Ex = new frmEx7();
            Ex.MdiParent = this;
            Ex.Show();
        }
    }
}

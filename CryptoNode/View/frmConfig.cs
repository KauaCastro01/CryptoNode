using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CryptoNode.View
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnDeslocamento_Click(object sender, EventArgs e)
        {
            frmAlterarDeslocamento frmAlterarDeslocamento = new frmAlterarDeslocamento();
            frmAlterarDeslocamento.Show();
            this.Close();
        }

        private void btnAlfabeto_Click(object sender, EventArgs e)
        {
            frmAlterarAlfabeto frmAlterarAlfabeto = new frmAlterarAlfabeto();
            frmAlterarAlfabeto.Show();
            this.Close();
        }

        private void btnChave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

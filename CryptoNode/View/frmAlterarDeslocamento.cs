using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CryptoNode.View
{
    public partial class frmAlterarDeslocamento : Form
    {
        public frmAlterarDeslocamento()
        {
            InitializeComponent();
            PopularCampo();
        }

        private void PopularCampo()
        {
            txtBoxDeslocamento.Text = Properties.Settings.Default.Deslocamento.ToString();
        }

        private void AbrirForms()
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.Show();
            this.Close();
        }

        private void txtBoxDeslocamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            VerificarCampo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            AbrirForms();
        }

        private void VerificarCampo()
        {
            if(int.TryParse(txtBoxDeslocamento.Text,out int deslocamento))
            {
                if (deslocamento < 1 || deslocamento > 25)
                {
                    MessageBox.Show("O deslocamento deve ser de 1 a 25!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Properties.Settings.Default.Deslocamento = deslocamento;
                    AbrirForms();
                }
                    
            }
            else
            {
                MessageBox.Show("O deslocamento deve ser de 1 a 25!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

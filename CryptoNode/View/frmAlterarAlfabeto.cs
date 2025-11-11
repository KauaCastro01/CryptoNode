using CryptoNode.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CryptoNode.View
{
    public partial class frmAlterarAlfabeto : Form
    {
        Criptografia Criptografia = new Criptografia();

        public frmAlterarAlfabeto()
        {
            InitializeComponent();
            PopularCampo();
        }

        private void PopularCampo()
        {
            string novoAlfabeto = "";
            string Alfabeto = Properties.Settings.Default.AlfabetoCriptografado;
            for (int i = 0; i < Alfabeto.Length; i++)
            {
                if(i == 25)
                    novoAlfabeto += Alfabeto[i];
                else
                    novoAlfabeto += Alfabeto[i] + " - ";
            }
                

            txtBoxDeslocamento.Text = novoAlfabeto;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlfabetoCriptografado = Criptografia.GerarAlfabetoAleatorioSubstituicao();
            PopularCampo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.Show();
            this.Close();
        }
    }
}

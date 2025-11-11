using CryptoNode.Util;
using CryptoNode.View;
using System.Text;

namespace CryptoNode
{
    public partial class Form1 : Form
    {
        Criptografia Criptografia = new Criptografia();
        private int CriptografiaSelecionada = 0;
        private int TamnhoTxtBoxOriginal = 0;
        private int[] chave = {4,3,2,1 };
        

        public Form1()
        {
            InitializeComponent();
            TamanhoOriginalTxtBoxOriginal();
            GerarAlfabetoSubtituicao();
            GerarChave();
        }

        private void GerarAlfabetoSubtituicao()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.AlfabetoCriptografado))
                Properties.Settings.Default.AlfabetoCriptografado = Criptografia.GerarAlfabetoAleatorioSubstituicao();
        }
        
        private void GerarChave()
        {
            chave = Criptografia.GerarChave();
        }

        private void btnCriptografiaCifraCesar_Click(object sender, EventArgs e)
        {
            lblCriptografiaSelecionada.Text = "Cifra de César";
            CriptografiaSelecionada = 0;
        }

        private void btnCriptografiaSubstituica_Click(object sender, EventArgs e)
        {
            lblCriptografiaSelecionada.Text = "Substituição";
            CriptografiaSelecionada = 1;
        }

        private void btnCriptografiaTransposicao_Click(object sender, EventArgs e)
        {
            lblCriptografiaSelecionada.Text = "Transposição";
            CriptografiaSelecionada = 2;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            VerificarCriptografiaSelecionada();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBoxModificado.Text))
                Clipboard.SetText(txtBoxModificado.Text);
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            VerificarDescriptografiaSelecionada();
        }

        private void VerificarCriptografiaSelecionada()
        {
            switch (CriptografiaSelecionada)
            {
                case 0:
                    txtBoxModificado.Text = Criptografia.CriptografiaCifraCesar(txtBoxOriginal.Text);
                    break;
                case 1:
                    txtBoxModificado.Text = Criptografia.CriptografiaSubstituicao(txtBoxOriginal.Text);
                    break;
                case 2:
                    txtBoxModificado.Text = Criptografia.CriptografarTransposicao(txtBoxOriginal.Text, chave);
                    break;
            }
        }

        private void VerificarDescriptografiaSelecionada()
        {
            switch (CriptografiaSelecionada)
            {
                case 0:
                    txtBoxModificado.Text = Criptografia.DescriptografiaCifraCesar(txtBoxOriginal.Text);
                    break;
                case 1:
                    txtBoxModificado.Text = Criptografia.DescriptografiaSubstituicao(txtBoxOriginal.Text);
                    break;
                case 2:
                    txtBoxModificado.Text = Criptografia.DescriptografarTransposicao(txtBoxOriginal.Text, chave);
                    break;
            }
        }

        private void txtBoxOriginal_TextChanged(object sender, EventArgs e)
        {
            int restante = txtBoxOriginal.MaxLength - txtBoxOriginal.Text.Length;
            lblTamanho.Text = $"{restante}";
        }

        private void TamanhoOriginalTxtBoxOriginal()
        {
            lblTamanho.Text = $"{txtBoxOriginal.MaxLength}";
        }
    }
}

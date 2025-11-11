namespace CryptoNode.View
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            btnDeslocamento = new Button();
            btnAlfabeto = new Button();
            btnChave = new Button();
            btnManual = new Button();
            btnSair = new Button();
            btnAvaliacao = new Button();
            SuspendLayout();
            // 
            // btnDeslocamento
            // 
            btnDeslocamento.BackColor = Color.FromArgb(57, 255, 20);
            btnDeslocamento.FlatAppearance.BorderSize = 0;
            btnDeslocamento.FlatStyle = FlatStyle.Flat;
            btnDeslocamento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDeslocamento.Location = new Point(78, 12);
            btnDeslocamento.Name = "btnDeslocamento";
            btnDeslocamento.Size = new Size(244, 66);
            btnDeslocamento.TabIndex = 2;
            btnDeslocamento.Text = "Deslocamento Cifra de César";
            btnDeslocamento.UseVisualStyleBackColor = false;
            btnDeslocamento.Click += btnDeslocamento_Click;
            // 
            // btnAlfabeto
            // 
            btnAlfabeto.BackColor = Color.FromArgb(57, 255, 20);
            btnAlfabeto.FlatAppearance.BorderSize = 0;
            btnAlfabeto.FlatStyle = FlatStyle.Flat;
            btnAlfabeto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAlfabeto.Location = new Point(78, 84);
            btnAlfabeto.Name = "btnAlfabeto";
            btnAlfabeto.Size = new Size(244, 66);
            btnAlfabeto.TabIndex = 3;
            btnAlfabeto.Text = "Alfabeto Substituição";
            btnAlfabeto.UseVisualStyleBackColor = false;
            btnAlfabeto.Click += btnAlfabeto_Click;
            // 
            // btnChave
            // 
            btnChave.BackColor = Color.FromArgb(57, 255, 20);
            btnChave.FlatAppearance.BorderSize = 0;
            btnChave.FlatStyle = FlatStyle.Flat;
            btnChave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnChave.Location = new Point(78, 156);
            btnChave.Name = "btnChave";
            btnChave.Size = new Size(244, 66);
            btnChave.TabIndex = 4;
            btnChave.Text = "Chave Transposição";
            btnChave.UseVisualStyleBackColor = false;
            btnChave.Click += btnChave_Click;
            // 
            // btnManual
            // 
            btnManual.BackColor = Color.FromArgb(57, 255, 20);
            btnManual.FlatAppearance.BorderSize = 0;
            btnManual.FlatStyle = FlatStyle.Flat;
            btnManual.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnManual.Location = new Point(78, 228);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(244, 66);
            btnManual.TabIndex = 6;
            btnManual.Text = "Manual  do Usuário";
            btnManual.UseVisualStyleBackColor = false;
            btnManual.Click += btnManual_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(57, 255, 20);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSair.Location = new Point(78, 372);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(244, 66);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnAvaliacao
            // 
            btnAvaliacao.BackColor = Color.FromArgb(57, 255, 20);
            btnAvaliacao.FlatAppearance.BorderSize = 0;
            btnAvaliacao.FlatStyle = FlatStyle.Flat;
            btnAvaliacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAvaliacao.Location = new Point(78, 300);
            btnAvaliacao.Name = "btnAvaliacao";
            btnAvaliacao.Size = new Size(244, 66);
            btnAvaliacao.TabIndex = 5;
            btnAvaliacao.Text = "Avaliação";
            btnAvaliacao.UseVisualStyleBackColor = false;
            btnAvaliacao.Click += btnAvaliacao_Click;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(400, 469);
            Controls.Add(btnSair);
            Controls.Add(btnManual);
            Controls.Add(btnAvaliacao);
            Controls.Add(btnChave);
            Controls.Add(btnAlfabeto);
            Controls.Add(btnDeslocamento);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CryptoNode";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeslocamento;
        private Button btnAlfabeto;
        private Button btnChave;
        private Button btnManual;
        private Button btnSair;
        private Button btnAvaliacao;
    }
}
namespace CryptoNode.View
{
    partial class frmAlterarAlfabeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarAlfabeto));
            btnSair = new Button();
            label2 = new Label();
            txtBoxDeslocamento = new TextBox();
            btnGerar = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(57, 255, 20);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSair.Location = new Point(126, 296);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(148, 56);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(230, 230, 230);
            label2.Location = new Point(38, 9);
            label2.Name = "label2";
            label2.Size = new Size(323, 31);
            label2.TabIndex = 11;
            label2.Text = "Alfabeto Criptografado Atual:";
            // 
            // txtBoxDeslocamento
            // 
            txtBoxDeslocamento.BackColor = Color.FromArgb(17, 34, 64);
            txtBoxDeslocamento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxDeslocamento.ForeColor = Color.FromArgb(230, 230, 230);
            txtBoxDeslocamento.Location = new Point(63, 43);
            txtBoxDeslocamento.Multiline = true;
            txtBoxDeslocamento.Name = "txtBoxDeslocamento";
            txtBoxDeslocamento.ReadOnly = true;
            txtBoxDeslocamento.Size = new Size(274, 185);
            txtBoxDeslocamento.TabIndex = 10;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.FromArgb(57, 255, 20);
            btnGerar.FlatAppearance.BorderSize = 0;
            btnGerar.FlatStyle = FlatStyle.Flat;
            btnGerar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGerar.Location = new Point(126, 234);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(148, 56);
            btnGerar.TabIndex = 14;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // frmAlterarAlfabeto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(400, 385);
            Controls.Add(btnGerar);
            Controls.Add(btnSair);
            Controls.Add(label2);
            Controls.Add(txtBoxDeslocamento);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAlterarAlfabeto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CryptoNode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnSalvar;
        private Label label2;
        private TextBox txtBoxDeslocamento;
        private Button btnGerar;
    }
}
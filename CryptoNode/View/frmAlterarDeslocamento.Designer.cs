namespace CryptoNode.View
{
    partial class frmAlterarDeslocamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarDeslocamento));
            txtBoxDeslocamento = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // txtBoxDeslocamento
            // 
            txtBoxDeslocamento.BackColor = Color.FromArgb(17, 34, 64);
            txtBoxDeslocamento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxDeslocamento.ForeColor = Color.FromArgb(230, 230, 230);
            txtBoxDeslocamento.Location = new Point(137, 43);
            txtBoxDeslocamento.Name = "txtBoxDeslocamento";
            txtBoxDeslocamento.Size = new Size(125, 34);
            txtBoxDeslocamento.TabIndex = 0;
            txtBoxDeslocamento.KeyPress += txtBoxDeslocamento_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(230, 230, 230);
            label2.Location = new Point(85, 9);
            label2.Name = "label2";
            label2.Size = new Size(229, 31);
            label2.TabIndex = 2;
            label2.Text = "Deslocamento Atual:";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(57, 255, 20);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSalvar.Location = new Point(126, 97);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(148, 56);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(57, 255, 20);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSair.Location = new Point(126, 159);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(148, 56);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // frmAlterarDeslocamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(400, 253);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(txtBoxDeslocamento);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAlterarDeslocamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CryptoNode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxDeslocamento;
        private Label label2;
        private Button btnSalvar;
        private Button btnSair;
    }
}
namespace CryptoNode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCriptografiaCifraCesar = new Button();
            btnCriptografiaSubstituica = new Button();
            btnCriptografiaTransposicao = new Button();
            btnConfig = new Button();
            btnSair = new Button();
            lblCriptografiaSelecionada = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblTamanho = new Label();
            label4 = new Label();
            btnCopiar = new Button();
            btnDescriptografar = new Button();
            btnCriptografar = new Button();
            txtBoxModificado = new TextBox();
            label3 = new Label();
            txtBoxOriginal = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 818);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(lblCriptografiaSelecionada);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 623);
            panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCriptografiaCifraCesar);
            flowLayoutPanel1.Controls.Add(btnCriptografiaSubstituica);
            flowLayoutPanel1.Controls.Add(btnCriptografiaTransposicao);
            flowLayoutPanel1.Controls.Add(btnConfig);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Location = new Point(0, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(317, 384);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCriptografiaCifraCesar
            // 
            btnCriptografiaCifraCesar.BackColor = Color.FromArgb(57, 255, 20);
            btnCriptografiaCifraCesar.FlatAppearance.BorderSize = 0;
            btnCriptografiaCifraCesar.FlatStyle = FlatStyle.Flat;
            btnCriptografiaCifraCesar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCriptografiaCifraCesar.Location = new Point(3, 3);
            btnCriptografiaCifraCesar.Name = "btnCriptografiaCifraCesar";
            btnCriptografiaCifraCesar.Size = new Size(314, 66);
            btnCriptografiaCifraCesar.TabIndex = 1;
            btnCriptografiaCifraCesar.Text = "Selecionar Cifra de Cesar";
            btnCriptografiaCifraCesar.UseVisualStyleBackColor = false;
            btnCriptografiaCifraCesar.Click += btnCriptografiaCifraCesar_Click;
            // 
            // btnCriptografiaSubstituica
            // 
            btnCriptografiaSubstituica.BackColor = Color.FromArgb(57, 255, 20);
            btnCriptografiaSubstituica.FlatAppearance.BorderSize = 0;
            btnCriptografiaSubstituica.FlatStyle = FlatStyle.Flat;
            btnCriptografiaSubstituica.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCriptografiaSubstituica.Location = new Point(3, 75);
            btnCriptografiaSubstituica.Name = "btnCriptografiaSubstituica";
            btnCriptografiaSubstituica.Size = new Size(314, 66);
            btnCriptografiaSubstituica.TabIndex = 2;
            btnCriptografiaSubstituica.Text = "Selecionar Substituição";
            btnCriptografiaSubstituica.UseVisualStyleBackColor = false;
            btnCriptografiaSubstituica.Click += btnCriptografiaSubstituica_Click;
            // 
            // btnCriptografiaTransposicao
            // 
            btnCriptografiaTransposicao.BackColor = Color.FromArgb(57, 255, 20);
            btnCriptografiaTransposicao.FlatAppearance.BorderSize = 0;
            btnCriptografiaTransposicao.FlatStyle = FlatStyle.Flat;
            btnCriptografiaTransposicao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCriptografiaTransposicao.Location = new Point(3, 147);
            btnCriptografiaTransposicao.Name = "btnCriptografiaTransposicao";
            btnCriptografiaTransposicao.Size = new Size(314, 66);
            btnCriptografiaTransposicao.TabIndex = 3;
            btnCriptografiaTransposicao.Text = "Selecionar Transposição";
            btnCriptografiaTransposicao.UseVisualStyleBackColor = false;
            btnCriptografiaTransposicao.Click += btnCriptografiaTransposicao_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(57, 255, 20);
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.Location = new Point(3, 219);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(314, 66);
            btnConfig.TabIndex = 4;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(57, 255, 20);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(3, 291);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(314, 66);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // lblCriptografiaSelecionada
            // 
            lblCriptografiaSelecionada.AutoSize = true;
            lblCriptografiaSelecionada.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriptografiaSelecionada.ForeColor = SystemColors.ButtonShadow;
            lblCriptografiaSelecionada.Location = new Point(12, 40);
            lblCriptografiaSelecionada.Name = "lblCriptografiaSelecionada";
            lblCriptografiaSelecionada.Size = new Size(158, 31);
            lblCriptografiaSelecionada.TabIndex = 1;
            lblCriptografiaSelecionada.Text = "Cifra de César";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(277, 31);
            label1.TabIndex = 0;
            label1.Text = "Criptografia Selecionada:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.CryptoNode;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTamanho);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnCopiar);
            panel2.Controls.Add(btnDescriptografar);
            panel2.Controls.Add(btnCriptografar);
            panel2.Controls.Add(txtBoxModificado);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtBoxOriginal);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(317, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 818);
            panel2.TabIndex = 1;
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTamanho.ForeColor = Color.FromArgb(230, 230, 230);
            lblTamanho.Location = new Point(567, 18);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(56, 28);
            lblTamanho.TabIndex = 9;
            lblTamanho.Text = "3000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(230, 230, 230);
            label4.Location = new Point(362, 19);
            label4.Name = "label4";
            label4.Size = new Size(199, 28);
            label4.TabIndex = 8;
            label4.Text = "Caracteres restantes:";
            // 
            // btnCopiar
            // 
            btnCopiar.BackColor = Color.FromArgb(57, 255, 20);
            btnCopiar.FlatAppearance.BorderSize = 0;
            btnCopiar.FlatStyle = FlatStyle.Flat;
            btnCopiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCopiar.Location = new Point(267, 709);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(148, 65);
            btnCopiar.TabIndex = 7;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = false;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnDescriptografar
            // 
            btnDescriptografar.BackColor = Color.FromArgb(57, 255, 20);
            btnDescriptografar.FlatAppearance.BorderSize = 0;
            btnDescriptografar.FlatStyle = FlatStyle.Flat;
            btnDescriptografar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDescriptografar.Location = new Point(421, 709);
            btnDescriptografar.Name = "btnDescriptografar";
            btnDescriptografar.Size = new Size(220, 65);
            btnDescriptografar.TabIndex = 6;
            btnDescriptografar.Text = "Descriptografar";
            btnDescriptografar.UseVisualStyleBackColor = false;
            btnDescriptografar.Click += btnDescriptografar_Click;
            // 
            // btnCriptografar
            // 
            btnCriptografar.BackColor = Color.FromArgb(57, 255, 20);
            btnCriptografar.FlatAppearance.BorderSize = 0;
            btnCriptografar.FlatStyle = FlatStyle.Flat;
            btnCriptografar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCriptografar.Location = new Point(41, 709);
            btnCriptografar.Name = "btnCriptografar";
            btnCriptografar.Size = new Size(220, 65);
            btnCriptografar.TabIndex = 5;
            btnCriptografar.Text = "Criptografar";
            btnCriptografar.UseVisualStyleBackColor = false;
            btnCriptografar.Click += btnCriptografar_Click;
            // 
            // txtBoxModificado
            // 
            txtBoxModificado.BackColor = Color.FromArgb(17, 34, 64);
            txtBoxModificado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxModificado.ForeColor = Color.FromArgb(230, 230, 230);
            txtBoxModificado.Location = new Point(41, 403);
            txtBoxModificado.MaxLength = 3000;
            txtBoxModificado.Multiline = true;
            txtBoxModificado.Name = "txtBoxModificado";
            txtBoxModificado.ReadOnly = true;
            txtBoxModificado.Size = new Size(600, 300);
            txtBoxModificado.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(230, 230, 230);
            label3.Location = new Point(41, 369);
            label3.Name = "label3";
            label3.Size = new Size(203, 31);
            label3.TabIndex = 3;
            label3.Text = "Texto Modificado:";
            // 
            // txtBoxOriginal
            // 
            txtBoxOriginal.BackColor = Color.FromArgb(17, 34, 64);
            txtBoxOriginal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxOriginal.ForeColor = Color.FromArgb(230, 230, 230);
            txtBoxOriginal.Location = new Point(41, 53);
            txtBoxOriginal.MaxLength = 3000;
            txtBoxOriginal.Multiline = true;
            txtBoxOriginal.Name = "txtBoxOriginal";
            txtBoxOriginal.Size = new Size(600, 300);
            txtBoxOriginal.TabIndex = 2;
            txtBoxOriginal.TextChanged += txtBoxOriginal_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(230, 230, 230);
            label2.Location = new Point(41, 16);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 1;
            label2.Text = "Texto Original:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 25, 47);
            ClientSize = new Size(1000, 818);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CryptoNode";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCriptografiaCifraCesar;
        private Panel panel3;
        private Label label1;
        private Label lblCriptografiaSelecionada;
        private Button btnCriptografiaSubstituica;
        private Button btnCriptografiaTransposicao;
        private Button btnConfig;
        private Button btnSair;
        private TextBox txtBoxOriginal;
        private TextBox txtBoxModificado;
        private Label label3;
        private Label label2;
        private Button btnCriptografar;
        private Button btnDescriptografar;
        private Button btnCopiar;
        private Label label4;
        private Label lblTamanho;
    }
}

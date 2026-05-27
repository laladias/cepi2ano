namespace Controledeestoquelala
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
            txtNome = new TextBox();
            txtQuantidade = new TextBox();
            txtValor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSalvar = new Button();
            btnSaida = new Button();
            btnLimpar = new Button();
            dgvEstoque = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 23);
            txtNome.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(169, 52);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(109, 23);
            txtQuantidade.TabIndex = 1;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(305, 52);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(113, 23);
            txtValor.TabIndex = 2;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 34);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 34);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor (R$)";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(305, 346);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Zerar Estoque";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // btnSaida
            // 
            btnSaida.Location = new Point(155, 94);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(75, 23);
            btnSaida.TabIndex = 7;
            btnSaida.Text = "Dar Saída";
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(305, 94);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(129, 23);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Adicionar ao Estoque";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += button3_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Location = new Point(35, 151);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(385, 189);
            dgvEstoque.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEstoque);
            Controls.Add(btnLimpar);
            Controls.Add(btnSaida);
            Controls.Add(btnSalvar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValor);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Controle de estoque ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtQuantidade;
        private TextBox txtValor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSalvar;
        private Button btnSaida;
        private Button btnLimpar;
        private DataGridView dgvEstoque;
    }
}

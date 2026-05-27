using System.Drawing.Text;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controledeestoquelala
{
    public partial class Form1 : Form
    {
        public List<Produto> listaEstoque = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrade();
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void ConfigurarGrade()
        {
            dgvEstoque.Columns.Clear();
            dgvEstoque.Columns.Add("colNome", "Produto");
            dgvEstoque.Columns.Add("colQuantidade", "Quantidade");
            dgvEstoque.Columns.Add("colValor", "Preço Unitário");
            dgvEstoque.Columns.Add("colTotalItem", "Total do Item");

            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.ReadOnly = true;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                if (e.KeyChar == ',' && !txtValor.Text.Contains(",")) return;
            e.Handled = true;
        }
        private void bntSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (string.IsNullOrEmpty(nome) ||
             !int.TryParse(txtQuantidade.Text, out int quantidade) ||
             !decimal.TryParse(txtValor.Text, out decimal valor))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            Produto novoProduto = new Produto
            {
                Nome = nome,
                Quantidade = quantidade,
                Valor = valor
            };
            listaEstoque.Add(novoProduto);
            AtualizartabelaTela();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtNome.Focus();
        }

        private void AtualizartabelaTela()
        {
            dgvEstoque.Rows.Clear();
            decimal valorTotalAcumulado = 0;

            foreach (Produto produto in listaEstoque)
            {
                decimal totalDoItem = produto.Quantidade * produto.Valor;
                valorTotalAcumulado += totalDoItem;

                dgvEstoque.Rows.Add(produto.Nome, produto.Quantidade, produto.Valor.ToString("C"),
                totalDoItem.ToString("C"));
            }


        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
           if (dgvEstoque.CurrentRow == null)
           {
            MessageBox.Show("Selecione um produto na tabela antes de dar saída.", "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
         if (!int.TryParse(txtQuantidade.Text, out int quantidadeRetirar) || quantidadeRetirar <= 0)
        }
    }
    public class Produto
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Valor { get; set; }

        }
    }

        
    
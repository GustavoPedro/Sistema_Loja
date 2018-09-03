using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeBStudio.Control;
using SeBStudio.Control.DTO;

namespace SeBStudio.View
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
            dgvProdutosCadastrados.AutoGenerateColumns = false;
        }

        CRUD tipo;
        Produto produto;

        public frmCadastrarProduto(CRUD tipo, Produto prod)
        {
            InitializeComponent();
            dgvProdutosCadastrados.AutoGenerateColumns = false;
            this.tipo = tipo;
            this.produto = prod;
        }
       
        List<Produto> prod = new List<Produto>();
        GestaoProdutoControl gestao = new GestaoProdutoControl();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (tipo == CRUD.alterar)
            {
                Produto product = new Produto();
                product.IdProduto = Convert.ToInt32(txbId.Text);
                product.NomeProduto = txbDescricao.Text;
                product.ValorUnit = Convert.ToDecimal(txbValorUnit.Text);
                string idProduto = gestao.AlterarProduto(product);

                try
                {
                    int idProduct = Convert.ToInt32(idProduto);
                    DialogResult = DialogResult.Yes;
                    MessageBox.Show("Produto alterado com sucesso", "Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao alterar produto","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
           
                if (tipo == CRUD.cadastrar)
                {
                    if (!(dgvProdutosCadastrados.DataSource == null))
                    {
                        string retorno = gestao.Inserir(prod);
                        try
                        {
                            int back = Convert.ToInt32(retorno);
                            MessageBox.Show("Produtos inseridos com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txbId.Text = null;
                            txbDescricao.Text = null;
                            txbValorUnit.Text = null;
                            dgvProdutosCadastrados.DataSource = null;
                            txbId.Focus();
                            DialogResult = DialogResult.Yes;
                        }
                        catch (Exception)
                        {
                            if (retorno == "O id inserido já existe")
                            {
                                MessageBox.Show(retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            { 
                                MessageBox.Show("Erro ao cadastrar produtos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você não inseriu nenhum produto na tabela");
                    }
                }
           
        }
        private void btnAdicionarNoGrid_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbDescricao.Text) && !string.IsNullOrWhiteSpace(txbId.Text) && !string.IsNullOrWhiteSpace(txbValorUnit.Text))
            {
                Produto produto = new Produto();
                produto.NomeProduto = txbDescricao.Text;
                produto.ValorUnit = Convert.ToDecimal(txbValorUnit.Text);
                produto.IdProduto = Convert.ToInt32(txbId.Text);
                prod.Add(produto);
                AtualizarGrid();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos primeiro");
            }
        }

        private void AtualizarGrid()
        {
            try
            { 
                dgvProdutosCadastrados.DataSource = null;
                dgvProdutosCadastrados.DataSource = prod;
                dgvProdutosCadastrados.Update();
                dgvProdutosCadastrados.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar tabela","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

      

        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            if (tipo == CRUD.cadastrar)
            {
                btnCadastrar.Text = "Cadastrar";
            }
            if (tipo == CRUD.alterar)
            {
                btnRemover.Visible = false;
                dgvProdutosCadastrados.Visible = false;
                btnAdicionarNoGrid.Visible = false;
                txbId.Text = produto.IdProduto.ToString();
                txbDescricao.Text = produto.NomeProduto;
                txbValorUnit.Text = produto.ValorUnit.ToString();
                btnCadastrar.Text = "Alterar";
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutosCadastrados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            //Pegar produto selecionado
            Produto produto = (dgvProdutosCadastrados.SelectedRows[0].DataBoundItem as Produto);
            prod.Remove(produto);

            AtualizarGrid();
        }
      

        private void frmCadastrarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        this.Close();
                    break;
                    case Keys.R:
                        btnRemover_Click(sender, e);
                        break;
                    case Keys.P:
                        btnCadastrar_Click(sender, e);
                        break;
                }
            }
            switch (e.KeyCode)
            {
                case Keys.Enter:
                        btnAdicionarNoGrid_Click(sender, e);
                break;                
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarProduto pesquisarProduto = new frmPesquisarProduto();
            pesquisarProduto.Show();
        }

        private void txbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

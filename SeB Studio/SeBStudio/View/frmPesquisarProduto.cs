using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeBStudio.Control;
using SeBStudio.Control.DTO;

namespace SeBStudio.View
{
    public partial class frmPesquisarProduto : Form
    {

        GestaoProdutoControl gestao = new GestaoProdutoControl();
        private int idPermissao;

        public frmPesquisarProduto()
        {
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
        }

        public frmPesquisarProduto(int idPermissao)
        {
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
            this.idPermissao = idPermissao;
        }

        private void frmPesquisarProduto_Load(object sender, EventArgs e)
        {
            if (idPermissao == 2)
            {
                btnAlterar.Enabled = false;
                btnDeletar.Enabled = false;
            }
            AtualizarGrid();
            rbrPorNome.Checked = true;
        }

        private void AtualizarGrid()
        {
            try
            {            
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = gestao.ConsultarTodos();
                dgvProdutos.Update();
                dgvProdutos.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível pesquisar produtos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto cadastrar = new frmCadastrarProduto(CRUD.cadastrar,null);
            cadastrar.ShowDialog();
            if (cadastrar.DialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }
            Produto produtoSelecionado = (dgvProdutos.SelectedRows[0].DataBoundItem as Produto);

            frmCadastrarProduto frmCadastrarProduto = new frmCadastrarProduto(CRUD.alterar, produtoSelecionado);

            DialogResult resultado = frmCadastrarProduto.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {            
                if (rbrPorNome.Checked == true)
                {
                    if (string.IsNullOrWhiteSpace(txbPesquisar.Text))
                    {
                        AtualizarGrid();
                    }
                    else
                    { 
                        dgvProdutos.DataSource = null;
                        dgvProdutos.DataSource = gestao.ConsultarPorNome(txbPesquisar.Text);
                        dgvProdutos.Update();
                        dgvProdutos.Refresh();
                    }
                }
                if (rbrPorId.Checked == true)
                {
                    dgvProdutos.DataSource = null;
                    if (string.IsNullOrWhiteSpace(txbPesquisar.Text))
                    {
                        AtualizarGrid();
                    }
                    else
                    {
                        dgvProdutos.DataSource = gestao.ConsultarPorId(Convert.ToInt32(txbPesquisar.Text));
                    }
                    dgvProdutos.Update();
                    dgvProdutos.Refresh();
                }
            }
            catch (Exception)
            {
                return;                
            }

        }

        private void frmPesquisarProduto_MouseClick(object sender, MouseEventArgs e)
        {
            int indiceselecionado = -1;
            // Se o usuário selecionou a Linha
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                indiceselecionado = dgvProdutos.SelectedRows[0].Index;
            }
            else
            { // Se o usuário selecionou a célula
                if (dgvProdutos.SelectedCells.Count > 0)
                {
                    indiceselecionado = dgvProdutos.SelectedCells[0].RowIndex;
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionada.");
                return;
            }
            //deseja realmente excluir?
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar produto selecionado
            Produto produtoSelecionado = (dgvProdutos.SelectedRows[0].DataBoundItem as Produto);

            GestaoProdutoControl ProdutoNegocio = new GestaoProdutoControl();

            string retorno = ProdutoNegocio.Excluir(produtoSelecionado.IdProduto);
            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Produto excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir." + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbrPorId.Checked == true)
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
}

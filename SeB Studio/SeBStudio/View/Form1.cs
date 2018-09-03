using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Control;
using WindowsFormsApp2.Control.DTO;
using WindowsFormsApp2.View;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class frmEnvelope : System.Windows.Forms.Form
    {
        
        public frmEnvelope()
        {
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
            foreach (DataGridViewColumn column in dgvProdutos.Columns)
            {
                if (column.DataPropertyName == "Descricao")
                    column.Width = 100; //tamanho fixo da primeira coluna

                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        List<ProdutosEnvelope> lista = new List<ProdutosEnvelope>();
        controleEnvelope controle = new controleEnvelope();
        Model.sebStudioBancoTableAdapters.spselecionaProdutoPorIdTableAdapter adapter = new Model.sebStudioBancoTableAdapters.spselecionaProdutoPorIdTableAdapter();
        

        private void TentarMultiplicar()
        {
            if (!string.IsNullOrWhiteSpace(txbQuantidade.Text)&& !string.IsNullOrWhiteSpace(txbValorUnitario.Text))
            {
                try
                {
                    txbTotal.Text = (Convert.ToDecimal(txbValorUnitario.Text) * Convert.ToDecimal(txbQuantidade.Text)).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel efetuar a multiplicação");
                    return;
                }
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           
            Adicionar();
            txbValor.Text =  controle.SomaTotalGeral(lista);
        }

        private void AtualizarEmDgv()
        {
          

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = lista;
            dgvProdutos.Update();
            dgvProdutos.Refresh();
            
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            Remover();
           txbValor.Text =  controle.SomaTotalGeral(lista);
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_MouseClick(object sender, MouseEventArgs e)
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

            if (indiceselecionado != -1)

            {

                btnRemover.Enabled = true;
                
            }
        }

        private void Remover()
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }           
            
            //Pegar produto selecionado
            ProdutosEnvelope prod = (dgvProdutos.SelectedRows[0].DataBoundItem as ProdutosEnvelope);
            lista.Remove(prod);
            AtualizarEmDgv();
    }


        //Adiciona no DataGridView o objeto
        private void Adicionar()
        {
            ProdutosEnvelope produto = new ProdutosEnvelope();
            produto.Codigo = Convert.ToInt32(txbIdProduto.Text);
            produto.Descricao = txbDescricao.Text;
            produto.Qnt = Convert.ToInt32(txbQuantidade.Text);
            produto.Cortes = cbxCortes.Text;
            produto.Total = Convert.ToDecimal(txbTotal.Text);
            produto.ValorUnit = Convert.ToDecimal(txbValorUnitario.Text);
            lista.Add(produto);

            AtualizarEmDgv();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
             frmListaProdutos frm = new frmListaProdutos();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txbIdProduto.Text = frm.ProdutoSelecionado[0];
                txbDescricao.Text = frm.ProdutoSelecionado[1];
                txbValorUnitario.Text = frm.ProdutoSelecionado[2];              
           }
        }

        private void txbIdProduto_Validated(object sender, EventArgs e)
        {
            TentarMultiplicar();

            try
            {
                var table = adapter.GetData(txbIdProduto.Text);
                foreach (DataRow linha in table.Rows)
                {
                    txbDescricao.Text = linha["nomeProduto"].ToString();
                    txbValorUnitario.Text = linha["valorUnit"].ToString();
                }
            }
            catch (Exception)
            {

                return;
            }
         

        }

        private void txbValorUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbValorUnitario_Validated(object sender, EventArgs e)
        {
            TentarMultiplicar();
        }

        private void txbQuantidade_Validated(object sender, EventArgs e)
        {
            TentarMultiplicar();
        }

        private void txbDescricao_Validated(object sender, EventArgs e)
        {
            TentarMultiplicar();
        }

        private void txbTotalTudo_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void SubtrairSinal()
        {
            if (!string.IsNullOrWhiteSpace(txbValor.Text) && !string.IsNullOrWhiteSpace(txbSinal.Text))
            {
                txbTotalTudo.Text = (Convert.ToDecimal(txbValor.Text) - Convert.ToDecimal(txbSinal.Text)).ToString();
            }
        }

        private void txbValor_Validated(object sender, EventArgs e)
        {
            SubtrairSinal();
        }

        private void txbSinal_Validated(object sender, EventArgs e)
        {
            SubtrairSinal();
        }

        private void txbTotalTudo_Validated(object sender, EventArgs e)
        {
            SubtrairSinal();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
    }


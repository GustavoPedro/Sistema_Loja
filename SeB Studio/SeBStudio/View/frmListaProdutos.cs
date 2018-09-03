using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeBStudio.Control.DTO;
using SeBStudio.Control;


namespace SeBStudio.View
{
    public partial class frmListaProdutos : Form
    {
        public frmListaProdutos()
        {
            InitializeComponent();
            ProdutoSelecionado = new string[3];
            dgvProdutos.AutoGenerateColumns = false;
        }

        public string[] ProdutoSelecionado { get; set; }
        GestaoProdutoControl gestao = new GestaoProdutoControl();


        private void frmListaProdutos_Load(object sender, EventArgs e)
        {
            AtualizarDgv();
            rbrSelecionaPorNome.Checked = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            AtribuirADgv();
            DialogResult = DialogResult.OK;
            
        }


        private void AtribuirADgv()
        {

            DataGridViewRow linhaAtual = dgvProdutos.CurrentRow;

            // vamos exibir o índice da linha atual
            int indice = linhaAtual.Index;

            for (int i = 0; i < ProdutoSelecionado.Length; i++)
            {
                ProdutoSelecionado[i] = dgvProdutos.Rows[indice].Cells[i].Value.ToString();
            }


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
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (rbrSelecionaPorNome.Checked == true)
            {
                ConsultaPorNomeProduto();
            }
            if (rbrSelecionaPorId.Checked == true)
            {
                ConsultaPorIdProduto();
            }

        }

        private void AtualizarDgv()
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
                MessageBox.Show("Não foi possível efetuar consulta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaPorNomeProduto()
        {
            try
            {            
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = gestao.ConsultarPorNome(txbPesquisar.Text);
            dgvProdutos.Update();
            dgvProdutos.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível efetuar consulta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaPorIdProduto()
        {

            if (txbPesquisar.Text == null || txbPesquisar.Text == " " || txbPesquisar.Text == "")
            {
                AtualizarDgv();
            }
            else
            {
                try
                {                
                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = gestao.ConsultarPorId(Convert.ToInt32(txbPesquisar.Text));
                    dgvProdutos.Update();
                    dgvProdutos.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível efetuar consulta","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void frmListaProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        this.Close();
                        break;
                }
            }
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnOk_Click(sender, e);
                break;
                
            }
                
        }

        private void txbPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbrSelecionaPorId.Checked == true)
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

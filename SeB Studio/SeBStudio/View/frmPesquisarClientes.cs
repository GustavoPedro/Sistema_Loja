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
    public partial class frmPesquisarClientes : Form
    {
        public frmPesquisarClientes()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
        }

        public frmPesquisarClientes(int idPermissao)
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
            this.idPermissao = idPermissao;
        }

        GestaoClienteControl clienteControl = new GestaoClienteControl();
        private int idPermissao;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente frmCadastrar = new frmCadastrarCliente(CRUD.cadastrar,null);
          
            if (frmCadastrar.ShowDialog() == DialogResult.Yes)
            {
                AtualizarGrid();   
            }
        }

        private void AtualizarGrid()
        {
            try
            {                            
                dgvClientes.DataSource = null;
                if (rbrTodos.Checked == true)
                {
                    if (rbrPorNome.Checked == true)
                    {
                        dgvClientes.DataSource = clienteControl.ConsultarTodos(txbPesquisar.Text,"nome");
                    }
                    if (rbrPorTelefone.Checked == true)
                    {
                        dgvClientes.DataSource = clienteControl.ConsultarTodos(txbPesquisar.Text, "telefone");
                    }
                
                }
                if (rbrSomenteVip.Checked == true)
                {
                    if (rbrPorNome.Checked == true)
                    {
                        dgvClientes.DataSource = clienteControl.ConsultarTodosVip(txbPesquisar.Text, "nome");
                    }
                    if (rbrPorTelefone.Checked == true)
                    {
                        dgvClientes.DataSource = clienteControl.ConsultarTodosVip(txbPesquisar.Text, "telefone");
                    }
                }
                if (rbrSomentePro.Checked == true)
                {
                    if (rbrPorNome.Checked == true)
                    {
                        dgvClientes.DataSource = clienteControl.ConsultarTodosPro(txbPesquisar.Text, "nome");
                    }
                    if (rbrPorTelefone.Checked == true)
                    {
                        dgvClientes.DataSource = clienteControl.ConsultarTodosPro(txbPesquisar.Text, "telefone");
                    }
                }
                dgvClientes.Update();
                dgvClientes.Refresh();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void frmPesquisarClientes_Load(object sender, EventArgs e)
        {
            if (idPermissao == 2)
            {
                btnAlterar.Enabled = false;
                btnDeletar.Enabled = false;
            }
            rbrTodos.Checked = true;
            rbrPorNome.Checked = true;
            AtualizarGrid();
        }

        private void rbrSomenteVip_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void rbrTodos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void rbrSomentePro_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionada.");
                return;
            }
            //deseja realmente excluir?
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar produto selecionado
            ClienteDTO clienteSelecionado = (dgvClientes.SelectedRows[0].DataBoundItem as ClienteDTO);

            GestaoClienteControl ClienteNegocio = new GestaoClienteControl();
            string retorno = ClienteNegocio.Excluir(clienteSelecionado.IdCliente);

            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("cliente excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir." + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }
            ClienteDTO clienteSelecionado = (dgvClientes.SelectedRows[0].DataBoundItem as ClienteDTO);

            frmCadastrarCliente CadastrarCliente = new frmCadastrarCliente(CRUD.alterar, clienteSelecionado);

            DialogResult resultado = CadastrarCliente.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void txbPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbrPorTelefone.Checked == true)
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

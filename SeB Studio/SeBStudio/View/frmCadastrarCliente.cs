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
    public partial class frmCadastrarCliente : Form
    {
        CRUD tipo;
        ClienteDTO cliente;

        public frmCadastrarCliente(CRUD tipo, ClienteDTO cliente)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.cliente = cliente;
        }
        GestaoClienteControl gestao = new GestaoClienteControl();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbNome.Text) && !string.IsNullOrWhiteSpace(txbTelefone.Text) && !string.IsNullOrWhiteSpace(cbxTipoCliente.Text))
            {              
                if (tipo == CRUD.cadastrar)
                {
                    ClienteDTO cliente = new ClienteDTO();
                    cliente.NomeCliente = txbNome.Text;
                    cliente.Telefone = txbTelefone.Text;
                    cliente.Email = txbEmail.Text;
                    cliente.TipoCliente = cbxTipoCliente.Text;
                    string idCliente = gestao.Inserir(cliente);

                    try
                    {
                        int id = Convert.ToInt32(idCliente);
                        MessageBox.Show("Cliente inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txbNome.Text = null;
                        txbTelefone.Text = null;
                        txbEmail.Text = null;
                        txbNome.Focus();
                        DialogResult = DialogResult.Yes;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao inserir cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                    }
                   
                }
                if (tipo == CRUD.alterar)
                {
                    ClienteDTO cliente = new ClienteDTO();
                    cliente.IdCliente = this.cliente.IdCliente;
                    cliente.NomeCliente = txbNome.Text;
                    cliente.Telefone = txbTelefone.Text;
                    cliente.Email = txbEmail.Text;
                    cliente.TipoCliente = cbxTipoCliente.Text;

                    string idAlterar = gestao.Alterar(cliente);

                    try
                    {
                        MessageBox.Show("Cliente alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.Yes;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao alterar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                    }                  
                }                              
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios");
            }
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {           

            if (tipo == CRUD.cadastrar)
            {
                cbxTipoCliente.SelectedIndex = 0;
                btnCadastrar.Text = "Cadastrar";
            }
            if (tipo == CRUD.alterar)
            {
                txbNome.Text = cliente.NomeCliente;
                txbTelefone.Text = cliente.Telefone;
                txbEmail.Text = cliente.Email;
                cbxTipoCliente.Text = cliente.TipoCliente;
                btnCadastrar.Text = "Alterar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarCliente_KeyDown(object sender, KeyEventArgs e)
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
                    btnCadastrar_Click(sender, e);
                    break;
            }
        }
        
    }
}

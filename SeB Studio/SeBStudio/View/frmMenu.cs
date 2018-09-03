using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeBStudio.Control;
using SeBStudio.Control.DTO;

namespace SeBStudio.View
{
    public partial class frmMenu : Form
    {
        private UsuarioDTO usuario;

        public frmMenu(UsuarioDTO usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (usuario.idPermissao == 2)
            {
                ConfiguracoesToolStrip.Enabled = false;
            }
        }

        private void cadastrarEnvelopeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
            frmEnvelope mspforma = new frmEnvelope(CRUD.cadastrar, usuario.Codigo,usuario.idPermissao);
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {

                mdiChildForm.Close();

            }
            frmCadastrarProduto mspforma = new frmCadastrarProduto(CRUD.cadastrar,null);
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

        

        private void PesquisarProdutos_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {

                mdiChildForm.Close();

            }

            frmPesquisarProduto mspforma = new frmPesquisarProduto(usuario.idPermissao);
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

        private void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {

                mdiChildForm.Close();

            }
            frmCadastrarCliente mspforma = new frmCadastrarCliente(CRUD.cadastrar,null);
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

        private void pesquisarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
            frmPesquisarClientes mspforma = new frmPesquisarClientes(usuario.idPermissao);
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

        private void darBaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pesquisarEnvelopesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {

                mdiChildForm.Close();

            }
            frmDarBaixa mspforma = new frmDarBaixa(usuario.idPermissao, usuario.Codigo);
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

       
        private void tamanhosPréDefinidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();

            }            
            frmTamPreDefinidos mspforma = new frmTamPreDefinidos();
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

        private void envelopesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {

                mdiChildForm.Close();

            }
            frmConfiguracoesDoEnvelope mspforma = new frmConfiguracoesDoEnvelope();
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

        private void atendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {

                mdiChildForm.Close();

            }
            frmAtendentes mspforma = new frmAtendentes();
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }


        private void calculoMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {

                mdiChildForm.Close();

            }
            CalcMetroQuadrado mspforma = new CalcMetroQuadrado();
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {

                mdiChildForm.Close();

            }
            frmGestaoUsuarios mspforma = new frmGestaoUsuarios();
            mspforma.MdiParent = this;
            mspforma.Show();
            mspforma.WindowState = FormWindowState.Maximized;
        }

        private void weTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWeTransfer frmWeTransfer = new frmWeTransfer();
            frmWeTransfer.MdiParent = this;
            frmWeTransfer.Show();
            frmWeTransfer.WindowState = FormWindowState.Maximized;
        }
    }
}

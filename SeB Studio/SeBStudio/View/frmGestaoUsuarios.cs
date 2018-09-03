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
    public partial class frmGestaoUsuarios : Form
    {
        public frmGestaoUsuarios()
        {
            InitializeComponent();
        }
        private int idUsuario;

        private void atualizar()
        {
            try
            {
                List<UsuarioDTO> usuarios;
                UsuarioControl usuarioControl = new UsuarioControl();
                if (usuarioControl.buscarUsuarios() == null)
                {
                    usuarios = new List<UsuarioDTO>();
                }
                else
                {
                    usuarios = usuarioControl.buscarUsuarios();
                }
                if (usuarios.Count != 0)
                {
                    
                    cbxUsuarios.DataSource = usuarios;
                    cbxUsuarios.DisplayMember = "Usuario";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao consultar usuarios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmGestaoUsuarios_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            txbSenha.UseSystemPasswordChar = true;
            atualizar();
        }

        private void cbxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsuarioDTO user = new UsuarioDTO();
            user = (UsuarioDTO)cbxUsuarios.SelectedItem;
            txbUsuario.Text = user.Usuario;
            txbSenha.Text = user.Senha;
            txbCodigo.Text = user.Codigo.ToString();
            cbxPermissao.Text = user.Permissao;
            idUsuario = user.idUsuario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (verificarVazio() == true)
            {
                if (!(cbxUsuarios.Items == null))
                {
                    foreach (UsuarioDTO item in cbxUsuarios.Items)
                    {
                        if (item.Usuario == txbUsuario.Text)
                        {
                            MessageBox.Show("Este usuário já existe");
                            return;
                        }
                        if (item.Codigo == Convert.ToInt32(txbCodigo.Text))
                        {
                            MessageBox.Show("Este codigo já existe");
                            return;
                        }
                    }
                }                
                UsuarioDTO usuario = new UsuarioDTO();
                usuario.Usuario = txbUsuario.Text;
                usuario.Codigo = Convert.ToInt32(txbCodigo.Text);
                usuario.Senha = txbSenha.Text;
                usuario.Permissao = cbxPermissao.Text;
                UsuarioControl control = new UsuarioControl();
                int id = Convert.ToInt32(control.InserirUsuario(usuario));
                try
                {
                    int i = Convert.ToInt32(id);
                    MessageBox.Show("Usuario cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    atualizar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao cadastrar usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    atualizar();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os items primeiro");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (verificarVazio() == true)
            {              
                UsuarioDTO usuario = new UsuarioDTO();
                usuario.Usuario = txbUsuario.Text;
                usuario.Codigo = Convert.ToInt32(txbCodigo.Text);
                usuario.Senha = txbSenha.Text;
                usuario.Permissao = cbxPermissao.Text;
                usuario.idUsuario = idUsuario;
                UsuarioControl control = new UsuarioControl();
                int id = Convert.ToInt32(control.AlterarUsuario(usuario));

                try
                {
                    int i = Convert.ToInt32(id);
                    MessageBox.Show("Usuario alterado com sucesso", "Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    atualizar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao alterar usuarios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    atualizar();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbxUsuarios.Text))
            {                   
                UsuarioControl usuarioControl = new UsuarioControl();
                string id = usuarioControl.DeletarUsuario(idUsuario);
                try
                {
                    int i = Convert.ToInt32(id);
                    MessageBox.Show("Usuario deletado com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    atualizar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao deletar usuarios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    atualizar();
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuario");
            }
        }
        private bool verificarVazio()
        {
            if (!string.IsNullOrWhiteSpace(txbCodigo.Text) && !string.IsNullOrWhiteSpace(txbSenha.Text) && !string.IsNullOrWhiteSpace(txbUsuario.Text) && !string.IsNullOrWhiteSpace(cbxPermissao.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
            txbSenha.UseSystemPasswordChar = !checkBox1.Checked;  
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeBStudio.Control;
using SeBStudio.Control.DTO;

namespace SeBStudio.View
{
    public partial class frmLoginUsuario : Form
    {
        public frmLoginUsuario()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbUsuario.Text) && !string.IsNullOrWhiteSpace(txbSenha.Text))
            {
                UsuarioControl loginControl = new UsuarioControl();
                string usuario = txbUsuario.Text;
                string senha = txbSenha.Text;

                UsuarioDTO usuarioDTO = loginControl.LoginUsuario(usuario, senha);

                if (usuarioDTO == null)
                {
                    MessageBox.Show("Usuário ou senha inválidos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    frmMenu frmLogin = new frmMenu(usuarioDTO);
                    frmLogin.Closed += (s, args) => this.Close();
                    frmLogin.Show();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");                
            }
        }

        private void frmLoginUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnLogin_Click(sender, e);
                    break;
            }
        }
    }
}

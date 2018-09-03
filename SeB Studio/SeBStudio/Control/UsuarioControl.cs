using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeBStudio.Control.DTO;
using SeBStudio.Model;

namespace SeBStudio.Control
{
    class UsuarioControl
    {
        public UsuarioDTO LoginUsuario(string usuario, string senha)
        {
            try
            { 
                UsuarioDTO usuarioDTO = null;
                AcessoDadosMySql acessoDadosMySql = new AcessoDadosMySql();
                acessoDadosMySql.AdicionarParametros("spUsuario",usuario);
                acessoDadosMySql.AdicionarParametros("spSenha", senha);

                DataTable data = acessoDadosMySql.ExecutarConsulta(System.Data.CommandType.StoredProcedure, "spUsuarioLogin");
            
                foreach (DataRow linha in data.Rows)
                {
                    usuarioDTO = new UsuarioDTO();
                    usuarioDTO.Codigo = Convert.ToInt32(linha["codigo"]);
                    usuarioDTO.idPermissao = Convert.ToInt32(linha["idPermissao"]);                
                }
            return usuarioDTO;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Não foi possível consultar usuários no banco","Erro",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public List<UsuarioDTO> buscarUsuarios()
        {
            try
            {
                
                AcessoDadosMySql acessoDadosMySql = new AcessoDadosMySql();                

                DataTable data = acessoDadosMySql.ExecutarConsulta(System.Data.CommandType.StoredProcedure, "spUsuarioSelecionar");

                List<UsuarioDTO> Usuarios = new List<UsuarioDTO>();
                foreach (DataRow linha in data.Rows)
                {
                    UsuarioDTO usuarioDTO = new UsuarioDTO();
                    usuarioDTO.idUsuario = Convert.ToInt32(linha["idUsuario"]);
                    usuarioDTO.Usuario = linha["usuario"].ToString();
                    usuarioDTO.Senha = linha["senha"].ToString();
                    usuarioDTO.Codigo = Convert.ToInt32(linha["codigo"]);
                    usuarioDTO.Permissao = linha["nivelPermissao"].ToString();
                    usuarioDTO.idPermissao = Convert.ToInt32(linha["idPermissao"]);
                    Usuarios.Add(usuarioDTO);
                }
                return Usuarios;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Não foi possível consultar usuários no banco", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        public string InserirUsuario(UsuarioDTO usuario)
        {
            try
            {
                AcessoDadosMySql acessoDadosMySql = new AcessoDadosMySql();
                string idUsuario = "";
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("spUsuario", usuario.Usuario);
                acessoDadosMySql.AdicionarParametros("spSenha", usuario.Senha);
                acessoDadosMySql.AdicionarParametros("spCodigo", usuario.Codigo);
                if (usuario.Permissao == "Administrador")
                {
                    usuario.idPermissao = 1;
                }
                else if (usuario.Permissao == "Funcionario")
                {
                    usuario.idPermissao = 2;
                }
                else
                {
                    usuario.idPermissao = 3;
                }
                acessoDadosMySql.AdicionarParametros("spIdPermissao", usuario.idPermissao);

                idUsuario = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spCadastroUsuario").ToString();
                return idUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string AlterarUsuario(UsuarioDTO usuario)
        {
            try
            {
                AcessoDadosMySql acessoDadosMySql = new AcessoDadosMySql();
                
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("spIdUsuario", usuario.idUsuario);
                acessoDadosMySql.AdicionarParametros("spUsuario", usuario.Usuario);
                acessoDadosMySql.AdicionarParametros("spSenha", usuario.Senha);
                acessoDadosMySql.AdicionarParametros("spCodigo", usuario.Codigo);
                if (usuario.Permissao == "Administrador")
                {
                    usuario.idPermissao = 1;
                }
                if (usuario.Permissao == "Funcionario")
                {
                    usuario.idPermissao = 2;
                }
                acessoDadosMySql.AdicionarParametros("spIdPermissao", usuario.idPermissao);

                string idUsuario = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spUsuarioAlterar").ToString();
                return idUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string DeletarUsuario(int id)
        {
            try
            {
                AcessoDadosMySql acessoMysql = new AcessoDadosMySql();
                acessoMysql.LimparParametros();
                acessoMysql.AdicionarParametros("spIdUsuario", id);
                string idUsuario = acessoMysql.ExecutarManipulacao(CommandType.StoredProcedure, "spUsuarioDeletar").ToString();
                return idUsuario;
            }
            catch (Exception exception)
            {
                return exception.ToString();
            }
        }
    }
}

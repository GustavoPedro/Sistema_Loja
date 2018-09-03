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
    class GestaoClienteControl
    {
        public string Inserir(ClienteDTO cliente)
        {
            try
            {                
                AcessoDadosMySql acessoMysql = new AcessoDadosMySql();

                acessoMysql.LimparParametros();
                acessoMysql.AdicionarParametros("spNome", cliente.NomeCliente);
                acessoMysql.AdicionarParametros("spTelefone", cliente.Telefone);
                acessoMysql.AdicionarParametros("spEmail", cliente.Email);
                acessoMysql.AdicionarParametros("spTipoCliente", cliente.TipoCliente);
                

                string idCliente = acessoMysql.ExecutarManipulacao(CommandType.StoredProcedure, "spCadastroCliente").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Alterar(ClienteDTO cliente)
        {
            try
            {
                AcessoDadosMySql acessoMysql = new AcessoDadosMySql();

                acessoMysql.LimparParametros();
                acessoMysql.AdicionarParametros("spIdCliente", cliente.IdCliente);
                acessoMysql.AdicionarParametros("spNomeCliente", cliente.NomeCliente);
                acessoMysql.AdicionarParametros("spTelefone", cliente.Telefone);
                acessoMysql.AdicionarParametros("spEmail", cliente.Email);
                acessoMysql.AdicionarParametros("spTipoCliente", cliente.TipoCliente);

                string idCliente = acessoMysql.ExecutarManipulacao(CommandType.StoredProcedure, "spClienteAlterar").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Entrega todos os clientes do banco
        /// </summary>
        /// <param name="parametro">a txb de pesquisa se tiver </param>
        /// <param name="tipo">Se é nome ou telefone que vai querer que use para filtrar</param>
        /// <returns></returns>
        public ClienteColecao ConsultarTodos(string parametro,string tipo = "")
        {
            try
            {
                AcessoDadosMySql acessoMysql = new AcessoDadosMySql();
                ClienteColecao clienteColecao = new ClienteColecao();

                DataTable datatableUsuario = null;
                acessoMysql.LimparParametros();
                if (tipo == "nome")
                {

                    acessoMysql.AdicionarParametros("spNome",parametro);
                    datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spClienteSelecionaTodosPorNome");
                }
                else if (tipo == "telefone")
                {
                    acessoMysql.AdicionarParametros("spTelefone", parametro);
                        datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spClienteSelecionaTodosPorTelefone");
                }
                else
                {
                    datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spClienteSelecionaTodosPorNome");
                }

                foreach (DataRow linha in datatableUsuario.Rows)
                {
                    ClienteDTO cliente = new ClienteDTO();
                    cliente.IdCliente = Convert.ToInt32(linha["idCliente"]);
                    cliente.NomeCliente = linha["nome"].ToString();
                    cliente.Telefone = Convert.ToString(linha["telefone"]);
                    cliente.Email = linha["email"].ToString();
                    cliente.TipoCliente = linha["tipoCliente"].ToString();                    
                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu algum erro durante o processo de consulta");
                return null;
            }
        }


        public ClienteColecao ConsultarTodosVip(string parametro,string tipo)
        {
            try
            {
                AcessoDadosMySql acessoMysql = new AcessoDadosMySql();
                ClienteColecao clienteColecao = new ClienteColecao();

                DataTable dataTableUsuario = null;

                acessoMysql.LimparParametros();
                if (tipo == "nome")
                {
                    acessoMysql.AdicionarParametros("spNome", parametro);
                    dataTableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spClienteSelecionaTodosVipPorNome");
                }
                if (tipo == "telefone")
                {
                    acessoMysql.AdicionarParametros("spTelefone", parametro);
                    dataTableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spClienteSelecionaTodosVipPorTelefone");
                }              

                foreach (DataRow linha in dataTableUsuario.Rows)
                {
                    ClienteDTO cliente = new ClienteDTO();
                    cliente.IdCliente = Convert.ToInt32(linha["idCliente"]);
                    cliente.NomeCliente = linha["nome"].ToString();
                    cliente.Telefone = Convert.ToString(linha["telefone"]);
                    cliente.Email = linha["email"].ToString();
                    cliente.TipoCliente = linha["tipoCliente"].ToString();

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu algum erro durante o processo de consulta");
                return null;
            }
        }

        public string Excluir(int codCliente)
        {
            try
            {
                AcessoDadosMySql acessoMysql = new AcessoDadosMySql();
                acessoMysql.LimparParametros();
                acessoMysql.AdicionarParametros("spIdCliente", codCliente);
                string id = acessoMysql.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletarCliente").ToString();
                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ClienteColecao ConsultarTodosPro(string parametro,string tipo)
        {
            try
            {
                AcessoDadosMySql acessoMysql = new AcessoDadosMySql();
                ClienteColecao clienteColecao = new ClienteColecao();

                DataTable datatableUsuario = null;

                acessoMysql.LimparParametros();
                if (tipo == "nome")
                {
                    acessoMysql.AdicionarParametros("spNome", parametro);
                    datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spClienteSelecionaTodosProPorNome");
                }
                if (tipo == "telefone")
                {
                    acessoMysql.AdicionarParametros("spTelefone", parametro);
                    datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spClienteSelecionaTodosProPorTelefone");
                }               

                foreach (DataRow linha in datatableUsuario.Rows)
                {
                    ClienteDTO cliente = new ClienteDTO();
                    cliente.IdCliente = Convert.ToInt32(linha["idCliente"]);
                    cliente.NomeCliente = linha["nome"].ToString();
                    cliente.Telefone = Convert.ToString(linha["telefone"]);
                    cliente.Email = linha["email"].ToString();
                    cliente.TipoCliente = linha["tipoCliente"].ToString();

                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu algum erro durante o processo de consulta");
                return null;
            }
        }

    }
}


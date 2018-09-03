using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeBStudio.Control.DTO;
using SeBStudio.Model;

namespace SeBStudio.Control
{
    class GestaoProdutoControl
    {               
            AcessoDadosMySql acessoMysql = new AcessoDadosMySql();

            public ProdutoColecao ConsultarTodos()
            {
                try
                {
                    ProdutoColecao produtoColecao = new ProdutoColecao();

                    acessoMysql.LimparParametros();

                    DataTable datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spProdutoSelecionaTodos");

                    foreach (DataRow linha in datatableUsuario.Rows)
                    {
                        Produto prod = new Produto();                        
                        prod.NomeProduto = linha["nomeProduto"].ToString();
                        prod.ValorUnit = Convert.ToDecimal(linha["valorUnit"]);
                        prod.IdProduto = Convert.ToInt32(linha["codigo"]);
                        produtoColecao.Add(prod);
                    }                   
                    return produtoColecao;
                }
                catch (Exception)
                {
                     System.Windows.Forms.MessageBox.Show("Ocorreu algum erro durante o processo de consulta");
                     return null;
                }
            }

        public ProdutoColecao ConsultarPorNome(string nome)
        {
            try
            {
                ProdutoColecao produtoColecao = new ProdutoColecao();

                acessoMysql.LimparParametros();
                acessoMysql.AdicionarParametros("sp_nomeProduto", nome);

                DataTable datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spselecionaProdutoPorNome");

                foreach (DataRow linha in datatableUsuario.Rows)
                {
                    Produto prod = new Produto();                    
                    prod.NomeProduto = linha["nomeProduto"].ToString();
                    prod.ValorUnit = Convert.ToDecimal(linha["valorUnit"]);
                    prod.IdProduto = Convert.ToInt32(linha["codigo"]);
                    produtoColecao.Add(prod);
                }

                return produtoColecao;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu algum erro durante o processo de consulta");
                return null;
            }
        }
        public string Inserir(List<Produto> produtos)
        {
            try
            {
                string idUsuario = "";
                foreach (var produto in produtos)
                {
                    acessoMysql.LimparParametros();                    
                    acessoMysql.AdicionarParametros("spNomeProduto", produto.NomeProduto);
                    acessoMysql.AdicionarParametros("spValorUnit", produto.ValorUnit);
                    acessoMysql.AdicionarParametros("spCodigo", produto.IdProduto);

                    idUsuario = acessoMysql.ExecutarManipulacao(CommandType.StoredProcedure, "spCadastroProduto").ToString();

                if (idUsuario == "Erro ao inserir produto")
                {
                    return "O id inserido já existe";
                }
                }
                return idUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string InserirProdutoEmEnvelope(string id,List<Produto> produtos)
        {
            try
            {
                string idProduto = "";                
                foreach (var produto in produtos)
                {
                    acessoMysql.LimparParametros();
                    acessoMysql.AdicionarParametros("spIdEnvelope", Convert.ToInt32(id));
                    acessoMysql.AdicionarParametros("spIdProduto", produto.IdProduto);                    
                    acessoMysql.AdicionarParametros("spQuantidade", produto.Qnt);
                    acessoMysql.AdicionarParametros("spCortes", produto.Cortes);
                    idProduto = acessoMysql.ExecutarManipulacao(CommandType.StoredProcedure, "spCadastroProdutoEnvelope").ToString();
                }
                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(int idProduto)
        {
            try
            {
                acessoMysql.LimparParametros();
                acessoMysql.AdicionarParametros("spCod", idProduto);
                string id = acessoMysql.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletarProduto").ToString();
                return id;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ProdutoColecao ConsultarPorId(int id)
        {
            try
            {
                ProdutoColecao produtoColecao = new ProdutoColecao();

                acessoMysql.LimparParametros();
                acessoMysql.AdicionarParametros("spCod", id);

                DataTable datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spselecionaProdutoPorId");

                foreach (DataRow linha in datatableUsuario.Rows)
                {
                    Produto prod = new Produto();                    
                    prod.NomeProduto = linha["nomeProduto"].ToString();
                    prod.ValorUnit = Convert.ToDecimal(linha["valorUnit"]);
                    prod.IdProduto = Convert.ToInt32(linha["codigo"]);
                    produtoColecao.Add(prod);
                }


                return produtoColecao;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu algum erro durante o processo de consulta");
                return null;
            }
        }

        public ProdutoColecao ConsultarPorId2(int id)
        {
            try
            {
                ProdutoColecao produtoColecao = new ProdutoColecao();

                acessoMysql.LimparParametros();
                acessoMysql.AdicionarParametros("spCod", id);

                DataTable datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spselecionaProdutoPorId2");

                foreach (DataRow linha in datatableUsuario.Rows)
                {
                    Produto prod = new Produto();                    
                    prod.NomeProduto = linha["nomeProduto"].ToString();
                    prod.ValorUnit = Convert.ToDecimal(linha["valorUnit"]);
                    prod.IdProduto = Convert.ToInt32(linha["codigo"]);
                    produtoColecao.Add(prod);
                }
                return produtoColecao;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu algum erro durante o processo de consulta");
                return null;
            }
        }

        public string AlterarProduto(Produto produto)
        {
            try
            {   
             acessoMysql.LimparParametros();                    
             acessoMysql.AdicionarParametros("spCod", produto.IdProduto);
            acessoMysql.AdicionarParametros("spNomeProduto", produto.NomeProduto);
             acessoMysql.AdicionarParametros("spValorUnit", produto.ValorUnit);

                string idProduto = acessoMysql.ExecutarManipulacao(CommandType.StoredProcedure, "spProdutoAlterar").ToString();
                
                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ProdutoColecao ConsultarProdutosEnvelope(int id)
        {
            try
            {
                ProdutoColecao produtoColecao = new ProdutoColecao();

                acessoMysql.LimparParametros();
                acessoMysql.AdicionarParametros("spOS", id);

                DataTable datatableUsuario = acessoMysql.ExecutarConsulta(CommandType.StoredProcedure, "spConsultarProdutosEnvelope");
                foreach (DataRow linha in datatableUsuario.Rows)
                {
                    Produto prod = new Produto();

                    prod.IdEnvelope = Convert.ToInt32(linha["fk_idEnvelope"]);
                    prod.IdProduto = Convert.ToInt32(linha["fk_idProduto"]);
                    prod.NomeProduto = linha["nomeProduto"].ToString();
                    prod.Qnt = Convert.ToInt32(linha["quantidade"]);
                    prod.ValorUnit = Convert.ToDecimal(linha["valorUnit"]);
                    prod.Cortes = Convert.ToString(linha["cortes"]);
                    produtoColecao.Add(prod);
                }
                return produtoColecao;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu algum erro durante o processo de consulta");
                return null;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SeBStudio.Control.DTO;
using SeBStudio.Model;

namespace SeBStudio.Control
{
    class EnvelopeControl
    {
        public string Inserir(EnvelopeDTO envelope)
        {
            DateTime dataInicio = Convert.ToDateTime(envelope.DataEntrada);
            envelope.DataEntrada = dataInicio.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime dataFim = Convert.ToDateTime(envelope.DataEntrega);
            envelope.DataEntrega = dataFim.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
            AcessoDadosMySql acessoMysql = new AcessoDadosMySql();
            acessoMysql.LimparParametros();
            acessoMysql.AdicionarParametros("spOS",envelope.IdEnvelope);
            acessoMysql.AdicionarParametros("spBaixa", envelope.Baixa);

            if (envelope.IdCliente == 0)
            {
                    acessoMysql.AdicionarParametros("spIdCliente", null);
            }
            else
            {
                    acessoMysql.AdicionarParametros("spIdCliente", envelope.IdCliente);
            }                

            acessoMysql.AdicionarParametros("spObservacao", envelope.Observacao);

            if (envelope.Preco == 0)
            {
                acessoMysql.AdicionarParametros("spPreco", null);
            }
            else
            {
                acessoMysql.AdicionarParametros("spPreco", envelope.Preco);
            }
                
            if (envelope.Total == 0)
            {
                acessoMysql.AdicionarParametros("spTotal", null);
            }
            else
            {
                acessoMysql.AdicionarParametros("spTotal", envelope.Total);
            }
            if (envelope.Sinal == 0)
            {
                acessoMysql.AdicionarParametros("spSinal", null);
            }
            else
            {
                acessoMysql.AdicionarParametros("spSinal", envelope.Sinal);
            }

            acessoMysql.AdicionarParametros("spNome", envelope.Nome);
            acessoMysql.AdicionarParametros("spTelefone", envelope.Telefone);
            acessoMysql.AdicionarParametros("spDataEntrega", envelope.DataEntrega);
            acessoMysql.AdicionarParametros("spDataEntrada", envelope.DataEntrada);                
            acessoMysql.AdicionarParametros("spAtend", envelope.Atend);
            acessoMysql.AdicionarParametros("spFormaPagamento", envelope.FormaPagamento);

             string idEnvelope =  acessoMysql.ExecutarManipulacao(CommandType.StoredProcedure, "spCadastroEnvelope").ToString();

                return idEnvelope;
            }   
            catch (Exception ex)
            {   
                return ex.Message;
            }

        }

        public EnvelopeColecao ConsultarTodosId(string id)
        {
            AcessoDadosMySql acessoMySql = new AcessoDadosMySql();
            acessoMySql.LimparParametros();
            acessoMySql.AdicionarParametros("spOS", id);
            DataTable table = acessoMySql.ExecutarConsulta(CommandType.StoredProcedure, "spEnvelopeSelecionaPorId");


            EnvelopeColecao envelopes = new EnvelopeColecao();

            foreach (DataRow linha in table.Rows)
            {
                EnvelopeDTO envelope = new EnvelopeDTO();
                envelope.Atend = linha["atend"].ToString();
                envelope.Baixa = Convert.ToBoolean(linha["baixa"]);
                envelope.IdEnvelope = Convert.ToInt32(linha["OS"]);

                if (linha["idCliente"].ToString() == null || linha["idCliente"].ToString() == "" || linha["idCliente"].ToString() == " ")
                {
                    envelope.IdCliente = 0;
                }
                else
                {
                    envelope.IdCliente = Convert.ToInt32(linha["idCliente"]);
                }
                envelope.Observacao = (linha["observacao"]).ToString();
                envelope.Preco = Convert.ToDecimal(linha["preco"]);

                if (linha["sinal"].ToString() == null || linha["sinal"].ToString() == "" || linha["sinal"].ToString() == " ")
                {
                    envelope.Sinal = 00.00M;
                }
                else
                {
                    envelope.Sinal = Convert.ToDecimal(linha["sinal"]);
                }
                envelope.Total = Convert.ToDecimal(linha["total"]);
                envelope.Nome = (linha["nome"]).ToString();
                envelope.Telefone = linha["telefone"].ToString();
                envelope.DataEntrega = linha["dataEntrega"].ToString();
                envelope.DataEntrada = linha["dataEntrada"].ToString();
                envelope.FormaPagamento = linha["formaPagamento"].ToString();
                envelopes.Add(envelope);
            }
            return envelopes;
        }

        public  string Excluir(int idEnvelope)
        {
            try
            {
                AcessoDadosMySql acessoDadosMySql = new AcessoDadosMySql();
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("spOS", idEnvelope);

                string retorno = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletarEnvelope").ToString();

                
                if (retorno == "-1")
                {
                    return "Não é possivel excluir envelope com produtos vinculados a ele";
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            
        }

        public EnvelopeColecao ConsultarTodos(string nome)
        {
            try
            {
                AcessoDadosMySql acessoMySql = new AcessoDadosMySql();
                acessoMySql.LimparParametros();
                acessoMySql.AdicionarParametros("spNome", nome);
                DataTable table = acessoMySql.ExecutarConsulta(CommandType.StoredProcedure, "spEnvelopeSelecionaPorNomeCliente");


                EnvelopeColecao envelopes = new EnvelopeColecao();

                foreach (DataRow linha in table.Rows)
                {
                    EnvelopeDTO envelope = new EnvelopeDTO();
                    envelope.Atend = linha["atend"].ToString();
                    envelope.Baixa = Convert.ToBoolean(linha["baixa"]);
                    envelope.IdEnvelope = Convert.ToInt32(linha["OS"]);

                    if (linha["idCliente"].ToString() == null || linha["idCliente"].ToString() == "" || linha["idCliente"].ToString() == " ")
                    {
                        envelope.IdCliente = 0;
                    }
                    else
                    {
                        envelope.IdCliente = Convert.ToInt32(linha["idCliente"]);
                    }
                    envelope.Observacao = (linha["observacao"]).ToString();
                    envelope.Preco = Convert.ToDecimal(linha["preco"]);

                    if (linha["sinal"].ToString() == null || linha["sinal"].ToString() == "" || linha["sinal"].ToString() == " ")
                    {
                        envelope.Sinal = 00.00M;
                    }
                    else
                    {
                        envelope.Sinal = Convert.ToDecimal(linha["sinal"]);
                    }
                    envelope.Total = Convert.ToDecimal(linha["total"]);
                    envelope.Nome = (linha["nome"]).ToString();
                    envelope.Telefone = linha["telefone"].ToString();
                    envelope.DataEntrega = linha["dataEntrega"].ToString();
                    envelope.DataEntrada = linha["dataEntrada"].ToString();
                    envelope.FormaPagamento = linha["formaPagamento"].ToString();
                    envelopes.Add(envelope);
                }
                return envelopes;
            }
            catch (Exception)
            {
                return null;   
            }
        }

        public string SomaTotalGeral(List<Produto> lista)
        {
            decimal valorProduto = 0.00M;

            foreach (var item in lista)
            {
                valorProduto += item.Total;
            }

            return valorProduto.ToString();


        }

        public int retornarUltimoId(int cod)
        {
            try
            {
                int num = 0;
                AcessoDadosMySql acessoDadosMySql = new AcessoDadosMySql();
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("spCod", cod);
                DataTable data = acessoDadosMySql.ExecutarConsulta(CommandType.StoredProcedure, "retornarUltimoEnvelopeInserido");

                foreach (DataRow item in data.Rows)
                {
                    if (item["max(OS)"] == DBNull.Value)
                    {
                        return 0;
                    }
                    num = Convert.ToInt32(item["max(OS)"]);
                }
                return num;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public string Alterar(EnvelopeDTO envelope)
        {
            try
            {
                DateTime dataInicio = Convert.ToDateTime(envelope.DataEntrada);
                envelope.DataEntrada = dataInicio.ToString("yyyy-MM-dd HH:mm:ss");

                DateTime dataFim = Convert.ToDateTime(envelope.DataEntrega);
                envelope.DataEntrega = dataFim.ToString("yyyy-MM-dd HH:mm:ss");

                AcessoDadosMySql acesso = new AcessoDadosMySql();
                acesso.LimparParametros();
                acesso.AdicionarParametros("spIdCliente", envelope.IdCliente);
                acesso.AdicionarParametros("spOS", envelope.IdEnvelope);
                acesso.AdicionarParametros("spBaixa", envelope.Baixa);
                acesso.AdicionarParametros("spObservacao", envelope.Observacao);
                acesso.AdicionarParametros("spPreco", envelope.Preco);
                acesso.AdicionarParametros("spSinal", envelope.Sinal);
                acesso.AdicionarParametros("spTotal", envelope.Total);
                acesso.AdicionarParametros("spNome", envelope.Nome);
                acesso.AdicionarParametros("spTelefone", envelope.Telefone);
                acesso.AdicionarParametros("spDataEntrega", envelope.DataEntrega);
                acesso.AdicionarParametros("spDataEntrada", envelope.DataEntrada);
                acesso.AdicionarParametros("spAtend", envelope.Atend);
                acesso.AdicionarParametros("spFormaPagamento", envelope.FormaPagamento);

                string id = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "spEnvelopeAlterar").ToString();
                return id;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string LimparProdutos(int idEnvelope)
        {
            try
            {
                AcessoDadosMySql acessoDadosMySql = new AcessoDadosMySql();
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("spOS", idEnvelope);

                string retorno = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spLimparProdutosDeEnvelope").ToString();


                if (retorno == "-1")
                {
                    return "Não é possivel excluir excluir produtos";
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        
    }
}

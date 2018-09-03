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
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace SeBStudio.View
{
    public partial class frmImprimir : Form
    {
        EnvelopeDTO envelope;
        List<Produto> produtos;


        PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        PrintDocument printDocument1 = new PrintDocument();      
        

        public frmImprimir(EnvelopeDTO envelope,List<Produto> produtos)
        {
            InitializeComponent();
            this.envelope = envelope;
            this.produtos = produtos;
        }
        public frmImprimir(EnvelopeDTO envelope)
        {
            InitializeComponent();
            this.envelope = envelope;
        }

        private void frmImprimir_Load(object sender, EventArgs e)
        {

            string hora = Convert.ToDateTime(envelope.DataEntrega).ToString("hh:mm");
            //rpvEnvelope.PrinterSettings.PrinterName
            string data = Convert.ToDateTime(envelope.DataEntrega).ToShortDateString();


            List<ReportParameter> parameter = new List<ReportParameter>();
            parameter.Add(new ReportParameter("Nome", envelope.Nome));

            parameter.Add(new ReportParameter("DataPrometida", data));
            parameter.Add(new ReportParameter("OS", envelope.IdEnvelope.ToString()));
            parameter.Add(new ReportParameter("Sinal", envelope.Sinal.ToString()));
            parameter.Add(new ReportParameter("DataEntrega", hora));
            parameter.Add(new ReportParameter("Total", envelope.Total.ToString()));
            parameter.Add(new ReportParameter("Telefone", envelope.Telefone.ToString()));
            parameter.Add(new ReportParameter("TipoPag", envelope.FormaPagamento));
            parameter.Add(new ReportParameter("Preco", envelope.Preco.ToString()));
            parameter.Add(new ReportParameter("DataEntrada", envelope.DataEntrada));

            int i = 0;
            foreach (Produto produto in produtos)
            {
                parameter.Add(new ReportParameter("Cod" + i, produto.IdProduto.ToString()));
                parameter.Add(new ReportParameter("Qnt" + i, produto.Qnt.ToString()));
                parameter.Add(new ReportParameter("Unit" + i, produto.ValorUnit.ToString()));
                parameter.Add(new ReportParameter("Descricao" + i, produto.NomeProduto));
                parameter.Add(new ReportParameter("Total" + i, produto.Total.ToString()));
                i++;
            }
            
            reportViewer1.LocalReport.SetParameters(parameter);
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            
        }
        /// <summary>
        /// Envia os ids dos produtos para o cadastro de produto em envelope     
        /// </summary>
        /// <param name="id">Id do envelope</param>
        /// <param name="lista">Lista de produtos</param>
        private void InserirProdutosEmEnvelope(string id,List<Produto> lista)
        {
            GestaoProdutoControl produto = new GestaoProdutoControl();
            string env = produto.InserirProdutoEmEnvelope(id, lista);
            try
            {
                int idProdutos = Convert.ToInt32(env);
                MessageBox.Show("Cadastro efetuado com sucesso","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel inserir produtos dentro do envelope", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }    
        private void frmImprimir_KeyDown(object sender, KeyEventArgs e)
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
                    btnConf_Click(sender, e);
                    break;
            }
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            EnvelopeControl envelop = new EnvelopeControl();
            string id = envelop.Inserir(envelope);
            try
            {
                int idEnvelope = Convert.ToInt32(id);   
                InserirProdutosEmEnvelope(Convert.ToString(envelope.IdEnvelope), produtos);
                DialogResult = DialogResult.Yes;
            }
            catch (Exception)
            {               
                DialogResult = DialogResult.No;
            }
        }
    }
}

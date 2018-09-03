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
using SeBStudio.Model;

namespace SeBStudio.View
{
    public partial class CalcMetroQuadrado : Form
    {

        private List<TamanhosPreDefinidos> lista = new List<TamanhosPreDefinidos>();
        private XmlControl xml;
        private string caminho;

        public CalcMetroQuadrado()
        {
            InitializeComponent();
            
        }
        //string[] array;
        private void CalcMetroQuadrado_Load(object sender, EventArgs e)
        {
            try
            {
                AcessoXml acesso = new AcessoXml();
                caminho = acesso.ConexaoXml();
                xml = new XmlControl(caminho);

                rbrCalcularMedia.Checked = true;
                lista = xml.BuscarTamanhos();
                if (cbxTamanhosPreDefinidos.Items.Count > 0)
                {
                    cbxTamanhosPreDefinidos.Items.Clear();
                }
                foreach (var item in lista)
                {
                    cbxTamanhosPreDefinidos.Items.Add(item);

                }
                cbxTamanhosPreDefinidos.DisplayMember = "Nome";
                cbxTamanhosPreDefinidos.ValueMember = "Nome";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível buscar tamanhos pré definidos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //verifica se todas as txb da group box calculo quantidade foi preenchido
        private void VerificarSeTudoFoiPreenchido()
        {
            try
            {
                if (rbrCalcularMedia.Checked == true)
                {
                    if (!string.IsNullOrWhiteSpace(txbAlturaDaAreaDeImpressao.Text) && !string.IsNullOrWhiteSpace(txbLarguraDaAreaDeImpressao.Text) && !string.IsNullOrWhiteSpace(txbLarguraDoAdesivo.Text) && !string.IsNullOrWhiteSpace(txbAlturaDoAdesivo.Text))
                    {
                        //Calcula a média por folha
                        txbMediaPorFolha.Text = (
                            Math.Floor(
                            (Convert.ToDecimal(txbLarguraDaAreaDeImpressao.Text) / Convert.ToDecimal(txbLarguraDoAdesivo.Text))
                                      )
                            *
                           (
                            Math.Floor
                            (Convert.ToDecimal(txbAlturaDaAreaDeImpressao.Text) / Convert.ToDecimal(txbAlturaDoAdesivo.Text))
                             )
                               ).ToString();
                    }
                    txbMediaPorFolha.Enabled = false;
                    txbAlturaDaAreaDeImpressao.Enabled = true;
                }
                if (rbrCalcularAltura.Checked == true)
                {
                    txbLarguraDaAreaDeImpressao.Text = 120.ToString();
                    if (!string.IsNullOrWhiteSpace(txbLarguraDoAdesivo.Text) && !string.IsNullOrWhiteSpace(txbAlturaDoAdesivo.Text) && !string.IsNullOrWhiteSpace(txbMediaPorFolha.Text))
                    {
                        decimal x = Math.Floor((120 / (Convert.ToDecimal(txbLarguraDoAdesivo.Text))));

                        txbAlturaDaAreaDeImpressao.Text = Math.Floor(Math.Floor((Convert.ToDecimal(txbMediaPorFolha.Text) * Convert.ToDecimal(txbLarguraDoAdesivo.Text))) / x).ToString();                        
                    }
                    txbAlturaDaAreaDeImpressao.Enabled = false;
                    txbMediaPorFolha.Enabled = true;

                }
            }
            catch (Exception)
            {                
                return;
            }

        }

        private void txbLarguraDaAreaDeImpressao_Validated(object sender, EventArgs e)
        {
            VerificarSeTudoFoiPreenchido();
        }

        private void txbAlturaDaAreaDeImpressao_Validated(object sender, EventArgs e)
        {
            VerificarSeTudoFoiPreenchido();
        }

        private void txbLarguraDoAdesivo_Validated(object sender, EventArgs e)
        {
            VerificarSeTudoFoiPreenchido();
        }

        private void txbAlturaDoAdesivo_Validated(object sender, EventArgs e)
        {
            VerificarSeTudoFoiPreenchido();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txbAlturaDaAreaDeImpressao.Text = null;
            txbLarguraDaAreaDeImpressao.Text = null;
            txbLarguraDoAdesivo.Text = null;
            txbAlturaDoAdesivo.Text = null;
            txbMediaPorFolha.Text = null;
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            txbValorM2.Text = null;
            txbAltura.Text = null;
            txbLargura.Text = null;
            txbTotal.Text = null;
        }

        private void cbxTamanhosPreDefinidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TamanhosPreDefinidos tam = new TamanhosPreDefinidos();
            tam = (TamanhosPreDefinidos)cbxTamanhosPreDefinidos.SelectedItem;         
            
            txbValorM2.Text = tam.Valor.ToString();
            txbAlturaDaAreaDeImpressao.Text = tam.Altura.ToString();
            txbLarguraDaAreaDeImpressao.Text = tam.Largura.ToString();

        }

        private void txbMediaPorFolha_Validated(object sender, EventArgs e)
        {
            VerificarSeTudoFoiPreenchido();
        }

        private void CalcValorTotal()
        {
            try
            {            
                if (!string.IsNullOrWhiteSpace(txbValorM2.Text) && !string.IsNullOrWhiteSpace(txbLargura.Text) && !string.IsNullOrWhiteSpace(txbAltura.Text))
                {
                    txbTotal.Text =  Math.Round((Convert.ToDecimal(txbAltura.Text) * Convert.ToDecimal(txbLargura.Text) * Convert.ToDecimal(txbValorM2.Text))/10000,2).ToString();
                }
            }
            catch (Exception)
            {
                return;             
            }
        }

        private void txbValorM2_Validated(object sender, EventArgs e)
        {
            CalcValorTotal();
        }

        private void txbLargura_Validated(object sender, EventArgs e)
        {
            CalcValorTotal();
        }

        private void txbAltura_Validated(object sender, EventArgs e)
        {
            CalcValorTotal();
        }
        private void rbrCalcularMedia_CheckedChanged(object sender, EventArgs e)
        {
            VerificarSeTudoFoiPreenchido();
        }

        private void rbrCalcularAltura_CheckedChanged(object sender, EventArgs e)
        {
            VerificarSeTudoFoiPreenchido();
        }

        private void CalcMetroQuadrado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.L:
                        btnLimpar2_Click(sender, e);
                        break;

                    case Keys.K:
                        btnLimpar_Click(sender, e);
                        break;
                    case Keys.W:
                        this.Close();
                        break;
                }
            }
        }
    }
}

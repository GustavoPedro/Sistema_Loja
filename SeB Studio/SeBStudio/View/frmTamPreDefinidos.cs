using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using SeBStudio.Control.DTO;
using SeBStudio.Model;
using SeBStudio.Control;

namespace SeBStudio.View
{
    public partial class frmTamPreDefinidos : Form
    {
        private int id;

        private int idParaCrud;
        string caminho;

        private XmlControl xml;

        private List<TamanhosPreDefinidos> lista = new List<TamanhosPreDefinidos>();

        public frmTamPreDefinidos()
        {
            InitializeComponent();
          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txbNomeExibido.Text) && !string.IsNullOrWhiteSpace(txbValorPreDefinido.Text) && !string.IsNullOrWhiteSpace(txbLargura.Text)&& !string.IsNullOrWhiteSpace(txbAltura.Text))
            {
                try
                {
                    TamanhosPreDefinidos tamanhosPreDefinidos = new TamanhosPreDefinidos();

                    tamanhosPreDefinidos.Id = id + 1;
                    tamanhosPreDefinidos.Nome = txbNomeExibido.Text;
                    tamanhosPreDefinidos.Valor = Convert.ToDecimal(txbValorPreDefinido.Text);
                    tamanhosPreDefinidos.Altura = Convert.ToInt32(txbAltura.Text);
                    tamanhosPreDefinidos.Largura = Convert.ToInt32(txbLargura.Text);
                    xml.CadastrarTamanhosPreDefinidos(tamanhosPreDefinidos);
                    Reload();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel salvar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void Reload()
        {
            try
            {                            
                cbxTamanhos.Text = "";
                txbNomeExibido.Text = null;
                txbValorPreDefinido.Text = null;
                txbAltura.Text = null;
                txbLargura.Text = null;
                lista = xml.BuscarTamanhos();
                if (cbxTamanhos.Items.Count > 0)
                {
                    cbxTamanhos.Items.Clear();
                }
                foreach (var item in lista)
                {
                    cbxTamanhos.Items.Add(item);
                    id = item.Id;
                }
                cbxTamanhos.DisplayMember = "Nome";
                cbxTamanhos.ValueMember = "Nome";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            AcessoXml acesso = new AcessoXml();
            caminho = acesso.ConexaoXml();
            if (caminho == "erro")
            {
                MessageBox.Show("Ocorreu um erro de conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            xml = new XmlControl(caminho);
            Reload();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            xml.ExcluirTamanho(idParaCrud.ToString());
            Reload();
        }

        private void cbxTamanhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TamanhosPreDefinidos tam = new TamanhosPreDefinidos();
            tam = (TamanhosPreDefinidos)cbxTamanhos.SelectedItem;
            idParaCrud = tam.Id;
            txbNomeExibido.Text = tam.Nome;
            txbValorPreDefinido.Text = tam.Valor.ToString();
            txbAltura.Text = tam.Altura.ToString();
            txbLargura.Text = tam.Largura.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            TamanhosPreDefinidos tam = new TamanhosPreDefinidos();
            tam.Id = idParaCrud;
            tam.Nome = txbNomeExibido.Text;
            tam.Valor = Convert.ToDecimal(txbValorPreDefinido.Text);
            tam.Altura = int.Parse(txbAltura.Text);
            tam.Largura = int.Parse(txbLargura.Text);
            xml.UpdateTamanho(tam);
            Reload();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        this.Close();
                        break;
                    case Keys.D:
                        btnExcluir_Click(sender, e);
                        break;
                    
                }
            }
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnSalvar_Click(sender, e);
                    break;
            }
        }

        private void txbAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbLargura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

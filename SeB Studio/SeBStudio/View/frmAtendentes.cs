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
    public partial class frmAtendentes : Form
    {
        XmlControl xml;
        string caminho;
        int id ;
        public frmAtendentes()
        {
            InitializeComponent();
        }

       
        private void frmAtendentes_Load(object sender, EventArgs e)
        {
            AcessoXml acesso = new AcessoXml();
            caminho = acesso.ConexaoXml();
            xml = new XmlControl(caminho);
            Atualizar();
            
        }

        private void Atualizar()
        {
            try
            {            
                 id = 0;
                lbxAtendentes.Items.Clear();
                List<Atendente> lista =  xml.BuscarAtendentes();
                if (lista.Count == 0)
                {
                    return;
                }
                else
                {
                    foreach (var item in lista)
                    {

                        lbxAtendentes.Items.Add(item);
                        lbxAtendentes.DisplayMember = "Nome";
                        lbxAtendentes.ValueMember = "Nome";
                        id = item.Id;
                    }
                    id = id + 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel atualizar atendentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbAtendentes.Text))
            {
                try
                {
                    xml.CadastrarAtendentes(txbAtendentes.Text, id.ToString());
                    Atualizar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel cadastrar atendente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Digite o nome de algum atendente antes de adicionar","Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lbxAtendentes.SelectedIndex != -1)
            {
                try
                {                
                    Atendente atend = (Atendente)lbxAtendentes.SelectedItem;
                    xml.ExcluirAtendente(atend.Id.ToString());
                    Atualizar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel remover atendente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um atendente para deletar","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAtendentes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnAdicionar_Click(sender, e);
                    break;
            }
            if (e.Control)
            {
                switch (e.KeyCode)
                {                    
                    case Keys.D:
                        btnRemover_Click(sender, e);
                        break;
                    case Keys.W:
                        this.Close();
                        break;
                }
            }
        }
    }
}

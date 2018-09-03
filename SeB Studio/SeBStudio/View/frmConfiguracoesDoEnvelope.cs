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
    public partial class frmConfiguracoesDoEnvelope : Form
    {
        public frmConfiguracoesDoEnvelope()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (fbdPastaEnv.ShowDialog() == DialogResult.OK)
            {
                txbCaminho.Text = fbdPastaEnv.SelectedPath;
            }            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {            
                AcessoXml acessoXml = new AcessoXml();
                XmlControl xmlControl = new XmlControl(acessoXml.ConexaoXml());
                xmlControl.RegistrarCaminho(txbCaminho.Text);

                MessageBox.Show("Caminho salvo com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível salvar o caminho " + ex.Message,"Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void frmConfiguracoesDoEnvelope_KeyDown(object sender, KeyEventArgs e)
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
                    btnSalvar_Click(sender, e);
                    break;
            }
        }
    }
}

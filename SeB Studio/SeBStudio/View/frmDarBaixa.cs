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
using SeBStudio.Control.DTO;

namespace SeBStudio.View
{
    public partial class frmDarBaixa : Form
    {
        EnvelopeControl env = new EnvelopeControl();
        private int idPermissao,codigo;

        public frmDarBaixa()
        {
            InitializeComponent();
            dgvBaixa.AutoGenerateColumns = false;
        }

        public frmDarBaixa(int idPermissao,int codigo)
        {
            InitializeComponent();
            this.idPermissao = idPermissao;
            this.codigo = codigo;
            dgvBaixa.AutoGenerateColumns = false;
        }

        private void frmDarBaixa_Load(object sender, EventArgs e)
        {
            if (idPermissao == 2)
            {
                btnAlterar.Enabled = false;
                btnDeletar.Enabled = false;
            }

            AtualizarGrid();
            rbrNome.Checked = true;
        }

        private void btnDarBaixa_Click(object sender, EventArgs e)
        {
            if (dgvBaixa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum envelope selecionado.");
                return;
            }

            EnvelopeDTO envelopeSelecionado  = (dgvBaixa.SelectedRows[0].DataBoundItem as EnvelopeDTO);
            envelopeSelecionado.Baixa = true;
            string idBaixa = env.Alterar(envelopeSelecionado);
            try
            {
                int a = Convert.ToInt32(idBaixa);
                AtualizarGrid();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel dar baixa","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void dgvBaixa_MouseClick(object sender, MouseEventArgs e)
        {
            int indiceselecionado = -1;
            // Se o usuário selecionou a Linha
            if (dgvBaixa.SelectedRows.Count > 0)
            {
                indiceselecionado = dgvBaixa.SelectedRows[0].Index;
            }
            else
            { // Se o usuário selecionou a célula
                if (dgvBaixa.SelectedCells.Count > 0)
                {
                    indiceselecionado = dgvBaixa.SelectedCells[0].RowIndex;
                }
            }
        }
        //Métodos

        private void AtualizarGrid()
        {
            try
            {
                dgvBaixa.DataSource = null;
                dgvBaixa.DataSource = env.ConsultarTodos(txbPesquisar.Text);
                dgvBaixa.Update();
                dgvBaixa.Refresh();
            }
            catch (Exception)
            {               
                MessageBox.Show("Não foi possivel consultar envelopes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbrId.Checked == true)
                {
                    dgvBaixa.DataSource = null;
                    dgvBaixa.DataSource = env.ConsultarTodosId(txbPesquisar.Text);
                    dgvBaixa.Update();
                    dgvBaixa.Refresh();
                }
                if (rbrNome.Checked == true)
                {
                    AtualizarGrid();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel consultar envelopes","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);;
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvBaixa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum envelope selecionado.");
                return;
            }
            //deseja realmente excluir?
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar produto selecionado
            EnvelopeDTO envelopeSelecionado = (dgvBaixa.SelectedRows[0].DataBoundItem as EnvelopeDTO);

            EnvelopeControl envelopeControl = new EnvelopeControl();
            string retorno = " ";                    
            
                 retorno = envelopeControl.Excluir(envelopeSelecionado.IdEnvelope);
            
            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Envelope excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir." + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvBaixa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum envelope selecionado.");
                return;
            }
            EnvelopeDTO envelopeSelecionado = (dgvBaixa.SelectedRows[0].DataBoundItem as EnvelopeDTO);
            envelopeSelecionado.Baixa = true;
            frmEnvelope frmEnvelope = new frmEnvelope(CRUD.alterar,envelopeSelecionado,0);

            if (frmEnvelope.ShowDialog()== DialogResult.Yes)
            {
                AtualizarGrid();
            }
            //env.Alterar(envelopeSelecionado);
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmEnvelope frm = new frmEnvelope(CRUD.cadastrar,null,codigo,idPermissao);
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                AtualizarGrid();
            } 
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txbPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbrId.Checked == true)
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

        private void btnDarBaixa_KeyDown(object sender, KeyEventArgs e)
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
                    btnDarBaixa_Click(sender, e);
                break;
            }
        }
    }
}

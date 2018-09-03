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
using SeBStudio.View;
using SeBStudio.Model;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace SeBStudio
{
    public partial class frmEnvelope : System.Windows.Forms.Form
    {


        private string idCliente;
        private string caminho;       

        List<Produto> lista = new List<Produto>();

        EnvelopeControl controle = new EnvelopeControl();

        GestaoProdutoControl gest = new GestaoProdutoControl();

        
        private CRUD crud;
        private EnvelopeDTO envelopeSelecionado;
        private int codigo;
        private int idPermissao;
        //CRUD crud;

        //EnvelopeDTO envelopeDTO;
        //List<Produto> produtoDTO;

        public frmEnvelope(CRUD crud, int codigo,int idPermissao = 0)
        {
            this.codigo = codigo;
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
            dgvClientesVip.AutoGenerateColumns = false;
            this.crud = crud;
            this.idPermissao = idPermissao;
            
        }

        public frmEnvelope(CRUD crud, EnvelopeDTO envelopeSelecionado,int codigo,int idPermissao = 0)
        {
            this.crud = crud;
            this.envelopeSelecionado = envelopeSelecionado;

            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
            dgvClientesVip.AutoGenerateColumns = false;
            this.codigo = codigo;
            this.idPermissao = idPermissao;
        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            txbDataEntrega.Text = DateTime.Now.ToString();
            AcessoXml acessoXml = new AcessoXml();            
            XmlControl xmlControl = new XmlControl(acessoXml.ConexaoXml());
            caminho = xmlControl.BuscarCaminho();
            List<Atendente> atendentes = xmlControl.BuscarAtendentes();

            if (atendentes.Count != 0)
            {
                cbxAtend.Items.Clear();
                foreach (var item in atendentes)
                {
                    cbxAtend.Items.Add(item.Nome);
                }
            }            
            
            if (crud == CRUD.alterar)
            {
                GestaoProdutoControl produtoControl = new GestaoProdutoControl();
                txbOs.Text = envelopeSelecionado.IdEnvelope.ToString();
                txbTotalTudo.Text = envelopeSelecionado.Total.ToString();
                txbSinal.Text = envelopeSelecionado.Sinal.ToString();
                txbValor.Text = envelopeSelecionado.Preco.ToString();
                txbObservacao.Text = envelopeSelecionado.Observacao;
                txbDataEntrega.Text = envelopeSelecionado.DataEntrega;
                lblDataAtual.Text = envelopeSelecionado.DataEntrada;
                idCliente = envelopeSelecionado.IdCliente.ToString();
                txbTelefone.Text = envelopeSelecionado.Telefone;
                txbCliente.Text = envelopeSelecionado.Nome;
                cbxAtend.Text = envelopeSelecionado.Atend;
                cbxFormaPagamento.Text = envelopeSelecionado.FormaPagamento;
                btnImprimir.Text = "Alterar";

                dgvProdutos.DataSource = null;

                ProdutoColecao colecao = produtoControl.ConsultarProdutosEnvelope(envelopeSelecionado.IdEnvelope);

                if (colecao != null)
                {
                    foreach (var item in colecao)
                    {
                        item.Total = (item.Qnt) * (item.ValorUnit);
                    }
                }                    

                lista = colecao;
                dgvProdutos.DataSource = lista;
                dgvProdutos.Update();
                dgvProdutos.Refresh();
                AtualizarDgvClientes();
            }

            if (crud == CRUD.cadastrar)
            {
                this.txbIdProduto.Select();
                AtualizarOs();
                if (idPermissao != 3)
                {
                    CriarPasta();
                }                
                AtualizarDgvClientes();
            }
            
        }
        // Primeira Tab Eventos
        private void btnAdicionar_Click(object sender, EventArgs e)
        {            
            Adicionar();
            txbValor.Text = controle.SomaTotalGeral(lista);
            txbTotalTudo.Text = txbValor.Text;
            this.txbIdProduto.Select();
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            //Pegar produto selecionado
            Produto prod = (dgvProdutos.SelectedRows[0].DataBoundItem as Produto);
            lista.Remove(prod);

            AtualizarEmDgv();
            if (txbSinal.Text == null || txbSinal.Text == " " || txbSinal.Text == "")
            {
                txbValor.Text = controle.SomaTotalGeral(lista);
                txbTotalTudo.Text = txbValor.Text;
            }
            else
            {
                decimal sinal = Convert.ToDecimal(txbSinal.Text);
                txbTotalTudo.Text = (Convert.ToDecimal(controle.SomaTotalGeral(lista)) - Convert.ToDecimal(sinal)).ToString();
                decimal totalTudo = Convert.ToDecimal(txbTotalTudo.Text);
                txbValor.Text = (totalTudo + sinal).ToString();

            }

        }

        private void dgvProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            int indiceselecionado = -1;
            // Se o usuário selecionou a Linha
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                indiceselecionado = dgvProdutos.SelectedRows[0].Index;
            }
            else
            { // Se o usuário selecionou a célula
                if (dgvProdutos.SelectedCells.Count > 0)
                {
                    indiceselecionado = dgvProdutos.SelectedCells[0].RowIndex;
                }
            }

            if (indiceselecionado != -1)
            {
                btnRemover.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmListaProdutos frm = new frmListaProdutos();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txbIdProduto.Text = frm.ProdutoSelecionado[0];
                txbDescricao.Text = frm.ProdutoSelecionado[1];
                txbValorUnitario.Text = frm.ProdutoSelecionado[2];
                txbQuantidade.Focus();
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnCalcMetroQuad_Click(object sender, EventArgs e)
        {
            CalcMetroQuadrado cal = new CalcMetroQuadrado();
            cal.Show();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbcCadastroEnvelope.SelectedTab = tbpDadosCliente;
        }


        //Validações

        private void txbIdProduto_Validated(object sender, EventArgs e)
        {
            TentarMultiplicar();

            try
            {
                ProdutoColecao table = gest.ConsultarPorId2(Convert.ToInt32(txbIdProduto.Text));
                foreach (var item in table)
                {
                    txbDescricao.Text = item.NomeProduto;
                    txbValorUnitario.Text = item.ValorUnit.ToString();
                }
            }
            catch (Exception)
            {

                return;
            }


        }
        private void txbValorUnitario_Validated(object sender, EventArgs e)
        {
            TentarMultiplicar();
        }

        private void txbQuantidade_Validated(object sender, EventArgs e)
        {
            TentarMultiplicar();
        }

        private void txbDescricao_Validated(object sender, EventArgs e)
        {
            TentarMultiplicar();
        }

      
        private void txbValor_Validated(object sender, EventArgs e)
        {
            SubtrairSinal();
            
        }

        private void txbSinal_Validated(object sender, EventArgs e)
        {
            SubtrairSinal();
        }

        private void txbTotalTudo_Validated(object sender, EventArgs e)
        {
            SubtrairSinal();
            
        }

        //Primeira tab
        private void LimparTela()
        {
            txbIdProduto.Text = null;
            txbDescricao.Text = null;
            txbQuantidade.Text = null;
            txbValorUnitario.Text = null;
            txbTotal.Text = null;
            cbxCortes.Text = null;
        }


        private void AtualizarOs()
        {
            EnvelopeControl control = new EnvelopeControl();
            int id = control.retornarUltimoId(codigo);

            try
            {
                int a = Convert.ToInt32(id);
                if (id == 0)
                {
                    
                    string x = "000";
                    id = Convert.ToInt32(codigo.ToString() + x);
                }
                else
                {
                    id++;
                }
                txbOs.Text = id.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Não foi possivel atualizar os", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Primeira Tab
        private void AtualizarEmDgv()
        {
            try
            {
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = lista;
                dgvProdutos.Update();
                dgvProdutos.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível atualizar tabela");
            }
        }    
      

        /*Primeira Tab
         Adiciona no DataGridView o objeto */
        private void Adicionar()
        {
            try
            {
                Produto produto = new Produto();
                produto.IdProduto = Convert.ToInt32(txbIdProduto.Text);
                produto.NomeProduto = txbDescricao.Text;
                produto.Qnt = Convert.ToInt32(txbQuantidade.Text);
                produto.Cortes = cbxCortes.Text;
                produto.Total = Convert.ToDecimal(txbTotal.Text);
                produto.ValorUnit = Convert.ToDecimal(txbValorUnitario.Text);
                lista.Add(produto);
                AtualizarEmDgv();
                LimparTela();
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel adicionar produto em tabela","Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }   
     
        //Primeira tab
        private void SubtrairSinal()
        {
            if (!string.IsNullOrWhiteSpace(txbValor.Text) && !string.IsNullOrWhiteSpace(txbSinal.Text))
            {
                txbTotalTudo.Text = (Convert.ToDecimal(txbValor.Text) - Convert.ToDecimal(txbSinal.Text)).ToString();
            }
        }
        // Segunda tab
        private void AtualizarDgvClientes()
        {
            try
            {
                GestaoClienteControl gestao = new GestaoClienteControl();
                dgvClientesVip.DataSource = null;
                dgvClientesVip.DataSource = gestao.ConsultarTodos(txbPesquisar.Text,"nome");
                dgvClientesVip.Update();
                dgvClientesVip.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel consultar clientes","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
      


        //Realiza a multiplicação da Quantidade X Valor Unitario do produto
        private void TentarMultiplicar()
        {
            if (!string.IsNullOrWhiteSpace(txbQuantidade.Text) && !string.IsNullOrWhiteSpace(txbValorUnitario.Text))
            {
                try
                {
                    txbTotal.Text = (Convert.ToDecimal(txbValorUnitario.Text) * Convert.ToDecimal(txbQuantidade.Text)).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel efetuar a multiplicação");
                    return;
                }
            }
        }


        //Limpa todos os campos da form após a impressão
        private void ClearForm()
        {
            txbIdProduto.Text = null;
            txbDescricao.Text = null;
            txbQuantidade.Text = null;
            txbValorUnitario.Text = null;
            cbxCortes.Text = null;
            txbTotal.Text = null;
            lista = new List<Produto>();
            AtualizarEmDgv();
            txbObservacao.Text = null;
            txbValor.Text = null;
            txbSinal.Text = null;
            txbTotalTudo.Text = null;
           
            AtualizarOs();
            if (idPermissao != 3)
            {
                CriarPasta();
            }
            idCliente = null;
            txbTelefone.Text = null;
            txbCliente.Text = null;
            txbTelefone.Text = null;            
            txbSituacao.Text = null;
            txbHora.Text = null;
            txbNumeroDeDias.Text = null;
            cbxAtend.Text = null;
            cbxFormaPagamento.Text = null;
            tbcCadastroEnvelope.SelectedTab = tbpCadastroEnv;
            this.txbIdProduto.Select();
            txbDataEntrega.Text = DateTime.Now.ToString();
        }

        private void CriarPasta()
        {
            try
            {                
                if (Directory.Exists(caminho + "/" + txbOs.Text))
                {
                    return;
                }
                else
                {
                    Directory.CreateDirectory(caminho + "/" + txbOs.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel salvar pasta referente a os " + ex.Message , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    
        //  Eventos Segunda tab
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            tbcCadastroEnvelope.SelectedTab = tbpCadastroEnv;
        }        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbTotalTudo.Text) && !string.IsNullOrWhiteSpace(txbCliente.Text) && !string.IsNullOrWhiteSpace(txbTelefone.Text) && !string.IsNullOrWhiteSpace(txbValor.Text) && !string.IsNullOrWhiteSpace(txbOs.Text) && dgvProdutos.DataSource != null)
            {
                if (crud == CRUD.cadastrar)
                {                    
                    //EnvelopeControl envelop = new EnvelopeControl();
                    EnvelopeDTO envelope = new EnvelopeDTO();

                    envelope.IdEnvelope = Convert.ToInt32(txbOs.Text);
                    envelope.Baixa = false;

                    if (!string.IsNullOrWhiteSpace(idCliente))
                    {
                        envelope.IdCliente = Convert.ToInt32(idCliente);
                    }
                    else
                    {
                        envelope.IdCliente = 0;
                    }

                    envelope.Observacao = txbObservacao.Text;
                    envelope.Preco = Convert.ToDecimal(txbValor.Text);

                    if (!string.IsNullOrWhiteSpace(txbSinal.Text))
                    {
                        envelope.Sinal = Convert.ToDecimal(txbSinal.Text);
                    }
                    else
                    {
                        envelope.Sinal = 00.00M;
                    }
                    envelope.Total = Convert.ToDecimal(txbTotalTudo.Text);
                    envelope.Nome = txbCliente.Text;
                    envelope.Telefone = txbTelefone.Text;
                    envelope.DataEntrada = DateTime.Now.ToString();
                    envelope.DataEntrega = txbDataEntrega.Text;
                    envelope.Atend = cbxAtend.Text;
                    envelope.FormaPagamento = cbxFormaPagamento.Text;               
                    
                    
                    frmImprimir imprimir = new frmImprimir(envelope, lista);

                    if (imprimir.ShowDialog() == DialogResult.Yes)
                    {
                        MessageBox.Show("Produto cadastrado com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        if (idPermissao == 3)
                        {
                            CriarPasta();
                        }
                        ClearForm();
                        DialogResult = DialogResult.Yes;
                       
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Cadastrar ","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                    }                    
                }

                if (crud == CRUD.alterar)
                {
                        
                        EnvelopeControl env = new EnvelopeControl();
                        GestaoProdutoControl produtoControl = new GestaoProdutoControl();
                        EnvelopeDTO envelope = new EnvelopeDTO();
                        envelope.IdEnvelope = Convert.ToInt32(txbOs.Text);
                        envelope.Baixa = envelopeSelecionado.Baixa;

                        if (!string.IsNullOrWhiteSpace(idCliente))
                        {
                            envelope.IdCliente = Convert.ToInt32(idCliente);
                        }
                        else
                        {
                            envelope.IdCliente = 0;
                        }

                        envelope.Observacao = txbObservacao.Text;
                        envelope.Preco = Convert.ToDecimal(txbValor.Text);

                        if (!string.IsNullOrWhiteSpace(txbSinal.Text))
                        {
                            envelope.Sinal = Convert.ToDecimal(txbSinal.Text);
                        }
                        else
                        {
                            envelope.Sinal = 00.00M;
                        }
                        envelope.Total = Convert.ToDecimal(txbTotalTudo.Text);
                        envelope.Nome = txbCliente.Text;
                        envelope.Telefone = txbTelefone.Text;
                        envelope.DataEntrada = lblDataAtual.Text;
                        envelope.DataEntrega = txbDataEntrega.Text;
                        envelope.Atend = cbxAtend.Text;
                        envelope.FormaPagamento = cbxFormaPagamento.Text;

                        string[] metodos = new string[3];
                        metodos[0] = env.LimparProdutos(envelope.IdEnvelope);
                        metodos[1] = produtoControl.InserirProdutoEmEnvelope(envelope.IdEnvelope.ToString(), lista);
                        metodos[2] = env.Alterar(envelope);
                        if (metodos[1] == "")
                        {
                            metodos[1] = "0";
                        }
                        try
                        {
                            //Verifica se algum processo deu erro
                            for (int i = 0; i < metodos.Count(); i++)
                            {
                                int idAlterar = Convert.ToInt32(metodos[i]);
                            }
                        MessageBox.Show("Alteração efetuada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.Yes;
                        }   
                        catch (Exception)
                        {
                            MessageBox.Show("Não foi possível alterar envelope selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                        }
                    }
                }   
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios primeiro","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

     

        private void dgvClientesVip_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvClientesVip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }
            ClienteDTO clienteSelecionado = (dgvClientesVip.SelectedRows[0].DataBoundItem as ClienteDTO);
            idCliente = (clienteSelecionado.IdCliente).ToString();
            txbCliente.Text = clienteSelecionado.NomeCliente;
            txbTelefone.Text = clienteSelecionado.Telefone;
            
        }

        private void dgvClientesVip_MouseClick(object sender, MouseEventArgs e)
        {
            int indiceselecionado = -1;
            // Se o usuário selecionou a Linha
            if (dgvClientesVip.SelectedRows.Count > 0)
            {
                indiceselecionado = dgvClientesVip.SelectedRows[0].Index;
            }
            else
            { // Se o usuário selecionou a célula
                if (dgvClientesVip.SelectedCells.Count > 0)
                {
                    indiceselecionado = dgvClientesVip.SelectedCells[0].RowIndex;
                }
            }
        }

        // Validações
        private void txbNumeroDeDias_Validated(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            if (txbNumeroDeDias.Text == null || txbNumeroDeDias.Text == " " || txbNumeroDeDias.Text == "")
            {
                today = DateTime.Now;
            }
            else
            {
                today = today.AddDays(Convert.ToDouble(txbNumeroDeDias.Text));
                txbDataEntrega.Text = today.ToString();
            }
        }

        private void txbHora_Validated(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            if (txbHora.Text == null || txbHora.Text == " " || txbHora.Text == "")
            {

            }
            else
            {
                try
                {
                    today = today.AddMinutes(Convert.ToDouble(txbHora.Text));
                    txbDataEntrega.Text = today.ToString();
                }
                catch (Exception)
                {
                    return;
                }
               
            }

        }

      
        
        private void frmEnvelope_KeyDown(object sender, KeyEventArgs e)
        {
            //Teclas de Atalho
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    //Abre a calculadora    
                    case Keys.D1:
                        btnCalculadora_Click(sender, e);
                        break;
                    //Remove do datagridview
                    case Keys.D:
                        btnRemover_Click(sender, e);
                        break;
                    // Abre a form calcular por metro quadrado
                    case Keys.M:
                        btnCalcMetroQuad_Click(sender, e);
                        break;
                    //Abre o form imprimir
                    case Keys.P:
                        btnImprimir_Click(sender, e);
                        break;
                    //Alterna entre tabs
                    case Keys.N:
                        if (tbcCadastroEnvelope.SelectedTab == tbpCadastroEnv)
                        {
                            tbcCadastroEnvelope.SelectedTab = tbpDadosCliente;
                            return;
                        }
                        if (tbcCadastroEnvelope.SelectedTab == tbpDadosCliente)
                        {
                            tbcCadastroEnvelope.SelectedTab = tbpCadastroEnv;
                            return;
                        }
                        break;
                }
            }
          
            switch (e.KeyCode)
            {
                //Adiciona no datagridview
                case Keys.Enter:
                    btnAdicionar_Click(sender, e);
                    break;
            }
        }
        


      

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {            
            AtualizarDgvClientes();
        }

       

        private void cbxAtend_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void cbxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void txbTelefone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbHora_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbNumeroDeDias_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbIdProduto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
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



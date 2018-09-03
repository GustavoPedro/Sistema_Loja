namespace SeBStudio
{
    partial class frmEnvelope
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvelope));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCortes = new System.Windows.Forms.Label();
            this.cbxCortes = new System.Windows.Forms.ComboBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCortes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbValorUnitario = new System.Windows.Forms.TextBox();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbIdProduto = new System.Windows.Forms.TextBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txbObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txbSinal = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbTotalTudo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcCadastroEnvelope = new System.Windows.Forms.TabControl();
            this.tbpCadastroEnv = new System.Windows.Forms.TabPage();
            this.txbOs = new System.Windows.Forms.TextBox();
            this.lblOs = new System.Windows.Forms.Label();
            this.btnCalcMetroQuad = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.tbpDadosCliente = new System.Windows.Forms.TabPage();
            this.gbxListaClientes = new System.Windows.Forms.GroupBox();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.dgvClientesVip = new System.Windows.Forms.DataGridView();
            this.colCodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gbxClienteDados = new System.Windows.Forms.GroupBox();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblAtend = new System.Windows.Forms.Label();
            this.txbDataEntrega = new System.Windows.Forms.TextBox();
            this.cbxAtend = new System.Windows.Forms.ComboBox();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.txbNumeroDeDias = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNDia = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbHora = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txbSituacao = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.tbcCadastroEnvelope.SuspendLayout();
            this.tbpCadastroEnv.SuspendLayout();
            this.tbpDadosCliente.SuspendLayout();
            this.gbxListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesVip)).BeginInit();
            this.gbxClienteDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(219, 145);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(48, 38);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "+";
            this.toolTip1.SetToolTip(this.btnAdicionar, "Atalho: Enter\r\nAdiciona produto em tabela");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCortes);
            this.groupBox1.Controls.Add(this.cbxCortes);
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbTotal);
            this.groupBox1.Controls.Add(this.txbValorUnitario);
            this.groupBox1.Controls.Add(this.txbDescricao);
            this.groupBox1.Controls.Add(this.txbQuantidade);
            this.groupBox1.Controls.Add(this.txbIdProduto);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblCortes
            // 
            this.lblCortes.AutoSize = true;
            this.lblCortes.Location = new System.Drawing.Point(11, 145);
            this.lblCortes.Name = "lblCortes";
            this.lblCortes.Size = new System.Drawing.Size(37, 13);
            this.lblCortes.TabIndex = 9;
            this.lblCortes.Text = "Cortes";
            // 
            // cbxCortes
            // 
            this.cbxCortes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCortes.FormattingEnabled = true;
            this.cbxCortes.Items.AddRange(new object[] {
            "B.ADAP",
            "B.N.ADAP",
            "MARGEM",
            "FOS.ADAP",
            "FOS.N.ADAP"});
            this.cbxCortes.Location = new System.Drawing.Point(66, 142);
            this.cbxCortes.Name = "cbxCortes";
            this.cbxCortes.Size = new System.Drawing.Size(100, 21);
            this.cbxCortes.TabIndex = 10;
            // 
            // dgvProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescricao,
            this.colQnt,
            this.colValorUnit,
            this.colTotal,
            this.colCortes});
            this.dgvProdutos.Location = new System.Drawing.Point(285, 19);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(607, 164);
            this.dgvProdutos.TabIndex = 15;
            this.dgvProdutos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProdutos_MouseClick);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Visible = false;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "NomeProduto";
            this.colDescricao.HeaderText = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 150;
            // 
            // colQnt
            // 
            this.colQnt.DataPropertyName = "Qnt";
            this.colQnt.HeaderText = "Quantidade";
            this.colQnt.Name = "colQnt";
            this.colQnt.ReadOnly = true;
            // 
            // colValorUnit
            // 
            this.colValorUnit.DataPropertyName = "ValorUnit";
            this.colValorUnit.HeaderText = "Valor Unitario";
            this.colValorUnit.Name = "colValorUnit";
            this.colValorUnit.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colCortes
            // 
            this.colCortes.DataPropertyName = "Cortes";
            this.colCortes.HeaderText = "Cortes";
            this.colCortes.Name = "colCortes";
            this.colCortes.ReadOnly = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::SeBStudio.Properties.Resources.outline_search_lupa_find_512;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(172, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(27, 22);
            this.btnPesquisar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnPesquisar, "Esse botão realiza a pesquisa dos produtos no banco");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(898, 27);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(48, 39);
            this.btnRemover.TabIndex = 15;
            this.btnRemover.Text = "-";
            this.toolTip1.SetToolTip(this.btnRemover, "Atalho: Control + D \r\nRemove produto selecionado da tabela");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qnt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod";
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(66, 169);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 20);
            this.txbTotal.TabIndex = 12;
            // 
            // txbValorUnitario
            // 
            this.txbValorUnitario.Location = new System.Drawing.Point(66, 116);
            this.txbValorUnitario.Name = "txbValorUnitario";
            this.txbValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.txbValorUnitario.TabIndex = 8;
            this.txbValorUnitario.Validated += new System.EventHandler(this.txbValorUnitario_Validated);
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(66, 64);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.ReadOnly = true;
            this.txbDescricao.Size = new System.Drawing.Size(201, 20);
            this.txbDescricao.TabIndex = 4;
            this.txbDescricao.Validated += new System.EventHandler(this.txbDescricao_Validated);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txbQuantidade.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txbQuantidade.Location = new System.Drawing.Point(66, 90);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidade.TabIndex = 6;
            this.txbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantidade_KeyPress);
            this.txbQuantidade.Validated += new System.EventHandler(this.txbQuantidade_Validated);
            // 
            // txbIdProduto
            // 
            this.txbIdProduto.Location = new System.Drawing.Point(66, 38);
            this.txbIdProduto.Name = "txbIdProduto";
            this.txbIdProduto.Size = new System.Drawing.Size(100, 20);
            this.txbIdProduto.TabIndex = 2;
            this.txbIdProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIdProduto_KeyPress);
            this.txbIdProduto.Validated += new System.EventHandler(this.txbIdProduto_Validated);
            // 
            // btnProximo
            // 
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Location = new System.Drawing.Point(862, 427);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 29);
            this.btnProximo.TabIndex = 10;
            this.btnProximo.Text = "Próximo";
            this.toolTip1.SetToolTip(this.btnProximo, "Atalho: F12\r\nAbre próxima aba");
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // txbObservacao
            // 
            this.txbObservacao.Location = new System.Drawing.Point(97, 252);
            this.txbObservacao.Multiline = true;
            this.txbObservacao.Name = "txbObservacao";
            this.txbObservacao.Size = new System.Drawing.Size(351, 76);
            this.txbObservacao.TabIndex = 1;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(8, 252);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 0;
            this.lblObservacao.Text = "Observacao";
            // 
            // txbSinal
            // 
            this.txbSinal.Location = new System.Drawing.Point(668, 249);
            this.txbSinal.Name = "txbSinal";
            this.txbSinal.Size = new System.Drawing.Size(100, 20);
            this.txbSinal.TabIndex = 5;
            this.txbSinal.Validated += new System.EventHandler(this.txbSinal_Validated);
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(547, 249);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 3;
            this.txbValor.Validated += new System.EventHandler(this.txbValor_Validated);
            // 
            // txbTotalTudo
            // 
            this.txbTotalTudo.Location = new System.Drawing.Point(784, 249);
            this.txbTotalTudo.Name = "txbTotalTudo";
            this.txbTotalTudo.Size = new System.Drawing.Size(100, 20);
            this.txbTotalTudo.TabIndex = 7;
            this.txbTotalTudo.Validated += new System.EventHandler(this.txbTotalTudo_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sinal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(781, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total*";
            // 
            // tbcCadastroEnvelope
            // 
            this.tbcCadastroEnvelope.Controls.Add(this.tbpCadastroEnv);
            this.tbcCadastroEnvelope.Controls.Add(this.tbpDadosCliente);
            this.tbcCadastroEnvelope.Location = new System.Drawing.Point(12, 12);
            this.tbcCadastroEnvelope.Name = "tbcCadastroEnvelope";
            this.tbcCadastroEnvelope.SelectedIndex = 0;
            this.tbcCadastroEnvelope.Size = new System.Drawing.Size(966, 495);
            this.tbcCadastroEnvelope.TabIndex = 0;
            // 
            // tbpCadastroEnv
            // 
            this.tbpCadastroEnv.Controls.Add(this.txbOs);
            this.tbpCadastroEnv.Controls.Add(this.lblOs);
            this.tbpCadastroEnv.Controls.Add(this.btnCalcMetroQuad);
            this.tbpCadastroEnv.Controls.Add(this.btnCalculadora);
            this.tbpCadastroEnv.Controls.Add(this.groupBox1);
            this.tbpCadastroEnv.Controls.Add(this.label8);
            this.tbpCadastroEnv.Controls.Add(this.btnProximo);
            this.tbpCadastroEnv.Controls.Add(this.label7);
            this.tbpCadastroEnv.Controls.Add(this.txbObservacao);
            this.tbpCadastroEnv.Controls.Add(this.label6);
            this.tbpCadastroEnv.Controls.Add(this.lblObservacao);
            this.tbpCadastroEnv.Controls.Add(this.txbTotalTudo);
            this.tbpCadastroEnv.Controls.Add(this.txbSinal);
            this.tbpCadastroEnv.Controls.Add(this.txbValor);
            this.tbpCadastroEnv.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastroEnv.Name = "tbpCadastroEnv";
            this.tbpCadastroEnv.Size = new System.Drawing.Size(958, 469);
            this.tbpCadastroEnv.TabIndex = 0;
            this.tbpCadastroEnv.Text = "Cadastro Env";
            this.tbpCadastroEnv.UseVisualStyleBackColor = true;
            // 
            // txbOs
            // 
            this.txbOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOs.Location = new System.Drawing.Point(212, 420);
            this.txbOs.Name = "txbOs";
            this.txbOs.Size = new System.Drawing.Size(175, 26);
            this.txbOs.TabIndex = 12;
            // 
            // lblOs
            // 
            this.lblOs.AutoSize = true;
            this.lblOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOs.Location = new System.Drawing.Point(174, 421);
            this.lblOs.Name = "lblOs";
            this.lblOs.Size = new System.Drawing.Size(31, 20);
            this.lblOs.TabIndex = 11;
            this.lblOs.Text = "Os";
            // 
            // btnCalcMetroQuad
            // 
            this.btnCalcMetroQuad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcMetroQuad.Location = new System.Drawing.Point(97, 409);
            this.btnCalcMetroQuad.Name = "btnCalcMetroQuad";
            this.btnCalcMetroQuad.Size = new System.Drawing.Size(56, 47);
            this.btnCalcMetroQuad.TabIndex = 9;
            this.btnCalcMetroQuad.Text = "Calcular M²";
            this.toolTip1.SetToolTip(this.btnCalcMetroQuad, "Atalho: Control + M\r\nAbre tela de calculo de metro quadrado de banner, revelações" +
        " ou adesivos");
            this.btnCalcMetroQuad.UseVisualStyleBackColor = true;
            this.btnCalcMetroQuad.Click += new System.EventHandler(this.btnCalcMetroQuad_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackgroundImage = global::SeBStudio.Properties.Resources.calcuworld;
            this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Location = new System.Drawing.Point(20, 409);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(49, 47);
            this.btnCalculadora.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnCalculadora, "Atalho: Control + 1\r\nAbre a calculadora");
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // tbpDadosCliente
            // 
            this.tbpDadosCliente.Controls.Add(this.gbxListaClientes);
            this.tbpDadosCliente.Controls.Add(this.btnImprimir);
            this.tbpDadosCliente.Controls.Add(this.btnVoltar);
            this.tbpDadosCliente.Controls.Add(this.gbxClienteDados);
            this.tbpDadosCliente.Location = new System.Drawing.Point(4, 22);
            this.tbpDadosCliente.Name = "tbpDadosCliente";
            this.tbpDadosCliente.Size = new System.Drawing.Size(958, 469);
            this.tbpDadosCliente.TabIndex = 0;
            this.tbpDadosCliente.Text = "Dados Cliente";
            this.tbpDadosCliente.UseVisualStyleBackColor = true;
            // 
            // gbxListaClientes
            // 
            this.gbxListaClientes.Controls.Add(this.txbPesquisar);
            this.gbxListaClientes.Controls.Add(this.dgvClientesVip);
            this.gbxListaClientes.Location = new System.Drawing.Point(513, 21);
            this.gbxListaClientes.Name = "gbxListaClientes";
            this.gbxListaClientes.Size = new System.Drawing.Size(422, 389);
            this.gbxListaClientes.TabIndex = 1;
            this.gbxListaClientes.TabStop = false;
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(7, 23);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(378, 20);
            this.txbPesquisar.TabIndex = 0;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            // 
            // dgvClientesVip
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvClientesVip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientesVip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesVip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodCliente,
            this.colNomeCliente,
            this.colTelefone,
            this.colEmail,
            this.colTipoCliente});
            this.dgvClientesVip.Location = new System.Drawing.Point(7, 49);
            this.dgvClientesVip.Name = "dgvClientesVip";
            this.dgvClientesVip.ReadOnly = true;
            this.dgvClientesVip.Size = new System.Drawing.Size(409, 334);
            this.dgvClientesVip.TabIndex = 1;
            this.dgvClientesVip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientesVip_MouseClick);
            this.dgvClientesVip.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientesVip_MouseDoubleClick);
            // 
            // colCodCliente
            // 
            this.colCodCliente.DataPropertyName = "CodCliente";
            this.colCodCliente.HeaderText = "Codigo Cliente";
            this.colCodCliente.Name = "colCodCliente";
            this.colCodCliente.ReadOnly = true;
            this.colCodCliente.Visible = false;
            // 
            // colNomeCliente
            // 
            this.colNomeCliente.DataPropertyName = "NomeCliente";
            this.colNomeCliente.HeaderText = "Nome";
            this.colNomeCliente.Name = "colNomeCliente";
            this.colNomeCliente.ReadOnly = true;
            this.colNomeCliente.Width = 150;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "Telefone";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Visible = false;
            // 
            // colTipoCliente
            // 
            this.colTipoCliente.DataPropertyName = "TipoCliente";
            this.colTipoCliente.HeaderText = "Tipo Cliente";
            this.colTipoCliente.Name = "colTipoCliente";
            this.colTipoCliente.ReadOnly = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(776, 427);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 27);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.toolTip1.SetToolTip(this.btnImprimir, "Atalho: Control + P\r\nAbre tela de impressão de envelope + nota");
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(862, 427);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(80, 27);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.toolTip1.SetToolTip(this.btnVoltar, "Atalho: F11\r\nRetorna a aba anterior");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gbxClienteDados
            // 
            this.gbxClienteDados.Controls.Add(this.lblDataAtual);
            this.gbxClienteDados.Controls.Add(this.label9);
            this.gbxClienteDados.Controls.Add(this.cbxFormaPagamento);
            this.gbxClienteDados.Controls.Add(this.lblAtend);
            this.gbxClienteDados.Controls.Add(this.txbDataEntrega);
            this.gbxClienteDados.Controls.Add(this.cbxAtend);
            this.gbxClienteDados.Controls.Add(this.lblDataEntrega);
            this.gbxClienteDados.Controls.Add(this.txbNumeroDeDias);
            this.gbxClienteDados.Controls.Add(this.lblHora);
            this.gbxClienteDados.Controls.Add(this.lblNDia);
            this.gbxClienteDados.Controls.Add(this.txbTelefone);
            this.gbxClienteDados.Controls.Add(this.txbHora);
            this.gbxClienteDados.Controls.Add(this.lblTelefone);
            this.gbxClienteDados.Controls.Add(this.txbCliente);
            this.gbxClienteDados.Controls.Add(this.lblCliente);
            this.gbxClienteDados.Controls.Add(this.lblSituacao);
            this.gbxClienteDados.Controls.Add(this.txbSituacao);
            this.gbxClienteDados.Location = new System.Drawing.Point(15, 21);
            this.gbxClienteDados.Name = "gbxClienteDados";
            this.gbxClienteDados.Size = new System.Drawing.Size(492, 414);
            this.gbxClienteDados.TabIndex = 0;
            this.gbxClienteDados.TabStop = false;
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(10, 20);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(57, 13);
            this.lblDataAtual.TabIndex = 0;
            this.lblDataAtual.Text = "Data Atual";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Forma de Pagamento*";
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFormaPagamento.FormattingEnabled = true;
            this.cbxFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão",
            "A Receber"});
            this.cbxFormaPagamento.Location = new System.Drawing.Point(121, 384);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(134, 21);
            this.cbxFormaPagamento.TabIndex = 20;
            this.cbxFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbxFormaPagamento_SelectedIndexChanged);
            // 
            // lblAtend
            // 
            this.lblAtend.AutoSize = true;
            this.lblAtend.Location = new System.Drawing.Point(258, 324);
            this.lblAtend.Name = "lblAtend";
            this.lblAtend.Size = new System.Drawing.Size(39, 13);
            this.lblAtend.TabIndex = 15;
            this.lblAtend.Text = "Atend*";
            // 
            // txbDataEntrega
            // 
            this.txbDataEntrega.Location = new System.Drawing.Point(91, 93);
            this.txbDataEntrega.Name = "txbDataEntrega";
            this.txbDataEntrega.Size = new System.Drawing.Size(177, 20);
            this.txbDataEntrega.TabIndex = 2;
            // 
            // cbxAtend
            // 
            this.cbxAtend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAtend.FormattingEnabled = true;
            this.cbxAtend.Items.AddRange(new object[] {
            "Gustavo",
            "Deomar",
            "Tamires",
            "Flavio",
            "Natalia"});
            this.cbxAtend.Location = new System.Drawing.Point(261, 340);
            this.cbxAtend.Name = "cbxAtend";
            this.cbxAtend.Size = new System.Drawing.Size(120, 21);
            this.cbxAtend.TabIndex = 18;
            this.cbxAtend.SelectedIndexChanged += new System.EventHandler(this.cbxAtend_SelectedIndexChanged);
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(6, 96);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(71, 13);
            this.lblDataEntrega.TabIndex = 1;
            this.lblDataEntrega.Text = "DataEntrega*";
            // 
            // txbNumeroDeDias
            // 
            this.txbNumeroDeDias.Location = new System.Drawing.Point(135, 341);
            this.txbNumeroDeDias.Name = "txbNumeroDeDias";
            this.txbNumeroDeDias.Size = new System.Drawing.Size(120, 20);
            this.txbNumeroDeDias.TabIndex = 17;
            this.txbNumeroDeDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumeroDeDias_KeyPress);
            this.txbNumeroDeDias.Validated += new System.EventHandler(this.txbNumeroDeDias_Validated);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(6, 325);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(90, 13);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "Adicionar minutos";
            // 
            // lblNDia
            // 
            this.lblNDia.AutoSize = true;
            this.lblNDia.Location = new System.Drawing.Point(132, 325);
            this.lblNDia.Name = "lblNDia";
            this.lblNDia.Size = new System.Drawing.Size(73, 13);
            this.lblNDia.TabIndex = 14;
            this.lblNDia.Text = "Adicionar dias";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(91, 133);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(177, 20);
            this.txbTelefone.TabIndex = 6;
            this.txbTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelefone_KeyPress);
            // 
            // txbHora
            // 
            this.txbHora.Location = new System.Drawing.Point(9, 341);
            this.txbHora.Name = "txbHora";
            this.txbHora.Size = new System.Drawing.Size(120, 20);
            this.txbHora.TabIndex = 16;
            this.txbHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbHora_KeyPress);
            this.txbHora.Validated += new System.EventHandler(this.txbHora_Validated);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 136);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(53, 13);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone*";
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(91, 179);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(177, 20);
            this.txbCliente.TabIndex = 8;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 182);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(74, 13);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Nome Cliente*";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(10, 227);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 11;
            this.lblSituacao.Text = "Situacao";
            // 
            // txbSituacao
            // 
            this.txbSituacao.Location = new System.Drawing.Point(91, 224);
            this.txbSituacao.Name = "txbSituacao";
            this.txbSituacao.Size = new System.Drawing.Size(226, 20);
            this.txbSituacao.TabIndex = 12;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // frmEnvelope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(990, 514);
            this.Controls.Add(this.tbcCadastroEnvelope);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmEnvelope";
            this.Text = "Envelope";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEnvelope_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.tbcCadastroEnvelope.ResumeLayout(false);
            this.tbpCadastroEnv.ResumeLayout(false);
            this.tbpCadastroEnv.PerformLayout();
            this.tbpDadosCliente.ResumeLayout(false);
            this.gbxListaClientes.ResumeLayout(false);
            this.gbxListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesVip)).EndInit();
            this.gbxClienteDados.ResumeLayout(false);
            this.gbxClienteDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.TextBox txbValorUnitario;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbIdProduto;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txbObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txbSinal;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbTotalTudo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCortes;
        private System.Windows.Forms.ComboBox cbxCortes;
        private System.Windows.Forms.TabControl tbcCadastroEnvelope;
        private System.Windows.Forms.TabPage tbpCadastroEnv;
        private System.Windows.Forms.TabPage tbpDadosCliente;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gbxClienteDados;
        private System.Windows.Forms.TextBox txbNumeroDeDias;
        private System.Windows.Forms.ComboBox cbxAtend;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblAtend;
        private System.Windows.Forms.TextBox txbHora;
        private System.Windows.Forms.Label lblNDia;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbDataEntrega;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.GroupBox gbxListaClientes;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.DataGridView dgvClientesVip;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnCalcMetroQuad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxFormaPagamento;
        private System.Windows.Forms.TextBox txbOs;
        private System.Windows.Forms.Label lblOs;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCortes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txbSituacao;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


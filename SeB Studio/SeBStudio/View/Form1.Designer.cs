namespace WindowsFormsApp2
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txbSinal = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbTotalTudo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxCortes = new System.Windows.Forms.ComboBox();
            this.lblCortes = new System.Windows.Forms.Label();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCortes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(219, 145);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(48, 38);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "+";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescricao,
            this.colQnt,
            this.colValorUnit,
            this.colCortes,
            this.colTotal});
            this.dgvProdutos.Location = new System.Drawing.Point(285, 19);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(607, 164);
            this.dgvProdutos.TabIndex = 14;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            this.dgvProdutos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProdutos_MouseClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(172, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(48, 22);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "+";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(898, 19);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(48, 39);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "-";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qnt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cod";
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(66, 169);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 20);
            this.txbTotal.TabIndex = 5;
            // 
            // txbValorUnitario
            // 
            this.txbValorUnitario.Location = new System.Drawing.Point(66, 116);
            this.txbValorUnitario.Name = "txbValorUnitario";
            this.txbValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.txbValorUnitario.TabIndex = 4;
            this.txbValorUnitario.TextChanged += new System.EventHandler(this.txbValorUnitario_TextChanged);
            this.txbValorUnitario.Validated += new System.EventHandler(this.txbValorUnitario_Validated);
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(66, 90);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.ReadOnly = true;
            this.txbDescricao.Size = new System.Drawing.Size(201, 20);
            this.txbDescricao.TabIndex = 3;
            this.txbDescricao.Validated += new System.EventHandler(this.txbDescricao_Validated);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(66, 64);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidade.TabIndex = 2;
            this.txbQuantidade.Validated += new System.EventHandler(this.txbQuantidade_Validated);
            // 
            // txbIdProduto
            // 
            this.txbIdProduto.Location = new System.Drawing.Point(66, 38);
            this.txbIdProduto.Name = "txbIdProduto";
            this.txbIdProduto.Size = new System.Drawing.Size(100, 20);
            this.txbIdProduto.TabIndex = 1;
            this.txbIdProduto.Validated += new System.EventHandler(this.txbIdProduto_Validated);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(889, 397);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 29);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Próximo";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txbObservacao
            // 
            this.txbObservacao.Location = new System.Drawing.Point(100, 276);
            this.txbObservacao.Multiline = true;
            this.txbObservacao.Name = "txbObservacao";
            this.txbObservacao.Size = new System.Drawing.Size(351, 76);
            this.txbObservacao.TabIndex = 3;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(14, 279);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 4;
            this.lblObservacao.Text = "Observacao";
            // 
            // txbSinal
            // 
            this.txbSinal.Location = new System.Drawing.Point(674, 276);
            this.txbSinal.Name = "txbSinal";
            this.txbSinal.Size = new System.Drawing.Size(100, 20);
            this.txbSinal.TabIndex = 5;
            this.txbSinal.Validated += new System.EventHandler(this.txbSinal_Validated);
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(553, 276);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 6;
            this.txbValor.Validated += new System.EventHandler(this.txbValor_Validated);
            // 
            // txbTotalTudo
            // 
            this.txbTotalTudo.Location = new System.Drawing.Point(790, 276);
            this.txbTotalTudo.Name = "txbTotalTudo";
            this.txbTotalTudo.Size = new System.Drawing.Size(100, 20);
            this.txbTotalTudo.TabIndex = 7;
            this.txbTotalTudo.TextChanged += new System.EventHandler(this.txbTotalTudo_TextChanged);
            this.txbTotalTudo.Validated += new System.EventHandler(this.txbTotalTudo_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(671, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sinal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(787, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total";
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
            this.cbxCortes.TabIndex = 15;
            // 
            // lblCortes
            // 
            this.lblCortes.AutoSize = true;
            this.lblCortes.Location = new System.Drawing.Point(11, 145);
            this.lblCortes.Name = "lblCortes";
            this.lblCortes.Size = new System.Drawing.Size(37, 13);
            this.lblCortes.TabIndex = 16;
            this.lblCortes.Text = "Cortes";
            this.lblCortes.Click += new System.EventHandler(this.label9_Click);
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "Codigo";
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = false;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.HeaderText = "Descricao";
            this.colDescricao.Name = "colDescricao";
            // 
            // colQnt
            // 
            this.colQnt.DataPropertyName = "Qnt";
            this.colQnt.HeaderText = "Quantidade";
            this.colQnt.Name = "colQnt";
            // 
            // colValorUnit
            // 
            this.colValorUnit.DataPropertyName = "ValorUnit";
            this.colValorUnit.HeaderText = "Valor Unitario";
            this.colValorUnit.Name = "colValorUnit";
            // 
            // colCortes
            // 
            this.colCortes.DataPropertyName = "Cortes";
            this.colCortes.HeaderText = "Cortes";
            this.colCortes.Name = "colCortes";
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // frmEnvelope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(990, 438);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbTotalTudo);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.txbSinal);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txbObservacao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEnvelope";
            this.Text = "Envelope";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnCadastrar;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCortes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}


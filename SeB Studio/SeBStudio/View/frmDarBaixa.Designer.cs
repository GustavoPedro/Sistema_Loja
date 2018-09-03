namespace SeBStudio.View
{
    partial class frmDarBaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDarBaixa));
            this.dgvBaixa = new System.Windows.Forms.DataGridView();
            this.btnDarBaixa = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbrId = new System.Windows.Forms.RadioButton();
            this.rbrNome = new System.Windows.Forms.RadioButton();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.colIdEnvelope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaixa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaixa
            // 
            this.dgvBaixa.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvBaixa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdEnvelope,
            this.colObservacao,
            this.colPreco,
            this.colSinal,
            this.colIdCliente,
            this.colNome,
            this.colTelefone,
            this.colDataEntrada,
            this.colDataEntrega,
            this.colAtend,
            this.colFormaPagamento,
            this.colTotal,
            this.colBaixa});
            this.dgvBaixa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBaixa.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBaixa.Location = new System.Drawing.Point(23, 90);
            this.dgvBaixa.Name = "dgvBaixa";
            this.dgvBaixa.ReadOnly = true;
            this.dgvBaixa.Size = new System.Drawing.Size(842, 355);
            this.dgvBaixa.TabIndex = 4;
            this.dgvBaixa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBaixa_MouseClick);
            // 
            // btnDarBaixa
            // 
            this.btnDarBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBaixa.Location = new System.Drawing.Point(871, 90);
            this.btnDarBaixa.Name = "btnDarBaixa";
            this.btnDarBaixa.Size = new System.Drawing.Size(75, 23);
            this.btnDarBaixa.TabIndex = 5;
            this.btnDarBaixa.Text = "Dar Baixa";
            this.toolTip1.SetToolTip(this.btnDarBaixa, "Atalho: Enter \r\nRealiza a baixa no envelope selecionado.");
            this.btnDarBaixa.UseVisualStyleBackColor = true;
            this.btnDarBaixa.Click += new System.EventHandler(this.btnDarBaixa_Click);
            this.btnDarBaixa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDarBaixa_KeyDown);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(790, 467);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Location = new System.Drawing.Point(628, 467);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(23, 25);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(744, 20);
            this.txbPesquisar.TabIndex = 1;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            this.txbPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPesquisar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // rbrId
            // 
            this.rbrId.AutoSize = true;
            this.rbrId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbrId.Location = new System.Drawing.Point(23, 52);
            this.rbrId.Name = "rbrId";
            this.rbrId.Size = new System.Drawing.Size(33, 17);
            this.rbrId.TabIndex = 2;
            this.rbrId.TabStop = true;
            this.rbrId.Text = "Id";
            this.rbrId.UseVisualStyleBackColor = true;
            // 
            // rbrNome
            // 
            this.rbrNome.AutoSize = true;
            this.rbrNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbrNome.Location = new System.Drawing.Point(62, 51);
            this.rbrNome.Name = "rbrNome";
            this.rbrNome.Size = new System.Drawing.Size(52, 17);
            this.rbrNome.TabIndex = 3;
            this.rbrNome.TabStop = true;
            this.rbrNome.Text = "Nome";
            this.rbrNome.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(709, 467);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(872, 151);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // colIdEnvelope
            // 
            this.colIdEnvelope.DataPropertyName = "IdEnvelope";
            this.colIdEnvelope.Frozen = true;
            this.colIdEnvelope.HeaderText = "OS";
            this.colIdEnvelope.Name = "colIdEnvelope";
            this.colIdEnvelope.ReadOnly = true;
            // 
            // colObservacao
            // 
            this.colObservacao.DataPropertyName = "Observacao";
            this.colObservacao.HeaderText = "Observação";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.ReadOnly = true;
            this.colObservacao.Visible = false;
            // 
            // colPreco
            // 
            this.colPreco.DataPropertyName = "Preco";
            this.colPreco.HeaderText = "Preço";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            this.colPreco.Visible = false;
            // 
            // colSinal
            // 
            this.colSinal.DataPropertyName = "Sinal";
            this.colSinal.HeaderText = "Sinal";
            this.colSinal.Name = "colSinal";
            this.colSinal.ReadOnly = true;
            this.colSinal.Visible = false;
            // 
            // colIdCliente
            // 
            this.colIdCliente.DataPropertyName = "IdCliente";
            this.colIdCliente.HeaderText = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.ReadOnly = true;
            this.colIdCliente.Visible = false;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.Frozen = true;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "Telefone";
            this.colTelefone.Frozen = true;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colDataEntrada
            // 
            this.colDataEntrada.DataPropertyName = "DataEntrada";
            this.colDataEntrada.Frozen = true;
            this.colDataEntrada.HeaderText = "Data Entrada";
            this.colDataEntrada.Name = "colDataEntrada";
            this.colDataEntrada.ReadOnly = true;
            // 
            // colDataEntrega
            // 
            this.colDataEntrega.DataPropertyName = "DataEntrega";
            this.colDataEntrega.Frozen = true;
            this.colDataEntrega.HeaderText = "Data Entrega";
            this.colDataEntrega.Name = "colDataEntrega";
            this.colDataEntrega.ReadOnly = true;
            // 
            // colAtend
            // 
            this.colAtend.DataPropertyName = "Atend";
            this.colAtend.Frozen = true;
            this.colAtend.HeaderText = "Atendente";
            this.colAtend.Name = "colAtend";
            this.colAtend.ReadOnly = true;
            // 
            // colFormaPagamento
            // 
            this.colFormaPagamento.DataPropertyName = "FormaPagamento";
            this.colFormaPagamento.HeaderText = "Forma de Pagamento";
            this.colFormaPagamento.Name = "colFormaPagamento";
            this.colFormaPagamento.ReadOnly = true;
            this.colFormaPagamento.Visible = false;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.Frozen = true;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colBaixa
            // 
            this.colBaixa.DataPropertyName = "Baixa";
            this.colBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colBaixa.Frozen = true;
            this.colBaixa.HeaderText = "Baixa";
            this.colBaixa.Name = "colBaixa";
            this.colBaixa.ReadOnly = true;
            this.colBaixa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBaixa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmDarBaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(962, 502);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.rbrNome);
            this.Controls.Add(this.rbrId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnDarBaixa);
            this.Controls.Add(this.dgvBaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDarBaixa";
            this.Text = "Pesquisar Envelopes";
            this.Load += new System.EventHandler(this.frmDarBaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaixa;
        private System.Windows.Forms.Button btnDarBaixa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbrId;
        private System.Windows.Forms.RadioButton rbrNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEnvelope;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtend;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colBaixa;
    }
}
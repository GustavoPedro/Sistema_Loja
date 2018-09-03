namespace SeBStudio.View
{
    partial class frmCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarProduto));
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbValorUnit = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvProdutosCadastrados = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarNoGrid = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descricao";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Location = new System.Drawing.Point(12, 117);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(70, 13);
            this.lblValorUnit.TabIndex = 5;
            this.lblValorUnit.Text = "Valor Unitário";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(16, 94);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(100, 20);
            this.txbDescricao.TabIndex = 4;
            // 
            // txbValorUnit
            // 
            this.txbValorUnit.Location = new System.Drawing.Point(16, 133);
            this.txbValorUnit.Name = "txbValorUnit";
            this.txbValorUnit.Size = new System.Drawing.Size(100, 20);
            this.txbValorUnit.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(440, 213);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.btnCadastrar, "Atalho: Control + P");
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvProdutosCadastrados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvProdutosCadastrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDescricao,
            this.colValorUnit});
            this.dgvProdutosCadastrados.Location = new System.Drawing.Point(134, 39);
            this.dgvProdutosCadastrados.Name = "dgvProdutosCadastrados";
            this.dgvProdutosCadastrados.ReadOnly = true;
            this.dgvProdutosCadastrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosCadastrados.Size = new System.Drawing.Size(342, 151);
            this.dgvProdutosCadastrados.TabIndex = 8;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "idProduto";
            this.colId.HeaderText = "Codigo Produto";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "nomeProduto";
            this.colDescricao.HeaderText = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colValorUnit
            // 
            this.colValorUnit.DataPropertyName = "ValorUnit";
            this.colValorUnit.HeaderText = "Valor Unitário";
            this.colValorUnit.Name = "colValorUnit";
            this.colValorUnit.ReadOnly = true;
            // 
            // btnAdicionarNoGrid
            // 
            this.btnAdicionarNoGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarNoGrid.Location = new System.Drawing.Point(77, 159);
            this.btnAdicionarNoGrid.Name = "btnAdicionarNoGrid";
            this.btnAdicionarNoGrid.Size = new System.Drawing.Size(39, 27);
            this.btnAdicionarNoGrid.TabIndex = 7;
            this.btnAdicionarNoGrid.Text = "+";
            this.toolTip1.SetToolTip(this.btnAdicionarNoGrid, "Atalho: Enter");
            this.btnAdicionarNoGrid.UseVisualStyleBackColor = true;
            this.btnAdicionarNoGrid.Click += new System.EventHandler(this.btnAdicionarNoGrid_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(16, 55);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 2;
            this.txbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(359, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(482, 39);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(39, 27);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "-";
            this.toolTip1.SetToolTip(this.btnRemover, "Atalho: Control + D");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(278, 213);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(527, 248);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnAdicionarNoGrid);
            this.Controls.Add(this.dgvProdutosCadastrados);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbValorUnit);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.lblValorUnit);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCadastrarProduto";
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.frmCadastrarProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastrarProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorUnit;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbValorUnit;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvProdutosCadastrados;
        private System.Windows.Forms.Button btnAdicionarNoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnPesquisar;
    }
}
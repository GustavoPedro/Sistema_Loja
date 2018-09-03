namespace SeBStudio.View
{
    partial class frmPesquisarProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarProduto));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbrPorId = new System.Windows.Forms.RadioButton();
            this.rbrPorNome = new System.Windows.Forms.RadioButton();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNomeProduto,
            this.colValorUnit});
            this.dgvProdutos.Location = new System.Drawing.Point(12, 102);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(643, 377);
            this.dgvProdutos.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(580, 485);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(499, 485);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Location = new System.Drawing.Point(418, 485);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(12, 35);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(643, 20);
            this.txbPesquisar.TabIndex = 1;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            this.txbPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPesquisar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // rbrPorId
            // 
            this.rbrPorId.AutoSize = true;
            this.rbrPorId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbrPorId.Location = new System.Drawing.Point(13, 79);
            this.rbrPorId.Name = "rbrPorId";
            this.rbrPorId.Size = new System.Drawing.Size(33, 17);
            this.rbrPorId.TabIndex = 2;
            this.rbrPorId.TabStop = true;
            this.rbrPorId.Text = "Id";
            this.rbrPorId.UseVisualStyleBackColor = true;
            // 
            // rbrPorNome
            // 
            this.rbrPorNome.AutoSize = true;
            this.rbrPorNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbrPorNome.Location = new System.Drawing.Point(52, 79);
            this.rbrPorNome.Name = "rbrPorNome";
            this.rbrPorNome.Size = new System.Drawing.Size(52, 17);
            this.rbrPorNome.TabIndex = 3;
            this.rbrPorNome.TabStop = true;
            this.rbrPorNome.Text = "Nome";
            this.rbrPorNome.UseVisualStyleBackColor = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "idProduto";
            this.colId.HeaderText = "Código";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.DataPropertyName = "nomeProduto";
            this.colNomeProduto.HeaderText = "Descrição";
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.ReadOnly = true;
            this.colNomeProduto.Width = 300;
            // 
            // colValorUnit
            // 
            this.colValorUnit.DataPropertyName = "valorUnit";
            this.colValorUnit.HeaderText = "Valor Unitário";
            this.colValorUnit.Name = "colValorUnit";
            this.colValorUnit.ReadOnly = true;
            this.colValorUnit.Width = 200;
            // 
            // frmPesquisarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(687, 520);
            this.Controls.Add(this.rbrPorNome);
            this.Controls.Add(this.rbrPorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisarProduto";
            this.Text = "Pesquisar Produtos";
            this.Load += new System.EventHandler(this.frmPesquisarProduto_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmPesquisarProduto_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbrPorId;
        private System.Windows.Forms.RadioButton rbrPorNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
    }
}
namespace SeBStudio.View
{
    partial class frmListaProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaProdutos));
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.rbrSelecionaPorNome = new System.Windows.Forms.RadioButton();
            this.rbrSelecionaPorId = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.colIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(426, 399);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvProdutos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProduto,
            this.colDescricao,
            this.colValorUnit});
            this.dgvProdutos.Location = new System.Drawing.Point(12, 107);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(488, 286);
            this.dgvProdutos.TabIndex = 3;
            this.dgvProdutos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProdutos_MouseClick);
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(12, 38);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(454, 20);
            this.txbPesquisar.TabIndex = 0;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            this.txbPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPesquisar_KeyPress);
            // 
            // rbrSelecionaPorNome
            // 
            this.rbrSelecionaPorNome.AutoSize = true;
            this.rbrSelecionaPorNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbrSelecionaPorNome.Location = new System.Drawing.Point(12, 84);
            this.rbrSelecionaPorNome.Name = "rbrSelecionaPorNome";
            this.rbrSelecionaPorNome.Size = new System.Drawing.Size(52, 17);
            this.rbrSelecionaPorNome.TabIndex = 1;
            this.rbrSelecionaPorNome.TabStop = true;
            this.rbrSelecionaPorNome.Text = "Nome";
            this.rbrSelecionaPorNome.UseVisualStyleBackColor = true;
            // 
            // rbrSelecionaPorId
            // 
            this.rbrSelecionaPorId.AutoSize = true;
            this.rbrSelecionaPorId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbrSelecionaPorId.Location = new System.Drawing.Point(70, 84);
            this.rbrSelecionaPorId.Name = "rbrSelecionaPorId";
            this.rbrSelecionaPorId.Size = new System.Drawing.Size(33, 17);
            this.rbrSelecionaPorId.TabIndex = 2;
            this.rbrSelecionaPorId.TabStop = true;
            this.rbrSelecionaPorId.Text = "Id";
            this.rbrSelecionaPorId.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar";
            // 
            // colIdProduto
            // 
            this.colIdProduto.DataPropertyName = "idProduto";
            this.colIdProduto.HeaderText = "Código";
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "nomeProduto";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 180;
            // 
            // colValorUnit
            // 
            this.colValorUnit.DataPropertyName = "valorUnit";
            this.colValorUnit.HeaderText = "Valor Unitario";
            this.colValorUnit.Name = "colValorUnit";
            this.colValorUnit.ReadOnly = true;
            this.colValorUnit.Width = 150;
            // 
            // frmListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(513, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbrSelecionaPorId);
            this.Controls.Add(this.rbrSelecionaPorNome);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmListaProdutos";
            this.Text = "Pesquisar produtos";
            this.Load += new System.EventHandler(this.frmListaProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmListaProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvProdutos;
        
        
        
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.RadioButton rbrSelecionaPorNome;
        private System.Windows.Forms.RadioButton rbrSelecionaPorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnit;
    }
}
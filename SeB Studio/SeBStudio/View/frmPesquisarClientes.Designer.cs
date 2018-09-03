namespace SeBStudio.View
{
    partial class frmPesquisarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.rbrTodos = new System.Windows.Forms.RadioButton();
            this.rbrSomenteVip = new System.Windows.Forms.RadioButton();
            this.rbrSomentePro = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbrPorNome = new System.Windows.Forms.RadioButton();
            this.rbrPorTelefone = new System.Windows.Forms.RadioButton();
            this.colIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCliente,
            this.colNome,
            this.colTelefone,
            this.colEmail,
            this.colTipoCliente});
            this.dgvClientes.Location = new System.Drawing.Point(12, 102);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(626, 338);
            this.dgvClientes.TabIndex = 4;
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(12, 54);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(626, 20);
            this.txbPesquisar.TabIndex = 1;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            this.txbPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPesquisar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(563, 463);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(481, 463);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Location = new System.Drawing.Point(400, 463);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // rbrTodos
            // 
            this.rbrTodos.AutoSize = true;
            this.rbrTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbrTodos.Location = new System.Drawing.Point(6, 23);
            this.rbrTodos.Name = "rbrTodos";
            this.rbrTodos.Size = new System.Drawing.Size(57, 17);
            this.rbrTodos.TabIndex = 0;
            this.rbrTodos.TabStop = true;
            this.rbrTodos.Text = "Todos ";
            this.rbrTodos.UseVisualStyleBackColor = true;
            this.rbrTodos.CheckedChanged += new System.EventHandler(this.rbrTodos_CheckedChanged);
            // 
            // rbrSomenteVip
            // 
            this.rbrSomenteVip.AutoSize = true;
            this.rbrSomenteVip.Location = new System.Drawing.Point(69, 23);
            this.rbrSomenteVip.Name = "rbrSomenteVip";
            this.rbrSomenteVip.Size = new System.Drawing.Size(85, 17);
            this.rbrSomenteVip.TabIndex = 1;
            this.rbrSomenteVip.TabStop = true;
            this.rbrSomenteVip.Text = "Somente Vip";
            this.rbrSomenteVip.UseVisualStyleBackColor = true;
            this.rbrSomenteVip.CheckedChanged += new System.EventHandler(this.rbrSomenteVip_CheckedChanged);
            // 
            // rbrSomentePro
            // 
            this.rbrSomentePro.AutoSize = true;
            this.rbrSomentePro.Location = new System.Drawing.Point(160, 23);
            this.rbrSomentePro.Name = "rbrSomentePro";
            this.rbrSomentePro.Size = new System.Drawing.Size(86, 17);
            this.rbrSomentePro.TabIndex = 2;
            this.rbrSomentePro.TabStop = true;
            this.rbrSomentePro.Text = "Somente Pro";
            this.rbrSomentePro.UseVisualStyleBackColor = true;
            this.rbrSomentePro.CheckedChanged += new System.EventHandler(this.rbrSomentePro_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbrSomentePro);
            this.groupBox1.Controls.Add(this.rbrTodos);
            this.groupBox1.Controls.Add(this.rbrSomenteVip);
            this.groupBox1.Location = new System.Drawing.Point(12, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbrPorNome
            // 
            this.rbrPorNome.AutoSize = true;
            this.rbrPorNome.Location = new System.Drawing.Point(13, 79);
            this.rbrPorNome.Name = "rbrPorNome";
            this.rbrPorNome.Size = new System.Drawing.Size(53, 17);
            this.rbrPorNome.TabIndex = 2;
            this.rbrPorNome.TabStop = true;
            this.rbrPorNome.Text = "Nome";
            this.rbrPorNome.UseVisualStyleBackColor = true;
            // 
            // rbrPorTelefone
            // 
            this.rbrPorTelefone.AutoSize = true;
            this.rbrPorTelefone.Location = new System.Drawing.Point(72, 79);
            this.rbrPorTelefone.Name = "rbrPorTelefone";
            this.rbrPorTelefone.Size = new System.Drawing.Size(67, 17);
            this.rbrPorTelefone.TabIndex = 3;
            this.rbrPorTelefone.TabStop = true;
            this.rbrPorTelefone.Text = "Telefone";
            this.rbrPorTelefone.UseVisualStyleBackColor = true;
            // 
            // colIdCliente
            // 
            this.colIdCliente.DataPropertyName = "CodCliente";
            this.colIdCliente.HeaderText = "Código Cliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.ReadOnly = true;
            this.colIdCliente.Visible = false;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "NomeCliente";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 180;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "Telefone";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Width = 120;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 180;
            // 
            // colTipoCliente
            // 
            this.colTipoCliente.DataPropertyName = "TipoCliente";
            this.colTipoCliente.HeaderText = "Tipo Cliente";
            this.colTipoCliente.Name = "colTipoCliente";
            this.colTipoCliente.ReadOnly = true;
            // 
            // frmPesquisarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(675, 520);
            this.Controls.Add(this.rbrPorTelefone);
            this.Controls.Add(this.rbrPorNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisarClientes";
            this.Text = "Pesquisar Clientes";
            this.Load += new System.EventHandler(this.frmPesquisarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.RadioButton rbrTodos;
        private System.Windows.Forms.RadioButton rbrSomenteVip;
        private System.Windows.Forms.RadioButton rbrSomentePro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbrPorNome;
        private System.Windows.Forms.RadioButton rbrPorTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCliente;
    }
}
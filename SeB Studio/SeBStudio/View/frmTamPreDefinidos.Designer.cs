
namespace SeBStudio.View
{
    partial class frmTamPreDefinidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTamPreDefinidos));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.gbxTamanhosPreDefinidos = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTamanhos = new System.Windows.Forms.ComboBox();
            this.txbLargura = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbValorPreDefinido = new System.Windows.Forms.TextBox();
            this.lblValorPreDefinido = new System.Windows.Forms.Label();
            this.lblNomeExibido = new System.Windows.Forms.Label();
            this.txbNomeExibido = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxTamanhosPreDefinidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(216, 269);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Inserir";
            this.toolTip1.SetToolTip(this.btnSalvar, "Atalho: Enter\r\nCadastra Tamanho Pré definido ");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSalvar_KeyDown);
            // 
            // btnConcluir
            // 
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Location = new System.Drawing.Point(307, 360);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(75, 23);
            this.btnConcluir.TabIndex = 8;
            this.btnConcluir.Text = "Fechar";
            this.toolTip1.SetToolTip(this.btnConcluir, "Atalho: Control + W");
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // gbxTamanhosPreDefinidos
            // 
            this.gbxTamanhosPreDefinidos.Controls.Add(this.btnAlterar);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.btnExcluir);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.btnSalvar);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.label3);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.cbxTamanhos);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.txbLargura);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.txbAltura);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.label6);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.lblAltura);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.txbValorPreDefinido);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.lblValorPreDefinido);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.lblNomeExibido);
            this.gbxTamanhosPreDefinidos.Controls.Add(this.txbNomeExibido);
            this.gbxTamanhosPreDefinidos.Location = new System.Drawing.Point(12, 31);
            this.gbxTamanhosPreDefinidos.Name = "gbxTamanhosPreDefinidos";
            this.gbxTamanhosPreDefinidos.Size = new System.Drawing.Size(370, 323);
            this.gbxTamanhosPreDefinidos.TabIndex = 1;
            this.gbxTamanhosPreDefinidos.TabStop = false;
            this.gbxTamanhosPreDefinidos.Text = "Tamanhos Pré definidos";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(216, 217);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btnAlterar, "Altera Tamanho selecionado na caixa\r\n");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(216, 166);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.toolTip1.SetToolTip(this.btnExcluir, "Atalho: Control + D\r\nExclui item selecionado na Lista de Tamanhos");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(159, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tamanhos Cadastrados";
            // 
            // cbxTamanhos
            // 
            this.cbxTamanhos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTamanhos.FormattingEnabled = true;
            this.cbxTamanhos.Location = new System.Drawing.Point(161, 62);
            this.cbxTamanhos.Name = "cbxTamanhos";
            this.cbxTamanhos.Size = new System.Drawing.Size(117, 21);
            this.cbxTamanhos.TabIndex = 9;
            this.cbxTamanhos.SelectedIndexChanged += new System.EventHandler(this.cbxTamanhos_SelectedIndexChanged);
            // 
            // txbLargura
            // 
            this.txbLargura.Location = new System.Drawing.Point(13, 254);
            this.txbLargura.Name = "txbLargura";
            this.txbLargura.Size = new System.Drawing.Size(78, 20);
            this.txbLargura.TabIndex = 7;
            this.txbLargura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLargura_KeyPress);
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(13, 192);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(78, 20);
            this.txbAltura.TabIndex = 5;
            this.txbAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAltura_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Largura";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(10, 166);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura";
            // 
            // txbValorPreDefinido
            // 
            this.txbValorPreDefinido.Location = new System.Drawing.Point(10, 128);
            this.txbValorPreDefinido.Name = "txbValorPreDefinido";
            this.txbValorPreDefinido.Size = new System.Drawing.Size(117, 20);
            this.txbValorPreDefinido.TabIndex = 3;
            // 
            // lblValorPreDefinido
            // 
            this.lblValorPreDefinido.AutoSize = true;
            this.lblValorPreDefinido.Location = new System.Drawing.Point(10, 101);
            this.lblValorPreDefinido.Name = "lblValorPreDefinido";
            this.lblValorPreDefinido.Size = new System.Drawing.Size(93, 13);
            this.lblValorPreDefinido.TabIndex = 2;
            this.lblValorPreDefinido.Text = "Valor Pré definido ";
            // 
            // lblNomeExibido
            // 
            this.lblNomeExibido.AutoSize = true;
            this.lblNomeExibido.Location = new System.Drawing.Point(7, 46);
            this.lblNomeExibido.Name = "lblNomeExibido";
            this.lblNomeExibido.Size = new System.Drawing.Size(133, 13);
            this.lblNomeExibido.TabIndex = 1;
            this.lblNomeExibido.Text = "Nome Exibido nas opções:";
            // 
            // txbNomeExibido
            // 
            this.txbNomeExibido.Location = new System.Drawing.Point(6, 65);
            this.txbNomeExibido.Name = "txbNomeExibido";
            this.txbNomeExibido.Size = new System.Drawing.Size(121, 20);
            this.txbNomeExibido.TabIndex = 0;
            // 
            // frmTamPreDefinidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(433, 400);
            this.Controls.Add(this.gbxTamanhosPreDefinidos);
            this.Controls.Add(this.btnConcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTamPreDefinidos";
            this.Text = "Tamanhos pré-definidos";
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            this.gbxTamanhosPreDefinidos.ResumeLayout(false);
            this.gbxTamanhosPreDefinidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.GroupBox gbxTamanhosPreDefinidos;
        private System.Windows.Forms.TextBox txbLargura;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txbValorPreDefinido;
        private System.Windows.Forms.Label lblValorPreDefinido;
        private System.Windows.Forms.Label lblNomeExibido;
        private System.Windows.Forms.TextBox txbNomeExibido;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTamanhos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
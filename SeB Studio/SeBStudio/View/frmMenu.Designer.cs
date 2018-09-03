namespace SeBStudio.View
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.mdiMenu = new System.Windows.Forms.MenuStrip();
            this.tsmEnvelope = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEnvelopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarEnvelopesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PesquisarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfiguracoesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tamanhosPréDefinidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envelopesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdiMenu
            // 
            this.mdiMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEnvelope,
            this.tsmProduto,
            this.tsmCliente,
            this.ConfiguracoesToolStrip,
            this.weTransferToolStripMenuItem});
            this.mdiMenu.Location = new System.Drawing.Point(0, 0);
            this.mdiMenu.Name = "mdiMenu";
            this.mdiMenu.Size = new System.Drawing.Size(1215, 24);
            this.mdiMenu.TabIndex = 0;
            this.mdiMenu.Text = "menuStrip1";
            // 
            // tsmEnvelope
            // 
            this.tsmEnvelope.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEnvelopeToolStripMenuItem,
            this.pesquisarEnvelopesToolStripMenuItem,
            this.calculoMToolStripMenuItem});
            this.tsmEnvelope.Image = ((System.Drawing.Image)(resources.GetObject("tsmEnvelope.Image")));
            this.tsmEnvelope.Name = "tsmEnvelope";
            this.tsmEnvelope.Size = new System.Drawing.Size(83, 20);
            this.tsmEnvelope.Text = "Envelope";
            // 
            // cadastrarEnvelopeToolStripMenuItem
            // 
            this.cadastrarEnvelopeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarEnvelopeToolStripMenuItem.Image")));
            this.cadastrarEnvelopeToolStripMenuItem.Name = "cadastrarEnvelopeToolStripMenuItem";
            this.cadastrarEnvelopeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cadastrarEnvelopeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cadastrarEnvelopeToolStripMenuItem.Text = "Cadastrar Envelope  ";
            this.cadastrarEnvelopeToolStripMenuItem.Click += new System.EventHandler(this.cadastrarEnvelopeToolStripMenuItem_Click);
            // 
            // pesquisarEnvelopesToolStripMenuItem
            // 
            this.pesquisarEnvelopesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pesquisarEnvelopesToolStripMenuItem.Image")));
            this.pesquisarEnvelopesToolStripMenuItem.Name = "pesquisarEnvelopesToolStripMenuItem";
            this.pesquisarEnvelopesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.pesquisarEnvelopesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.pesquisarEnvelopesToolStripMenuItem.Text = "Pesquisar Envelopes";
            this.pesquisarEnvelopesToolStripMenuItem.Click += new System.EventHandler(this.pesquisarEnvelopesToolStripMenuItem_Click);
            // 
            // calculoMToolStripMenuItem
            // 
            this.calculoMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculoMToolStripMenuItem.Image")));
            this.calculoMToolStripMenuItem.Name = "calculoMToolStripMenuItem";
            this.calculoMToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.calculoMToolStripMenuItem.Text = "Calculo M²";
            this.calculoMToolStripMenuItem.Click += new System.EventHandler(this.calculoMToolStripMenuItem_Click);
            // 
            // tsmProduto
            // 
            this.tsmProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem,
            this.PesquisarProdutos});
            this.tsmProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsmProduto.Image")));
            this.tsmProduto.Name = "tsmProduto";
            this.tsmProduto.Size = new System.Drawing.Size(78, 20);
            this.tsmProduto.Text = "Produto";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarProdutoToolStripMenuItem.Image")));
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // PesquisarProdutos
            // 
            this.PesquisarProdutos.Image = ((System.Drawing.Image)(resources.GetObject("PesquisarProdutos.Image")));
            this.PesquisarProdutos.Name = "PesquisarProdutos";
            this.PesquisarProdutos.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.PesquisarProdutos.Size = new System.Drawing.Size(194, 22);
            this.PesquisarProdutos.Text = "Pesquisar Produtos";
            this.PesquisarProdutos.Click += new System.EventHandler(this.PesquisarProdutos_Click);
            // 
            // tsmCliente
            // 
            this.tsmCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClientesToolStripMenuItem,
            this.pesquisarClientesToolStripMenuItem});
            this.tsmCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsmCliente.Image")));
            this.tsmCliente.Name = "tsmCliente";
            this.tsmCliente.Size = new System.Drawing.Size(72, 20);
            this.tsmCliente.Text = "Cliente";
            // 
            // cadastrarClientesToolStripMenuItem
            // 
            this.cadastrarClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarClientesToolStripMenuItem.Image")));
            this.cadastrarClientesToolStripMenuItem.Name = "cadastrarClientesToolStripMenuItem";
            this.cadastrarClientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.cadastrarClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastrarClientesToolStripMenuItem.Text = "Cadastrar Clientes";
            this.cadastrarClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClientesToolStripMenuItem_Click);
            // 
            // pesquisarClientesToolStripMenuItem
            // 
            this.pesquisarClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pesquisarClientesToolStripMenuItem.Image")));
            this.pesquisarClientesToolStripMenuItem.Name = "pesquisarClientesToolStripMenuItem";
            this.pesquisarClientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.pesquisarClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pesquisarClientesToolStripMenuItem.Text = "Pesquisar Clientes";
            this.pesquisarClientesToolStripMenuItem.Click += new System.EventHandler(this.pesquisarClientesToolStripMenuItem_Click);
            // 
            // ConfiguracoesToolStrip
            // 
            this.ConfiguracoesToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamanhosPréDefinidosToolStripMenuItem,
            this.atendentesToolStripMenuItem,
            this.envelopesToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.ConfiguracoesToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ConfiguracoesToolStrip.Image")));
            this.ConfiguracoesToolStrip.Name = "ConfiguracoesToolStrip";
            this.ConfiguracoesToolStrip.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.ConfiguracoesToolStrip.Size = new System.Drawing.Size(112, 20);
            this.ConfiguracoesToolStrip.Text = "Configurações";
            // 
            // tamanhosPréDefinidosToolStripMenuItem
            // 
            this.tamanhosPréDefinidosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tamanhosPréDefinidosToolStripMenuItem.Image")));
            this.tamanhosPréDefinidosToolStripMenuItem.Name = "tamanhosPréDefinidosToolStripMenuItem";
            this.tamanhosPréDefinidosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.tamanhosPréDefinidosToolStripMenuItem.Text = "Tamanhos Pré definidos";
            this.tamanhosPréDefinidosToolStripMenuItem.Click += new System.EventHandler(this.tamanhosPréDefinidosToolStripMenuItem_Click);
            // 
            // atendentesToolStripMenuItem
            // 
            this.atendentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("atendentesToolStripMenuItem.Image")));
            this.atendentesToolStripMenuItem.Name = "atendentesToolStripMenuItem";
            this.atendentesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.atendentesToolStripMenuItem.Text = "Atendentes";
            this.atendentesToolStripMenuItem.Click += new System.EventHandler(this.atendentesToolStripMenuItem_Click);
            // 
            // envelopesToolStripMenuItem
            // 
            this.envelopesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("envelopesToolStripMenuItem.Image")));
            this.envelopesToolStripMenuItem.Name = "envelopesToolStripMenuItem";
            this.envelopesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.envelopesToolStripMenuItem.Text = "Local onde salvar Envelopes";
            this.envelopesToolStripMenuItem.Click += new System.EventHandler(this.envelopesToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuáriosToolStripMenuItem.Image")));
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // weTransferToolStripMenuItem
            // 
            this.weTransferToolStripMenuItem.Name = "weTransferToolStripMenuItem";
            this.weTransferToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.weTransferToolStripMenuItem.Text = "WeTransfer";
            this.weTransferToolStripMenuItem.Click += new System.EventHandler(this.weTransferToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1215, 583);
            this.Controls.Add(this.mdiMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mdiMenu;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mdiMenu.ResumeLayout(false);
            this.mdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mdiMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmEnvelope;
        private System.Windows.Forms.ToolStripMenuItem tsmProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmCliente;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEnvelopeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarEnvelopesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PesquisarProdutos;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfiguracoesToolStrip;
        private System.Windows.Forms.ToolStripMenuItem tamanhosPréDefinidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envelopesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weTransferToolStripMenuItem;
    }
}
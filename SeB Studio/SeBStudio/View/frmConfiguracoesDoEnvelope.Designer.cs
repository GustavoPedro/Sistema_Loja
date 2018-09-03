namespace SeBStudio.View
{
    partial class frmConfiguracoesDoEnvelope
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoesDoEnvelope));
            this.lblCaminho = new System.Windows.Forms.Label();
            this.txbCaminho = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.fbdPastaEnv = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(23, 71);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(48, 13);
            this.lblCaminho.TabIndex = 0;
            this.lblCaminho.Text = "Caminho";
            // 
            // txbCaminho
            // 
            this.txbCaminho.Location = new System.Drawing.Point(23, 90);
            this.txbCaminho.Name = "txbCaminho";
            this.txbCaminho.Size = new System.Drawing.Size(341, 20);
            this.txbCaminho.TabIndex = 1;
            // 
            // btnCarregar
            // 
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Location = new System.Drawing.Point(370, 88);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(62, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.toolTip1.SetToolTip(this.btnCarregar, "Abre file explorer do windows");
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(357, 222);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.toolTip1.SetToolTip(this.btnSalvar, "Atalho: Enter");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmConfiguracoesDoEnvelope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(448, 268);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.txbCaminho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmConfiguracoesDoEnvelope";
            this.Text = "Configurar pasta de salvamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConfiguracoesDoEnvelope_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.TextBox txbCaminho;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.FolderBrowserDialog fbdPastaEnv;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
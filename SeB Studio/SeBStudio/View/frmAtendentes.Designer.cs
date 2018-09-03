namespace SeBStudio.View
{
    partial class frmAtendentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtendentes));
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAtendentes = new System.Windows.Forms.ListBox();
            this.txbAtendentes = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnConcluir
            // 
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Location = new System.Drawing.Point(207, 242);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(75, 23);
            this.btnConcluir.TabIndex = 5;
            this.btnConcluir.Text = "Fechar";
            this.toolTip1.SetToolTip(this.btnConcluir, "Atalho: Control + W");
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atendentes:";
            // 
            // lbxAtendentes
            // 
            this.lbxAtendentes.FormattingEnabled = true;
            this.lbxAtendentes.Location = new System.Drawing.Point(15, 76);
            this.lbxAtendentes.Name = "lbxAtendentes";
            this.lbxAtendentes.Size = new System.Drawing.Size(203, 160);
            this.lbxAtendentes.TabIndex = 3;

            // 
            // txbAtendentes
            // 
            this.txbAtendentes.Location = new System.Drawing.Point(15, 38);
            this.txbAtendentes.Name = "txbAtendentes";
            this.txbAtendentes.Size = new System.Drawing.Size(203, 20);
            this.txbAtendentes.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(224, 36);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(33, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "+";
            this.toolTip1.SetToolTip(this.btnAdicionar, "Atalho: Enter\r\nCadastra atendente");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(224, 213);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(33, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "-";
            this.toolTip1.SetToolTip(this.btnRemover, "Atalho: Control + D\r\nRemove atendente selecionado");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmAtendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(294, 277);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbAtendentes);
            this.Controls.Add(this.lbxAtendentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAtendentes";
            this.Text = "Atendentes";
            this.Load += new System.EventHandler(this.frmAtendentes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAtendentes_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxAtendentes;
        private System.Windows.Forms.TextBox txbAtendentes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
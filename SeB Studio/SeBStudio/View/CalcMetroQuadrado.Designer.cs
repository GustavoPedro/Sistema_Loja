namespace SeBStudio.View
{
    partial class CalcMetroQuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcMetroQuadrado));
            this.txbAlturaDoAdesivo = new System.Windows.Forms.TextBox();
            this.txbLarguraDaAreaDeImpressao = new System.Windows.Forms.TextBox();
            this.txbAlturaDaAreaDeImpressao = new System.Windows.Forms.TextBox();
            this.txbLarguraDoAdesivo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbMediaPorFolha = new System.Windows.Forms.TextBox();
            this.gbxCalcQuantidade = new System.Windows.Forms.GroupBox();
            this.rbrCalcularAltura = new System.Windows.Forms.RadioButton();
            this.rbrCalcularMedia = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTamanhosPreDefinidos = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.gbxCalcDeMetroQuad = new System.Windows.Forms.GroupBox();
            this.txbValorM2 = new System.Windows.Forms.TextBox();
            this.btnLimpar2 = new System.Windows.Forms.Button();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.txbLargura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCalcQuantidade.SuspendLayout();
            this.gbxCalcDeMetroQuad.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbAlturaDoAdesivo
            // 
            this.txbAlturaDoAdesivo.Location = new System.Drawing.Point(133, 149);
            this.txbAlturaDoAdesivo.Name = "txbAlturaDoAdesivo";
            this.txbAlturaDoAdesivo.Size = new System.Drawing.Size(100, 20);
            this.txbAlturaDoAdesivo.TabIndex = 9;
            this.txbAlturaDoAdesivo.Validated += new System.EventHandler(this.txbAlturaDoAdesivo_Validated);
            // 
            // txbLarguraDaAreaDeImpressao
            // 
            this.txbLarguraDaAreaDeImpressao.Location = new System.Drawing.Point(9, 65);
            this.txbLarguraDaAreaDeImpressao.Name = "txbLarguraDaAreaDeImpressao";
            this.txbLarguraDaAreaDeImpressao.Size = new System.Drawing.Size(100, 20);
            this.txbLarguraDaAreaDeImpressao.TabIndex = 2;
            this.txbLarguraDaAreaDeImpressao.Validated += new System.EventHandler(this.txbLarguraDaAreaDeImpressao_Validated);
            // 
            // txbAlturaDaAreaDeImpressao
            // 
            this.txbAlturaDaAreaDeImpressao.Location = new System.Drawing.Point(133, 65);
            this.txbAlturaDaAreaDeImpressao.Name = "txbAlturaDaAreaDeImpressao";
            this.txbAlturaDaAreaDeImpressao.Size = new System.Drawing.Size(100, 20);
            this.txbAlturaDaAreaDeImpressao.TabIndex = 4;
            this.txbAlturaDaAreaDeImpressao.Validated += new System.EventHandler(this.txbAlturaDaAreaDeImpressao_Validated);
            // 
            // txbLarguraDoAdesivo
            // 
            this.txbLarguraDoAdesivo.Location = new System.Drawing.Point(9, 149);
            this.txbLarguraDoAdesivo.Name = "txbLarguraDoAdesivo";
            this.txbLarguraDoAdesivo.Size = new System.Drawing.Size(100, 20);
            this.txbLarguraDoAdesivo.TabIndex = 7;

            this.txbLarguraDoAdesivo.Validated += new System.EventHandler(this.txbLarguraDoAdesivo_Validated);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(158, 175);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.btnLimpar, "Atalho: Control + K\r\nLimpa Todos os campos do grupo");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbMediaPorFolha
            // 
            this.txbMediaPorFolha.Location = new System.Drawing.Point(9, 275);
            this.txbMediaPorFolha.Name = "txbMediaPorFolha";
            this.txbMediaPorFolha.Size = new System.Drawing.Size(100, 20);
            this.txbMediaPorFolha.TabIndex = 15;
            
            this.txbMediaPorFolha.Validated += new System.EventHandler(this.txbMediaPorFolha_Validated);
            // 
            // gbxCalcQuantidade
            // 
            this.gbxCalcQuantidade.Controls.Add(this.rbrCalcularAltura);
            this.gbxCalcQuantidade.Controls.Add(this.rbrCalcularMedia);
            this.gbxCalcQuantidade.Controls.Add(this.label11);
            this.gbxCalcQuantidade.Controls.Add(this.cbxTamanhosPreDefinidos);
            this.gbxCalcQuantidade.Controls.Add(this.label10);
            this.gbxCalcQuantidade.Controls.Add(this.label5);
            this.gbxCalcQuantidade.Controls.Add(this.label1);
            this.gbxCalcQuantidade.Controls.Add(this.label4);
            this.gbxCalcQuantidade.Controls.Add(this.label3);
            this.gbxCalcQuantidade.Controls.Add(this.label2);
            this.gbxCalcQuantidade.Controls.Add(this.lblLargura);
            this.gbxCalcQuantidade.Controls.Add(this.txbAlturaDaAreaDeImpressao);
            this.gbxCalcQuantidade.Controls.Add(this.txbMediaPorFolha);
            this.gbxCalcQuantidade.Controls.Add(this.txbLarguraDaAreaDeImpressao);
            this.gbxCalcQuantidade.Controls.Add(this.btnLimpar);
            this.gbxCalcQuantidade.Controls.Add(this.txbAlturaDoAdesivo);
            this.gbxCalcQuantidade.Controls.Add(this.txbLarguraDoAdesivo);
            this.gbxCalcQuantidade.Location = new System.Drawing.Point(304, 7);
            this.gbxCalcQuantidade.Name = "gbxCalcQuantidade";
            this.gbxCalcQuantidade.Size = new System.Drawing.Size(239, 311);
            this.gbxCalcQuantidade.TabIndex = 0;
            this.gbxCalcQuantidade.TabStop = false;
            this.gbxCalcQuantidade.Text = "Calculo Quantidade";
            
            // 
            // rbrCalcularAltura
            // 
            this.rbrCalcularAltura.AutoSize = true;
            this.rbrCalcularAltura.Location = new System.Drawing.Point(135, 276);
            this.rbrCalcularAltura.Name = "rbrCalcularAltura";
            this.rbrCalcularAltura.Size = new System.Drawing.Size(93, 17);
            this.rbrCalcularAltura.TabIndex = 16;
            this.rbrCalcularAltura.TabStop = true;
            this.rbrCalcularAltura.Text = "Calcular Altura";
            this.rbrCalcularAltura.UseVisualStyleBackColor = true;
            this.rbrCalcularAltura.CheckedChanged += new System.EventHandler(this.rbrCalcularAltura_CheckedChanged);
            // 
            // rbrCalcularMedia
            // 
            this.rbrCalcularMedia.AutoSize = true;
            this.rbrCalcularMedia.Location = new System.Drawing.Point(133, 223);
            this.rbrCalcularMedia.Name = "rbrCalcularMedia";
            this.rbrCalcularMedia.Size = new System.Drawing.Size(95, 17);
            this.rbrCalcularMedia.TabIndex = 13;
            this.rbrCalcularMedia.TabStop = true;
            this.rbrCalcularMedia.Text = "Calcular Media";
            this.rbrCalcularMedia.UseVisualStyleBackColor = true;
            this.rbrCalcularMedia.CheckedChanged += new System.EventHandler(this.rbrCalcularMedia_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tamanhos Pré definidos";
            // 
            // cbxTamanhosPreDefinidos
            // 
            this.cbxTamanhosPreDefinidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTamanhosPreDefinidos.FormattingEnabled = true;
            this.cbxTamanhosPreDefinidos.Items.AddRange(new object[] {
            "",
            "Adesivo Tam Min",
            "Tamanho Min Por M²",
            ""});
            this.cbxTamanhosPreDefinidos.Location = new System.Drawing.Point(9, 223);
            this.cbxTamanhosPreDefinidos.Name = "cbxTamanhosPreDefinidos";
            this.cbxTamanhosPreDefinidos.Size = new System.Drawing.Size(118, 21);
            this.cbxTamanhosPreDefinidos.TabIndex = 12;
            this.cbxTamanhosPreDefinidos.SelectedIndexChanged += new System.EventHandler(this.cbxTamanhosPreDefinidos_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Media por Folha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Medida da Imagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medida da Area de Impressão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Largura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura";
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(6, 49);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(43, 13);
            this.lblLargura.TabIndex = 1;
            this.lblLargura.Text = "Largura";
            // 
            // gbxCalcDeMetroQuad
            // 
            this.gbxCalcDeMetroQuad.Controls.Add(this.txbValorM2);
            this.gbxCalcDeMetroQuad.Controls.Add(this.btnLimpar2);
            this.gbxCalcDeMetroQuad.Controls.Add(this.txbTotal);
            this.gbxCalcDeMetroQuad.Controls.Add(this.label9);
            this.gbxCalcDeMetroQuad.Controls.Add(this.txbAltura);
            this.gbxCalcDeMetroQuad.Controls.Add(this.txbLargura);
            this.gbxCalcDeMetroQuad.Controls.Add(this.label8);
            this.gbxCalcDeMetroQuad.Controls.Add(this.label7);
            this.gbxCalcDeMetroQuad.Controls.Add(this.label6);
            this.gbxCalcDeMetroQuad.Location = new System.Drawing.Point(13, 12);
            this.gbxCalcDeMetroQuad.Name = "gbxCalcDeMetroQuad";
            this.gbxCalcDeMetroQuad.Size = new System.Drawing.Size(285, 306);
            this.gbxCalcDeMetroQuad.TabIndex = 7;
            this.gbxCalcDeMetroQuad.TabStop = false;
            this.gbxCalcDeMetroQuad.Text = "Calculo de Metro Quadrado";
            // 
            // txbValorM2
            // 
            this.txbValorM2.Location = new System.Drawing.Point(9, 61);
            this.txbValorM2.Name = "txbValorM2";
            this.txbValorM2.Size = new System.Drawing.Size(100, 20);
            this.txbValorM2.TabIndex = 0;
            this.txbValorM2.Validated += new System.EventHandler(this.txbValorM2_Validated);
            // 
            // btnLimpar2
            // 
            this.btnLimpar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar2.Location = new System.Drawing.Point(122, 216);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar2.TabIndex = 7;
            this.btnLimpar2.Text = "Limpar";
            this.toolTip1.SetToolTip(this.btnLimpar2, "Atalho: Control + L\r\nLimpa todos os campos do grupo");
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(6, 218);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 20);
            this.txbTotal.TabIndex = 6;
            
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total";
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(6, 157);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 4;
            this.txbAltura.Validated += new System.EventHandler(this.txbAltura_Validated);
            // 
            // txbLargura
            // 
            this.txbLargura.Location = new System.Drawing.Point(9, 106);
            this.txbLargura.Name = "txbLargura";
            this.txbLargura.Size = new System.Drawing.Size(100, 20);
            this.txbLargura.TabIndex = 2;
            this.txbLargura.Validated += new System.EventHandler(this.txbLargura_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Largura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Valor M²";
            // 
            // CalcMetroQuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(555, 330);
            this.Controls.Add(this.gbxCalcDeMetroQuad);
            this.Controls.Add(this.gbxCalcQuantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CalcMetroQuadrado";
            this.Text = "Calculo Metro Quadrado";
            this.Load += new System.EventHandler(this.CalcMetroQuadrado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalcMetroQuadrado_KeyDown);
            this.gbxCalcQuantidade.ResumeLayout(false);
            this.gbxCalcQuantidade.PerformLayout();
            this.gbxCalcDeMetroQuad.ResumeLayout(false);
            this.gbxCalcDeMetroQuad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbAlturaDoAdesivo;
        private System.Windows.Forms.TextBox txbLarguraDaAreaDeImpressao;
        private System.Windows.Forms.TextBox txbAlturaDaAreaDeImpressao;
        private System.Windows.Forms.TextBox txbLarguraDoAdesivo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txbMediaPorFolha;
        private System.Windows.Forms.GroupBox gbxCalcQuantidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.GroupBox gbxCalcDeMetroQuad;
        private System.Windows.Forms.Button btnLimpar2;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.TextBox txbLargura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxTamanhosPreDefinidos;
        private System.Windows.Forms.TextBox txbValorM2;
        private System.Windows.Forms.RadioButton rbrCalcularAltura;
        private System.Windows.Forms.RadioButton rbrCalcularMedia;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
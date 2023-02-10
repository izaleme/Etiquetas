namespace EtqCor
{
    partial class Frm000100EtqTestesCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm000100EtqTestesCor));
            this.containerPanel1 = new TIPlasutil.Componentes.ContainerPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPigmento = new Plasutil.Components.CustomBox();
            this.lblCodCor = new System.Windows.Forms.Label();
            this.cbxCodCor = new Plasutil.Components.CustomBox();
            this.lblConcentracao = new System.Windows.Forms.Label();
            this.cbxConcentracao = new Plasutil.Components.CustomBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cbxFornecedor = new Plasutil.Components.CustomBox();
            this.lblResina = new System.Windows.Forms.Label();
            this.cbxResina = new Plasutil.Components.CustomBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel1
            // 
            this.containerPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.containerPanel1.CorGradiente = true;
            this.containerPanel1.CorGradienteFinal = System.Drawing.Color.White;
            this.containerPanel1.CorGradienteInicial = System.Drawing.Color.MediumSlateBlue;
            this.containerPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel1.ExportarExcelVisivel = false;
            this.containerPanel1.FonteTitulo = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerPanel1.ForeColorTitulo = System.Drawing.SystemColors.HighlightText;
            this.containerPanel1.Icone = ((System.Drawing.Image)(resources.GetObject("containerPanel1.Icone")));
            this.containerPanel1.Location = new System.Drawing.Point(0, 0);
            this.containerPanel1.Name = "containerPanel1";
            this.containerPanel1.PainelCentro = this.pnlContent;
            this.containerPanel1.PerfilUsuarioVisivel = false;
            this.containerPanel1.RotacaoGradiente = 0F;
            this.containerPanel1.Size = new System.Drawing.Size(800, 450);
            this.containerPanel1.TabIndex = 0;
            this.containerPanel1.Titulo = "Impressão de Etiqueta";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoSize = true;
            this.pnlContent.Controls.Add(this.comboBox1);
            this.pnlContent.Controls.Add(this.cbxResina);
            this.pnlContent.Controls.Add(this.cbxFornecedor);
            this.pnlContent.Controls.Add(this.cbxConcentracao);
            this.pnlContent.Controls.Add(this.cbxCodCor);
            this.pnlContent.Controls.Add(this.cbxPigmento);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.lblResina);
            this.pnlContent.Controls.Add(this.lblFornecedor);
            this.pnlContent.Controls.Add(this.lblConcentracao);
            this.pnlContent.Controls.Add(this.lblCodCor);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(798, 428);
            this.pnlContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pigmento:";
            // 
            // cbxPigmento
            // 
            this.cbxPigmento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxPigmento.CasasDecimais = 2;
            this.cbxPigmento.Formato = Plasutil.Components.Tipo.AlfaNumérico;
            this.cbxPigmento.Location = new System.Drawing.Point(112, 14);
            this.cbxPigmento.Name = "cbxPigmento";
            this.cbxPigmento.Size = new System.Drawing.Size(259, 20);
            this.cbxPigmento.TabIndex = 1;
            // 
            // lblCodCor
            // 
            this.lblCodCor.AutoSize = true;
            this.lblCodCor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCor.Location = new System.Drawing.Point(11, 41);
            this.lblCodCor.Name = "lblCodCor";
            this.lblCodCor.Size = new System.Drawing.Size(79, 14);
            this.lblCodCor.TabIndex = 0;
            this.lblCodCor.Text = "Código Cor:";
            // 
            // cbxCodCor
            // 
            this.cbxCodCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxCodCor.CasasDecimais = 2;
            this.cbxCodCor.Formato = Plasutil.Components.Tipo.AlfaNumérico;
            this.cbxCodCor.Location = new System.Drawing.Point(112, 39);
            this.cbxCodCor.Name = "cbxCodCor";
            this.cbxCodCor.Size = new System.Drawing.Size(259, 20);
            this.cbxCodCor.TabIndex = 2;
            // 
            // lblConcentracao
            // 
            this.lblConcentracao.AutoSize = true;
            this.lblConcentracao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcentracao.Location = new System.Drawing.Point(11, 66);
            this.lblConcentracao.Name = "lblConcentracao";
            this.lblConcentracao.Size = new System.Drawing.Size(95, 14);
            this.lblConcentracao.TabIndex = 0;
            this.lblConcentracao.Text = "Concentração:";
            // 
            // cbxConcentracao
            // 
            this.cbxConcentracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxConcentracao.CasasDecimais = 2;
            this.cbxConcentracao.Formato = Plasutil.Components.Tipo.AlfaNumérico;
            this.cbxConcentracao.Location = new System.Drawing.Point(112, 64);
            this.cbxConcentracao.Name = "cbxConcentracao";
            this.cbxConcentracao.Size = new System.Drawing.Size(259, 20);
            this.cbxConcentracao.TabIndex = 3;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(11, 91);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(79, 14);
            this.lblFornecedor.TabIndex = 0;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxFornecedor.CasasDecimais = 2;
            this.cbxFornecedor.Formato = Plasutil.Components.Tipo.AlfaNumérico;
            this.cbxFornecedor.Location = new System.Drawing.Point(112, 89);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(259, 20);
            this.cbxFornecedor.TabIndex = 4;
            // 
            // lblResina
            // 
            this.lblResina.AutoSize = true;
            this.lblResina.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResina.Location = new System.Drawing.Point(11, 116);
            this.lblResina.Name = "lblResina";
            this.lblResina.Size = new System.Drawing.Size(51, 14);
            this.lblResina.TabIndex = 0;
            this.lblResina.Text = "Resina:";
            // 
            // cbxResina
            // 
            this.cbxResina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxResina.CasasDecimais = 2;
            this.cbxResina.Formato = Plasutil.Components.Tipo.AlfaNumérico;
            this.cbxResina.Location = new System.Drawing.Point(112, 114);
            this.cbxResina.Name = "cbxResina";
            this.cbxResina.Size = new System.Drawing.Size(259, 20);
            this.cbxResina.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(11, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Impressora:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Frm000100EtqTestesCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.containerPanel1);
            this.Name = "Frm000100EtqTestesCor";
            this.Text = "Frm000100EtqTestesCor";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TIPlasutil.Componentes.ContainerPanel containerPanel1;
        private System.Windows.Forms.Panel pnlContent;
        private Plasutil.Components.CustomBox cbxResina;
        private Plasutil.Components.CustomBox cbxFornecedor;
        private Plasutil.Components.CustomBox cbxConcentracao;
        private Plasutil.Components.CustomBox cbxCodCor;
        private Plasutil.Components.CustomBox cbxPigmento;
        private System.Windows.Forms.Label lblResina;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblConcentracao;
        private System.Windows.Forms.Label lblCodCor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
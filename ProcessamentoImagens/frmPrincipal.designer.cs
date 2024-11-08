﻿namespace ProcessamentoImagens
{
    partial class frmPrincipal
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
            this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
            this.pictBoxImg2 = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLuminanciaSemDMA = new System.Windows.Forms.Button();
            this.btnLuminanciaComDMA = new System.Windows.Forms.Button();
            this.btnNegativoComDMA = new System.Windows.Forms.Button();
            this.btnNegativoSemDMA = new System.Windows.Forms.Button();
            this.btnAfinamentoSemDMA = new System.Windows.Forms.Button();
            this.btnAfinamentoComDMA = new System.Windows.Forms.Button();
            this.btnDesenharContorno = new System.Windows.Forms.Button();
            this.btnContornoRetMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxImg1
            // 
            this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg1.Location = new System.Drawing.Point(7, 7);
            this.pictBoxImg1.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxImg1.Name = "pictBoxImg1";
            this.pictBoxImg1.Size = new System.Drawing.Size(800, 615);
            this.pictBoxImg1.TabIndex = 102;
            this.pictBoxImg1.TabStop = false;
            // 
            // pictBoxImg2
            // 
            this.pictBoxImg2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxImg2.Location = new System.Drawing.Point(815, 7);
            this.pictBoxImg2.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxImg2.Name = "pictBoxImg2";
            this.pictBoxImg2.Size = new System.Drawing.Size(800, 615);
            this.pictBoxImg2.TabIndex = 105;
            this.pictBoxImg2.TabStop = false;
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(7, 630);
            this.btnAbrirImagem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(135, 28);
            this.btnAbrirImagem.TabIndex = 106;
            this.btnAbrirImagem.Text = "Abrir Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(149, 630);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 28);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLuminanciaSemDMA
            // 
            this.btnLuminanciaSemDMA.Location = new System.Drawing.Point(292, 630);
            this.btnLuminanciaSemDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuminanciaSemDMA.Name = "btnLuminanciaSemDMA";
            this.btnLuminanciaSemDMA.Size = new System.Drawing.Size(277, 28);
            this.btnLuminanciaSemDMA.TabIndex = 108;
            this.btnLuminanciaSemDMA.Text = "Luminância sem DMA";
            this.btnLuminanciaSemDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaSemDMA.Click += new System.EventHandler(this.btnLuminanciaSemDMA_Click);
            // 
            // btnLuminanciaComDMA
            // 
            this.btnLuminanciaComDMA.Location = new System.Drawing.Point(292, 666);
            this.btnLuminanciaComDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuminanciaComDMA.Name = "btnLuminanciaComDMA";
            this.btnLuminanciaComDMA.Size = new System.Drawing.Size(277, 28);
            this.btnLuminanciaComDMA.TabIndex = 109;
            this.btnLuminanciaComDMA.Text = "Luminância com DMA";
            this.btnLuminanciaComDMA.UseVisualStyleBackColor = true;
            this.btnLuminanciaComDMA.Click += new System.EventHandler(this.btnLuminanciaComDMA_Click);
            // 
            // btnNegativoComDMA
            // 
            this.btnNegativoComDMA.Location = new System.Drawing.Point(577, 666);
            this.btnNegativoComDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegativoComDMA.Name = "btnNegativoComDMA";
            this.btnNegativoComDMA.Size = new System.Drawing.Size(277, 28);
            this.btnNegativoComDMA.TabIndex = 111;
            this.btnNegativoComDMA.Text = "Negativo com DMA";
            this.btnNegativoComDMA.UseVisualStyleBackColor = true;
            this.btnNegativoComDMA.Click += new System.EventHandler(this.btnNegativoComDMA_Click);
            // 
            // btnNegativoSemDMA
            // 
            this.btnNegativoSemDMA.Location = new System.Drawing.Point(577, 630);
            this.btnNegativoSemDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegativoSemDMA.Name = "btnNegativoSemDMA";
            this.btnNegativoSemDMA.Size = new System.Drawing.Size(277, 28);
            this.btnNegativoSemDMA.TabIndex = 110;
            this.btnNegativoSemDMA.Text = "Negativo sem DMA";
            this.btnNegativoSemDMA.UseVisualStyleBackColor = true;
            this.btnNegativoSemDMA.Click += new System.EventHandler(this.btnNegativoSemDMA_Click);
            // 
            // btnAfinamentoSemDMA
            // 
            this.btnAfinamentoSemDMA.Location = new System.Drawing.Point(862, 630);
            this.btnAfinamentoSemDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfinamentoSemDMA.Name = "btnAfinamentoSemDMA";
            this.btnAfinamentoSemDMA.Size = new System.Drawing.Size(277, 28);
            this.btnAfinamentoSemDMA.TabIndex = 112;
            this.btnAfinamentoSemDMA.Text = "Afinamento sem DMA";
            this.btnAfinamentoSemDMA.UseVisualStyleBackColor = true;
            this.btnAfinamentoSemDMA.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAfinamentoComDMA
            // 
            this.btnAfinamentoComDMA.Location = new System.Drawing.Point(862, 666);
            this.btnAfinamentoComDMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfinamentoComDMA.Name = "btnAfinamentoComDMA";
            this.btnAfinamentoComDMA.Size = new System.Drawing.Size(277, 28);
            this.btnAfinamentoComDMA.TabIndex = 113;
            this.btnAfinamentoComDMA.Text = "Afinamento com DMA";
            this.btnAfinamentoComDMA.UseVisualStyleBackColor = true;
            this.btnAfinamentoComDMA.Click += new System.EventHandler(this.btnAfinamentoComDMA_Click_1);
            // 
            // btnDesenharContorno
            // 
            this.btnDesenharContorno.Location = new System.Drawing.Point(1147, 630);
            this.btnDesenharContorno.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesenharContorno.Name = "btnDesenharContorno";
            this.btnDesenharContorno.Size = new System.Drawing.Size(277, 28);
            this.btnDesenharContorno.TabIndex = 114;
            this.btnDesenharContorno.Text = "Desenhar Contorno";
            this.btnDesenharContorno.UseVisualStyleBackColor = true;
            this.btnDesenharContorno.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnContornoRetMin
            // 
            this.btnContornoRetMin.Location = new System.Drawing.Point(1147, 666);
            this.btnContornoRetMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnContornoRetMin.Name = "btnContornoRetMin";
            this.btnContornoRetMin.Size = new System.Drawing.Size(277, 28);
            this.btnContornoRetMin.TabIndex = 115;
            this.btnContornoRetMin.Text = "Contorno + Retângulo Minimo";
            this.btnContornoRetMin.UseVisualStyleBackColor = true;
            this.btnContornoRetMin.Click += new System.EventHandler(this.btnContornoRetMin_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 748);
            this.Controls.Add(this.btnContornoRetMin);
            this.Controls.Add(this.btnDesenharContorno);
            this.Controls.Add(this.btnAfinamentoComDMA);
            this.Controls.Add(this.btnAfinamentoSemDMA);
            this.Controls.Add(this.btnNegativoComDMA);
            this.Controls.Add(this.btnNegativoSemDMA);
            this.Controls.Add(this.btnLuminanciaComDMA);
            this.Controls.Add(this.btnLuminanciaSemDMA);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAbrirImagem);
            this.Controls.Add(this.pictBoxImg2);
            this.Controls.Add(this.pictBoxImg1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxImg2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxImg1;
        private System.Windows.Forms.PictureBox pictBoxImg2;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLuminanciaSemDMA;
        private System.Windows.Forms.Button btnLuminanciaComDMA;
        private System.Windows.Forms.Button btnNegativoComDMA;
        private System.Windows.Forms.Button btnNegativoSemDMA;
        private System.Windows.Forms.Button btnAfinamentoSemDMA;
        private System.Windows.Forms.Button btnAfinamentoComDMA;
        private System.Windows.Forms.Button btnDesenharContorno;
        private System.Windows.Forms.Button btnContornoRetMin;
        // private System.Windows.Forms.Button btnAfinamentoSemDMA;
    }
}


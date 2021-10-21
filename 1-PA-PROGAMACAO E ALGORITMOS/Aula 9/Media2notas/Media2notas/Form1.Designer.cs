namespace Media2notas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctxNota1 = new System.Windows.Forms.TextBox();
            this.ctxNota2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ctxMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcula a média de 2 notas e mostra a situação do aluno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 1:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ctxNota1
            // 
            this.ctxNota1.Location = new System.Drawing.Point(115, 58);
            this.ctxNota1.Name = "ctxNota1";
            this.ctxNota1.Size = new System.Drawing.Size(100, 20);
            this.ctxNota1.TabIndex = 2;
            this.ctxNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctxNota1.TextChanged += new System.EventHandler(this.ctxNota1_TextChanged);
            // 
            // ctxNota2
            // 
            this.ctxNota2.Location = new System.Drawing.Point(571, 58);
            this.ctxNota2.Name = "ctxNota2";
            this.ctxNota2.Size = new System.Drawing.Size(100, 20);
            this.ctxNota2.TabIndex = 4;
            this.ctxNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctxNota2.TextChanged += new System.EventHandler(this.ctxNota2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 2:";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(70, 112);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(104, 23);
            this.btnCalcula.TabIndex = 5;
            this.btnCalcula.Text = "Calcular a média";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(567, 112);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(323, 112);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ctxMedia
            // 
            this.ctxMedia.Enabled = false;
            this.ctxMedia.Location = new System.Drawing.Point(115, 172);
            this.ctxMedia.Name = "ctxMedia";
            this.ctxMedia.Size = new System.Drawing.Size(100, 20);
            this.ctxMedia.TabIndex = 9;
            this.ctxMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Média:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(235, 175);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 13);
            this.lblSituacao.TabIndex = 10;
            this.lblSituacao.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 535);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.ctxMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.ctxNota2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctxNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Média 2 notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctxNota1;
        private System.Windows.Forms.TextBox ctxNota2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox ctxMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSituacao;
    }
}


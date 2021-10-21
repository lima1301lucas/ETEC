namespace fr
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
            this.peri = new System.Windows.Forms.TextBox();
            this.per = new System.Windows.Forms.Label();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.BTNCalcula = new System.Windows.Forms.Button();
            this.CTAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CTLarg = new System.Windows.Forms.TextBox();
            this.LBLarg = new System.Windows.Forms.Label();
            this.CTAltura = new System.Windows.Forms.TextBox();
            this.LBAltura = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.Título = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peri
            // 
            this.peri.Enabled = false;
            this.peri.Location = new System.Drawing.Point(98, 167);
            this.peri.Name = "peri";
            this.peri.Size = new System.Drawing.Size(100, 20);
            this.peri.TabIndex = 38;
            this.peri.TextChanged += new System.EventHandler(this.peri_TextChanged_1);
            // 
            // per
            // 
            this.per.AutoSize = true;
            this.per.ForeColor = System.Drawing.Color.Blue;
            this.per.Location = new System.Drawing.Point(39, 170);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(53, 13);
            this.per.TabIndex = 37;
            this.per.Text = "Perímetro";
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpar.ForeColor = System.Drawing.Color.Black;
            this.BTNLimpar.Location = new System.Drawing.Point(366, 371);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(75, 33);
            this.BTNLimpar.TabIndex = 36;
            this.BTNLimpar.Text = "Limpar";
            this.BTNLimpar.UseVisualStyleBackColor = true;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click_1);
            // 
            // BTNCalcula
            // 
            this.BTNCalcula.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCalcula.Location = new System.Drawing.Point(240, 71);
            this.BTNCalcula.Name = "BTNCalcula";
            this.BTNCalcula.Size = new System.Drawing.Size(298, 59);
            this.BTNCalcula.TabIndex = 35;
            this.BTNCalcula.Text = "CALCULA A ÁREA E O PERÍMETRO ";
            this.BTNCalcula.UseVisualStyleBackColor = true;
            this.BTNCalcula.Click += new System.EventHandler(this.BTNCalcula_Click);
            // 
            // CTAr
            // 
            this.CTAr.Enabled = false;
            this.CTAr.Location = new System.Drawing.Point(98, 200);
            this.CTAr.Name = "CTAr";
            this.CTAr.Size = new System.Drawing.Size(100, 20);
            this.CTAr.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(63, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Área";
            // 
            // CTLarg
            // 
            this.CTLarg.Location = new System.Drawing.Point(98, 97);
            this.CTLarg.Name = "CTLarg";
            this.CTLarg.Size = new System.Drawing.Size(100, 20);
            this.CTLarg.TabIndex = 32;
            this.CTLarg.TextChanged += new System.EventHandler(this.CTLarg_TextChanged_1);
            // 
            // LBLarg
            // 
            this.LBLarg.AutoSize = true;
            this.LBLarg.Location = new System.Drawing.Point(17, 104);
            this.LBLarg.Name = "LBLarg";
            this.LBLarg.Size = new System.Drawing.Size(81, 13);
            this.LBLarg.TabIndex = 31;
            this.LBLarg.Text = "Digite a largura:";
            // 
            // CTAltura
            // 
            this.CTAltura.Location = new System.Drawing.Point(98, 71);
            this.CTAltura.Name = "CTAltura";
            this.CTAltura.Size = new System.Drawing.Size(100, 20);
            this.CTAltura.TabIndex = 30;
            this.CTAltura.TextChanged += new System.EventHandler(this.CTAltura_TextChanged_1);
            // 
            // LBAltura
            // 
            this.LBAltura.AutoSize = true;
            this.LBAltura.Location = new System.Drawing.Point(17, 78);
            this.LBAltura.Name = "LBAltura";
            this.LBAltura.Size = new System.Drawing.Size(75, 13);
            this.LBAltura.TabIndex = 29;
            this.LBAltura.Text = "Digite a altura:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(463, 371);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 33);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // Título
            // 
            this.Título.AutoSize = true;
            this.Título.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Título.ForeColor = System.Drawing.Color.Black;
            this.Título.Location = new System.Drawing.Point(60, 9);
            this.Título.Name = "Título";
            this.Título.Size = new System.Drawing.Size(454, 41);
            this.Título.TabIndex = 27;
            this.Título.Text = "Calcula a área do retângulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 435);
            this.Controls.Add(this.peri);
            this.Controls.Add(this.per);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNCalcula);
            this.Controls.Add(this.CTAr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CTLarg);
            this.Controls.Add(this.LBLarg);
            this.Controls.Add(this.CTAltura);
            this.Controls.Add(this.LBAltura);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.Título);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox peri;
        private System.Windows.Forms.Label per;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNCalcula;
        private System.Windows.Forms.TextBox CTAr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CTLarg;
        private System.Windows.Forms.Label LBLarg;
        private System.Windows.Forms.TextBox CTAltura;
        private System.Windows.Forms.Label LBAltura;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label Título;
    }
}


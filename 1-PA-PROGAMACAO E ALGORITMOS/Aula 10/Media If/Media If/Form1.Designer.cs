namespace media2notasif
{
    partial class btnlim
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
            this.lbln1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.ctxn1 = new System.Windows.Forms.TextBox();
            this.ctxn2 = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnenc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CtxMediaE = new System.Windows.Forms.TextBox();
            this.CtxMedisS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CtxSituacaoE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CtxSituacaoS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULA MÉDIA COM 2 NOTAS";
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln1.Location = new System.Drawing.Point(105, 78);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(58, 18);
            this.lbln1.TabIndex = 1;
            this.lbln1.Text = "Nota 1:";
            this.lbln1.Click += new System.EventHandler(this.Lbln1_Click);
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln2.Location = new System.Drawing.Point(294, 78);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(58, 18);
            this.lbln2.TabIndex = 2;
            this.lbln2.Text = "Nota 2:";
            this.lbln2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ctxn1
            // 
            this.ctxn1.Location = new System.Drawing.Point(169, 71);
            this.ctxn1.Name = "ctxn1";
            this.ctxn1.Size = new System.Drawing.Size(80, 32);
            this.ctxn1.TabIndex = 3;
            this.ctxn1.TextChanged += new System.EventHandler(this.Ctxn1_TextChanged);
            // 
            // ctxn2
            // 
            this.ctxn2.Location = new System.Drawing.Point(358, 71);
            this.ctxn2.Name = "ctxn2";
            this.ctxn2.Size = new System.Drawing.Size(80, 32);
            this.ctxn2.TabIndex = 4;
            this.ctxn2.TextChanged += new System.EventHandler(this.Ctxn2_TextChanged);
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(187, 129);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(104, 35);
            this.btncalc.TabIndex = 5;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.Btncalc_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(297, 129);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(105, 35);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnenc
            // 
            this.btnenc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenc.Location = new System.Drawing.Point(418, 355);
            this.btnenc.Name = "btnenc";
            this.btnenc.Size = new System.Drawing.Size(107, 35);
            this.btnenc.TabIndex = 7;
            this.btnenc.Text = "Encerrar";
            this.btnenc.UseVisualStyleBackColor = true;
            this.btnenc.Click += new System.EventHandler(this.Btnenc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Com desvio ordenado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Com desvio sequêncial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Média:";
            // 
            // CtxMediaE
            // 
            this.CtxMediaE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtxMediaE.Location = new System.Drawing.Point(96, 217);
            this.CtxMediaE.Name = "CtxMediaE";
            this.CtxMediaE.Size = new System.Drawing.Size(100, 26);
            this.CtxMediaE.TabIndex = 11;
            this.CtxMediaE.TextChanged += new System.EventHandler(this.CtxMediaE_TextChanged);
            // 
            // CtxMedisS
            // 
            this.CtxMedisS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtxMedisS.Location = new System.Drawing.Point(96, 310);
            this.CtxMedisS.Name = "CtxMedisS";
            this.CtxMedisS.Size = new System.Drawing.Size(100, 26);
            this.CtxMedisS.TabIndex = 13;
            this.CtxMedisS.TextChanged += new System.EventHandler(this.CtxMedisS_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Média:";
            // 
            // CtxSituacaoE
            // 
            this.CtxSituacaoE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtxSituacaoE.Location = new System.Drawing.Point(352, 217);
            this.CtxSituacaoE.Name = "CtxSituacaoE";
            this.CtxSituacaoE.Size = new System.Drawing.Size(100, 26);
            this.CtxSituacaoE.TabIndex = 15;
            this.CtxSituacaoE.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Situação";
            // 
            // CtxSituacaoS
            // 
            this.CtxSituacaoS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtxSituacaoS.Location = new System.Drawing.Point(352, 310);
            this.CtxSituacaoS.Name = "CtxSituacaoS";
            this.CtxSituacaoS.Size = new System.Drawing.Size(100, 26);
            this.CtxSituacaoS.TabIndex = 17;
            this.CtxSituacaoS.TextChanged += new System.EventHandler(this.CtxSituacaoS_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Situação";
            // 
            // btnlim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 402);
            this.Controls.Add(this.CtxSituacaoS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CtxSituacaoE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CtxMedisS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CtxMediaE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnenc);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.ctxn2);
            this.Controls.Add(this.ctxn1);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbln1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "btnlim";
            this.Text = "Média";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.Label lbln2;
        private System.Windows.Forms.TextBox ctxn1;
        private System.Windows.Forms.TextBox ctxn2;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnenc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CtxMediaE;
        private System.Windows.Forms.TextBox CtxMedisS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CtxSituacaoE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CtxSituacaoS;
        private System.Windows.Forms.Label label7;
    }
}


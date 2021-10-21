namespace Raizes
{
    partial class Raizes
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
            this.calculo = new System.Windows.Forms.Label();
            this.ctx_y = new System.Windows.Forms.TextBox();
            this.ctx_x = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_x1 = new System.Windows.Forms.Label();
            this.lbl_x2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctx_c = new System.Windows.Forms.TextBox();
            this.ctx_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctx_b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_mais = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_parabola = new System.Windows.Forms.Label();
            this.ctx_raizes = new System.Windows.Forms.TextBox();
            this.ctx_sentido = new System.Windows.Forms.TextBox();
            this.ctx_delta = new System.Windows.Forms.TextBox();
            this.label_orientacao = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.img_parabola = new System.Windows.Forms.PictureBox();
            this.botao_encerrar = new System.Windows.Forms.Button();
            this.botao_limpar = new System.Windows.Forms.Button();
            this.botao_calcular = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_parabola)).BeginInit();
            this.SuspendLayout();
            // 
            // calculo
            // 
            this.calculo.AutoSize = true;
            this.calculo.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculo.Location = new System.Drawing.Point(41, 197);
            this.calculo.Name = "calculo";
            this.calculo.Size = new System.Drawing.Size(127, 23);
            this.calculo.TabIndex = 97;
            this.calculo.Text = "Cálculos:";
            // 
            // ctx_y
            // 
            this.ctx_y.Enabled = false;
            this.ctx_y.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_y.ForeColor = System.Drawing.Color.Red;
            this.ctx_y.Location = new System.Drawing.Point(79, 408);
            this.ctx_y.Name = "ctx_y";
            this.ctx_y.Size = new System.Drawing.Size(265, 26);
            this.ctx_y.TabIndex = 96;
            this.ctx_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctx_x
            // 
            this.ctx_x.Enabled = false;
            this.ctx_x.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_x.ForeColor = System.Drawing.Color.Red;
            this.ctx_x.Location = new System.Drawing.Point(79, 371);
            this.ctx_x.Name = "ctx_x";
            this.ctx_x.Size = new System.Drawing.Size(265, 26);
            this.ctx_x.TabIndex = 95;
            this.ctx_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_x1);
            this.groupBox2.Controls.Add(this.lbl_x2);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(79, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 65);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            // 
            // lbl_x1
            // 
            this.lbl_x1.AutoSize = true;
            this.lbl_x1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x1.Location = new System.Drawing.Point(6, 17);
            this.lbl_x1.Name = "lbl_x1";
            this.lbl_x1.Size = new System.Drawing.Size(0, 16);
            this.lbl_x1.TabIndex = 46;
            this.lbl_x1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_x2
            // 
            this.lbl_x2.AutoSize = true;
            this.lbl_x2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x2.Location = new System.Drawing.Point(6, 39);
            this.lbl_x2.Name = "lbl_x2";
            this.lbl_x2.Size = new System.Drawing.Size(0, 16);
            this.lbl_x2.TabIndex = 47;
            this.lbl_x2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctx_c);
            this.groupBox1.Controls.Add(this.ctx_a);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctx_b);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_mais);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 52);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            // 
            // ctx_c
            // 
            this.ctx_c.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_c.Location = new System.Drawing.Point(234, 13);
            this.ctx_c.Name = "ctx_c";
            this.ctx_c.Size = new System.Drawing.Size(48, 32);
            this.ctx_c.TabIndex = 20;
            this.ctx_c.TextChanged += new System.EventHandler(this.Ctx_c_TextChanged_1);
            // 
            // ctx_a
            // 
            this.ctx_a.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_a.Location = new System.Drawing.Point(18, 13);
            this.ctx_a.Name = "ctx_a";
            this.ctx_a.Size = new System.Drawing.Size(46, 32);
            this.ctx_a.TabIndex = 15;
            this.ctx_a.TextChanged += new System.EventHandler(this.Ctx_a_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "X²";
            // 
            // ctx_b
            // 
            this.ctx_b.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_b.Location = new System.Drawing.Point(130, 13);
            this.ctx_b.Name = "ctx_b";
            this.ctx_b.Size = new System.Drawing.Size(48, 32);
            this.ctx_b.TabIndex = 17;
            this.ctx_b.TextChanged += new System.EventHandler(this.Ctx_b_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            // 
            // lbl_mais
            // 
            this.lbl_mais.AutoSize = true;
            this.lbl_mais.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mais.Location = new System.Drawing.Point(100, 18);
            this.lbl_mais.Name = "lbl_mais";
            this.lbl_mais.Size = new System.Drawing.Size(23, 24);
            this.lbl_mais.TabIndex = 19;
            this.lbl_mais.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "+";
            // 
            // lbl_parabola
            // 
            this.lbl_parabola.AutoSize = true;
            this.lbl_parabola.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parabola.Location = new System.Drawing.Point(349, 197);
            this.lbl_parabola.Name = "lbl_parabola";
            this.lbl_parabola.Size = new System.Drawing.Size(127, 23);
            this.lbl_parabola.TabIndex = 92;
            this.lbl_parabola.Text = "Parábola:";
            this.lbl_parabola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctx_raizes
            // 
            this.ctx_raizes.Enabled = false;
            this.ctx_raizes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_raizes.ForeColor = System.Drawing.Color.Red;
            this.ctx_raizes.Location = new System.Drawing.Point(495, 422);
            this.ctx_raizes.Name = "ctx_raizes";
            this.ctx_raizes.Size = new System.Drawing.Size(265, 26);
            this.ctx_raizes.TabIndex = 91;
            this.ctx_raizes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctx_sentido
            // 
            this.ctx_sentido.Enabled = false;
            this.ctx_sentido.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_sentido.ForeColor = System.Drawing.Color.Red;
            this.ctx_sentido.Location = new System.Drawing.Point(495, 390);
            this.ctx_sentido.Name = "ctx_sentido";
            this.ctx_sentido.Size = new System.Drawing.Size(265, 26);
            this.ctx_sentido.TabIndex = 90;
            this.ctx_sentido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctx_delta
            // 
            this.ctx_delta.Enabled = false;
            this.ctx_delta.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_delta.ForeColor = System.Drawing.Color.Red;
            this.ctx_delta.Location = new System.Drawing.Point(79, 259);
            this.ctx_delta.Name = "ctx_delta";
            this.ctx_delta.Size = new System.Drawing.Size(265, 29);
            this.ctx_delta.TabIndex = 89;
            this.ctx_delta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_orientacao
            // 
            this.label_orientacao.AutoSize = true;
            this.label_orientacao.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orientacao.Location = new System.Drawing.Point(60, 74);
            this.label_orientacao.Name = "label_orientacao";
            this.label_orientacao.Size = new System.Drawing.Size(558, 18);
            this.label_orientacao.TabIndex = 88;
            this.label_orientacao.Text = "Digite os respectivos números e aperte o botão calcular";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Courier New", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_titulo.Location = new System.Drawing.Point(86, 3);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(584, 40);
            this.lbl_titulo.TabIndex = 87;
            this.lbl_titulo.Text = "Calcula equações de 2º grau";
            // 
            // img_parabola
            // 
            this.img_parabola.Image = global::Raizes.Properties.Resources.Branco;
            this.img_parabola.Location = new System.Drawing.Point(495, 197);
            this.img_parabola.Name = "img_parabola";
            this.img_parabola.Size = new System.Drawing.Size(265, 187);
            this.img_parabola.TabIndex = 86;
            this.img_parabola.TabStop = false;
            // 
            // botao_encerrar
            // 
            this.botao_encerrar.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_encerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botao_encerrar.Location = new System.Drawing.Point(616, 129);
            this.botao_encerrar.Name = "botao_encerrar";
            this.botao_encerrar.Size = new System.Drawing.Size(114, 28);
            this.botao_encerrar.TabIndex = 85;
            this.botao_encerrar.Text = "Encerrar";
            this.botao_encerrar.UseVisualStyleBackColor = true;
            this.botao_encerrar.Click += new System.EventHandler(this.Botao_encerrar_Click_1);
            // 
            // botao_limpar
            // 
            this.botao_limpar.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_limpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botao_limpar.Location = new System.Drawing.Point(506, 129);
            this.botao_limpar.Name = "botao_limpar";
            this.botao_limpar.Size = new System.Drawing.Size(104, 28);
            this.botao_limpar.TabIndex = 84;
            this.botao_limpar.Text = "Limpar";
            this.botao_limpar.UseVisualStyleBackColor = true;
            this.botao_limpar.Click += new System.EventHandler(this.Botao_limpar_Click_1);
            // 
            // botao_calcular
            // 
            this.botao_calcular.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_calcular.ForeColor = System.Drawing.Color.Green;
            this.botao_calcular.Location = new System.Drawing.Point(389, 129);
            this.botao_calcular.Name = "botao_calcular";
            this.botao_calcular.Size = new System.Drawing.Size(106, 29);
            this.botao_calcular.TabIndex = 83;
            this.botao_calcular.Text = "Calcular";
            this.botao_calcular.UseVisualStyleBackColor = true;
            this.botao_calcular.Click += new System.EventHandler(this.Botao_calcular_Click);
            // 
            // Raizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.calculo);
            this.Controls.Add(this.ctx_y);
            this.Controls.Add(this.ctx_x);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_parabola);
            this.Controls.Add(this.ctx_raizes);
            this.Controls.Add(this.ctx_sentido);
            this.Controls.Add(this.ctx_delta);
            this.Controls.Add(this.label_orientacao);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.img_parabola);
            this.Controls.Add(this.botao_encerrar);
            this.Controls.Add(this.botao_limpar);
            this.Controls.Add(this.botao_calcular);
            this.Name = "Raizes";
            this.Text = "Raizes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_parabola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label calculo;
        private System.Windows.Forms.TextBox ctx_y;
        private System.Windows.Forms.TextBox ctx_x;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_x1;
        private System.Windows.Forms.Label lbl_x2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ctx_c;
        private System.Windows.Forms.TextBox ctx_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctx_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_mais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_parabola;
        private System.Windows.Forms.TextBox ctx_raizes;
        private System.Windows.Forms.TextBox ctx_sentido;
        private System.Windows.Forms.TextBox ctx_delta;
        private System.Windows.Forms.Label label_orientacao;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox img_parabola;
        private System.Windows.Forms.Button botao_encerrar;
        private System.Windows.Forms.Button botao_limpar;
        private System.Windows.Forms.Button botao_calcular;
    }
}


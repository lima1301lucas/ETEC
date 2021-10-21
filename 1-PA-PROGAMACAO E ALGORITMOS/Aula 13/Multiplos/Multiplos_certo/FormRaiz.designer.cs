namespace Multiplos_certo
{
    partial class Equação
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
            this.label_orientacao = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.botao_encerrar = new System.Windows.Forms.Button();
            this.botao_limpar = new System.Windows.Forms.Button();
            this.botao_calcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mais = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_parabola = new System.Windows.Forms.Label();
            this.lbl_delta = new System.Windows.Forms.Label();
            this.lbl_raizes = new System.Windows.Forms.Label();
            this.ctx_a = new System.Windows.Forms.TextBox();
            this.ctx_b = new System.Windows.Forms.TextBox();
            this.ctx_c = new System.Windows.Forms.TextBox();
            this.ctx_x1 = new System.Windows.Forms.TextBox();
            this.ctx_x2 = new System.Windows.Forms.TextBox();
            this.ctx_x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.img_parabola = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ctx_raizes = new System.Windows.Forms.TextBox();
            this.ctx_y = new System.Windows.Forms.TextBox();
            this.ctx_sentido = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_parabola)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_orientacao
            // 
            this.label_orientacao.AutoSize = true;
            this.label_orientacao.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orientacao.Location = new System.Drawing.Point(14, 84);
            this.label_orientacao.Name = "label_orientacao";
            this.label_orientacao.Size = new System.Drawing.Size(619, 26);
            this.label_orientacao.TabIndex = 27;
            this.label_orientacao.Text = "Digite os números e aperte o botão calcular";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Geometr415 Blk BT", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_titulo.Location = new System.Drawing.Point(57, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(639, 57);
            this.lbl_titulo.TabIndex = 26;
            this.lbl_titulo.Text = "Calcula equações de 2º grau";
            this.lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // botao_encerrar
            // 
            this.botao_encerrar.Font = new System.Drawing.Font("Geometr415 Blk BT", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_encerrar.ForeColor = System.Drawing.Color.Black;
            this.botao_encerrar.Location = new System.Drawing.Point(5, 115);
            this.botao_encerrar.Name = "botao_encerrar";
            this.botao_encerrar.Size = new System.Drawing.Size(133, 44);
            this.botao_encerrar.TabIndex = 24;
            this.botao_encerrar.Text = "Sair";
            this.botao_encerrar.UseVisualStyleBackColor = true;
            this.botao_encerrar.Click += new System.EventHandler(this.Botao_encerrar_Click);
            // 
            // botao_limpar
            // 
            this.botao_limpar.Font = new System.Drawing.Font("Geometr415 Blk BT", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_limpar.ForeColor = System.Drawing.Color.Black;
            this.botao_limpar.Location = new System.Drawing.Point(6, 65);
            this.botao_limpar.Name = "botao_limpar";
            this.botao_limpar.Size = new System.Drawing.Size(132, 44);
            this.botao_limpar.TabIndex = 23;
            this.botao_limpar.Text = "Limpar";
            this.botao_limpar.UseVisualStyleBackColor = true;
            this.botao_limpar.Click += new System.EventHandler(this.botao_limpar_Click);
            // 
            // botao_calcular
            // 
            this.botao_calcular.Font = new System.Drawing.Font("Geometr415 Blk BT", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_calcular.ForeColor = System.Drawing.Color.Black;
            this.botao_calcular.Location = new System.Drawing.Point(7, 17);
            this.botao_calcular.Name = "botao_calcular";
            this.botao_calcular.Size = new System.Drawing.Size(132, 42);
            this.botao_calcular.TabIndex = 22;
            this.botao_calcular.Text = "Calcular";
            this.botao_calcular.UseVisualStyleBackColor = true;
            this.botao_calcular.Click += new System.EventHandler(this.Botao_calcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geometr212 BkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "+";
            // 
            // lbl_mais
            // 
            this.lbl_mais.AutoSize = true;
            this.lbl_mais.Font = new System.Drawing.Font("Geometr212 BkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mais.Location = new System.Drawing.Point(89, 18);
            this.lbl_mais.Name = "lbl_mais";
            this.lbl_mais.Size = new System.Drawing.Size(37, 33);
            this.lbl_mais.TabIndex = 19;
            this.lbl_mais.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometr212 BkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometr212 BkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "X²";
            // 
            // lbl_parabola
            // 
            this.lbl_parabola.AutoSize = true;
            this.lbl_parabola.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parabola.Location = new System.Drawing.Point(269, 257);
            this.lbl_parabola.Name = "lbl_parabola";
            this.lbl_parabola.Size = new System.Drawing.Size(0, 18);
            this.lbl_parabola.TabIndex = 34;
            // 
            // lbl_delta
            // 
            this.lbl_delta.AutoSize = true;
            this.lbl_delta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delta.Location = new System.Drawing.Point(19, 34);
            this.lbl_delta.Name = "lbl_delta";
            this.lbl_delta.Size = new System.Drawing.Size(0, 31);
            this.lbl_delta.TabIndex = 35;
            // 
            // lbl_raizes
            // 
            this.lbl_raizes.AutoSize = true;
            this.lbl_raizes.Location = new System.Drawing.Point(6, 50);
            this.lbl_raizes.Name = "lbl_raizes";
            this.lbl_raizes.Size = new System.Drawing.Size(0, 13);
            this.lbl_raizes.TabIndex = 37;
            // 
            // ctx_a
            // 
            this.ctx_a.Font = new System.Drawing.Font("Geometr212 BkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_a.Location = new System.Drawing.Point(12, 16);
            this.ctx_a.Name = "ctx_a";
            this.ctx_a.Size = new System.Drawing.Size(36, 41);
            this.ctx_a.TabIndex = 38;
            this.ctx_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctx_a.TextChanged += new System.EventHandler(this.ctx_a_TextChanged_1);
            // 
            // ctx_b
            // 
            this.ctx_b.Font = new System.Drawing.Font("Geometr212 BkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_b.Location = new System.Drawing.Point(132, 17);
            this.ctx_b.Name = "ctx_b";
            this.ctx_b.Size = new System.Drawing.Size(36, 41);
            this.ctx_b.TabIndex = 39;
            this.ctx_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctx_b.TextChanged += new System.EventHandler(this.ctx_b_TextChanged_1);
            // 
            // ctx_c
            // 
            this.ctx_c.Font = new System.Drawing.Font("Geometr212 BkCn BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_c.Location = new System.Drawing.Point(240, 16);
            this.ctx_c.Name = "ctx_c";
            this.ctx_c.Size = new System.Drawing.Size(36, 41);
            this.ctx_c.TabIndex = 40;
            this.ctx_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctx_c.TextChanged += new System.EventHandler(this.ctx_c_TextChanged_1);
            // 
            // ctx_x1
            // 
            this.ctx_x1.Enabled = false;
            this.ctx_x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_x1.Location = new System.Drawing.Point(9, 50);
            this.ctx_x1.Name = "ctx_x1";
            this.ctx_x1.Size = new System.Drawing.Size(122, 31);
            this.ctx_x1.TabIndex = 41;
            this.ctx_x1.TextChanged += new System.EventHandler(this.ctx_x1_TextChanged);
            // 
            // ctx_x2
            // 
            this.ctx_x2.Enabled = false;
            this.ctx_x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_x2.Location = new System.Drawing.Point(9, 92);
            this.ctx_x2.Name = "ctx_x2";
            this.ctx_x2.Size = new System.Drawing.Size(122, 31);
            this.ctx_x2.TabIndex = 42;
            // 
            // ctx_x
            // 
            this.ctx_x.Enabled = false;
            this.ctx_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_x.Location = new System.Drawing.Point(10, 39);
            this.ctx_x.Name = "ctx_x";
            this.ctx_x.Size = new System.Drawing.Size(304, 26);
            this.ctx_x.TabIndex = 43;
            this.ctx_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctx_x.TextChanged += new System.EventHandler(this.ctx_vertice_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "RAÍZES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "VÉRTICES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "DELTA";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botao_encerrar);
            this.groupBox1.Controls.Add(this.botao_calcular);
            this.groupBox1.Controls.Add(this.botao_limpar);
            this.groupBox1.Location = new System.Drawing.Point(506, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 171);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctx_c);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_mais);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ctx_a);
            this.groupBox2.Controls.Add(this.ctx_b);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 63);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ctx_x1);
            this.groupBox3.Controls.Add(this.lbl_raizes);
            this.groupBox3.Controls.Add(this.ctx_x2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(330, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 137);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lbl_delta);
            this.groupBox4.Location = new System.Drawing.Point(330, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 76);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            // 
            // img_parabola
            // 
            this.img_parabola.Image = global::Multiplos_certo.Properties.Resources.Branco1;
            this.img_parabola.Location = new System.Drawing.Point(28, 101);
            this.img_parabola.Name = "img_parabola";
            this.img_parabola.Size = new System.Drawing.Size(264, 172);
            this.img_parabola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_parabola.TabIndex = 25;
            this.img_parabola.TabStop = false;
            this.img_parabola.Click += new System.EventHandler(this.img_parabola_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ctx_y);
            this.groupBox5.Controls.Add(this.ctx_x);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(330, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 108);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ctx_sentido);
            this.groupBox6.Controls.Add(this.ctx_raizes);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.img_parabola);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Location = new System.Drawing.Point(19, 125);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(677, 368);
            this.groupBox6.TabIndex = 52;
            this.groupBox6.TabStop = false;
            // 
            // ctx_raizes
            // 
            this.ctx_raizes.Enabled = false;
            this.ctx_raizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_raizes.Location = new System.Drawing.Point(28, 288);
            this.ctx_raizes.Name = "ctx_raizes";
            this.ctx_raizes.Size = new System.Drawing.Size(264, 29);
            this.ctx_raizes.TabIndex = 52;
            this.ctx_raizes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctx_y
            // 
            this.ctx_y.Enabled = false;
            this.ctx_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_y.Location = new System.Drawing.Point(10, 71);
            this.ctx_y.Name = "ctx_y";
            this.ctx_y.Size = new System.Drawing.Size(304, 26);
            this.ctx_y.TabIndex = 46;
            this.ctx_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctx_sentido
            // 
            this.ctx_sentido.Enabled = false;
            this.ctx_sentido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_sentido.Location = new System.Drawing.Point(28, 325);
            this.ctx_sentido.Name = "ctx_sentido";
            this.ctx_sentido.Size = new System.Drawing.Size(264, 29);
            this.ctx_sentido.TabIndex = 53;
            this.ctx_sentido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Equação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 499);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.lbl_parabola);
            this.Controls.Add(this.label_orientacao);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Equação";
            this.Text = "Equação de 2º grau";
            this.Load += new System.EventHandler(this.Equação_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_parabola)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_orientacao;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox img_parabola;
        private System.Windows.Forms.Button botao_encerrar;
        private System.Windows.Forms.Button botao_limpar;
        private System.Windows.Forms.Button botao_calcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_parabola;
        private System.Windows.Forms.Label lbl_delta;
        private System.Windows.Forms.Label lbl_raizes;
        private System.Windows.Forms.TextBox ctx_a;
        private System.Windows.Forms.TextBox ctx_b;
        private System.Windows.Forms.TextBox ctx_c;
        private System.Windows.Forms.TextBox ctx_x1;
        private System.Windows.Forms.TextBox ctx_x2;
        private System.Windows.Forms.TextBox ctx_x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox ctx_raizes;
        private System.Windows.Forms.TextBox ctx_y;
        private System.Windows.Forms.TextBox ctx_sentido;
    }
}


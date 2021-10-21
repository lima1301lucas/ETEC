namespace Multiplos_certo
{
    partial class FormRodizio
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.ctx_a = new System.Windows.Forms.TextBox();
            this.lbl_orientacao_placa = new System.Windows.Forms.Label();
            this.btn_rodizio = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_orientacao_resultado = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r0 = new System.Windows.Forms.RadioButton();
            this.r9 = new System.Windows.Forms.RadioButton();
            this.r8 = new System.Windows.Forms.RadioButton();
            this.r7 = new System.Windows.Forms.RadioButton();
            this.r6 = new System.Windows.Forms.RadioButton();
            this.r5 = new System.Windows.Forms.RadioButton();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Geometr415 Blk BT", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_titulo.Location = new System.Drawing.Point(69, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(670, 57);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Rodízio veicular em São Paulo";
            // 
            // ctx_a
            // 
            this.ctx_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctx_a.Location = new System.Drawing.Point(13, 19);
            this.ctx_a.Name = "ctx_a";
            this.ctx_a.Size = new System.Drawing.Size(45, 38);
            this.ctx_a.TabIndex = 1;
            this.ctx_a.TextChanged += new System.EventHandler(this.ctx_placa_TextChanged);
            // 
            // lbl_orientacao_placa
            // 
            this.lbl_orientacao_placa.AutoSize = true;
            this.lbl_orientacao_placa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orientacao_placa.Location = new System.Drawing.Point(27, 94);
            this.lbl_orientacao_placa.Name = "lbl_orientacao_placa";
            this.lbl_orientacao_placa.Size = new System.Drawing.Size(587, 18);
            this.lbl_orientacao_placa.TabIndex = 2;
            this.lbl_orientacao_placa.Text = "Digite o último número da placa do seu carro ou clique nos botões e aperte avança" +
    "r";
            // 
            // btn_rodizio
            // 
            this.btn_rodizio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rodizio.ForeColor = System.Drawing.Color.Black;
            this.btn_rodizio.Location = new System.Drawing.Point(66, 19);
            this.btn_rodizio.Name = "btn_rodizio";
            this.btn_rodizio.Size = new System.Drawing.Size(83, 37);
            this.btn_rodizio.TabIndex = 3;
            this.btn_rodizio.Text = "Avançar";
            this.btn_rodizio.UseVisualStyleBackColor = true;
            this.btn_rodizio.Click += new System.EventHandler(this.btn_rodizio_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(155, 19);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(86, 37);
            this.btn_Limpar.TabIndex = 4;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Black;
            this.btn_sair.Location = new System.Drawing.Point(628, 244);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(99, 37);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_orientacao_resultado
            // 
            this.lbl_orientacao_resultado.AutoSize = true;
            this.lbl_orientacao_resultado.Font = new System.Drawing.Font("Geometr415 Blk BT", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orientacao_resultado.Location = new System.Drawing.Point(5, 23);
            this.lbl_orientacao_resultado.Name = "lbl_orientacao_resultado";
            this.lbl_orientacao_resultado.Size = new System.Drawing.Size(229, 22);
            this.lbl_orientacao_resultado.TabIndex = 6;
            this.lbl_orientacao_resultado.Text = "O rodízio do seu veículo é:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.Red;
            this.lbl_resultado.Location = new System.Drawing.Point(252, 25);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(131, 25);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "Dia da semana";
            this.lbl_resultado.Click += new System.EventHandler(this.lbl_resultado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r0);
            this.groupBox1.Controls.Add(this.r9);
            this.groupBox1.Controls.Add(this.r8);
            this.groupBox1.Controls.Add(this.r7);
            this.groupBox1.Controls.Add(this.r6);
            this.groupBox1.Controls.Add(this.r5);
            this.groupBox1.Controls.Add(this.r4);
            this.groupBox1.Controls.Add(this.r3);
            this.groupBox1.Controls.Add(this.r2);
            this.groupBox1.Controls.Add(this.r1);
            this.groupBox1.Location = new System.Drawing.Point(30, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // r0
            // 
            this.r0.AutoSize = true;
            this.r0.Location = new System.Drawing.Point(210, 53);
            this.r0.Name = "r0";
            this.r0.Size = new System.Drawing.Size(31, 17);
            this.r0.TabIndex = 20;
            this.r0.TabStop = true;
            this.r0.Text = "0";
            this.r0.UseVisualStyleBackColor = true;
            this.r0.CheckedChanged += new System.EventHandler(this.R0_CheckedChanged);
            // 
            // r9
            // 
            this.r9.AutoSize = true;
            this.r9.Location = new System.Drawing.Point(164, 53);
            this.r9.Name = "r9";
            this.r9.Size = new System.Drawing.Size(31, 17);
            this.r9.TabIndex = 19;
            this.r9.TabStop = true;
            this.r9.Text = "9";
            this.r9.UseVisualStyleBackColor = true;
            this.r9.CheckedChanged += new System.EventHandler(this.R9_CheckedChanged);
            // 
            // r8
            // 
            this.r8.AutoSize = true;
            this.r8.Location = new System.Drawing.Point(118, 53);
            this.r8.Name = "r8";
            this.r8.Size = new System.Drawing.Size(31, 17);
            this.r8.TabIndex = 18;
            this.r8.TabStop = true;
            this.r8.Text = "8";
            this.r8.UseVisualStyleBackColor = true;
            this.r8.CheckedChanged += new System.EventHandler(this.R8_CheckedChanged);
            // 
            // r7
            // 
            this.r7.AutoSize = true;
            this.r7.Location = new System.Drawing.Point(66, 53);
            this.r7.Name = "r7";
            this.r7.Size = new System.Drawing.Size(31, 17);
            this.r7.TabIndex = 17;
            this.r7.TabStop = true;
            this.r7.Text = "7";
            this.r7.UseVisualStyleBackColor = true;
            this.r7.CheckedChanged += new System.EventHandler(this.R7_CheckedChanged);
            // 
            // r6
            // 
            this.r6.AutoSize = true;
            this.r6.Location = new System.Drawing.Point(13, 53);
            this.r6.Name = "r6";
            this.r6.Size = new System.Drawing.Size(31, 17);
            this.r6.TabIndex = 16;
            this.r6.TabStop = true;
            this.r6.Text = "6";
            this.r6.UseVisualStyleBackColor = true;
            this.r6.CheckedChanged += new System.EventHandler(this.R6_CheckedChanged);
            // 
            // r5
            // 
            this.r5.AutoSize = true;
            this.r5.Location = new System.Drawing.Point(210, 19);
            this.r5.Name = "r5";
            this.r5.Size = new System.Drawing.Size(31, 17);
            this.r5.TabIndex = 15;
            this.r5.TabStop = true;
            this.r5.Text = "5";
            this.r5.UseVisualStyleBackColor = true;
            this.r5.CheckedChanged += new System.EventHandler(this.R5_CheckedChanged);
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Location = new System.Drawing.Point(164, 19);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(31, 17);
            this.r4.TabIndex = 14;
            this.r4.TabStop = true;
            this.r4.Text = "4";
            this.r4.UseVisualStyleBackColor = true;
            this.r4.CheckedChanged += new System.EventHandler(this.R4_CheckedChanged);
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(118, 19);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(31, 17);
            this.r3.TabIndex = 13;
            this.r3.TabStop = true;
            this.r3.Text = "3";
            this.r3.UseVisualStyleBackColor = true;
            this.r3.CheckedChanged += new System.EventHandler(this.R3_CheckedChanged);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(66, 19);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(31, 17);
            this.r2.TabIndex = 12;
            this.r2.TabStop = true;
            this.r2.Text = "2";
            this.r2.UseVisualStyleBackColor = true;
            this.r2.CheckedChanged += new System.EventHandler(this.R2_CheckedChanged);
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(13, 19);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(31, 17);
            this.r1.TabIndex = 11;
            this.r1.TabStop = true;
            this.r1.Text = "1";
            this.r1.UseVisualStyleBackColor = true;
            this.r1.CheckedChanged += new System.EventHandler(this.R1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Limpar);
            this.groupBox2.Controls.Add(this.ctx_a);
            this.groupBox2.Controls.Add(this.btn_rodizio);
            this.groupBox2.Location = new System.Drawing.Point(30, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 71);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_resultado);
            this.groupBox3.Controls.Add(this.lbl_orientacao_resultado);
            this.groupBox3.Location = new System.Drawing.Point(310, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 71);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // frmRodizio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 302);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_orientacao_placa);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frmRodizio";
            this.Text = "Rodízio veicular na cidade de São Paulo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox ctx_a;
        private System.Windows.Forms.Label lbl_orientacao_placa;
        private System.Windows.Forms.Button btn_rodizio;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_orientacao_resultado;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton r0;
        private System.Windows.Forms.RadioButton r9;
        private System.Windows.Forms.RadioButton r8;
        private System.Windows.Forms.RadioButton r7;
        private System.Windows.Forms.RadioButton r6;
        private System.Windows.Forms.RadioButton r5;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
    }
}
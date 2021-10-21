namespace exemplo
{
    partial class Incluir
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.Data_Nasc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mae = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(68, 50);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(471, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // Data_Nasc
            // 
            this.Data_Nasc.Location = new System.Drawing.Point(134, 92);
            this.Data_Nasc.Name = "Data_Nasc";
            this.Data_Nasc.Size = new System.Drawing.Size(200, 20);
            this.Data_Nasc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de nascimento";
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(428, 96);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(34, 17);
            this.Masculino.TabIndex = 4;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "M";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Location = new System.Drawing.Point(486, 96);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(31, 17);
            this.Feminino.TabIndex = 5;
            this.Feminino.TabStop = true;
            this.Feminino.Text = "F";
            this.Feminino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RG";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(41, 176);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(194, 20);
            this.txt_rg.TabIndex = 7;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(270, 176);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(240, 20);
            this.txt_cpf.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            // 
            // txt_pai
            // 
            this.txt_pai.Location = new System.Drawing.Point(270, 246);
            this.txt_pai.Name = "txt_pai";
            this.txt_pai.Size = new System.Drawing.Size(247, 20);
            this.txt_pai.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome pai";
            // 
            // txt_mae
            // 
            this.txt_mae.Location = new System.Drawing.Point(41, 246);
            this.txt_mae.Name = "txt_mae";
            this.txt_mae.Size = new System.Drawing.Size(194, 20);
            this.txt_mae.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome mãe";
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(41, 314);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(194, 23);
            this.btn_gravar.TabIndex = 14;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(270, 314);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(247, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(234, 12);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 16;
            this.txt_codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Incluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 365);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_pai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_mae);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Feminino);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Data_Nasc);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Incluir";
            this.Text = "Incluir";
            this.Load += new System.EventHandler(this.Incluir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.DateTimePicker Data_Nasc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.RadioButton Feminino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mae;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_codigo;
    }
}
namespace cadastro
{
    partial class Form2
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.Datanasc = new System.Windows.Forms.DateTimePicker();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.rdbmasc = new System.Windows.Forms.RadioButton();
            this.rdbfemi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmae = new System.Windows.Forms.TextBox();
            this.txtpai = new System.Windows.Forms.TextBox();
            this.cmdgravar = new System.Windows.Forms.Button();
            this.cmdcancelar = new System.Windows.Forms.Button();
            this.lcodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(12, 36);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(200, 20);
            this.txtnome.TabIndex = 0;
            // 
            // Datanasc
            // 
            this.Datanasc.Location = new System.Drawing.Point(12, 80);
            this.Datanasc.Name = "Datanasc";
            this.Datanasc.Size = new System.Drawing.Size(200, 20);
            this.Datanasc.TabIndex = 1;
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(12, 138);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(200, 20);
            this.txtrg.TabIndex = 2;
            this.txtrg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(230, 138);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(176, 20);
            this.txtcpf.TabIndex = 3;
            // 
            // rdbmasc
            // 
            this.rdbmasc.AutoSize = true;
            this.rdbmasc.Location = new System.Drawing.Point(248, 84);
            this.rdbmasc.Name = "rdbmasc";
            this.rdbmasc.Size = new System.Drawing.Size(73, 17);
            this.rdbmasc.TabIndex = 4;
            this.rdbmasc.TabStop = true;
            this.rdbmasc.Text = "Masculino";
            this.rdbmasc.UseVisualStyleBackColor = true;
            // 
            // rdbfemi
            // 
            this.rdbfemi.AutoSize = true;
            this.rdbfemi.Location = new System.Drawing.Point(353, 84);
            this.rdbfemi.Name = "rdbfemi";
            this.rdbfemi.Size = new System.Drawing.Size(67, 17);
            this.rdbfemi.TabIndex = 5;
            this.rdbfemi.TabStop = true;
            this.rdbfemi.Text = "Feminino";
            this.rdbfemi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome do Pai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome da Mãe";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtmae
            // 
            this.txtmae.Location = new System.Drawing.Point(12, 209);
            this.txtmae.Name = "txtmae";
            this.txtmae.Size = new System.Drawing.Size(200, 20);
            this.txtmae.TabIndex = 12;
            // 
            // txtpai
            // 
            this.txtpai.Location = new System.Drawing.Point(230, 211);
            this.txtpai.Name = "txtpai";
            this.txtpai.Size = new System.Drawing.Size(176, 20);
            this.txtpai.TabIndex = 13;
            // 
            // cmdgravar
            // 
            this.cmdgravar.Location = new System.Drawing.Point(218, 251);
            this.cmdgravar.Name = "cmdgravar";
            this.cmdgravar.Size = new System.Drawing.Size(75, 23);
            this.cmdgravar.TabIndex = 14;
            this.cmdgravar.Text = "Gravar";
            this.cmdgravar.UseVisualStyleBackColor = true;
            this.cmdgravar.Click += new System.EventHandler(this.cmdgravar_Click);
            // 
            // cmdcancelar
            // 
            this.cmdcancelar.Location = new System.Drawing.Point(331, 251);
            this.cmdcancelar.Name = "cmdcancelar";
            this.cmdcancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdcancelar.TabIndex = 15;
            this.cmdcancelar.Text = "Cancelar";
            this.cmdcancelar.UseVisualStyleBackColor = true;
            this.cmdcancelar.Click += new System.EventHandler(this.cmdcancelar_Click);
            // 
            // lcodigo
            // 
            this.lcodigo.Location = new System.Drawing.Point(20, 235);
            this.lcodigo.Name = "lcodigo";
            this.lcodigo.Size = new System.Drawing.Size(100, 20);
            this.lcodigo.TabIndex = 16;
            this.lcodigo.Text = "0";
            this.lcodigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 324);
            this.Controls.Add(this.lcodigo);
            this.Controls.Add(this.cmdcancelar);
            this.Controls.Add(this.cmdgravar);
            this.Controls.Add(this.txtpai);
            this.Controls.Add(this.txtmae);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbfemi);
            this.Controls.Add(this.rdbmasc);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.Datanasc);
            this.Controls.Add(this.txtnome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.DateTimePicker Datanasc;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.RadioButton rdbmasc;
        private System.Windows.Forms.RadioButton rdbfemi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmae;
        private System.Windows.Forms.TextBox txtpai;
        private System.Windows.Forms.Button cmdgravar;
        private System.Windows.Forms.Button cmdcancelar;
        private System.Windows.Forms.TextBox lcodigo;
    }
}
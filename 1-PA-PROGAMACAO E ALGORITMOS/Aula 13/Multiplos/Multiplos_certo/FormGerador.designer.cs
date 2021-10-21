namespace Multiplos_certo
{
    partial class FormGerador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ltbpares = new System.Windows.Forms.ListBox();
            this.btnPares = new System.Windows.Forms.Button();
            this.ctxPares = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImpares = new System.Windows.Forms.Button();
            this.ltbImpares = new System.Windows.Forms.ListBox();
            this.ctxImpares = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ctxMultiplo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMultiplos = new System.Windows.Forms.Button();
            this.ltbMultiplos = new System.Windows.Forms.ListBox();
            this.ctxMultiPartir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ltbpares);
            this.groupBox1.Controls.Add(this.btnPares);
            this.groupBox1.Controls.Add(this.ctxPares);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Números Pares";
            // 
            // ltbpares
            // 
            this.ltbpares.FormattingEnabled = true;
            this.ltbpares.HorizontalScrollbar = true;
            this.ltbpares.ItemHeight = 18;
            this.ltbpares.Location = new System.Drawing.Point(21, 96);
            this.ltbpares.Name = "ltbpares";
            this.ltbpares.Size = new System.Drawing.Size(239, 328);
            this.ltbpares.TabIndex = 5;
            // 
            // btnPares
            // 
            this.btnPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPares.Location = new System.Drawing.Point(81, 60);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(120, 30);
            this.btnPares.TabIndex = 4;
            this.btnPares.Text = "Gerar Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // ctxPares
            // 
            this.ctxPares.Location = new System.Drawing.Point(102, 30);
            this.ctxPares.Name = "ctxPares";
            this.ctxPares.Size = new System.Drawing.Size(36, 24);
            this.ctxPares.TabIndex = 3;
            this.ctxPares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctxPares.TextChanged += new System.EventHandler(this.ctxPares_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "A partir de:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometr415 Blk BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerador de números pares, ímpares e múltiplos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImpares);
            this.groupBox2.Controls.Add(this.ltbImpares);
            this.groupBox2.Controls.Add(this.ctxImpares);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(299, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 442);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Números Impares";
            // 
            // btnImpares
            // 
            this.btnImpares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpares.Location = new System.Drawing.Point(81, 60);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(120, 30);
            this.btnImpares.TabIndex = 4;
            this.btnImpares.Text = "Gerar Ímpares";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
            // 
            // ltbImpares
            // 
            this.ltbImpares.FormattingEnabled = true;
            this.ltbImpares.HorizontalScrollbar = true;
            this.ltbImpares.ItemHeight = 18;
            this.ltbImpares.Location = new System.Drawing.Point(21, 96);
            this.ltbImpares.Name = "ltbImpares";
            this.ltbImpares.Size = new System.Drawing.Size(239, 328);
            this.ltbImpares.TabIndex = 2;
            // 
            // ctxImpares
            // 
            this.ctxImpares.Location = new System.Drawing.Point(102, 30);
            this.ctxImpares.Name = "ctxImpares";
            this.ctxImpares.Size = new System.Drawing.Size(36, 24);
            this.ctxImpares.TabIndex = 3;
            this.ctxImpares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctxImpares.TextChanged += new System.EventHandler(this.ctxImpares_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "A partir de:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ctxMultiplo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnMultiplos);
            this.groupBox3.Controls.Add(this.ltbMultiplos);
            this.groupBox3.Controls.Add(this.ctxMultiPartir);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(584, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 442);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Números Multiplos";
            // 
            // ctxMultiplo
            // 
            this.ctxMultiplo.Location = new System.Drawing.Point(90, 30);
            this.ctxMultiplo.Name = "ctxMultiplo";
            this.ctxMultiplo.Size = new System.Drawing.Size(36, 24);
            this.ctxMultiplo.TabIndex = 6;
            this.ctxMultiplo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctxMultiplo.TextChanged += new System.EventHandler(this.ctxMultiplo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Multiplo de:";
            // 
            // btnMultiplos
            // 
            this.btnMultiplos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplos.Location = new System.Drawing.Point(81, 60);
            this.btnMultiplos.Name = "btnMultiplos";
            this.btnMultiplos.Size = new System.Drawing.Size(120, 30);
            this.btnMultiplos.TabIndex = 4;
            this.btnMultiplos.Text = "Gerar Multiplos";
            this.btnMultiplos.UseVisualStyleBackColor = true;
            this.btnMultiplos.Click += new System.EventHandler(this.btnMultiplos_Click);
            // 
            // ltbMultiplos
            // 
            this.ltbMultiplos.FormattingEnabled = true;
            this.ltbMultiplos.HorizontalScrollbar = true;
            this.ltbMultiplos.ItemHeight = 18;
            this.ltbMultiplos.Location = new System.Drawing.Point(21, 96);
            this.ltbMultiplos.Name = "ltbMultiplos";
            this.ltbMultiplos.Size = new System.Drawing.Size(239, 328);
            this.ltbMultiplos.TabIndex = 2;
            // 
            // ctxMultiPartir
            // 
            this.ctxMultiPartir.Location = new System.Drawing.Point(224, 30);
            this.ctxMultiPartir.Name = "ctxMultiPartir";
            this.ctxMultiPartir.Size = new System.Drawing.Size(36, 24);
            this.ctxMultiPartir.TabIndex = 3;
            this.ctxMultiPartir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctxMultiPartir.TextChanged += new System.EventHandler(this.ctxMultiPartir_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "A partir de:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(744, 550);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 31);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.Location = new System.Drawing.Point(605, 550);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(121, 31);
            this.btnLimp.TabIndex = 9;
            this.btnLimp.Text = "Limpar ";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // FormGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 593);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGerador";
            this.Text = "Gerador de Números";
            this.Load += new System.EventHandler(this.FormGerador_Load);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.TextBox ctxPares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImpares;
        private System.Windows.Forms.ListBox ltbImpares;
        private System.Windows.Forms.TextBox ctxImpares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ctxMultiplo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMultiplos;
        private System.Windows.Forms.ListBox ltbMultiplos;
        private System.Windows.Forms.TextBox ctxMultiPartir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.ListBox ltbpares;
    }
}
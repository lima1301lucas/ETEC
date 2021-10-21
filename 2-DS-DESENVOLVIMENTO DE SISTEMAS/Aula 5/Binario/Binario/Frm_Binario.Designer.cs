namespace Binario
{
    partial class Frm_Binario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_letra = new System.Windows.Forms.TextBox();
            this.btn_binario = new System.Windows.Forms.Button();
            this.btn_ascii = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_binario = new System.Windows.Forms.Label();
            this.lbl_ascii = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_letra
            // 
            this.txt_letra.Location = new System.Drawing.Point(117, 66);
            this.txt_letra.MaxLength = 1;
            this.txt_letra.Name = "txt_letra";
            this.txt_letra.Size = new System.Drawing.Size(148, 20);
            this.txt_letra.TabIndex = 0;
            // 
            // btn_binario
            // 
            this.btn_binario.Location = new System.Drawing.Point(27, 103);
            this.btn_binario.Name = "btn_binario";
            this.btn_binario.Size = new System.Drawing.Size(148, 40);
            this.btn_binario.TabIndex = 1;
            this.btn_binario.Text = "BINÁRIO";
            this.btn_binario.UseVisualStyleBackColor = true;
            this.btn_binario.Click += new System.EventHandler(this.Btn_binario_Click);
            // 
            // btn_ascii
            // 
            this.btn_ascii.Location = new System.Drawing.Point(197, 103);
            this.btn_ascii.Name = "btn_ascii";
            this.btn_ascii.Size = new System.Drawing.Size(148, 40);
            this.btn_ascii.TabIndex = 2;
            this.btn_ascii.Text = "ASCII";
            this.btn_ascii.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite uma letra";
            // 
            // lbl_binario
            // 
            this.lbl_binario.AutoSize = true;
            this.lbl_binario.Location = new System.Drawing.Point(91, 163);
            this.lbl_binario.Name = "lbl_binario";
            this.lbl_binario.Size = new System.Drawing.Size(16, 13);
            this.lbl_binario.TabIndex = 4;
            this.lbl_binario.Text = "...";
            // 
            // lbl_ascii
            // 
            this.lbl_ascii.AutoSize = true;
            this.lbl_ascii.Location = new System.Drawing.Point(260, 163);
            this.lbl_ascii.Name = "lbl_ascii";
            this.lbl_ascii.Size = new System.Drawing.Size(16, 13);
            this.lbl_ascii.TabIndex = 5;
            this.lbl_ascii.Text = "...";
            // 
            // Frm_Binario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 198);
            this.Controls.Add(this.lbl_ascii);
            this.Controls.Add(this.lbl_binario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ascii);
            this.Controls.Add(this.btn_binario);
            this.Controls.Add(this.txt_letra);
            this.Name = "Frm_Binario";
            this.Text = "Transforma letra em binário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_letra;
        private System.Windows.Forms.Button btn_binario;
        private System.Windows.Forms.Button btn_ascii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_binario;
        private System.Windows.Forms.Label lbl_ascii;
    }
}


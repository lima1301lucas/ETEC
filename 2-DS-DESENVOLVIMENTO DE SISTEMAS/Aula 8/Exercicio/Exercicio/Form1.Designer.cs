namespace Exercicio
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
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.Pn_letra = new System.Windows.Forms.Panel();
            this.btn_avancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(34, 12);
            this.txt_valor.MaxLength = 1;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 0;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // Pn_letra
            // 
            this.Pn_letra.Location = new System.Drawing.Point(34, 52);
            this.Pn_letra.Name = "Pn_letra";
            this.Pn_letra.Size = new System.Drawing.Size(250, 300);
            this.Pn_letra.TabIndex = 1;
            this.Pn_letra.Paint += new System.Windows.Forms.PaintEventHandler(this.Pn_letra_Paint);
            // 
            // btn_avancar
            // 
            this.btn_avancar.Location = new System.Drawing.Point(154, 10);
            this.btn_avancar.Name = "btn_avancar";
            this.btn_avancar.Size = new System.Drawing.Size(92, 23);
            this.btn_avancar.TabIndex = 0;
            this.btn_avancar.Text = "Transformar";
            this.btn_avancar.UseVisualStyleBackColor = true;
            this.btn_avancar.Click += new System.EventHandler(this.btn_avancar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 574);
            this.Controls.Add(this.btn_avancar);
            this.Controls.Add(this.Pn_letra);
            this.Controls.Add(this.txt_valor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Panel Pn_letra;
        private System.Windows.Forms.Button btn_avancar;
    }
}


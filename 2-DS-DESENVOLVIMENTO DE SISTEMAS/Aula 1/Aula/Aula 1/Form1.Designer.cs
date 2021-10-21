namespace Aula_1
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
            this.ctx_texto = new System.Windows.Forms.TextBox();
            this.btn_avancar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblqtde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctx_texto
            // 
            this.ctx_texto.Location = new System.Drawing.Point(134, 125);
            this.ctx_texto.MaxLength = 500;
            this.ctx_texto.Name = "ctx_texto";
            this.ctx_texto.Size = new System.Drawing.Size(100, 20);
            this.ctx_texto.TabIndex = 0;
            this.ctx_texto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctx_texto_KeyDown);
            this.ctx_texto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctx_texto_KeyUp);
            // 
            // btn_avancar
            // 
            this.btn_avancar.Location = new System.Drawing.Point(279, 122);
            this.btn_avancar.Name = "btn_avancar";
            this.btn_avancar.Size = new System.Drawing.Size(75, 23);
            this.btn_avancar.TabIndex = 1;
            this.btn_avancar.Text = "Avançar";
            this.btn_avancar.UseVisualStyleBackColor = true;
            this.btn_avancar.Click += new System.EventHandler(this.btn_avancar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(245, 22);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(219, 28);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Digite alguma coisa :)";
            // 
            // lblqtde
            // 
            this.lblqtde.AutoSize = true;
            this.lblqtde.Font = new System.Drawing.Font("Open Sans", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtde.Location = new System.Drawing.Point(43, 217);
            this.lblqtde.Name = "lblqtde";
            this.lblqtde.Size = new System.Drawing.Size(155, 55);
            this.lblqtde.TabIndex = 3;
            this.lblqtde.Text = "lblqtde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 296);
            this.Controls.Add(this.lblqtde);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_avancar);
            this.Controls.Add(this.ctx_texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctx_texto;
        private System.Windows.Forms.Button btn_avancar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblqtde;
    }
}


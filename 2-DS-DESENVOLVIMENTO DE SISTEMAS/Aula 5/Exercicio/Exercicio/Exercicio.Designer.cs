namespace Exercicio
{
    partial class Exercicio
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
            this.btn_mes = new System.Windows.Forms.Button();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.Trb_m = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_m)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um numero de 1 até 12";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_mes
            // 
            this.btn_mes.Location = new System.Drawing.Point(42, 80);
            this.btn_mes.Name = "btn_mes";
            this.btn_mes.Size = new System.Drawing.Size(116, 55);
            this.btn_mes.TabIndex = 1;
            this.btn_mes.Text = "Mês atual";
            this.btn_mes.UseVisualStyleBackColor = true;
            this.btn_mes.Click += new System.EventHandler(this.btn_btn_Click);
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(79, 46);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(100, 20);
            this.txt_mes.TabIndex = 2;
            // 
            // Trb_m
            // 
            this.Trb_m.Location = new System.Drawing.Point(42, 166);
            this.Trb_m.Maximum = 11;
            this.Trb_m.Name = "Trb_m";
            this.Trb_m.Size = new System.Drawing.Size(104, 45);
            this.Trb_m.TabIndex = 3;
            this.Trb_m.Value = 1;
            this.Trb_m.Scroll += new System.EventHandler(this.Trb_m_Scroll);
            // 
            // Exercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 223);
            this.Controls.Add(this.Trb_m);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.btn_mes);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio";
            this.Text = "Exercício";
            ((System.ComponentModel.ISupportInitialize)(this.Trb_m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mes;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.TrackBar Trb_m;
    }
}


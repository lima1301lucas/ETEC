namespace ExercícioCheque
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_extenso = new System.Windows.Forms.Label();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.btn_dia = new System.Windows.Forms.Button();
            this.btn_mes = new System.Windows.Forms.Button();
            this.btn_ano = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(658, 23);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(95, 20);
            this.txt_valor.TabIndex = 0;
            this.txt_valor.TextChanged += new System.EventHandler(this.Txt_valor_TextChanged);
            this.txt_valor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_valor_KeyUp);
            // 
            // lbl_extenso
            // 
            this.lbl_extenso.AutoSize = true;
            this.lbl_extenso.Location = new System.Drawing.Point(251, 79);
            this.lbl_extenso.Name = "lbl_extenso";
            this.lbl_extenso.Size = new System.Drawing.Size(16, 13);
            this.lbl_extenso.TabIndex = 1;
            this.lbl_extenso.Text = "...";
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Location = new System.Drawing.Point(531, 127);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(16, 13);
            this.lbl_dia.TabIndex = 2;
            this.lbl_dia.Text = "...";
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Location = new System.Drawing.Point(693, 127);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(16, 13);
            this.lbl_mes.TabIndex = 3;
            this.lbl_mes.Text = "...";
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(772, 127);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(16, 13);
            this.lbl_ano.TabIndex = 4;
            this.lbl_ano.Text = "...";
            // 
            // btn_dia
            // 
            this.btn_dia.Location = new System.Drawing.Point(523, 151);
            this.btn_dia.Name = "btn_dia";
            this.btn_dia.Size = new System.Drawing.Size(36, 21);
            this.btn_dia.TabIndex = 5;
            this.btn_dia.Text = "dia";
            this.btn_dia.UseVisualStyleBackColor = true;
            this.btn_dia.Click += new System.EventHandler(this.Btn_dia_Click);
            // 
            // btn_mes
            // 
            this.btn_mes.Location = new System.Drawing.Point(673, 151);
            this.btn_mes.Name = "btn_mes";
            this.btn_mes.Size = new System.Drawing.Size(36, 21);
            this.btn_mes.TabIndex = 6;
            this.btn_mes.Text = "mês";
            this.btn_mes.UseVisualStyleBackColor = true;
            this.btn_mes.Click += new System.EventHandler(this.Btn_mes_Click);
            // 
            // btn_ano
            // 
            this.btn_ano.Location = new System.Drawing.Point(761, 152);
            this.btn_ano.Name = "btn_ano";
            this.btn_ano.Size = new System.Drawing.Size(36, 21);
            this.btn_ano.TabIndex = 7;
            this.btn_ano.Text = "ano";
            this.btn_ano.UseVisualStyleBackColor = true;
            this.btn_ano.Click += new System.EventHandler(this.Btn_ano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 299);
            this.Controls.Add(this.btn_ano);
            this.Controls.Add(this.btn_mes);
            this.Controls.Add(this.btn_dia);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.lbl_extenso);
            this.Controls.Add(this.txt_valor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_extenso;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Button btn_dia;
        private System.Windows.Forms.Button btn_mes;
        private System.Windows.Forms.Button btn_ano;
    }
}


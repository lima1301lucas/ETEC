namespace exemplo
{
    partial class Listar
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
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.DataGridView();
            this.btniserir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(21, 15);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(271, 20);
            this.txtpesquisa.TabIndex = 0;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(403, 12);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisar.TabIndex = 1;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Location = new System.Drawing.Point(21, 51);
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.Size = new System.Drawing.Size(457, 444);
            this.lista.TabIndex = 2;
            // 
            // btniserir
            // 
            this.btniserir.Location = new System.Drawing.Point(21, 513);
            this.btniserir.Name = "btniserir";
            this.btniserir.Size = new System.Drawing.Size(206, 23);
            this.btniserir.TabIndex = 3;
            this.btniserir.Text = "Inserir";
            this.btniserir.UseVisualStyleBackColor = true;
            this.btniserir.Click += new System.EventHandler(this.btniserir_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(282, 513);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(196, 23);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(303, 15);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(86, 20);
            this.txtnumero.TabIndex = 5;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 548);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btniserir);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.txtpesquisa);
            this.Name = "Listar";
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Button btniserir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox txtnumero;
    }
}
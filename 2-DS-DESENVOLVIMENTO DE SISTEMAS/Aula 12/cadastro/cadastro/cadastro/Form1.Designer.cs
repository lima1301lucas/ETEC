namespace cadastro
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.cmdincluir = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(24, 50);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(86, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "PESQUISAR";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(24, 24);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            // 
            // dt1
            // 
            this.dt1.AllowUserToAddRows = false;
            this.dt1.AllowUserToDeleteRows = false;
            this.dt1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Location = new System.Drawing.Point(-1, 104);
            this.dt1.Name = "dt1";
            this.dt1.ReadOnly = true;
            this.dt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt1.Size = new System.Drawing.Size(442, 347);
            this.dt1.TabIndex = 2;
            this.dt1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt1_CellContentClick);
            this.dt1.DoubleClick += new System.EventHandler(this.dt1_DoubleClick);
            // 
            // cmdincluir
            // 
            this.cmdincluir.Location = new System.Drawing.Point(348, 50);
            this.cmdincluir.Name = "cmdincluir";
            this.cmdincluir.Size = new System.Drawing.Size(75, 23);
            this.cmdincluir.TabIndex = 3;
            this.cmdincluir.Text = "Incluir";
            this.cmdincluir.UseVisualStyleBackColor = true;
            this.cmdincluir.Click += new System.EventHandler(this.cmdincluir_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(245, 50);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 4;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 452);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.cmdincluir);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.Button cmdincluir;
        private System.Windows.Forms.Button btnexcluir;
    }
}


namespace exemplo1
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
            this.lbl_um = new System.Windows.Forms.Label();
            this.lbl_dois = new System.Windows.Forms.Label();
            this.lbl_tres = new System.Windows.Forms.Label();
            this.btn_um = new System.Windows.Forms.Button();
            this.btn_dois = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_um
            // 
            this.lbl_um.AutoSize = true;
            this.lbl_um.Location = new System.Drawing.Point(125, 26);
            this.lbl_um.Name = "lbl_um";
            this.lbl_um.Size = new System.Drawing.Size(35, 13);
            this.lbl_um.TabIndex = 0;
            this.lbl_um.Text = "label1";
            // 
            // lbl_dois
            // 
            this.lbl_dois.AutoSize = true;
            this.lbl_dois.Location = new System.Drawing.Point(183, 26);
            this.lbl_dois.Name = "lbl_dois";
            this.lbl_dois.Size = new System.Drawing.Size(35, 13);
            this.lbl_dois.TabIndex = 1;
            this.lbl_dois.Text = "label2";
            // 
            // lbl_tres
            // 
            this.lbl_tres.AutoSize = true;
            this.lbl_tres.Location = new System.Drawing.Point(238, 26);
            this.lbl_tres.Name = "lbl_tres";
            this.lbl_tres.Size = new System.Drawing.Size(35, 13);
            this.lbl_tres.TabIndex = 2;
            this.lbl_tres.Text = "label3";
            // 
            // btn_um
            // 
            this.btn_um.Location = new System.Drawing.Point(115, 89);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(75, 23);
            this.btn_um.TabIndex = 3;
            this.btn_um.Text = "1";
            this.btn_um.UseVisualStyleBackColor = true;
            this.btn_um.Click += new System.EventHandler(this.btn_um_Click);
            // 
            // btn_dois
            // 
            this.btn_dois.Location = new System.Drawing.Point(216, 89);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(75, 23);
            this.btn_dois.TabIndex = 4;
            this.btn_dois.Text = "2";
            this.btn_dois.UseVisualStyleBackColor = true;
            this.btn_dois.Click += new System.EventHandler(this.btn_dois_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 231);
            this.Controls.Add(this.btn_dois);
            this.Controls.Add(this.btn_um);
            this.Controls.Add(this.lbl_tres);
            this.Controls.Add(this.lbl_dois);
            this.Controls.Add(this.lbl_um);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_um;
        private System.Windows.Forms.Label lbl_dois;
        private System.Windows.Forms.Label lbl_tres;
        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.Button btn_dois;
    }
}


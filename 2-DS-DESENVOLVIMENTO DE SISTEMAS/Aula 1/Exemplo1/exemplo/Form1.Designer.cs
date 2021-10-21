namespace exemplo
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
            this.lblposx = new System.Windows.Forms.Label();
            this.lblposy = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblposx
            // 
            this.lblposx.AutoSize = true;
            this.lblposx.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposx.Location = new System.Drawing.Point(41, 39);
            this.lblposx.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblposx.Name = "lblposx";
            this.lblposx.Size = new System.Drawing.Size(126, 46);
            this.lblposx.TabIndex = 0;
            this.lblposx.Text = "label1";
            this.lblposx.Click += new System.EventHandler(this.lblposx_Click);
            // 
            // lblposy
            // 
            this.lblposy.AutoSize = true;
            this.lblposy.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposy.Location = new System.Drawing.Point(629, 39);
            this.lblposy.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblposy.Name = "lblposy";
            this.lblposy.Size = new System.Drawing.Size(126, 46);
            this.lblposy.TabIndex = 1;
            this.lblposy.Text = "label1";
            this.lblposy.Click += new System.EventHandler(this.lblposy_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(357, 39);
            this.lblnome.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(41, 46);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "x";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 307);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblposy);
            this.Controls.Add(this.lblposx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblposx;
        private System.Windows.Forms.Label lblposy;
        private System.Windows.Forms.Label lblnome;
    }
}


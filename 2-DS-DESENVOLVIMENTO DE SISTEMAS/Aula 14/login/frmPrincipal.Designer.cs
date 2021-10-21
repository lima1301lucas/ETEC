namespace login
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraçãoDeSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloqueioDesbloqueioDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoUsuárioToolStripMenuItem,
            this.alteraçãoDeSenhaToolStripMenuItem,
            this.bloqueioDesbloqueioDeUsuárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrarNovoUsuárioToolStripMenuItem
            // 
            this.cadastrarNovoUsuárioToolStripMenuItem.Name = "cadastrarNovoUsuárioToolStripMenuItem";
            this.cadastrarNovoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.cadastrarNovoUsuárioToolStripMenuItem.Text = "Cadastrar novo usuário";
            this.cadastrarNovoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoUsuárioToolStripMenuItem_Click);
            // 
            // alteraçãoDeSenhaToolStripMenuItem
            // 
            this.alteraçãoDeSenhaToolStripMenuItem.Name = "alteraçãoDeSenhaToolStripMenuItem";
            this.alteraçãoDeSenhaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.alteraçãoDeSenhaToolStripMenuItem.Text = "Alteração de senha";
            this.alteraçãoDeSenhaToolStripMenuItem.Click += new System.EventHandler(this.alteraçãoDeSenhaToolStripMenuItem_Click);
            // 
            // bloqueioDesbloqueioDeUsuárioToolStripMenuItem
            // 
            this.bloqueioDesbloqueioDeUsuárioToolStripMenuItem.Name = "bloqueioDesbloqueioDeUsuárioToolStripMenuItem";
            this.bloqueioDesbloqueioDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.bloqueioDesbloqueioDeUsuárioToolStripMenuItem.Text = "Bloqueio/ Desbloqueio de usuário";
            this.bloqueioDesbloqueioDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.bloqueioDesbloqueioDeUsuárioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoDeSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloqueioDesbloqueioDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}


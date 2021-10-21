namespace menu1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mudarCorDeFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarPlanoDeFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obj_color = new System.Windows.Forms.ColorDialog();
            this.obj_arquivo = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posicionamentoDaImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nenhumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esticadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redimensionadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparPlanoDeFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mudarCorDeFundoToolStripMenuItem,
            this.mudarPlanoDeFundoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 70);
            // 
            // mudarCorDeFundoToolStripMenuItem
            // 
            this.mudarCorDeFundoToolStripMenuItem.Name = "mudarCorDeFundoToolStripMenuItem";
            this.mudarCorDeFundoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.mudarCorDeFundoToolStripMenuItem.Text = "Mudar cor de fundo";
            this.mudarCorDeFundoToolStripMenuItem.Click += new System.EventHandler(this.mudarCorDeFundoToolStripMenuItem_Click);
            // 
            // mudarPlanoDeFundoToolStripMenuItem
            // 
            this.mudarPlanoDeFundoToolStripMenuItem.Name = "mudarPlanoDeFundoToolStripMenuItem";
            this.mudarPlanoDeFundoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.mudarPlanoDeFundoToolStripMenuItem.Text = "Mudar plano de fundo";
            this.mudarPlanoDeFundoToolStripMenuItem.Click += new System.EventHandler(this.mudarPlanoDeFundoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // obj_arquivo
            // 
            this.obj_arquivo.Filter = "imagens|*.png;*.jpg;*.jpe;*.jpeg|imagens png|*.png";
            this.obj_arquivo.Title = "Selecionar imagem de fundo";
            this.obj_arquivo.FileOk += new System.ComponentModel.CancelEventHandler(this.obj_arquivo_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posicionamentoDaImagemToolStripMenuItem,
            this.limparPlanoDeFundoToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // posicionamentoDaImagemToolStripMenuItem
            // 
            this.posicionamentoDaImagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nenhumToolStripMenuItem,
            this.ladoALadoToolStripMenuItem,
            this.centralizadoToolStripMenuItem,
            this.esticadoToolStripMenuItem,
            this.redimensionadaToolStripMenuItem});
            this.posicionamentoDaImagemToolStripMenuItem.Name = "posicionamentoDaImagemToolStripMenuItem";
            this.posicionamentoDaImagemToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.posicionamentoDaImagemToolStripMenuItem.Text = "Posicionamento da imagem";
            // 
            // nenhumToolStripMenuItem
            // 
            this.nenhumToolStripMenuItem.Name = "nenhumToolStripMenuItem";
            this.nenhumToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.nenhumToolStripMenuItem.Text = "Nenhum";
            this.nenhumToolStripMenuItem.Click += new System.EventHandler(this.nenhumToolStripMenuItem_Click);
            // 
            // ladoALadoToolStripMenuItem
            // 
            this.ladoALadoToolStripMenuItem.Name = "ladoALadoToolStripMenuItem";
            this.ladoALadoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ladoALadoToolStripMenuItem.Text = "Lado a lado";
            this.ladoALadoToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoToolStripMenuItem_Click);
            // 
            // centralizadoToolStripMenuItem
            // 
            this.centralizadoToolStripMenuItem.Name = "centralizadoToolStripMenuItem";
            this.centralizadoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.centralizadoToolStripMenuItem.Text = "Centralizado";
            this.centralizadoToolStripMenuItem.Click += new System.EventHandler(this.centralizadoToolStripMenuItem_Click);
            // 
            // esticadoToolStripMenuItem
            // 
            this.esticadoToolStripMenuItem.Name = "esticadoToolStripMenuItem";
            this.esticadoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.esticadoToolStripMenuItem.Text = "Esticado";
            this.esticadoToolStripMenuItem.Click += new System.EventHandler(this.esticadoToolStripMenuItem_Click);
            // 
            // redimensionadaToolStripMenuItem
            // 
            this.redimensionadaToolStripMenuItem.Name = "redimensionadaToolStripMenuItem";
            this.redimensionadaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.redimensionadaToolStripMenuItem.Text = "Redimensionada";
            this.redimensionadaToolStripMenuItem.Click += new System.EventHandler(this.redimensionadaToolStripMenuItem_Click);
            // 
            // limparPlanoDeFundoToolStripMenuItem
            // 
            this.limparPlanoDeFundoToolStripMenuItem.Name = "limparPlanoDeFundoToolStripMenuItem";
            this.limparPlanoDeFundoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.limparPlanoDeFundoToolStripMenuItem.Text = "Limpar plano de fundo ";
            this.limparPlanoDeFundoToolStripMenuItem.Click += new System.EventHandler(this.limparPlanoDeFundoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 586);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mudarCorDeFundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mudarPlanoDeFundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ColorDialog obj_color;
        private System.Windows.Forms.OpenFileDialog obj_arquivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posicionamentoDaImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nenhumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esticadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redimensionadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparPlanoDeFundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}


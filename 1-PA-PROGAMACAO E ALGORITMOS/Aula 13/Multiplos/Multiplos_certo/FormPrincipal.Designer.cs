namespace Multiplos_certo
{
    partial class FormPrincipal
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
            this.process1 = new System.Diagnostics.Process();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raizEquação2ºGrauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodizioVeicularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diversosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicativosToolStripMenuItem,
            this.diversosToolStripMenuItem,
            this.encerrarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(816, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem,
            this.raizEquação2ºGrauToolStripMenuItem,
            this.rodizioVeicularToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aplicativosToolStripMenuItem.Text = "Aplicativos";
            this.aplicativosToolStripMenuItem.Click += new System.EventHandler(this.AplicativosToolStripMenuItem_Click);
            // 
            // gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem
            // 
            this.gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem.Name = "gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem";
            this.gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem.Text = "Gerar Numeros pares, ímpares e múltiplos";
            this.gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem.Click += new System.EventHandler(this.gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem_Click);
            // 
            // raizEquação2ºGrauToolStripMenuItem
            // 
            this.raizEquação2ºGrauToolStripMenuItem.Name = "raizEquação2ºGrauToolStripMenuItem";
            this.raizEquação2ºGrauToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.raizEquação2ºGrauToolStripMenuItem.Text = "Raiz equação 2º grau";
            this.raizEquação2ºGrauToolStripMenuItem.Click += new System.EventHandler(this.raizEquação2ºGrauToolStripMenuItem_Click);
            // 
            // rodizioVeicularToolStripMenuItem
            // 
            this.rodizioVeicularToolStripMenuItem.Name = "rodizioVeicularToolStripMenuItem";
            this.rodizioVeicularToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.rodizioVeicularToolStripMenuItem.Text = "Rodizio Veicular";
            this.rodizioVeicularToolStripMenuItem.Click += new System.EventHandler(this.rodizioVeicularToolStripMenuItem_Click);
            // 
            // diversosToolStripMenuItem
            // 
            this.diversosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraWindowsToolStripMenuItem});
            this.diversosToolStripMenuItem.Name = "diversosToolStripMenuItem";
            this.diversosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.diversosToolStripMenuItem.Text = "Diversos";
            // 
            // calculadoraWindowsToolStripMenuItem
            // 
            this.calculadoraWindowsToolStripMenuItem.Name = "calculadoraWindowsToolStripMenuItem";
            this.calculadoraWindowsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.calculadoraWindowsToolStripMenuItem.Text = "Calculadora Windows";
            this.calculadoraWindowsToolStripMenuItem.Click += new System.EventHandler(this.calculadoraWindowsToolStripMenuItem_Click_1);
            // 
            // encerrarToolStripMenuItem
            // 
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.encerrarToolStripMenuItem.Text = "Encerrar";
            this.encerrarToolStripMenuItem.Click += new System.EventHandler(this.encerrarToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 418);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormPrincipal";
            this.Text = "Multiplos";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raizEquação2ºGrauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rodizioVeicularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diversosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarNumerosParesÍmparesEMúltiplosToolStripMenuItem;
    }
}


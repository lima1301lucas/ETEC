namespace Loja
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
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.txt_categoria = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_codigobarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbCdsCategoria = new System.Windows.Forms.RadioButton();
            this.rbListaCategoria = new System.Windows.Forms.RadioButton();
            this.pnlCategorias = new System.Windows.Forms.Panel();
            this.txt_nomecategoria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rbListarProd = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.pnlProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_categoria)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.BackColor = System.Drawing.Color.White;
            this.pnlProdutos.Controls.Add(this.pictureBox1);
            this.pnlProdutos.Controls.Add(this.txt_categoria);
            this.pnlProdutos.Controls.Add(this.label6);
            this.pnlProdutos.Controls.Add(this.label5);
            this.pnlProdutos.Controls.Add(this.txt_descricao);
            this.pnlProdutos.Controls.Add(this.label4);
            this.pnlProdutos.Controls.Add(this.txt_codigobarras);
            this.pnlProdutos.Controls.Add(this.label3);
            this.pnlProdutos.Controls.Add(this.txt_valor);
            this.pnlProdutos.Controls.Add(this.label2);
            this.pnlProdutos.Controls.Add(this.label1);
            this.pnlProdutos.Controls.Add(this.txt_nome);
            this.pnlProdutos.ForeColor = System.Drawing.Color.Black;
            this.pnlProdutos.Location = new System.Drawing.Point(250, 60);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(407, 472);
            this.pnlProdutos.TabIndex = 0;
            this.pnlProdutos.Visible = false;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.Location = new System.Drawing.Point(31, 277);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(120, 26);
            this.txt_categoria.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "PRODUTOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código de barras";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(31, 140);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(325, 87);
            this.txt_descricao.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // txt_codigobarras
            // 
            this.txt_codigobarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigobarras.Location = new System.Drawing.Point(31, 425);
            this.txt_codigobarras.Name = "txt_codigobarras";
            this.txt_codigobarras.Size = new System.Drawing.Size(100, 26);
            this.txt_codigobarras.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria";
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(31, 345);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(120, 26);
            this.txt_valor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(31, 73);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(334, 26);
            this.txt_nome.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbProduto);
            this.flowLayoutPanel1.Controls.Add(this.rbCdsCategoria);
            this.flowLayoutPanel1.Controls.Add(this.rbListaCategoria);
            this.flowLayoutPanel1.Controls.Add(this.rbListarProd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 57, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 552);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // rbProduto
            // 
            this.rbProduto.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbProduto.FlatAppearance.BorderSize = 0;
            this.rbProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProduto.Location = new System.Drawing.Point(3, 60);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(250, 30);
            this.rbProduto.TabIndex = 0;
            this.rbProduto.Text = "Cadastrar produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            this.rbProduto.Click += new System.EventHandler(this.fnExibir);
            // 
            // rbCdsCategoria
            // 
            this.rbCdsCategoria.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCdsCategoria.FlatAppearance.BorderSize = 0;
            this.rbCdsCategoria.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbCdsCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCdsCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCdsCategoria.Location = new System.Drawing.Point(3, 96);
            this.rbCdsCategoria.Name = "rbCdsCategoria";
            this.rbCdsCategoria.Size = new System.Drawing.Size(250, 30);
            this.rbCdsCategoria.TabIndex = 1;
            this.rbCdsCategoria.Text = "Cadastrar categorias";
            this.rbCdsCategoria.UseVisualStyleBackColor = true;
            this.rbCdsCategoria.CheckedChanged += new System.EventHandler(this.rbCdsCategoria_CheckedChanged);
            this.rbCdsCategoria.Click += new System.EventHandler(this.fnExibir);
            // 
            // rbListaCategoria
            // 
            this.rbListaCategoria.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbListaCategoria.FlatAppearance.BorderSize = 0;
            this.rbListaCategoria.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbListaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbListaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbListaCategoria.Location = new System.Drawing.Point(3, 132);
            this.rbListaCategoria.Name = "rbListaCategoria";
            this.rbListaCategoria.Size = new System.Drawing.Size(250, 30);
            this.rbListaCategoria.TabIndex = 2;
            this.rbListaCategoria.Text = "Listar categorias";
            this.rbListaCategoria.UseVisualStyleBackColor = true;
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.BackColor = System.Drawing.Color.White;
            this.pnlCategorias.Controls.Add(this.txt_nomecategoria);
            this.pnlCategorias.Controls.Add(this.label8);
            this.pnlCategorias.Controls.Add(this.label7);
            this.pnlCategorias.ForeColor = System.Drawing.Color.Black;
            this.pnlCategorias.Location = new System.Drawing.Point(250, 60);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(407, 472);
            this.pnlCategorias.TabIndex = 2;
            this.pnlCategorias.Visible = false;
            // 
            // txt_nomecategoria
            // 
            this.txt_nomecategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomecategoria.Location = new System.Drawing.Point(19, 96);
            this.txt_nomecategoria.Name = "txt_nomecategoria";
            this.txt_nomecategoria.Size = new System.Drawing.Size(135, 26);
            this.txt_nomecategoria.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Categorias";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // rbListarProd
            // 
            this.rbListarProd.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbListarProd.FlatAppearance.BorderSize = 0;
            this.rbListarProd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbListarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbListarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbListarProd.Location = new System.Drawing.Point(3, 168);
            this.rbListarProd.Name = "rbListarProd";
            this.rbListarProd.Size = new System.Drawing.Size(250, 30);
            this.rbListarProd.TabIndex = 3;
            this.rbListarProd.Text = "Listar produtos";
            this.rbListarProd.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Loja.Properties.Resources.up;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(208, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 144);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.BackgroundImage = global::Loja.Properties.Resources.addicon1;
            this.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Location = new System.Drawing.Point(452, -11);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(102, 82);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.White;
            this.btn_enviar.BackgroundImage = global::Loja.Properties.Resources.addicon;
            this.btn_enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.Color.Black;
            this.btn_enviar.Location = new System.Drawing.Point(363, -13);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(102, 82);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(902, 552);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlProdutos);
            this.Controls.Add(this.pnlCategorias);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_enviar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlProdutos.ResumeLayout(false);
            this.pnlProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_categoria)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlCategorias.ResumeLayout(false);
            this.pnlCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_codigobarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.RadioButton rbCdsCategoria;
        private System.Windows.Forms.RadioButton rbListaCategoria;
        private System.Windows.Forms.Panel pnlCategorias;
        private System.Windows.Forms.TextBox txt_nomecategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.NumericUpDown txt_categoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.RadioButton rbListarProd;
    }
}


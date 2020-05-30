namespace AvaliacaoA1
{
    partial class FormCadastroProduto
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
            this.cbCategoriaComputador = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.txtImagemProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisaImagem = new System.Windows.Forms.Button();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCategoriaConsoles = new System.Windows.Forms.ComboBox();
            this.cbCategoriaCelular = new System.Windows.Forms.ComboBox();
            this.rbConsoles = new System.Windows.Forms.RadioButton();
            this.rbCelular = new System.Windows.Forms.RadioButton();
            this.rbComputador = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCategoriaComputador
            // 
            this.cbCategoriaComputador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategoriaComputador.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaComputador.FormattingEnabled = true;
            this.cbCategoriaComputador.Location = new System.Drawing.Point(195, 39);
            this.cbCategoriaComputador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoriaComputador.Name = "cbCategoriaComputador";
            this.cbCategoriaComputador.Size = new System.Drawing.Size(169, 29);
            this.cbCategoriaComputador.TabIndex = 31;
            this.cbCategoriaComputador.Text = "Selecione...";
            this.cbCategoriaComputador.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaComputador_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(553, 473);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 38);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarUsuario.FlatAppearance.BorderSize = 2;
            this.btnSalvarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvarUsuario.Location = new System.Drawing.Point(341, 473);
            this.btnSalvarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(165, 38);
            this.btnSalvarUsuario.TabIndex = 29;
            this.btnSalvarUsuario.Text = "CADASTRAR";
            this.btnSalvarUsuario.UseVisualStyleBackColor = false;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txtImagemProduto
            // 
            this.txtImagemProduto.Enabled = false;
            this.txtImagemProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtImagemProduto.Location = new System.Drawing.Point(675, 129);
            this.txtImagemProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImagemProduto.Name = "txtImagemProduto";
            this.txtImagemProduto.Size = new System.Drawing.Size(217, 30);
            this.txtImagemProduto.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(669, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(111, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descrição:";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescricaoProduto.Location = new System.Drawing.Point(116, 228);
            this.txtDescricaoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(389, 30);
            this.txtDescricaoProduto.TabIndex = 21;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.Location = new System.Drawing.Point(109, 82);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(78, 29);
            this.labelNomeProduto.TabIndex = 20;
            this.labelNomeProduto.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeProduto.Location = new System.Drawing.Point(115, 129);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(391, 30);
            this.txtNomeProduto.TabIndex = 19;
            // 
            // btnPesquisaImagem
            // 
            this.btnPesquisaImagem.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPesquisaImagem.BackgroundImage = global::AvaliacaoA1.Properties.Resources.searchmagnifierinterfacesymbol1_79893;
            this.btnPesquisaImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisaImagem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisaImagem.FlatAppearance.BorderSize = 2;
            this.btnPesquisaImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesquisaImagem.Location = new System.Drawing.Point(897, 129);
            this.btnPesquisaImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisaImagem.Name = "btnPesquisaImagem";
            this.btnPesquisaImagem.Size = new System.Drawing.Size(51, 30);
            this.btnPesquisaImagem.TabIndex = 34;
            this.btnPesquisaImagem.UseVisualStyleBackColor = false;
            this.btnPesquisaImagem.Click += new System.EventHandler(this.btnPesquisaImagem_Click);
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.BackColor = System.Drawing.Color.Black;
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::AvaliacaoA1.Properties.Resources.Adobe_Post_20200416_0902470_8175506600410369;
            this.pbImagemProduto.Location = new System.Drawing.Point(675, 181);
            this.pbImagemProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(273, 183);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 35;
            this.pbImagemProduto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCategoriaConsoles);
            this.groupBox1.Controls.Add(this.cbCategoriaCelular);
            this.groupBox1.Controls.Add(this.rbConsoles);
            this.groupBox1.Controls.Add(this.rbCelular);
            this.groupBox1.Controls.Add(this.rbComputador);
            this.groupBox1.Controls.Add(this.cbCategoriaComputador);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(115, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(392, 166);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // cbCategoriaConsoles
            // 
            this.cbCategoriaConsoles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategoriaConsoles.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaConsoles.FormattingEnabled = true;
            this.cbCategoriaConsoles.Location = new System.Drawing.Point(195, 111);
            this.cbCategoriaConsoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoriaConsoles.Name = "cbCategoriaConsoles";
            this.cbCategoriaConsoles.Size = new System.Drawing.Size(169, 29);
            this.cbCategoriaConsoles.TabIndex = 38;
            this.cbCategoriaConsoles.Text = "Selecione...";
            this.cbCategoriaConsoles.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaConsoles_SelectedIndexChanged);
            // 
            // cbCategoriaCelular
            // 
            this.cbCategoriaCelular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategoriaCelular.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaCelular.FormattingEnabled = true;
            this.cbCategoriaCelular.Location = new System.Drawing.Point(195, 75);
            this.cbCategoriaCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoriaCelular.Name = "cbCategoriaCelular";
            this.cbCategoriaCelular.Size = new System.Drawing.Size(169, 29);
            this.cbCategoriaCelular.TabIndex = 38;
            this.cbCategoriaCelular.Text = "Selecione...";
            this.cbCategoriaCelular.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaCelular_SelectedIndexChanged);
            // 
            // rbConsoles
            // 
            this.rbConsoles.AutoSize = true;
            this.rbConsoles.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConsoles.Location = new System.Drawing.Point(19, 110);
            this.rbConsoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbConsoles.Name = "rbConsoles";
            this.rbConsoles.Size = new System.Drawing.Size(90, 28);
            this.rbConsoles.TabIndex = 32;
            this.rbConsoles.TabStop = true;
            this.rbConsoles.Text = "Consoles";
            this.rbConsoles.UseVisualStyleBackColor = true;
            this.rbConsoles.CheckedChanged += new System.EventHandler(this.rbConsoles_CheckedChanged);
            // 
            // rbCelular
            // 
            this.rbCelular.AutoSize = true;
            this.rbCelular.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelular.Location = new System.Drawing.Point(19, 74);
            this.rbCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCelular.Name = "rbCelular";
            this.rbCelular.Size = new System.Drawing.Size(94, 28);
            this.rbCelular.TabIndex = 1;
            this.rbCelular.TabStop = true;
            this.rbCelular.Text = "Celulares";
            this.rbCelular.UseVisualStyleBackColor = true;
            this.rbCelular.CheckedChanged += new System.EventHandler(this.rbCelular_CheckedChanged);
            // 
            // rbComputador
            // 
            this.rbComputador.AutoSize = true;
            this.rbComputador.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComputador.Location = new System.Drawing.Point(19, 39);
            this.rbComputador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbComputador.Name = "rbComputador";
            this.rbComputador.Size = new System.Drawing.Size(59, 28);
            this.rbComputador.TabIndex = 0;
            this.rbComputador.TabStop = true;
            this.rbComputador.Text = "PC´s";
            this.rbComputador.UseVisualStyleBackColor = true;
            this.rbComputador.CheckedChanged += new System.EventHandler(this.rbComputador_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(669, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Imagem:";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPreco.Location = new System.Drawing.Point(788, 399);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(160, 30);
            this.txtPreco.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 59);
            this.panel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(387, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "CADASTRAR PRODUTOS\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 535);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 59);
            this.panel2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(461, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Feito por Matheus Pimentel  \r\n 2020\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Location = new System.Drawing.Point(12, 17);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 30);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1053, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbImagemProduto);
            this.Controls.Add(this.btnPesquisaImagem);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvarUsuario);
            this.Controls.Add(this.txtImagemProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cbCategoriaComputador;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvarUsuario;
        public System.Windows.Forms.TextBox txtImagemProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label labelNomeProduto;
        public System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnPesquisaImagem;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbConsoles;
        private System.Windows.Forms.RadioButton rbCelular;
        private System.Windows.Forms.RadioButton rbComputador;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbCategoriaConsoles;
        public System.Windows.Forms.ComboBox cbCategoriaCelular;
        public System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
    }
}
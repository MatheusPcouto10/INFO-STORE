namespace AvaliacaoA1.View
{
    partial class FormCadastroEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroEntradas));
            this.dtDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidadeEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoEntrada = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionarEntrada = new System.Windows.Forms.Button();
            this.dgProdutos_Entrada = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFormPesquisaFornecedor = new System.Windows.Forms.Button();
            this.btnFormPesquisa_Produto = new System.Windows.Forms.Button();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaInformaticaDataSetProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaInformaticaDataSetProdutosEntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaInformaticaDataSetProdutosEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lojaInformaticaDataSetComboUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos_Entrada)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetProdutosEntradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetProdutosEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetComboUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDataEntrada
            // 
            this.dtDataEntrada.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataEntrada.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEntrada.Location = new System.Drawing.Point(621, 106);
            this.dtDataEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataEntrada.Name = "dtDataEntrada";
            this.dtDataEntrada.Size = new System.Drawing.Size(240, 24);
            this.dtDataEntrada.TabIndex = 5;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.Location = new System.Drawing.Point(617, 80);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(101, 21);
            this.labelNomeProduto.TabIndex = 21;
            this.labelNomeProduto.Text = "Data de Entrada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(725, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quantidade:";
            // 
            // txtQuantidadeEntrada
            // 
            this.txtQuantidadeEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtQuantidadeEntrada.Location = new System.Drawing.Point(729, 172);
            this.txtQuantidadeEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidadeEntrada.Name = "txtQuantidadeEntrada";
            this.txtQuantidadeEntrada.Size = new System.Drawing.Size(160, 26);
            this.txtQuantidadeEntrada.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1069, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Produtos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Valor Unitário:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecoEntrada
            // 
            this.txtPrecoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrecoEntrada.Location = new System.Drawing.Point(563, 172);
            this.txtPrecoEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecoEntrada.Name = "txtPrecoEntrada";
            this.txtPrecoEntrada.Size = new System.Drawing.Size(163, 26);
            this.txtPrecoEntrada.TabIndex = 26;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(631, 475);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(136, 38);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdicionarEntrada
            // 
            this.btnAdicionarEntrada.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdicionarEntrada.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionarEntrada.FlatAppearance.BorderSize = 2;
            this.btnAdicionarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarEntrada.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarEntrada.Location = new System.Drawing.Point(385, 475);
            this.btnAdicionarEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarEntrada.Name = "btnAdicionarEntrada";
            this.btnAdicionarEntrada.Size = new System.Drawing.Size(240, 38);
            this.btnAdicionarEntrada.TabIndex = 31;
            this.btnAdicionarEntrada.Text = "ADICIONAR REMESSA";
            this.btnAdicionarEntrada.UseVisualStyleBackColor = false;
            this.btnAdicionarEntrada.Click += new System.EventHandler(this.btnAdicionarEntradas_Click);
            // 
            // dgProdutos_Entrada
            // 
            this.dgProdutos_Entrada.BackgroundColor = System.Drawing.Color.Black;
            this.dgProdutos_Entrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos_Entrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar});
            this.dgProdutos_Entrada.GridColor = System.Drawing.Color.Black;
            this.dgProdutos_Entrada.Location = new System.Drawing.Point(55, 223);
            this.dgProdutos_Entrada.Margin = new System.Windows.Forms.Padding(4);
            this.dgProdutos_Entrada.Name = "dgProdutos_Entrada";
            this.dgProdutos_Entrada.RowHeadersWidth = 51;
            this.dgProdutos_Entrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos_Entrada.Size = new System.Drawing.Size(1075, 246);
            this.dgProdutos_Entrada.TabIndex = 33;
            this.dgProdutos_Entrada.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgProdutos_Entrada_DataBindingComplete);
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = "";
            this.selecionar.MinimumWidth = 6;
            this.selecionar.Name = "selecionar";
            this.selecionar.Width = 125;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(293, 172);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(240, 26);
            this.txtNomeProduto.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Produto:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 59);
            this.panel1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(469, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTRADA DE PRODUTOS\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 535);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 59);
            this.panel2.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(543, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "Feito por Matheus Pimentel  \r\n 2020\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 47;
            this.label7.Text = "Fornecedor:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(293, 106);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(303, 26);
            this.txtNomeFantasia.TabIndex = 46;
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(55, 103);
            this.txtIdFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(157, 26);
            this.txtIdFornecedor.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(51, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdProduto.Location = new System.Drawing.Point(55, 174);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(157, 26);
            this.txtIdProduto.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(51, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 21);
            this.label9.TabIndex = 52;
            this.label9.Text = "Código:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFormPesquisaFornecedor
            // 
            this.btnFormPesquisaFornecedor.BackColor = System.Drawing.Color.LawnGreen;
            this.btnFormPesquisaFornecedor.BackgroundImage = global::AvaliacaoA1.Properties.Resources.searchmagnifierinterfacesymbol1_79893;
            this.btnFormPesquisaFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFormPesquisaFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFormPesquisaFornecedor.FlatAppearance.BorderSize = 2;
            this.btnFormPesquisaFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormPesquisaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFormPesquisaFornecedor.Location = new System.Drawing.Point(219, 105);
            this.btnFormPesquisaFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisaFornecedor.Name = "btnFormPesquisaFornecedor";
            this.btnFormPesquisaFornecedor.Size = new System.Drawing.Size(63, 26);
            this.btnFormPesquisaFornecedor.TabIndex = 48;
            this.btnFormPesquisaFornecedor.UseVisualStyleBackColor = false;
            this.btnFormPesquisaFornecedor.Click += new System.EventHandler(this.btnFormPesquisaFornecedor_Click);
            // 
            // btnFormPesquisa_Produto
            // 
            this.btnFormPesquisa_Produto.BackColor = System.Drawing.Color.LawnGreen;
            this.btnFormPesquisa_Produto.BackgroundImage = global::AvaliacaoA1.Properties.Resources.searchmagnifierinterfacesymbol1_79893;
            this.btnFormPesquisa_Produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFormPesquisa_Produto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFormPesquisa_Produto.FlatAppearance.BorderSize = 2;
            this.btnFormPesquisa_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormPesquisa_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFormPesquisa_Produto.Location = new System.Drawing.Point(219, 174);
            this.btnFormPesquisa_Produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisa_Produto.Name = "btnFormPesquisa_Produto";
            this.btnFormPesquisa_Produto.Size = new System.Drawing.Size(63, 27);
            this.btnFormPesquisa_Produto.TabIndex = 36;
            this.btnFormPesquisa_Produto.UseVisualStyleBackColor = false;
            this.btnFormPesquisa_Produto.Click += new System.EventHandler(this.btnFormPesquisa_Produto_Click);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "Produtos";
            // 
            // FormCadastroEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1181, 594);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFormPesquisaFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFormPesquisa_Produto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.dgProdutos_Entrada);
            this.Controls.Add(this.txtQuantidadeEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecoEntrada);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionarEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.dtDataEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormCadastroEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.FormCadastroEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos_Entrada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetProdutosEntradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetProdutosEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetComboUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtDataEntrada;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtQuantidadeEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPrecoEntrada;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionarEntrada;
        private System.Windows.Forms.BindingSource lojaInformaticaDataSetProdutosBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.BindingSource lojaInformaticaDataSetProdutosEntradasBindingSource;
        private System.Windows.Forms.BindingSource lojaInformaticaDataSetProdutosEntradaBindingSource;
        private System.Windows.Forms.BindingSource lojaInformaticaDataSetUsuariosBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.BindingSource lojaInformaticaDataSetComboUsuarioBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private System.Windows.Forms.DataGridView dgProdutos_Entrada;
        public System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFormPesquisa_Produto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnFormPesquisaFornecedor;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNomeFantasia;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label9;
    }
}
namespace AvaliacaoA1.View
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.telaPesquisa = new System.Windows.Forms.TabPage();
            this.fillByNomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.btnPesquisa = new System.Windows.Forms.ToolStripButton();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.telaEditar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSubCategorias = new System.Windows.Forms.ComboBox();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.btnPesquisaImagem = new System.Windows.Forms.Button();
            this.txtImagemProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaInformaticaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.telaPesquisa.SuspendLayout();
            this.fillByNomeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.telaEditar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.telaPesquisa);
            this.tabControl1.Controls.Add(this.telaEditar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-7, 57);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1196, 494);
            this.tabControl1.TabIndex = 4;
            // 
            // telaPesquisa
            // 
            this.telaPesquisa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaPesquisa.Controls.Add(this.fillByNomeToolStrip);
            this.telaPesquisa.Controls.Add(this.dgProdutos);
            this.telaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaPesquisa.Location = new System.Drawing.Point(4, 26);
            this.telaPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Name = "telaPesquisa";
            this.telaPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Size = new System.Drawing.Size(1188, 464);
            this.telaPesquisa.TabIndex = 0;
            this.telaPesquisa.Text = "Pesquisa";
            // 
            // fillByNomeToolStrip
            // 
            this.fillByNomeToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByNomeToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByNomeToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByNomeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPesquisa,
            this.btnPesquisa});
            this.fillByNomeToolStrip.Location = new System.Drawing.Point(439, 72);
            this.fillByNomeToolStrip.Name = "fillByNomeToolStrip";
            this.fillByNomeToolStrip.Size = new System.Drawing.Size(320, 27);
            this.fillByNomeToolStrip.TabIndex = 6;
            this.fillByNomeToolStrip.Text = "fillByNomeToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(87, 24);
            this.toolStripLabel1.Text = "PESQUISAR:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(199, 27);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPesquisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPesquisa.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnPesquisa.Image = global::AvaliacaoA1.Properties.Resources.searchmagnifierinterfacesymbol1_79893;
            this.btnPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(29, 24);
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AllowUserToOrderColumns = true;
            this.dgProdutos.BackgroundColor = System.Drawing.Color.Black;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dgProdutos.Location = new System.Drawing.Point(13, 138);
            this.dgProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersWidth = 51;
            this.dgProdutos.RowTemplate.Height = 24;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(1159, 289);
            this.dgProdutos.TabIndex = 5;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellContentClick);
            this.dgProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProdutos_CellFormatting);
            this.dgProdutos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgUsuarios_DataBindingComplete);
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = global::AvaliacaoA1.Properties.Resources.editar;
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 125;
            // 
            // telaEditar
            // 
            this.telaEditar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaEditar.Controls.Add(this.groupBox1);
            this.telaEditar.Controls.Add(this.label6);
            this.telaEditar.Controls.Add(this.cbStatus);
            this.telaEditar.Controls.Add(this.txtPreco);
            this.telaEditar.Controls.Add(this.label4);
            this.telaEditar.Controls.Add(this.pbImagemProduto);
            this.telaEditar.Controls.Add(this.btnPesquisaImagem);
            this.telaEditar.Controls.Add(this.txtImagemProduto);
            this.telaEditar.Controls.Add(this.label5);
            this.telaEditar.Controls.Add(this.label1);
            this.telaEditar.Controls.Add(this.txtDescricaoProduto);
            this.telaEditar.Controls.Add(this.labelNomeProduto);
            this.telaEditar.Controls.Add(this.txtNomeProduto);
            this.telaEditar.Controls.Add(this.btnSalvarProduto);
            this.telaEditar.Location = new System.Drawing.Point(4, 26);
            this.telaEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Name = "telaEditar";
            this.telaEditar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Size = new System.Drawing.Size(1188, 464);
            this.telaEditar.TabIndex = 1;
            this.telaEditar.Text = "Editar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSubCategorias);
            this.groupBox1.Controls.Add(this.cbCategorias);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(105, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(392, 107);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // cbSubCategorias
            // 
            this.cbSubCategorias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSubCategorias.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategorias.FormattingEnabled = true;
            this.cbSubCategorias.Location = new System.Drawing.Point(195, 45);
            this.cbSubCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubCategorias.Name = "cbSubCategorias";
            this.cbSubCategorias.Size = new System.Drawing.Size(169, 29);
            this.cbSubCategorias.TabIndex = 38;
            this.cbSubCategorias.Text = "Selecione...";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategorias.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(6, 45);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(169, 29);
            this.cbCategorias.TabIndex = 31;
            this.cbCategorias.Text = "Selecione...";
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(763, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Em Atividade",
            "Fora de Atividade"});
            this.cbStatus.Location = new System.Drawing.Point(872, 329);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(169, 30);
            this.cbStatus.TabIndex = 50;
            this.cbStatus.Text = "Selecione...";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPreco.Location = new System.Drawing.Point(181, 344);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(169, 30);
            this.txtPreco.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(762, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Imagem:";
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.BackColor = System.Drawing.Color.Black;
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::AvaliacaoA1.Properties.Resources.Adobe_Post_20200416_0902470_8175506600410369;
            this.pbImagemProduto.Location = new System.Drawing.Point(766, 113);
            this.pbImagemProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(273, 183);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 46;
            this.pbImagemProduto.TabStop = false;
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
            this.btnPesquisaImagem.Location = new System.Drawing.Point(990, 62);
            this.btnPesquisaImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisaImagem.Name = "btnPesquisaImagem";
            this.btnPesquisaImagem.Size = new System.Drawing.Size(51, 32);
            this.btnPesquisaImagem.TabIndex = 45;
            this.btnPesquisaImagem.UseVisualStyleBackColor = false;
            // 
            // txtImagemProduto
            // 
            this.txtImagemProduto.Enabled = false;
            this.txtImagemProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtImagemProduto.Location = new System.Drawing.Point(766, 62);
            this.txtImagemProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImagemProduto.Name = "txtImagemProduto";
            this.txtImagemProduto.Size = new System.Drawing.Size(217, 30);
            this.txtImagemProduto.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(100, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(103, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescricaoProduto.Location = new System.Drawing.Point(108, 160);
            this.txtDescricaoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(389, 30);
            this.txtDescricaoProduto.TabIndex = 41;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.Location = new System.Drawing.Point(101, 15);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(78, 29);
            this.labelNomeProduto.TabIndex = 40;
            this.labelNomeProduto.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomeProduto.Location = new System.Drawing.Point(107, 62);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(391, 30);
            this.txtNomeProduto.TabIndex = 39;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarProduto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarProduto.FlatAppearance.BorderSize = 2;
            this.btnSalvarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvarProduto.Location = new System.Drawing.Point(538, 401);
            this.btnSalvarProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(140, 38);
            this.btnSalvarProduto.TabIndex = 29;
            this.btnSalvarProduto.Text = "SALVAR";
            this.btnSalvarProduto.UseVisualStyleBackColor = false;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "Produtos";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
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
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(545, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "ESTOQUE\r\n";
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
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(532, 14);
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
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEstoque_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.telaPesquisa.ResumeLayout(false);
            this.telaPesquisa.PerformLayout();
            this.fillByNomeToolStrip.ResumeLayout(false);
            this.fillByNomeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.telaEditar.ResumeLayout(false);
            this.telaEditar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage telaPesquisa;
        private System.Windows.Forms.ToolStrip fillByNomeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripButton btnPesquisa;
        public System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.TabPage telaEditar;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.BindingSource lojaInformaticaDataSetBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private System.Windows.Forms.BindingSource subCategoriasBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.Button btnPesquisaImagem;
        public System.Windows.Forms.TextBox txtImagemProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label labelNomeProduto;
        public System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbSubCategorias;
        public System.Windows.Forms.ComboBox cbCategorias;
    }
}
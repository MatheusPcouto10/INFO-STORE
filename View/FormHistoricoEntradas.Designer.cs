namespace AvaliacaoA1.View
{
    partial class FormHistoricoEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoEntradas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.telaPesquisa = new System.Windows.Forms.TabPage();
            this.fillByNomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.btnPesquisa = new System.Windows.Forms.ToolStripButton();
            this.dgEntradas = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.telaEditar = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFormPesquisaFornecedor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.btnFormPesquisa_Produto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.dgProdutos_Entrada = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtQuantidadeEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.dtDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarEntrada = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.telaPesquisa.SuspendLayout();
            this.fillByNomeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).BeginInit();
            this.telaEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos_Entrada)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(449, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "HISTÓRICO DE ENTRADAS";
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
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(524, 13);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.telaPesquisa);
            this.tabControl1.Controls.Add(this.telaEditar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-7, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 492);
            this.tabControl1.TabIndex = 8;
            // 
            // telaPesquisa
            // 
            this.telaPesquisa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaPesquisa.Controls.Add(this.fillByNomeToolStrip);
            this.telaPesquisa.Controls.Add(this.dgEntradas);
            this.telaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaPesquisa.Location = new System.Drawing.Point(4, 26);
            this.telaPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Name = "telaPesquisa";
            this.telaPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Size = new System.Drawing.Size(1187, 462);
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
            this.fillByNomeToolStrip.Location = new System.Drawing.Point(405, 66);
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
            // dgEntradas
            // 
            this.dgEntradas.AllowUserToAddRows = false;
            this.dgEntradas.AllowUserToDeleteRows = false;
            this.dgEntradas.AllowUserToOrderColumns = true;
            this.dgEntradas.BackgroundColor = System.Drawing.Color.Black;
            this.dgEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dgEntradas.Location = new System.Drawing.Point(15, 138);
            this.dgEntradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgEntradas.Name = "dgEntradas";
            this.dgEntradas.ReadOnly = true;
            this.dgEntradas.RowHeadersWidth = 51;
            this.dgEntradas.RowTemplate.Height = 24;
            this.dgEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEntradas.Size = new System.Drawing.Size(1157, 294);
            this.dgEntradas.TabIndex = 5;
            this.dgEntradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntradas_CellContentClick);
            this.dgEntradas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgEntradas_CellFormatting);
            this.dgEntradas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgEntradas_DataBindingComplete);
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
            this.telaEditar.Controls.Add(this.label9);
            this.telaEditar.Controls.Add(this.txtNomeProduto);
            this.telaEditar.Controls.Add(this.txtIdFornecedor);
            this.telaEditar.Controls.Add(this.label8);
            this.telaEditar.Controls.Add(this.btnFormPesquisaFornecedor);
            this.telaEditar.Controls.Add(this.label7);
            this.telaEditar.Controls.Add(this.txtNomeFantasia);
            this.telaEditar.Controls.Add(this.btnFormPesquisa_Produto);
            this.telaEditar.Controls.Add(this.label6);
            this.telaEditar.Controls.Add(this.txtIdProduto);
            this.telaEditar.Controls.Add(this.dgProdutos_Entrada);
            this.telaEditar.Controls.Add(this.txtQuantidadeEntrada);
            this.telaEditar.Controls.Add(this.label1);
            this.telaEditar.Controls.Add(this.txtPrecoEntrada);
            this.telaEditar.Controls.Add(this.label5);
            this.telaEditar.Controls.Add(this.label4);
            this.telaEditar.Controls.Add(this.labelNomeProduto);
            this.telaEditar.Controls.Add(this.dtDataEntrada);
            this.telaEditar.Controls.Add(this.btnSalvarEntrada);
            this.telaEditar.Location = new System.Drawing.Point(4, 26);
            this.telaEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Name = "telaEditar";
            this.telaEditar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Size = new System.Drawing.Size(1187, 462);
            this.telaEditar.TabIndex = 1;
            this.telaEditar.Text = "Editar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(372, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(376, 129);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(240, 26);
            this.txtNomeProduto.TabIndex = 56;
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(60, 63);
            this.txtIdFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(157, 26);
            this.txtIdFornecedor.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(56, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnFormPesquisaFornecedor.Location = new System.Drawing.Point(224, 63);
            this.btnFormPesquisaFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisaFornecedor.Name = "btnFormPesquisaFornecedor";
            this.btnFormPesquisaFornecedor.Size = new System.Drawing.Size(63, 26);
            this.btnFormPesquisaFornecedor.TabIndex = 53;
            this.btnFormPesquisaFornecedor.UseVisualStyleBackColor = false;
            this.btnFormPesquisaFornecedor.Click += new System.EventHandler(this.btnFormPesquisaFornecedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Fornecedor:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(299, 62);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(303, 26);
            this.txtNomeFantasia.TabIndex = 51;
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
            this.btnFormPesquisa_Produto.Location = new System.Drawing.Point(307, 129);
            this.btnFormPesquisa_Produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisa_Produto.Name = "btnFormPesquisa_Produto";
            this.btnFormPesquisa_Produto.Size = new System.Drawing.Size(63, 26);
            this.btnFormPesquisa_Produto.TabIndex = 47;
            this.btnFormPesquisa_Produto.UseVisualStyleBackColor = false;
            this.btnFormPesquisa_Produto.Click += new System.EventHandler(this.btnFormPesquisa_Produto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Código:";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(60, 129);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(240, 26);
            this.txtIdProduto.TabIndex = 45;
            // 
            // dgProdutos_Entrada
            // 
            this.dgProdutos_Entrada.BackgroundColor = System.Drawing.Color.Black;
            this.dgProdutos_Entrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos_Entrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar});
            this.dgProdutos_Entrada.GridColor = System.Drawing.Color.Black;
            this.dgProdutos_Entrada.Location = new System.Drawing.Point(60, 178);
            this.dgProdutos_Entrada.Margin = new System.Windows.Forms.Padding(4);
            this.dgProdutos_Entrada.Name = "dgProdutos_Entrada";
            this.dgProdutos_Entrada.RowHeadersWidth = 51;
            this.dgProdutos_Entrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos_Entrada.Size = new System.Drawing.Size(1050, 217);
            this.dgProdutos_Entrada.TabIndex = 44;
            this.dgProdutos_Entrada.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgProdutos_Entrada_DataBindingComplete);
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = "";
            this.selecionar.MinimumWidth = 6;
            this.selecionar.Name = "selecionar";
            this.selecionar.Width = 125;
            // 
            // txtQuantidadeEntrada
            // 
            this.txtQuantidadeEntrada.Enabled = false;
            this.txtQuantidadeEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtQuantidadeEntrada.Location = new System.Drawing.Point(789, 129);
            this.txtQuantidadeEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidadeEntrada.Name = "txtQuantidadeEntrada";
            this.txtQuantidadeEntrada.Size = new System.Drawing.Size(160, 26);
            this.txtQuantidadeEntrada.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(785, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Quantidade:";
            // 
            // txtPrecoEntrada
            // 
            this.txtPrecoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrecoEntrada.Location = new System.Drawing.Point(620, 129);
            this.txtPrecoEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecoEntrada.Name = "txtPrecoEntrada";
            this.txtPrecoEntrada.Size = new System.Drawing.Size(163, 26);
            this.txtPrecoEntrada.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(621, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Valor Unitário:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1049, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Produtos:";
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.Location = new System.Drawing.Point(621, 39);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(101, 21);
            this.labelNomeProduto.TabIndex = 38;
            this.labelNomeProduto.Text = "Data de Entrada:";
            // 
            // dtDataEntrada
            // 
            this.dtDataEntrada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataEntrada.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEntrada.Location = new System.Drawing.Point(625, 65);
            this.dtDataEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataEntrada.Name = "dtDataEntrada";
            this.dtDataEntrada.Size = new System.Drawing.Size(271, 24);
            this.dtDataEntrada.TabIndex = 37;
            // 
            // btnSalvarEntrada
            // 
            this.btnSalvarEntrada.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarEntrada.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarEntrada.FlatAppearance.BorderSize = 2;
            this.btnSalvarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEntrada.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvarEntrada.Location = new System.Drawing.Point(528, 401);
            this.btnSalvarEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarEntrada.Name = "btnSalvarEntrada";
            this.btnSalvarEntrada.Size = new System.Drawing.Size(140, 38);
            this.btnSalvarEntrada.TabIndex = 29;
            this.btnSalvarEntrada.Text = "SALVAR";
            this.btnSalvarEntrada.UseVisualStyleBackColor = false;
            this.btnSalvarEntrada.Click += new System.EventHandler(this.btnSalvarEntrada_Click);
            // 
            // FormHistoricoEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1181, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormHistoricoEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de Entradas";
            this.Load += new System.EventHandler(this.FormHistoricoEntradas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHistoricoEntradas_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.telaPesquisa.ResumeLayout(false);
            this.telaPesquisa.PerformLayout();
            this.fillByNomeToolStrip.ResumeLayout(false);
            this.fillByNomeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).EndInit();
            this.telaEditar.ResumeLayout(false);
            this.telaEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos_Entrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabPage telaPesquisa;
        private System.Windows.Forms.ToolStrip fillByNomeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripButton btnPesquisa;
        public System.Windows.Forms.DataGridView dgEntradas;
        private System.Windows.Forms.TabPage telaEditar;
        private System.Windows.Forms.Button btnFormPesquisa_Produto;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.DataGridView dgProdutos_Entrada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        public System.Windows.Forms.TextBox txtQuantidadeEntrada;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPrecoEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        public System.Windows.Forms.DateTimePicker dtDataEntrada;
        public System.Windows.Forms.Button btnSalvarEntrada;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFormPesquisaFornecedor;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtNomeProduto;
    }
}
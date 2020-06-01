namespace AvaliacaoA1.View
{
    partial class FormHistoricoRetiradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoricoRetiradas));
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
            this.dgRetiradas = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.telaEditar = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFormPesquisaFornecedor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.btnFormPesquisa_Produto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.dgProdutos_Retiradas = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtQuantidadeRetirada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.dtDataRetirada = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarRetirada = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.telaPesquisa.SuspendLayout();
            this.fillByNomeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRetiradas)).BeginInit();
            this.telaEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos_Retiradas)).BeginInit();
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
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(468, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "HISTÓRICO DE RETIRADAS\r\n";
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
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(538, 15);
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
            this.tabControl1.Location = new System.Drawing.Point(-7, 55);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1193, 498);
            this.tabControl1.TabIndex = 9;
            // 
            // telaPesquisa
            // 
            this.telaPesquisa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaPesquisa.Controls.Add(this.fillByNomeToolStrip);
            this.telaPesquisa.Controls.Add(this.dgRetiradas);
            this.telaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaPesquisa.Location = new System.Drawing.Point(4, 26);
            this.telaPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Name = "telaPesquisa";
            this.telaPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Size = new System.Drawing.Size(1185, 468);
            this.telaPesquisa.TabIndex = 0;
            this.telaPesquisa.Text = "Pesquisar";
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
            this.fillByNomeToolStrip.Location = new System.Drawing.Point(426, 75);
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
            // dgRetiradas
            // 
            this.dgRetiradas.AllowUserToAddRows = false;
            this.dgRetiradas.AllowUserToDeleteRows = false;
            this.dgRetiradas.AllowUserToOrderColumns = true;
            this.dgRetiradas.BackgroundColor = System.Drawing.Color.Black;
            this.dgRetiradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRetiradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dgRetiradas.Location = new System.Drawing.Point(19, 143);
            this.dgRetiradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgRetiradas.Name = "dgRetiradas";
            this.dgRetiradas.ReadOnly = true;
            this.dgRetiradas.RowHeadersWidth = 51;
            this.dgRetiradas.RowTemplate.Height = 24;
            this.dgRetiradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRetiradas.Size = new System.Drawing.Size(1153, 292);
            this.dgRetiradas.TabIndex = 5;
            this.dgRetiradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRetiradas_CellContentClick);
            this.dgRetiradas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgRetiradas_CellFormatting);
            this.dgRetiradas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgRetiradas_DataBindingComplete);
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
            this.telaEditar.Controls.Add(this.label5);
            this.telaEditar.Controls.Add(this.txtNomeProduto);
            this.telaEditar.Controls.Add(this.txtIdFornecedor);
            this.telaEditar.Controls.Add(this.label8);
            this.telaEditar.Controls.Add(this.btnFormPesquisaFornecedor);
            this.telaEditar.Controls.Add(this.label7);
            this.telaEditar.Controls.Add(this.txtNomeFantasia);
            this.telaEditar.Controls.Add(this.btnFormPesquisa_Produto);
            this.telaEditar.Controls.Add(this.label6);
            this.telaEditar.Controls.Add(this.txtIdProduto);
            this.telaEditar.Controls.Add(this.dgProdutos_Retiradas);
            this.telaEditar.Controls.Add(this.txtQuantidadeRetirada);
            this.telaEditar.Controls.Add(this.label1);
            this.telaEditar.Controls.Add(this.label4);
            this.telaEditar.Controls.Add(this.labelNomeProduto);
            this.telaEditar.Controls.Add(this.dtDataRetirada);
            this.telaEditar.Controls.Add(this.btnSalvarRetirada);
            this.telaEditar.Location = new System.Drawing.Point(4, 26);
            this.telaEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Name = "telaEditar";
            this.telaEditar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Size = new System.Drawing.Size(1185, 468);
            this.telaEditar.TabIndex = 1;
            this.telaEditar.Text = "Editar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(376, 133);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(240, 26);
            this.txtNomeProduto.TabIndex = 61;
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(60, 69);
            this.txtIdFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(157, 26);
            this.txtIdFornecedor.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(56, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 21);
            this.label8.TabIndex = 60;
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
            this.btnFormPesquisaFornecedor.Location = new System.Drawing.Point(224, 69);
            this.btnFormPesquisaFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisaFornecedor.Name = "btnFormPesquisaFornecedor";
            this.btnFormPesquisaFornecedor.Size = new System.Drawing.Size(63, 26);
            this.btnFormPesquisaFornecedor.TabIndex = 58;
            this.btnFormPesquisaFornecedor.UseVisualStyleBackColor = false;
            this.btnFormPesquisaFornecedor.Click += new System.EventHandler(this.btnFormPesquisaFornecedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Fornecedor:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(299, 68);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(303, 26);
            this.txtNomeFantasia.TabIndex = 56;
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
            this.btnFormPesquisa_Produto.Location = new System.Drawing.Point(307, 133);
            this.btnFormPesquisa_Produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisa_Produto.Name = "btnFormPesquisa_Produto";
            this.btnFormPesquisa_Produto.Size = new System.Drawing.Size(63, 26);
            this.btnFormPesquisa_Produto.TabIndex = 47;
            this.btnFormPesquisa_Produto.UseVisualStyleBackColor = false;
            this.btnFormPesquisa_Produto.Click += new System.EventHandler(this.btnPesquisa_Produtos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Código:";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(60, 133);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(240, 27);
            this.txtIdProduto.TabIndex = 45;
            // 
            // dgProdutos_Retiradas
            // 
            this.dgProdutos_Retiradas.BackgroundColor = System.Drawing.Color.Black;
            this.dgProdutos_Retiradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos_Retiradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar});
            this.dgProdutos_Retiradas.GridColor = System.Drawing.Color.Black;
            this.dgProdutos_Retiradas.Location = new System.Drawing.Point(60, 178);
            this.dgProdutos_Retiradas.Margin = new System.Windows.Forms.Padding(4);
            this.dgProdutos_Retiradas.Name = "dgProdutos_Retiradas";
            this.dgProdutos_Retiradas.RowHeadersWidth = 51;
            this.dgProdutos_Retiradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos_Retiradas.Size = new System.Drawing.Size(1072, 217);
            this.dgProdutos_Retiradas.TabIndex = 44;
            this.dgProdutos_Retiradas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgProdutos_Retiradas_DataBindingComplete);
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = "";
            this.selecionar.MinimumWidth = 6;
            this.selecionar.Name = "selecionar";
            this.selecionar.Width = 125;
            // 
            // txtQuantidadeRetirada
            // 
            this.txtQuantidadeRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeRetirada.Location = new System.Drawing.Point(622, 132);
            this.txtQuantidadeRetirada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidadeRetirada.Name = "txtQuantidadeRetirada";
            this.txtQuantidadeRetirada.Size = new System.Drawing.Size(160, 27);
            this.txtQuantidadeRetirada.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(617, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1071, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Produtos:";
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.Location = new System.Drawing.Point(617, 44);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(101, 21);
            this.labelNomeProduto.TabIndex = 38;
            this.labelNomeProduto.Text = "Data de Entrada:";
            // 
            // dtDataRetirada
            // 
            this.dtDataRetirada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataRetirada.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtDataRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataRetirada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataRetirada.Location = new System.Drawing.Point(621, 70);
            this.dtDataRetirada.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataRetirada.Name = "dtDataRetirada";
            this.dtDataRetirada.Size = new System.Drawing.Size(240, 24);
            this.dtDataRetirada.TabIndex = 37;
            // 
            // btnSalvarRetirada
            // 
            this.btnSalvarRetirada.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarRetirada.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarRetirada.FlatAppearance.BorderSize = 2;
            this.btnSalvarRetirada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarRetirada.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvarRetirada.Location = new System.Drawing.Point(544, 401);
            this.btnSalvarRetirada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarRetirada.Name = "btnSalvarRetirada";
            this.btnSalvarRetirada.Size = new System.Drawing.Size(140, 38);
            this.btnSalvarRetirada.TabIndex = 29;
            this.btnSalvarRetirada.Text = "SALVAR";
            this.btnSalvarRetirada.UseVisualStyleBackColor = false;
            this.btnSalvarRetirada.Click += new System.EventHandler(this.btnSalvarRetirada_Click);
            // 
            // FormHistoricoRetiradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHistoricoRetiradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de Retiradas";
            this.Load += new System.EventHandler(this.FormHistoricoRetiradas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.telaPesquisa.ResumeLayout(false);
            this.telaPesquisa.PerformLayout();
            this.fillByNomeToolStrip.ResumeLayout(false);
            this.fillByNomeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRetiradas)).EndInit();
            this.telaEditar.ResumeLayout(false);
            this.telaEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos_Retiradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage telaPesquisa;
        private System.Windows.Forms.ToolStrip fillByNomeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripButton btnPesquisa;
        public System.Windows.Forms.DataGridView dgRetiradas;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.TabPage telaEditar;
        private System.Windows.Forms.Button btnFormPesquisa_Produto;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.DataGridView dgProdutos_Retiradas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        public System.Windows.Forms.TextBox txtQuantidadeRetirada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNomeProduto;
        public System.Windows.Forms.DateTimePicker dtDataRetirada;
        private System.Windows.Forms.Button btnSalvarRetirada;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFormPesquisaFornecedor;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNomeProduto;
    }
}
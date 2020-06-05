namespace AvaliacaoA1.View
{
    partial class FormGerenciarFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarFornecedores));
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
            this.dgFornecedores = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.telaEditar = new System.Windows.Forms.TabPage();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtLoteFornecedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuadraFornecedor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAlamedaFornecedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairroFornecedor = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailFornecedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarFornecedor = new System.Windows.Forms.Button();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.telaPesquisa.SuspendLayout();
            this.fillByNomeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).BeginInit();
            this.telaEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(450, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "GERENCIAR FORNECEDORES";
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
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(542, 13);
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.telaPesquisa);
            this.tabControl1.Controls.Add(this.telaEditar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-8, 55);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 495);
            this.tabControl1.TabIndex = 4;
            // 
            // telaPesquisa
            // 
            this.telaPesquisa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaPesquisa.Controls.Add(this.fillByNomeToolStrip);
            this.telaPesquisa.Controls.Add(this.dgFornecedores);
            this.telaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaPesquisa.Location = new System.Drawing.Point(4, 26);
            this.telaPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Name = "telaPesquisa";
            this.telaPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Size = new System.Drawing.Size(1191, 465);
            this.telaPesquisa.TabIndex = 0;
            this.telaPesquisa.Text = "Pesquisa";
            // 
            // fillByNomeToolStrip
            // 
            this.fillByNomeToolStrip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fillByNomeToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.fillByNomeToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByNomeToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByNomeToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByNomeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPesquisa,
            this.btnPesquisa});
            this.fillByNomeToolStrip.Location = new System.Drawing.Point(435, 75);
            this.fillByNomeToolStrip.Name = "fillByNomeToolStrip";
            this.fillByNomeToolStrip.Size = new System.Drawing.Size(320, 27);
            this.fillByNomeToolStrip.TabIndex = 6;
            this.fillByNomeToolStrip.Text = "fillByNomeToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // dgFornecedores
            // 
            this.dgFornecedores.AllowUserToAddRows = false;
            this.dgFornecedores.AllowUserToDeleteRows = false;
            this.dgFornecedores.AllowUserToOrderColumns = true;
            this.dgFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFornecedores.BackgroundColor = System.Drawing.Color.Black;
            this.dgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dgFornecedores.GridColor = System.Drawing.Color.Black;
            this.dgFornecedores.Location = new System.Drawing.Point(15, 146);
            this.dgFornecedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgFornecedores.Name = "dgFornecedores";
            this.dgFornecedores.ReadOnly = true;
            this.dgFornecedores.RowHeadersWidth = 51;
            this.dgFornecedores.RowTemplate.Height = 24;
            this.dgFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornecedores.Size = new System.Drawing.Size(1152, 282);
            this.dgFornecedores.TabIndex = 5;
            this.dgFornecedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFornecedores_CellContentClick);
            this.dgFornecedores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFornecedores_CellFormatting);
            this.dgFornecedores.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgFornecedores_DataBindingComplete);
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = global::AvaliacaoA1.Properties.Resources.editar;
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.Width = 1099;
            // 
            // telaEditar
            // 
            this.telaEditar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaEditar.Controls.Add(this.txtNomeFornecedor);
            this.telaEditar.Controls.Add(this.label6);
            this.telaEditar.Controls.Add(this.label7);
            this.telaEditar.Controls.Add(this.cbStatus);
            this.telaEditar.Controls.Add(this.label4);
            this.telaEditar.Controls.Add(this.txtNomeFantasia);
            this.telaEditar.Controls.Add(this.txtLoteFornecedor);
            this.telaEditar.Controls.Add(this.label12);
            this.telaEditar.Controls.Add(this.txtQuadraFornecedor);
            this.telaEditar.Controls.Add(this.label13);
            this.telaEditar.Controls.Add(this.txtAlamedaFornecedor);
            this.telaEditar.Controls.Add(this.label10);
            this.telaEditar.Controls.Add(this.label11);
            this.telaEditar.Controls.Add(this.txtBairroFornecedor);
            this.telaEditar.Controls.Add(this.txtCnpj);
            this.telaEditar.Controls.Add(this.label1);
            this.telaEditar.Controls.Add(this.txtEmailFornecedor);
            this.telaEditar.Controls.Add(this.label5);
            this.telaEditar.Controls.Add(this.label8);
            this.telaEditar.Controls.Add(this.txtTelefoneFornecedor);
            this.telaEditar.Controls.Add(this.btnSalvarFornecedor);
            this.telaEditar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaEditar.Location = new System.Drawing.Point(4, 26);
            this.telaEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Name = "telaEditar";
            this.telaEditar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Size = new System.Drawing.Size(1191, 465);
            this.telaEditar.TabIndex = 1;
            this.telaEditar.Text = "Editar";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.Location = new System.Drawing.Point(247, 82);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(333, 26);
            this.txtNomeFornecedor.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 89;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 73;
            this.label7.Text = "Fornecedor:";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(660, 304);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(155, 30);
            this.cbStatus.TabIndex = 88;
            this.cbStatus.Text = "Selecione...";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "Nome Fantasia:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(247, 156);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(333, 26);
            this.txtNomeFantasia.TabIndex = 86;
            // 
            // txtLoteFornecedor
            // 
            this.txtLoteFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoteFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoteFornecedor.Location = new System.Drawing.Point(871, 230);
            this.txtLoteFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoteFornecedor.Name = "txtLoteFornecedor";
            this.txtLoteFornecedor.Size = new System.Drawing.Size(120, 26);
            this.txtLoteFornecedor.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(867, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 21);
            this.label12.TabIndex = 83;
            this.label12.Text = "Lote:";
            // 
            // txtQuadraFornecedor
            // 
            this.txtQuadraFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuadraFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuadraFornecedor.Location = new System.Drawing.Point(661, 156);
            this.txtQuadraFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuadraFornecedor.Name = "txtQuadraFornecedor";
            this.txtQuadraFornecedor.Size = new System.Drawing.Size(331, 26);
            this.txtQuadraFornecedor.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(657, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 21);
            this.label13.TabIndex = 85;
            this.label13.Text = "Quadra:";
            // 
            // txtAlamedaFornecedor
            // 
            this.txtAlamedaFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlamedaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamedaFornecedor.Location = new System.Drawing.Point(660, 230);
            this.txtAlamedaFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlamedaFornecedor.Name = "txtAlamedaFornecedor";
            this.txtAlamedaFornecedor.Size = new System.Drawing.Size(155, 26);
            this.txtAlamedaFornecedor.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(656, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 81;
            this.label10.Text = "Alameda:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(657, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 79;
            this.label11.Text = "Bairro:";
            // 
            // txtBairroFornecedor
            // 
            this.txtBairroFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroFornecedor.Location = new System.Drawing.Point(661, 82);
            this.txtBairroFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairroFornecedor.Name = "txtBairroFornecedor";
            this.txtBairroFornecedor.Size = new System.Drawing.Size(331, 26);
            this.txtBairroFornecedor.TabIndex = 78;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(247, 304);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.Mask = "000.000.000.0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(168, 26);
            this.txtCnpj.TabIndex = 77;
            this.txtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "CNPJ:";
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFornecedor.Location = new System.Drawing.Point(247, 230);
            this.txtEmailFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(333, 26);
            this.txtEmailFornecedor.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 74;
            this.label5.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 70;
            this.label8.Text = "Telefone:";
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefoneFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(448, 304);
            this.txtTelefoneFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefoneFornecedor.Mask = "(99) 00000-0000";
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(132, 26);
            this.txtTelefoneFornecedor.TabIndex = 71;
            this.txtTelefoneFornecedor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnSalvarFornecedor
            // 
            this.btnSalvarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvarFornecedor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarFornecedor.FlatAppearance.BorderSize = 2;
            this.btnSalvarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFornecedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvarFornecedor.Location = new System.Drawing.Point(525, 374);
            this.btnSalvarFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarFornecedor.Name = "btnSalvarFornecedor";
            this.btnSalvarFornecedor.Size = new System.Drawing.Size(125, 38);
            this.btnSalvarFornecedor.TabIndex = 29;
            this.btnSalvarFornecedor.Text = "SALVAR";
            this.btnSalvarFornecedor.UseVisualStyleBackColor = false;
            this.btnSalvarFornecedor.Click += new System.EventHandler(this.btnSalvarFornecedor_Click);
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            // 
            // FormGerenciarFornecedores
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
            this.MinimumSize = new System.Drawing.Size(1199, 641);
            this.Name = "FormGerenciarFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Fornecedores";
            this.Load += new System.EventHandler(this.FormGerenciarFornecedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGerenciarFornecedores_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.telaPesquisa.ResumeLayout(false);
            this.telaPesquisa.PerformLayout();
            this.fillByNomeToolStrip.ResumeLayout(false);
            this.fillByNomeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornecedores)).EndInit();
            this.telaEditar.ResumeLayout(false);
            this.telaEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
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
        public System.Windows.Forms.DataGridView dgFornecedores;
        private System.Windows.Forms.TabPage telaEditar;
        private System.Windows.Forms.Button btnSalvarFornecedor;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtLoteFornecedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuadraFornecedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAlamedaFornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairroFornecedor;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn quadra;
        private System.Windows.Forms.DataGridViewTextBoxColumn alameda;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewImageColumn editar;
    }
}
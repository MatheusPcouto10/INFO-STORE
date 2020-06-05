namespace AvaliacaoA1
{
    partial class FormGerenciarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.telaPesquisa = new System.Windows.Forms.TabPage();
            this.fillByNomeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.btnPesquisa = new System.Windows.Forms.ToolStripButton();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.telaEditar = new System.Windows.Forms.TabPage();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuadraUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoteUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAlamedaUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairroUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefoneUsuario = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfUsuario = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lojaInformaticaDataSetUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaInformaticaDataSetUsuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lojaInformaticaDataSetUsuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.telaPesquisa.SuspendLayout();
            this.fillByNomeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.telaEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetUsuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetUsuariosBindingSource2)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(446, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "GERENCIAR USUÁRIOS";
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
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(518, 11);
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
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "editar";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Clique para editar o usuário";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.Frozen = true;
            this.dataGridViewImageColumn2.HeaderText = "excluir";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Clique aqui para excluir o usuário";
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.Frozen = true;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::AvaliacaoA1.Properties.Resources.editar;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ToolTipText = "Clique para editar o usuário";
            this.dataGridViewImageColumn3.Width = 30;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.Frozen = true;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.MinimumWidth = 6;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ToolTipText = "Clique aqui para excluir o usuário";
            this.dataGridViewImageColumn4.Width = 30;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.MinimumWidth = 6;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Width = 40;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.telaPesquisa);
            this.tabControl1.Controls.Add(this.telaEditar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-8, 64);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 484);
            this.tabControl1.TabIndex = 2;
            // 
            // telaPesquisa
            // 
            this.telaPesquisa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaPesquisa.Controls.Add(this.fillByNomeToolStrip);
            this.telaPesquisa.Controls.Add(this.dgUsuarios);
            this.telaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaPesquisa.Location = new System.Drawing.Point(4, 26);
            this.telaPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Name = "telaPesquisa";
            this.telaPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Size = new System.Drawing.Size(1191, 454);
            this.telaPesquisa.TabIndex = 0;
            this.telaPesquisa.Text = "Pesquisa";
            // 
            // fillByNomeToolStrip
            // 
            this.fillByNomeToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.fillByNomeToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByNomeToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByNomeToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByNomeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPesquisa,
            this.btnPesquisa});
            this.fillByNomeToolStrip.Location = new System.Drawing.Point(388, 71);
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
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AllowUserToOrderColumns = true;
            this.dgUsuarios.BackgroundColor = System.Drawing.Color.Black;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dgUsuarios.GridColor = System.Drawing.Color.Black;
            this.dgUsuarios.Location = new System.Drawing.Point(15, 146);
            this.dgUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.RowTemplate.Height = 24;
            this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuarios.Size = new System.Drawing.Size(1152, 276);
            this.dgUsuarios.TabIndex = 5;
            this.dgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellContentClick);
            this.dgUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgUsuarios_DataBindingComplete);
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = global::AvaliacaoA1.Properties.Resources.editar;
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 40;
            // 
            // telaEditar
            // 
            this.telaEditar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaEditar.Controls.Add(this.txtNomeUsuario);
            this.telaEditar.Controls.Add(this.label5);
            this.telaEditar.Controls.Add(this.txtEmailUsuario);
            this.telaEditar.Controls.Add(this.label13);
            this.telaEditar.Controls.Add(this.txtQuadraUsuario);
            this.telaEditar.Controls.Add(this.label12);
            this.telaEditar.Controls.Add(this.txtLoteUsuario);
            this.telaEditar.Controls.Add(this.label10);
            this.telaEditar.Controls.Add(this.txtAlamedaUsuario);
            this.telaEditar.Controls.Add(this.label11);
            this.telaEditar.Controls.Add(this.txtBairroUsuario);
            this.telaEditar.Controls.Add(this.label9);
            this.telaEditar.Controls.Add(this.dtNascimento);
            this.telaEditar.Controls.Add(this.txtTelefoneUsuario);
            this.telaEditar.Controls.Add(this.txtCpfUsuario);
            this.telaEditar.Controls.Add(this.label8);
            this.telaEditar.Controls.Add(this.label7);
            this.telaEditar.Controls.Add(this.cbTipoUsuario);
            this.telaEditar.Controls.Add(this.label4);
            this.telaEditar.Controls.Add(this.txtSenhaUsuario);
            this.telaEditar.Controls.Add(this.label14);
            this.telaEditar.Controls.Add(this.labelNome);
            this.telaEditar.Controls.Add(this.label6);
            this.telaEditar.Controls.Add(this.btnSalvarUsuario);
            this.telaEditar.Controls.Add(this.cbStatus);
            this.telaEditar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaEditar.Location = new System.Drawing.Point(4, 26);
            this.telaEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Name = "telaEditar";
            this.telaEditar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaEditar.Size = new System.Drawing.Size(1191, 454);
            this.telaEditar.TabIndex = 1;
            this.telaEditar.Text = "Editar";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(171, 50);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(333, 26);
            this.txtNomeUsuario.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 63;
            this.label5.Text = "E-mail:";
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUsuario.Location = new System.Drawing.Point(171, 112);
            this.txtEmailUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(333, 26);
            this.txtEmailUsuario.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(621, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 21);
            this.label13.TabIndex = 82;
            this.label13.Text = "Quadra:";
            // 
            // txtQuadraUsuario
            // 
            this.txtQuadraUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuadraUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuadraUsuario.Location = new System.Drawing.Point(625, 174);
            this.txtQuadraUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuadraUsuario.Name = "txtQuadraUsuario";
            this.txtQuadraUsuario.Size = new System.Drawing.Size(349, 26);
            this.txtQuadraUsuario.TabIndex = 81;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(820, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 21);
            this.label12.TabIndex = 80;
            this.label12.Text = "Lote:";
            // 
            // txtLoteUsuario
            // 
            this.txtLoteUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoteUsuario.Location = new System.Drawing.Point(824, 235);
            this.txtLoteUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoteUsuario.Name = "txtLoteUsuario";
            this.txtLoteUsuario.Size = new System.Drawing.Size(151, 26);
            this.txtLoteUsuario.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(621, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 78;
            this.label10.Text = "Alameda:";
            // 
            // txtAlamedaUsuario
            // 
            this.txtAlamedaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlamedaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamedaUsuario.Location = new System.Drawing.Point(624, 235);
            this.txtAlamedaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlamedaUsuario.Name = "txtAlamedaUsuario";
            this.txtAlamedaUsuario.Size = new System.Drawing.Size(132, 26);
            this.txtAlamedaUsuario.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(621, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 76;
            this.label11.Text = "Bairro:";
            // 
            // txtBairroUsuario
            // 
            this.txtBairroUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroUsuario.Location = new System.Drawing.Point(625, 112);
            this.txtBairroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairroUsuario.Name = "txtBairroUsuario";
            this.txtBairroUsuario.Size = new System.Drawing.Size(349, 26);
            this.txtBairroUsuario.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 74;
            this.label9.Text = "Data de Nascimento:";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtNascimento.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(171, 235);
            this.dtNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(232, 29);
            this.dtNascimento.TabIndex = 73;
            // 
            // txtTelefoneUsuario
            // 
            this.txtTelefoneUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefoneUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneUsuario.Location = new System.Drawing.Point(839, 50);
            this.txtTelefoneUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefoneUsuario.Mask = "(99) 00000-0000";
            this.txtTelefoneUsuario.Name = "txtTelefoneUsuario";
            this.txtTelefoneUsuario.Size = new System.Drawing.Size(136, 26);
            this.txtTelefoneUsuario.TabIndex = 72;
            this.txtTelefoneUsuario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCpfUsuario
            // 
            this.txtCpfUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpfUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfUsuario.Location = new System.Drawing.Point(625, 50);
            this.txtCpfUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfUsuario.Mask = "000.000.000-00";
            this.txtCpfUsuario.Name = "txtCpfUsuario";
            this.txtCpfUsuario.Size = new System.Drawing.Size(131, 26);
            this.txtCpfUsuario.TabIndex = 71;
            this.txtCpfUsuario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(835, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 70;
            this.label8.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(167, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tipo de Usuário:";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(171, 297);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(235, 30);
            this.cbTipoUsuario.TabIndex = 66;
            this.cbTipoUsuario.Text = "Selecione...";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 65;
            this.label4.Text = "Senha:";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(171, 174);
            this.txtSenhaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(331, 26);
            this.txtSenhaUsuario.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(621, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 21);
            this.label14.TabIndex = 61;
            this.label14.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(169, 25);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 21);
            this.labelNome.TabIndex = 35;
            this.labelNome.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(620, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Status:";
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarUsuario.FlatAppearance.BorderSize = 2;
            this.btnSalvarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvarUsuario.Location = new System.Drawing.Point(525, 374);
            this.btnSalvarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(125, 38);
            this.btnSalvarUsuario.TabIndex = 29;
            this.btnSalvarUsuario.Text = "SALVAR";
            this.btnSalvarUsuario.UseVisualStyleBackColor = false;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(624, 298);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(155, 30);
            this.cbStatus.TabIndex = 33;
            this.cbStatus.Text = "Selecione...";
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            // 
            // FormGerenciarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1181, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormGerenciarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuários";
            this.Load += new System.EventHandler(this.AdministracaoUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGerenciarUsuario_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.telaPesquisa.ResumeLayout(false);
            this.telaPesquisa.PerformLayout();
            this.fillByNomeToolStrip.ResumeLayout(false);
            this.fillByNomeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.telaEditar.ResumeLayout(false);
            this.telaEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetUsuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaInformaticaDataSetUsuariosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage telaPesquisa;
        private System.Windows.Forms.ToolStrip fillByNomeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripButton btnPesquisa;
        private System.Windows.Forms.TabPage telaEditar;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        public System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.BindingSource lojaInformaticaDataSetUsuariosBindingSource;
        private System.Windows.Forms.BindingSource lojaInformaticaDataSetUsuariosBindingSource1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuadraUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLoteUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAlamedaUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairroUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.MaskedTextBox txtTelefoneUsuario;
        private System.Windows.Forms.MaskedTextBox txtCpfUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource lojaInformaticaDataSetUsuariosBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn quadra;
        private System.Windows.Forms.DataGridViewTextBoxColumn alameda;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewImageColumn editar;
    }
}
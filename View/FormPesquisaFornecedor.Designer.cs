namespace AvaliacaoA1.View
{
    partial class FormPesquisaFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaFornecedor));
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            this.dgPesquisa_Fornecedores = new System.Windows.Forms.DataGridView();
            this.fornecedoresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa_Fornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.Location = new System.Drawing.Point(133, 50);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(333, 28);
            this.txtNomeFornecedor.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 75;
            this.label7.Text = "Fornecedor:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 89;
            this.label4.Text = "Nome Fantasia:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(500, 50);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(333, 28);
            this.txtNomeFantasia.TabIndex = 88;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(16, 127);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.Mask = "000.000.000.0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(236, 28);
            this.txtCnpj.TabIndex = 91;
            this.txtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "CNPJ:";
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFornecedor.Location = new System.Drawing.Point(16, 50);
            this.txtIdFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(85, 28);
            this.txtIdFornecedor.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 93;
            this.label12.Text = "Código:";
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPesquisarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisarFornecedor.FlatAppearance.BorderSize = 2;
            this.btnPesquisarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarFornecedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(651, 124);
            this.btnPesquisarFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(139, 35);
            this.btnPesquisarFornecedor.TabIndex = 94;
            this.btnPesquisarFornecedor.Text = "PESQUISAR";
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = false;
            this.btnPesquisarFornecedor.Click += new System.EventHandler(this.btnPesquisarFornecedor_Click);
            // 
            // dgPesquisa_Fornecedores
            // 
            this.dgPesquisa_Fornecedores.AllowUserToAddRows = false;
            this.dgPesquisa_Fornecedores.AllowUserToDeleteRows = false;
            this.dgPesquisa_Fornecedores.AllowUserToOrderColumns = true;
            this.dgPesquisa_Fornecedores.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPesquisa_Fornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPesquisa_Fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPesquisa_Fornecedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPesquisa_Fornecedores.GridColor = System.Drawing.Color.Black;
            this.dgPesquisa_Fornecedores.Location = new System.Drawing.Point(16, 177);
            this.dgPesquisa_Fornecedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPesquisa_Fornecedores.MultiSelect = false;
            this.dgPesquisa_Fornecedores.Name = "dgPesquisa_Fornecedores";
            this.dgPesquisa_Fornecedores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPesquisa_Fornecedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPesquisa_Fornecedores.RowHeadersWidth = 51;
            this.dgPesquisa_Fornecedores.RowTemplate.Height = 24;
            this.dgPesquisa_Fornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesquisa_Fornecedores.Size = new System.Drawing.Size(883, 256);
            this.dgPesquisa_Fornecedores.TabIndex = 95;
            this.dgPesquisa_Fornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisa_Fornecedores_CellClick);
            this.dgPesquisa_Fornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisa_Fornecedores_CellDoubleClick);
            this.dgPesquisa_Fornecedores.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgPesquisa_Fornecedores_DataBindingComplete);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(796, 124);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 35);
            this.btnLimpar.TabIndex = 96;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // nome
            // 
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 125;
            // 
            // cnpjFornecedor
            // 
            this.cnpjFornecedor.MinimumWidth = 6;
            this.cnpjFornecedor.Name = "cnpjFornecedor";
            this.cnpjFornecedor.Width = 125;
            // 
            // statusFornecedor
            // 
            this.statusFornecedor.MinimumWidth = 6;
            this.statusFornecedor.Name = "statusFornecedor";
            this.statusFornecedor.Width = 125;
            // 
            // fantasia
            // 
            this.fantasia.MinimumWidth = 6;
            this.fantasia.Name = "fantasia";
            this.fantasia.Width = 125;
            // 
            // FormPesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(920, 453);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgPesquisa_Fornecedores);
            this.Controls.Add(this.btnPesquisarFornecedor);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPesquisaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Fornecedor";
            this.Load += new System.EventHandler(this.FormPesquisaFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaFornecedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa_Fornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        public System.Windows.Forms.DataGridView dgPesquisa_Fornecedores;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource1;
        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.TextBox txtNomeFornecedor;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fantasia;
    }
}
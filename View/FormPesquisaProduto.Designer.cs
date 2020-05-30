namespace AvaliacaoA1.View
{
    partial class FormPesquisaProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgPesquisa_Produtos = new System.Windows.Forms.DataGridView();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.cbSubCategorias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(167, 107);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 34);
            this.btnLimpar.TabIndex = 107;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgPesquisa_Produtos
            // 
            this.dgPesquisa_Produtos.AllowUserToAddRows = false;
            this.dgPesquisa_Produtos.AllowUserToDeleteRows = false;
            this.dgPesquisa_Produtos.AllowUserToOrderColumns = true;
            this.dgPesquisa_Produtos.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPesquisa_Produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPesquisa_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPesquisa_Produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPesquisa_Produtos.GridColor = System.Drawing.Color.Black;
            this.dgPesquisa_Produtos.Location = new System.Drawing.Point(23, 146);
            this.dgPesquisa_Produtos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPesquisa_Produtos.MultiSelect = false;
            this.dgPesquisa_Produtos.Name = "dgPesquisa_Produtos";
            this.dgPesquisa_Produtos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPesquisa_Produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPesquisa_Produtos.RowHeadersWidth = 51;
            this.dgPesquisa_Produtos.RowTemplate.Height = 24;
            this.dgPesquisa_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesquisa_Produtos.Size = new System.Drawing.Size(883, 287);
            this.dgPesquisa_Produtos.TabIndex = 106;
            this.dgPesquisa_Produtos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisa_Produtos_CellClick);
            this.dgPesquisa_Produtos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisa_Produtos_CellDoubleClick);
            this.dgPesquisa_Produtos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgPesquisa_Produtos_DataBindingComplete);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPesquisarProduto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisarProduto.FlatAppearance.BorderSize = 2;
            this.btnPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProduto.Location = new System.Drawing.Point(23, 107);
            this.btnPesquisarProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(139, 34);
            this.btnPesquisarProduto.TabIndex = 105;
            this.btnPesquisarProduto.Text = "PESQUISAR";
            this.btnPesquisarProduto.UseVisualStyleBackColor = false;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(23, 50);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(85, 28);
            this.txtIdProduto.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 104;
            this.label12.Text = "Código:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 101;
            this.label1.Text = "Categoria:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(143, 50);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(333, 28);
            this.txtNomeProduto.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 98;
            this.label7.Text = "Produto:";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategorias.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(516, 50);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(169, 30);
            this.cbCategorias.TabIndex = 108;
            this.cbCategorias.Text = "Selecione...";
            // 
            // cbSubCategorias
            // 
            this.cbSubCategorias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSubCategorias.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategorias.FormattingEnabled = true;
            this.cbSubCategorias.Location = new System.Drawing.Point(705, 50);
            this.cbSubCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubCategorias.Name = "cbSubCategorias";
            this.cbSubCategorias.Size = new System.Drawing.Size(199, 30);
            this.cbSubCategorias.TabIndex = 109;
            this.cbSubCategorias.Text = "Selecione...";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(701, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 110;
            this.label2.Text = "Sub-Categoria:";
            // 
            // FormPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(920, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSubCategorias);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgPesquisa_Produtos);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormPesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produto";
            this.Load += new System.EventHandler(this.FormPesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa_Produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.DataGridView dgPesquisa_Produtos;
        private System.Windows.Forms.Button btnPesquisarProduto;
        public System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbCategorias;
        public System.Windows.Forms.ComboBox cbSubCategorias;
        private System.Windows.Forms.Label label2;
    }
}
namespace AvaliacaoA1.View
{
    partial class FormCadastroRetiradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroRetiradas));
            this.btnFormPesquisa_Produto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.dgProdutos_Retirada = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtQuantidadeRetirada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDespacharProduto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.dtDataRetirada = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFormPesquisaFornecedor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos_Retirada)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnFormPesquisa_Produto.Location = new System.Drawing.Point(300, 178);
            this.btnFormPesquisa_Produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisa_Produto.Name = "btnFormPesquisa_Produto";
            this.btnFormPesquisa_Produto.Size = new System.Drawing.Size(63, 26);
            this.btnFormPesquisa_Produto.TabIndex = 49;
            this.btnFormPesquisa_Produto.UseVisualStyleBackColor = false;
            this.btnFormPesquisa_Produto.Click += new System.EventHandler(this.btnFormPesquisa_Produto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "Código:";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdProduto.Location = new System.Drawing.Point(53, 178);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(240, 26);
            this.txtIdProduto.TabIndex = 47;
            // 
            // dgProdutos_Retirada
            // 
            this.dgProdutos_Retirada.BackgroundColor = System.Drawing.Color.Black;
            this.dgProdutos_Retirada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos_Retirada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar});
            this.dgProdutos_Retirada.Location = new System.Drawing.Point(53, 220);
            this.dgProdutos_Retirada.Margin = new System.Windows.Forms.Padding(4);
            this.dgProdutos_Retirada.Name = "dgProdutos_Retirada";
            this.dgProdutos_Retirada.RowHeadersWidth = 51;
            this.dgProdutos_Retirada.Size = new System.Drawing.Size(1077, 246);
            this.dgProdutos_Retirada.TabIndex = 46;
            this.dgProdutos_Retirada.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgProdutos_Retirada_DataBindingComplete);
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
            this.txtQuantidadeRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtQuantidadeRetirada.Location = new System.Drawing.Point(627, 177);
            this.txtQuantidadeRetirada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidadeRetirada.Name = "txtQuantidadeRetirada";
            this.txtQuantidadeRetirada.Size = new System.Drawing.Size(163, 26);
            this.txtQuantidadeRetirada.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Quantidade:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(656, 480);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 38);
            this.btnLimpar.TabIndex = 45;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDespacharProduto
            // 
            this.btnDespacharProduto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDespacharProduto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDespacharProduto.FlatAppearance.BorderSize = 2;
            this.btnDespacharProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespacharProduto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespacharProduto.Location = new System.Drawing.Point(410, 481);
            this.btnDespacharProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDespacharProduto.Name = "btnDespacharProduto";
            this.btnDespacharProduto.Size = new System.Drawing.Size(240, 38);
            this.btnDespacharProduto.TabIndex = 44;
            this.btnDespacharProduto.Text = "DESPACHAR REMESSA";
            this.btnDespacharProduto.UseVisualStyleBackColor = false;
            this.btnDespacharProduto.Click += new System.EventHandler(this.btnDespacharProduto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1058, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Produtos:";
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProduto.Location = new System.Drawing.Point(599, 87);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(123, 21);
            this.labelNomeProduto.TabIndex = 38;
            this.labelNomeProduto.Text = "Data de Retirada:";
            // 
            // dtDataRetirada
            // 
            this.dtDataRetirada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataRetirada.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtDataRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataRetirada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataRetirada.Location = new System.Drawing.Point(603, 113);
            this.dtDataRetirada.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataRetirada.Name = "dtDataRetirada";
            this.dtDataRetirada.Size = new System.Drawing.Size(240, 24);
            this.dtDataRetirada.TabIndex = 37;
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
            this.panel1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(419, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "RETIRADA DE PRODUTOS\r\n";
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
            this.panel2.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(507, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "Feito por Matheus Pimentel  \r\n 2020\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(53, 113);
            this.txtIdFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(157, 26);
            this.txtIdFornecedor.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 21);
            this.label8.TabIndex = 56;
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
            this.btnFormPesquisaFornecedor.Location = new System.Drawing.Point(217, 113);
            this.btnFormPesquisaFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisaFornecedor.Name = "btnFormPesquisaFornecedor";
            this.btnFormPesquisaFornecedor.Size = new System.Drawing.Size(63, 26);
            this.btnFormPesquisaFornecedor.TabIndex = 54;
            this.btnFormPesquisaFornecedor.UseVisualStyleBackColor = false;
            this.btnFormPesquisaFornecedor.Click += new System.EventHandler(this.btnFormPesquisaFornecedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Fornecedor:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(292, 112);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(303, 26);
            this.txtNomeFantasia.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(369, 177);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(240, 26);
            this.txtNomeProduto.TabIndex = 57;
            // 
            // FormCadastroRetiradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1181, 594);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFormPesquisaFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFormPesquisa_Produto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.dgProdutos_Retirada);
            this.Controls.Add(this.txtQuantidadeRetirada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDespacharProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.dtDataRetirada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormCadastroRetiradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retiradas";
            this.Load += new System.EventHandler(this.FormCadastroRetiradas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroRetiradas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos_Retirada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFormPesquisa_Produto;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.DataGridView dgProdutos_Retirada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        public System.Windows.Forms.TextBox txtQuantidadeRetirada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDespacharProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.DateTimePicker dtDataRetirada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFormPesquisaFornecedor;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNomeProduto;
    }
}
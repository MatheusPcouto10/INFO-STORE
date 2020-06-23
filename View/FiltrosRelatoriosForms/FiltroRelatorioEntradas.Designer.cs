namespace AvaliacaoA1.View.FiltrosRelatoriosForms
{
    partial class FiltroRelatorioEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroRelatorioEntradas));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImprimirRelatorio = new System.Windows.Forms.Button();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFormPesquisa_Produto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFormPesquisaFornecedor = new System.Windows.Forms.Button();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(438, 365);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 38);
            this.btnLimpar.TabIndex = 46;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImprimirRelatorio
            // 
            this.btnImprimirRelatorio.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnImprimirRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImprimirRelatorio.FlatAppearance.BorderSize = 2;
            this.btnImprimirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirRelatorio.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelatorio.Location = new System.Drawing.Point(258, 365);
            this.btnImprimirRelatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimirRelatorio.Name = "btnImprimirRelatorio";
            this.btnImprimirRelatorio.Size = new System.Drawing.Size(165, 38);
            this.btnImprimirRelatorio.TabIndex = 41;
            this.btnImprimirRelatorio.Text = "IMPRIMIR";
            this.btnImprimirRelatorio.UseVisualStyleBackColor = false;
            this.btnImprimirRelatorio.Click += new System.EventHandler(this.btnImprimirRelatorio_Click);
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.Location = new System.Drawing.Point(12, 30);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(106, 21);
            this.labelNomeProduto.TabIndex = 69;
            this.labelNomeProduto.Text = "Período Inicial:";
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataInicial.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicial.Location = new System.Drawing.Point(16, 56);
            this.dtDataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(240, 24);
            this.dtDataInicial.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(313, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 71;
            this.label3.Text = "Período Final:";
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.CalendarFont = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataFinal.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(317, 56);
            this.dtDataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(240, 24);
            this.dtDataFinal.TabIndex = 70;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(254, 162);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(303, 26);
            this.txtNomeProduto.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(250, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Produto:";
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
            this.btnFormPesquisa_Produto.Location = new System.Drawing.Point(179, 162);
            this.btnFormPesquisa_Produto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisa_Produto.Name = "btnFormPesquisa_Produto";
            this.btnFormPesquisa_Produto.Size = new System.Drawing.Size(63, 27);
            this.btnFormPesquisa_Produto.TabIndex = 55;
            this.btnFormPesquisa_Produto.UseVisualStyleBackColor = false;
            this.btnFormPesquisa_Produto.Click += new System.EventHandler(this.btnFormPesquisa_Produto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Código:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdProduto.Location = new System.Drawing.Point(16, 162);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(157, 26);
            this.txtIdProduto.TabIndex = 56;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(254, 239);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(303, 26);
            this.txtNomeFantasia.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(250, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 59;
            this.label7.Text = "Fornecedor:";
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
            this.btnFormPesquisaFornecedor.Location = new System.Drawing.Point(179, 239);
            this.btnFormPesquisaFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormPesquisaFornecedor.Name = "btnFormPesquisaFornecedor";
            this.btnFormPesquisaFornecedor.Size = new System.Drawing.Size(63, 26);
            this.btnFormPesquisaFornecedor.TabIndex = 60;
            this.btnFormPesquisaFornecedor.UseVisualStyleBackColor = false;
            this.btnFormPesquisaFornecedor.Click += new System.EventHandler(this.btnFormPesquisaFornecedor_Click);
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(16, 239);
            this.txtIdFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(157, 26);
            this.txtIdFornecedor.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 72;
            this.label4.Text = "ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FiltroRelatorioEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(615, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDataFinal);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.dtDataInicial);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.btnFormPesquisaFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFormPesquisa_Produto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnImprimirRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiltroRelatorioEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Relatório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimirRelatorio;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        public System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFormPesquisa_Produto;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtIdProduto;
        public System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFormPesquisaFornecedor;
        public System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Label label4;
    }
}
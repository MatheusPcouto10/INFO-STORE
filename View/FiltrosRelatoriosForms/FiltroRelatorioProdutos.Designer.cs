namespace AvaliacaoA1.View.FiltrosRelatoriosForms
{
    partial class FiltroRelatorioProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroRelatorioProdutos));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnImprimirRelatorio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(427, 260);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 38);
            this.btnLimpar.TabIndex = 46;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Em Atividade",
            "Fora de Atividade"});
            this.cbStatus.Location = new System.Drawing.Point(16, 147);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(267, 29);
            this.cbStatus.TabIndex = 44;
            this.cbStatus.Text = "Selecione...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategoria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cbCategoria.Location = new System.Drawing.Point(16, 54);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(267, 29);
            this.cbCategoria.TabIndex = 42;
            this.cbCategoria.Text = "Selecione...";
            // 
            // btnImprimirRelatorio
            // 
            this.btnImprimirRelatorio.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnImprimirRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImprimirRelatorio.FlatAppearance.BorderSize = 2;
            this.btnImprimirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirRelatorio.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRelatorio.Location = new System.Drawing.Point(247, 260);
            this.btnImprimirRelatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimirRelatorio.Name = "btnImprimirRelatorio";
            this.btnImprimirRelatorio.Size = new System.Drawing.Size(165, 38);
            this.btnImprimirRelatorio.TabIndex = 41;
            this.btnImprimirRelatorio.Text = "IMPRIMIR";
            this.btnImprimirRelatorio.UseVisualStyleBackColor = false;
            this.btnImprimirRelatorio.Click += new System.EventHandler(this.btnImprimirRelatorio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Sub-Categoria:";
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSubCategoria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbSubCategoria.Location = new System.Drawing.Point(302, 54);
            this.cbSubCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(267, 29);
            this.cbSubCategoria.TabIndex = 47;
            this.cbSubCategoria.Text = "Selecione...";
            // 
            // FiltroRelatorioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(604, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSubCategoria);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnImprimirRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiltroRelatorioProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Relatório";
            this.Load += new System.EventHandler(this.FiltroRelatorioProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnImprimirRelatorio;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbSubCategoria;
    }
}
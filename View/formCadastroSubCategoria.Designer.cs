namespace AvaliacaoA1.View
{
    partial class formCadastroSubCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastroSubCategoria));
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeSubCategoria = new System.Windows.Forms.TextBox();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarSubCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProduto.Location = new System.Drawing.Point(15, 27);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(162, 23);
            this.labelNomeProduto.TabIndex = 22;
            this.labelNomeProduto.Text = "Nome da Sub-categoria:";
            // 
            // txtNomeSubCategoria
            // 
            this.txtNomeSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSubCategoria.Location = new System.Drawing.Point(15, 50);
            this.txtNomeSubCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeSubCategoria.Name = "txtNomeSubCategoria";
            this.txtNomeSubCategoria.Size = new System.Drawing.Size(267, 26);
            this.txtNomeSubCategoria.TabIndex = 21;
            // 
            // cbCategorias
            // 
            this.cbCategorias.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategorias.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(15, 130);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(267, 29);
            this.cbCategorias.TabIndex = 32;
            this.cbCategorias.Text = "Selecione...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selecione a categoria:";
            // 
            // btnCadastrarSubCategoria
            // 
            this.btnCadastrarSubCategoria.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarSubCategoria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarSubCategoria.FlatAppearance.BorderSize = 2;
            this.btnCadastrarSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSubCategoria.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarSubCategoria.Location = new System.Drawing.Point(117, 239);
            this.btnCadastrarSubCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarSubCategoria.Name = "btnCadastrarSubCategoria";
            this.btnCadastrarSubCategoria.Size = new System.Drawing.Size(165, 38);
            this.btnCadastrarSubCategoria.TabIndex = 34;
            this.btnCadastrarSubCategoria.Text = "CADASTRAR";
            this.btnCadastrarSubCategoria.UseVisualStyleBackColor = false;
            this.btnCadastrarSubCategoria.Click += new System.EventHandler(this.btnCadastrarSubCategoria_Click);
            // 
            // formCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(315, 302);
            this.Controls.Add(this.btnCadastrarSubCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.txtNomeSubCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formCadastroSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Sub-Categoria";
            this.Load += new System.EventHandler(this.formCadastroSubCategoria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formCadastroSubCategoria_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeProduto;
        public System.Windows.Forms.TextBox txtNomeSubCategoria;
        public System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarSubCategoria;
    }
}
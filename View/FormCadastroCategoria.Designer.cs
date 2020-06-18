namespace AvaliacaoA1.View
{
    partial class FormCadastroCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCategoria));
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProduto.Location = new System.Drawing.Point(12, 26);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(155, 23);
            this.labelNomeProduto.TabIndex = 24;
            this.labelNomeProduto.Text = "Nome da Categoria:";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCategoria.Location = new System.Drawing.Point(12, 50);
            this.txtNomeCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(267, 26);
            this.txtNomeCategoria.TabIndex = 23;
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarCategoria.FlatAppearance.BorderSize = 2;
            this.btnCadastrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCategoria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(114, 269);
            this.btnCadastrarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(165, 40);
            this.btnCadastrarCategoria.TabIndex = 35;
            this.btnCadastrarCategoria.Text = "CADASTRAR";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = false;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // FormCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(315, 321);
            this.Controls.Add(this.btnCadastrarCategoria);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.txtNomeCategoria);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormCadastroCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroCategoria";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroCategoria_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeProduto;
        public System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Button btnCadastrarCategoria;
    }
}
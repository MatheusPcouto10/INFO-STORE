namespace AvaliacaoA1.View
{
    partial class FormAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarSenha));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtConfirmarNovaSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(109, 224);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(125, 41);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtConfirmarNovaSenha
            // 
            this.txtConfirmarNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarNovaSenha.Location = new System.Drawing.Point(53, 166);
            this.txtConfirmarNovaSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmarNovaSenha.Name = "txtConfirmarNovaSenha";
            this.txtConfirmarNovaSenha.Size = new System.Drawing.Size(233, 26);
            this.txtConfirmarNovaSenha.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(49, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Confirmar Senha:";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(53, 108);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(233, 26);
            this.txtNovaSenha.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(49, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nova Senha:";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.Location = new System.Drawing.Point(53, 50);
            this.txtSenhaAtual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(233, 26);
            this.txtSenhaAtual.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(49, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Senha Atual:";
            // 
            // FormAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(341, 276);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtConfirmarNovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAlterarSenha_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtConfirmarNovaSenha;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label3;
    }
}
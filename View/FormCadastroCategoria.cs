using AvaliacaoA1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoA1.View
{
    public partial class FormCadastroCategoria : Form
    {
        Categorias categorias = new Categorias();
        public FormCadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNomeCategoria.Text != null)
            {
                categorias.nomeCategoria = txtNomeCategoria.Text;
                categorias.create(categorias);
            }
            else
            {
                MessageBox.Show("Campos não informados");
            }
        }

        private void FormCadastroCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnCadastrarCategoria_Click(null, null);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}

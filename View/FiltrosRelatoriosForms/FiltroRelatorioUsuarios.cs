using AvaliacaoA1.View.RelatoriosForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoA1.View.FiltrosRelatoriosForms
{
    public partial class FiltroRelatorioUsuarios : Form
    {
        public FiltroRelatorioUsuarios()
        {
            InitializeComponent();
        }

        private void btnImprimirRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorioUsuario form = new FormRelatorioUsuario();

            if (cbStatus.Text != "Selecione..." && cbTipoUsuario.Text != "Selecione...")
            {
                form.comando = "SELECT * FROM usuarios WHERE status = '" + cbStatus.Text + "' AND tipoUsuario = '" + cbTipoUsuario.Text + "'";
                form.Show();
            }
            else if (cbTipoUsuario.Text != "Selecione...")
            {
                form.comando = "SELECT * FROM usuarios WHERE tipoUsuario = '" + cbTipoUsuario.Text + "'";
                form.Show();
            }
            else if (cbStatus.Text != "Selecione...")
            {
                form.comando = "SELECT * FROM usuarios WHERE status = '" + cbStatus.Text + "'";
                form.Show();
            }
            else
            {
                form.comando = "SELECT * FROM usuarios";
                form.Show();
            }
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbTipoUsuario.Text = "Selecione...";
            cbStatus.Text = "Selecione...";
        }
    }
}

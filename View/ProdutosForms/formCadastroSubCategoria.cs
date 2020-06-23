using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoA1.View
{
    public partial class formCadastroSubCategoria : Form
    {
        SqlCommand cmd = new SqlCommand();
        SubCategorias subCategorias = new SubCategorias();
        public formCadastroSubCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrarSubCategoria_Click(object sender, EventArgs e)
        {
            if ((txtNomeSubCategoria.Text != ""))
            {
                subCategorias.nomeSubCategoria = txtNomeSubCategoria.Text;
                subCategorias.idCategoria_fk = (int)cbCategorias.SelectedValue;

                subCategorias.create(subCategorias);
            }
            else
            {
                MessageBox.Show("Campos não informados");
            }
        }

        private void preencheComboBoxCategorias()
        {
            cmd.CommandText = "SELECT * FROM categorias";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbCategorias.DisplayMember = "nomeCategoria";
                cbCategorias.ValueMember = "idCategoria";
                cbCategorias.DataSource = dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void formCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxCategorias();
        }

        private void formCadastroSubCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnCadastrarSubCategoria_Click(null, null);
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

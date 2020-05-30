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
    public partial class FormCadastroFornecedor : Form
    {
        Fornecedor fornecedor = new Fornecedor();
        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAlamedaFornecedor.Text = "";
            txtBairroFornecedor.Text = "";
            txtCnpj.Text = "";
            txtEmailFornecedor.Text = "";
            txtLoteFornecedor.Text = "";
            txtNomeFantasia.Text = "";
            txtNomeFornecedor.Text = "";
            txtQuadraFornecedor.Text = "";
            txtTelefoneFornecedor.Text = "";
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            if ((txtNomeFornecedor.Text != "") && (txtCnpj.Text != "") && (txtEmailFornecedor.Text != "") && (txtTelefoneFornecedor.Text != "") &&
               (txtNomeFantasia.Text != "") && (txtQuadraFornecedor.Text != "") && (txtAlamedaFornecedor.Text != "") && (txtLoteFornecedor.Text != ""))
            {
                fornecedor.nomeFantasia = txtNomeFantasia.Text;
                fornecedor.nomeFornecedor = txtNomeFornecedor.Text;
                fornecedor.lote = txtLoteFornecedor.Text;
                fornecedor.quadra = txtQuadraFornecedor.Text;
                fornecedor.status = "Ativo";
                fornecedor.telefone = txtTelefoneFornecedor.Text;
                fornecedor.bairro = txtBairroFornecedor.Text;
                fornecedor.cnpj = txtCnpj.Text;
                fornecedor.alameda = txtAlamedaFornecedor.Text;
                fornecedor.email = txtEmailFornecedor.Text;

                fornecedor.create(fornecedor);
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                this.btnLimpar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Informe os campos");
            }
        }
    }
}

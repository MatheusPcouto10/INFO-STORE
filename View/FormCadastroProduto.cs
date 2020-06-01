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

namespace AvaliacaoA1
{
    public partial class FormCadastroProduto : Form
    {
        SqlCommand cmd = new SqlCommand();
        Produtos produtos = new Produtos();
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisaImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();

            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                txtImagemProduto.Text = abrirArquivo.FileName;
                pbImagemProduto.ImageLocation = abrirArquivo.FileName;
            }
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxCategorias();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricaoProduto.Text = "";
            txtImagemProduto.Text = "";
            txtNomeProduto.Text = "";
            txtPreco.Text = "";
            cbCategorias.Text = "Selecione...";
            cbSubCategorias.Text = "Selecione...";
            pbImagemProduto.ImageLocation = null;
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNomeProduto.Text != "") && (txtDescricaoProduto.Text != "") && (txtPreco.Text != ""))
                {
                    produtos.nomeProduto = txtNomeProduto.Text;
                    produtos.descricao = txtDescricaoProduto.Text;
                    produtos.preco = Convert.ToDecimal(txtPreco.Text);
                    produtos.imagem = txtImagemProduto.Text;
                    produtos.Status = "Em Atividade";
                    produtos.subCategorias.idSubCategoria = (int)cbSubCategorias.SelectedValue;

                    produtos.create(produtos);
                    this.btnLimpar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Campos não informados");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex);
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
        private void preencheComboBoxSubCategorias()
        {
            cmd.CommandText = "SELECT * FROM subcategorias WHERE idCategoria_fk = " + (int)cbCategorias.SelectedValue;
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                // Categorias de Consoles
                cbSubCategorias.DisplayMember = "nomeSubCategoria";
                cbSubCategorias.ValueMember = "idSubCategorias";
                cbSubCategorias.DataSource = dt;

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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.preencheComboBoxSubCategorias();
        }
    }
}

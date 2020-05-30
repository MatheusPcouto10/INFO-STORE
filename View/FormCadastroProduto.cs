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
            cbCategoriaCelular.Visible = false;
            cbCategoriaComputador.Visible = false;
            cbCategoriaConsoles.Visible = false;
            this.preencheComboBoxPC();
            this.preencheComboBoxCelular();
            this.preencheComboBoxConsoles();
        }

        private void rbComputador_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoriaComputador.Visible = true;

            if (rbCelular.Checked == true || rbConsoles.Checked == true)
            {
                cbCategoriaComputador.Visible = false;
            }
        }

        private void rbCelular_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoriaCelular.Visible = true;

            if (rbComputador.Checked == true || rbConsoles.Checked == true)
            {
                cbCategoriaCelular.Visible = false;
            }
        }

        private void rbConsoles_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoriaConsoles.Visible = true;

            if (rbCelular.Checked == true || rbComputador.Checked == true)
            {
                cbCategoriaConsoles.Visible = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricaoProduto.Text = "";
            txtImagemProduto.Text = "";
            txtNomeProduto.Text = "";
            txtPreco.Text = "";
            rbConsoles.Checked = false;
            cbCategoriaConsoles.Visible = false;
            rbComputador.Checked = false;
            cbCategoriaComputador.Visible = false;
            rbCelular.Checked = false;
            cbCategoriaCelular.Visible = false;
            pbImagemProduto.ImageLocation = null;
        }

        private void preencheComboBoxPC()
        {
            cmd.CommandText = "SELECT * FROM subcategorias WHERE idCategoria_fk = 1";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr); 

                // Categorias de PC
                cbCategoriaComputador.DisplayMember = "nomeSubCategoria";
                cbCategoriaComputador.ValueMember = "idSubCategorias";
                cbCategoriaComputador.DataSource = dt;

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

        private void preencheComboBoxCelular()
        {
            cmd.CommandText = "SELECT * FROM subcategorias WHERE idCategoria_fk = 2";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                // Categorias de Celulares
                cbCategoriaCelular.DisplayMember = "nomeSubCategoria";
                cbCategoriaCelular.ValueMember = "idSubCategorias";
                cbCategoriaCelular.DataSource = dt;

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

        private void preencheComboBoxConsoles()
        {
            cmd.CommandText = "SELECT * FROM subcategorias WHERE idCategoria_fk = 3";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                // Categorias de Consoles
                cbCategoriaConsoles.DisplayMember = "nomeSubCategoria";
                cbCategoriaConsoles.ValueMember = "idSubCategorias";
                cbCategoriaConsoles.DataSource = dt;

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

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            if ((txtNomeProduto.Text != "") && (txtDescricaoProduto.Text != "") && (txtPreco.Text != ""))
            {
                produtos.nomeProduto = txtNomeProduto.Text;
                produtos.descricao = txtDescricaoProduto.Text;
                produtos.preco = Convert.ToDecimal(txtPreco.Text);
                produtos.imagem = txtImagemProduto.Text;
                produtos.Status = "Em Atividade";

                produtos.create(produtos);
                MessageBox.Show("Produto cadastrado com sucesso!");
                this.btnLimpar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Campos não informados");
            }

        }

        private void cbCategoriaComputador_SelectedIndexChanged(object sender, EventArgs e)
        {
            produtos.subCategorias.idSubCategoria = (int)cbCategoriaComputador.SelectedValue;
        }

        private void cbCategoriaCelular_SelectedIndexChanged(object sender, EventArgs e)
        {
            produtos.subCategorias.idSubCategoria = (int)cbCategoriaCelular.SelectedValue;
        }

        private void cbCategoriaConsoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            produtos.subCategorias.idSubCategoria = (int)cbCategoriaConsoles.SelectedValue;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

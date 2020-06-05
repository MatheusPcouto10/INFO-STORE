using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoA1.View
{
    public partial class FormEstoque : Form
    {
        public int idProduto;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        Produtos produtos = new Produtos();

        public FormEstoque()
        {
            InitializeComponent();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            this.preencheComboBoxCategorias();
            btnSalvarProduto.Enabled = false;

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                this.CarregarDataGrid();
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao.Conectar();

                    cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, 
                                           p.descricao, p.preco, p.imagem, p.status,
                                           e.qtdDisponivel, e.precoAtual
                                           FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                           ON p.idProduto = e.idProduto_fk 
                                           INNER JOIN dbo.SubCategorias AS s 
                                           ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                           ON s.idCategoria_fk = c.idCategoria AND p.idProduto = " + txtPesquisa.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgProdutos.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Produto Encontrado");
                    }
                }
                catch (Exception erro)
                {
                    // Exibe a mensagem de erro
                    MessageBox.Show("Erro: " +
                        erro.Message);
                }
                conexao.Desconectar();
            }
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

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if ((txtNomeProduto.Text != "") && (txtDescricaoProduto.Text != "") && (txtPreco.Text != ""))
            {
                produtos.nomeProduto = txtNomeProduto.Text;
                produtos.descricao = txtDescricaoProduto.Text;
                produtos.imagem = txtImagemProduto.Text;
                produtos.preco = Convert.ToDecimal(txtPreco.Text);
                produtos.Status = cbStatus.Text;
                produtos.subCategorias.idSubCategoria = (int)cbSubCategorias.SelectedValue;
                produtos.update(produtos, idProduto);

                tabControl1.SelectedIndex = 0;
                btnSalvarProduto.Enabled = false;
                this.CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Informe os campos");
            }
        }

        private void dgUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgProdutos.Columns)
            {
                switch (coluna.Name)
                {
                    case "idProduto":
                        coluna.Width = 30;
                        coluna.HeaderText = "ID";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeProduto":
                        coluna.Width = 150;
                        coluna.HeaderText = "Nome";
                        break;
                    case "nomeSubCategoria":
                        coluna.Width = 90;
                        coluna.HeaderText = "Sub-Categoria";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "descricao":
                        coluna.Width = 150;
                        coluna.HeaderText = "Descrição";
                        break;
                    case "preco":
                        coluna.Width = 70;
                        coluna.HeaderText = "Preço de Cadastro";
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "imagem":
                        coluna.Width = 120;
                        coluna.HeaderText = "URL-Imagem";
                        break;
                    case "qtdDisponivel":
                        coluna.Width = 65;
                        coluna.HeaderText = "Quantidade Disponível";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "precoAtual":
                        coluna.Width = 70;
                        coluna.HeaderText = "Preço Atual";
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "editar":
                        coluna.Width = 40;
                        coluna.DisplayIndex = 10;
                        break;
                    case "status":
                        coluna.Width = 80;
                        coluna.HeaderText = "Status";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeCategoria":
                        coluna.Width = 90;
                        coluna.HeaderText = "Categoria";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
                        break;
                }
            }
        }

        private void dgProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgProdutos.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // pegar o id para editar
            idProduto = Convert.ToInt32(dgProdutos.Rows[e.RowIndex].Cells["idProduto"].Value.ToString());

            //verificar qual a coluna clicada é a de editar
            if (dgProdutos.Columns[e.ColumnIndex] == dgProdutos.Columns["editar"])
            {
                try
                {
                    cmd.CommandText = "SELECT idCategoria FROM produtos,subcategorias,categorias " +
                                      "WHERE idCategoria_fk = idCategoria AND idSubCategoria_fk = idSubCategorias" +
                                      " AND idProduto = " + idProduto;

                    cmd.Connection = conexao.Conectar();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        txtNomeProduto.Text = dgProdutos.Rows[e.RowIndex].Cells["nomeProduto"].Value.ToString();
                        txtDescricaoProduto.Text = dgProdutos.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                        txtPreco.Text = dgProdutos.Rows[e.RowIndex].Cells["preco"].Value.ToString();
                        txtImagemProduto.Text = dgProdutos.Rows[e.RowIndex].Cells["imagem"].Value.ToString();
                        pbImagemProduto.ImageLocation = dgProdutos.Rows[e.RowIndex].Cells["imagem"].Value.ToString();
                        cbStatus.Text = dgProdutos.Rows[e.RowIndex].Cells["status"].Value.ToString();
                        cbCategorias.Text = dgProdutos.Rows[e.RowIndex].Cells["nomeCategoria"].Value.ToString();
                        cbSubCategorias.Text = dgProdutos.Rows[e.RowIndex].Cells["nomeSubCategoria"].Value.ToString();

                    }

                    tabControl1.SelectedIndex = 1;
                    btnSalvarProduto.Enabled = true;
                    conexao.Desconectar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex);
                }

            }
        }

        private void CarregarDataGrid()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, 
                                           p.descricao, p.preco, p.imagem, p.status,
                                           e.qtdDisponivel, e.precoAtual
                                           FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                           ON p.idProduto = e.idProduto_fk 
                                           INNER JOIN dbo.SubCategorias AS s 
                                           ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                           ON s.idCategoria_fk = c.idCategoria";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgProdutos.DataSource = dt; // Preenche o DataGridView
                }
                else
                {
                    MessageBox.Show("erro");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
            conexao.Desconectar();
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

        private void FormEstoque_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnPesquisa_Click(null, null);
                    break;
                default:
                    break;
            }

        }
    }
}

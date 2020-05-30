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
    public partial class FormPesquisaProduto : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string formAtual { get; set; }
        public FormPesquisaProduto()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdProduto.Text = "";
            txtNomeProduto.Text = "";
            cbCategorias.Text = "Selecione...";
            cbSubCategorias.Text = "Selecione...";
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            if ((txtIdProduto.Text == "") && (txtNomeProduto.Text == "") && (cbSubCategorias.Text == "Selecione...") && (cbCategorias.Text == "Selecione..."))
            {
                this.CarregarDataGridPesquisaProdutos();
            }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                if ((txtNomeProduto.Text == "") && (cbSubCategorias.Text == "Selecione...") && (txtIdProduto.Text != "") && (cbCategorias.Text == "Selecione..."))
                {
                    cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e
                                  ON p.idProduto = e.idProduto_fk INNER JOIN dbo.SubCategorias AS s
                                  ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                  ON s.idCategoria_fk = c.idCategoria AND p.status = 'Em Atividade' AND p.idProduto = " + txtIdProduto.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {
                        
                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgPesquisa_Produtos.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Produto encontrado");
                    }
                }
                else if ((txtNomeProduto.Text != "") && (cbSubCategorias.Text == "Selecione...") && (txtIdProduto.Text == "") && (cbCategorias.Text == "Selecione..."))
                {
                    cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e
                                  ON p.idProduto = e.idProduto_fk INNER JOIN dbo.SubCategorias AS s
                                  ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                  ON s.idCategoria_fk = c.idCategoria AND p.status = 'Em Atividade' AND p.nomeProduto LIKE '%" + txtNomeProduto.Text + "%'";

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgPesquisa_Produtos.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Produto encontrado");
                    }
                }
                else if ((txtNomeProduto.Text == "") && (cbSubCategorias.Text != "Selecione...") && (cbCategorias.Text == "Selecione...") && (txtIdProduto.Text == ""))
                {
                    cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e
                                  ON p.idProduto = e.idProduto_fk INNER JOIN dbo.SubCategorias AS s
                                  ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                  ON s.idCategoria_fk = c.idCategoria AND p.status = 'Em Atividade' AND s.idSubCategorias = " + (int)cbSubCategorias.SelectedValue;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {
                        
                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgPesquisa_Produtos.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Produto encontrado");
                    }
                }
                else if ((txtNomeProduto.Text == "") && (cbSubCategorias.Text == "Selecione...") && (cbCategorias.Text != "Selecione...") && (txtIdProduto.Text == ""))
                {
                    cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e
                                  ON p.idProduto = e.idProduto_fk INNER JOIN dbo.SubCategorias AS s
                                  ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                  ON s.idCategoria_fk = c.idCategoria AND p.status = 'Em Atividade' AND c.idCategoria = " + (int)cbCategorias.SelectedValue;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgPesquisa_Produtos.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Produto encontrado");
                    }
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
            cmd.CommandText = "SELECT * FROM subcategorias";
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

        private void CarregarDataGridPesquisaProdutos()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e
                                  ON p.idProduto = e.idProduto_fk INNER JOIN dbo.SubCategorias AS s
                                  ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                  ON s.idCategoria_fk = c.idCategoria AND p.status = 'Em Atividade'";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgPesquisa_Produtos.DataSource = dt; // Preenche o DataGridView
                }
                else
                {
                    MessageBox.Show("erro");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            conexao.Desconectar();
        }

        private void FormPesquisaProduto_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxCategorias();
            this.preencheComboBoxSubCategorias();
            this.CarregarDataGridPesquisaProdutos();
            cbCategorias.Text = "Selecione...";
            cbSubCategorias.Text = "Selecione...";
        }

        private void dgPesquisa_Produtos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeProduto.Text = dgPesquisa_Produtos.Rows[e.RowIndex].Cells["nomeProduto"].Value.ToString();
            txtIdProduto.Text = dgPesquisa_Produtos.Rows[e.RowIndex].Cells["idProduto"].Value.ToString();
            cbSubCategorias.Text = dgPesquisa_Produtos.Rows[e.RowIndex].Cells["nomeSubCategoria"].Value.ToString();
            cbCategorias.Text = dgPesquisa_Produtos.Rows[e.RowIndex].Cells["nomeCategoria"].Value.ToString();
        }

        private void dgPesquisa_Produtos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formAtual == "cadastroEntradas")
            {
                (Application.OpenForms["FormCadastroEntradas"].Controls["txtIdProduto"] as TextBox).Text = txtIdProduto.Text;
                (Application.OpenForms["FormCadastroEntradas"].Controls["txtNomeProduto"] as TextBox).Text = txtNomeProduto.Text;
                this.Hide();
            }
            else if (formAtual == "cadastroRetiradas")
            {
                (Application.OpenForms["FormCadastroRetiradas"].Controls["txtIdProduto"] as TextBox).Text = txtIdProduto.Text;
                (Application.OpenForms["FormCadastroRetiradas"].Controls["txtNomeProduto"] as TextBox).Text = txtNomeProduto.Text;
                this.Hide();
            }
            else if (formAtual == "historicoEntradas")
            {
                //(Application.OpenForms["FormHistoricoEntradas"].Controls["tabControl1"].Controls["telaEditar"].Controls["txtIdFornecedor"] as TextBox).Text = txtIdFornecedor.Text;
                //(Application.OpenForms["FormHistoricoEntradas"].Controls["tabControl1"].Controls["telaEditar"].Controls["txtNomeFantasia"] as TextBox).Text = txtNomeFantasia.Text;
                //this.Hide();
            }
            else if (formAtual == "historicoRetiradas")
            {
                //(Application.OpenForms["FormHistoricoRetiradas"].Controls["tabControl1"].Controls["telaEditar"].Controls["txtIdFornecedor"] as TextBox).Text = txtIdFornecedor.Text;
                //(Application.OpenForms["FormHistoricoRetiradas"].Controls["tabControl1"].Controls["telaEditar"].Controls["txtNomeFantasia"] as TextBox).Text = txtNomeFantasia.Text;
                //this.Hide();
            }
        }

        private void dgPesquisa_Produtos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgPesquisa_Produtos.Columns)
            {
                switch (coluna.Name)
                {
                    case "idProduto":
                        coluna.Width = 50;
                        coluna.HeaderText = "ID";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeProduto":
                        coluna.Width = 180;
                        coluna.HeaderText = "Produto";
                        break;
                    case "nomeCategoria":
                        coluna.Width = 100;
                        coluna.HeaderText = "Categoria";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeSubCategoria":
                        coluna.Width = 100;
                        coluna.HeaderText = "Sub-Categoria";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "qtdDisponivel":
                        coluna.Width = 80;
                        coluna.HeaderText = "Quantidade Disponível";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "precoAtual":
                        coluna.Width = 100;
                        coluna.HeaderText = "Preço Atual";
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

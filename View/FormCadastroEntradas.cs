using AvaliacaoA1.Model;
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
using AvaliacaoA1.Session;

namespace AvaliacaoA1.View
{
    public partial class FormCadastroEntradas : Form
    {
        public int idProduto;

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public FormCadastroEntradas()
        {
            InitializeComponent();
        }

        private void btnAdicionarEntradas_Click(object sender, EventArgs e)
        {
            if ((txtPrecoEntrada.Text != "") && (txtQuantidadeEntrada.Text != "") && (txtIdFornecedor.Text != "") && (bool.Parse(dgProdutos_Entrada.CurrentRow.Cells[0].FormattedValue.ToString()) == true))
            {
                Entradas entradas = new Entradas();

                foreach (DataGridViewRow check in dgProdutos_Entrada.Rows)
                {
                    if ((bool)check.Cells[0].FormattedValue)
                    {
                        entradas.idProduto = Convert.ToInt32(check.Cells[1].Value.ToString());
                    }
                }
                entradas.qtdEntrada = Convert.ToInt32(txtQuantidadeEntrada.Text);
                entradas.precoEntrada = Convert.ToDecimal(txtPrecoEntrada.Text);
                entradas.dataEntrada = dtDataEntrada.Value;
                entradas.idUsuario = UsuarioSession.idUsuario;
                entradas.idFornecedor = Convert.ToInt32(txtIdFornecedor.Text);
                entradas.create(entradas);
                MessageBox.Show("Remessa adicionada com sucesso!");
                this.CarregarDataGrid();
                this.btnLimpar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Campos não informados");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtPrecoEntrada.Text = "";
            txtQuantidadeEntrada.Text = "";
            txtNomeProduto.Text = "";
            txtIdFornecedor.Text = "";
            txtNomeFantasia.Text = "";
            txtIdProduto.Text = "";
            foreach (DataGridViewRow check in dgProdutos_Entrada.Rows)
            {
                if ((bool)check.Cells[0].FormattedValue)
                {
                    check.Cells[0].Value = null;
                }
            }
            this.CarregarDataGrid();

        }

        private void dgProdutos_Entrada_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgProdutos_Entrada.Columns)
            {
                switch (coluna.Name)
                {
                    case "idProduto":
                        coluna.Width = 100;
                        coluna.HeaderText = "Código";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeProduto":
                        coluna.Width = 230;
                        coluna.HeaderText = "Produto";
                        break;
                    case "qtdDisponivel":
                        coluna.Width = 100;
                        coluna.HeaderText = "Quantidade Disponível";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "precoAtual":
                        coluna.Width = 130;
                        coluna.HeaderText = "Preço Atual";
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "selecionar":
                        coluna.Width = 100;
                        break;
                    default:
                        break;
                }
            }
        }
        private void CarregarDataGrid()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                  ON p.idProduto = e.idProduto_fk AND p.status = 'Em Atividade'";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgProdutos_Entrada.DataSource = dt; // Preenche o DataGridView
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

        private void FormCadastroEntradas_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
        }

        public void btnPesquisa_Click(object sender, EventArgs e)
        {
            FormPesquisaProduto formPesquisaProduto = new FormPesquisaProduto();
            if (txtIdProduto.Text == "")
            {
                formPesquisaProduto.formAtual = "cadastroEntradas";
                formPesquisaProduto.Show();
            }
            else {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao.Conectar();

                    cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e
                                  ON p.idProduto = e.idProduto_fk AND p.status = 'Em Atividade' AND p.idProduto = " + txtIdProduto.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    if (dr.HasRows == true)
                    {
                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgProdutos_Entrada.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto encontrado");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFormPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FormPesquisaFornecedor formPesquisaFornecedor = new FormPesquisaFornecedor();
            if (txtIdFornecedor.Text == "")
            {
                formPesquisaFornecedor.formAtual = "cadastroEntradas";
                formPesquisaFornecedor.Show();
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                cmd.CommandText = @"SELECT idFornecedor,nomeFantasia
                                    FROM fornecedores WHERE idFornecedor = " + txtIdFornecedor.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                   txtIdFornecedor.Text = dr[0].ToString();
                   txtNomeFantasia.Text = dr[1].ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum fornecedor encontrado");
                }
                conexao.Desconectar();
            }

        }

        private void txtIdProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProduto.Text != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao.Conectar();

                    cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e
                                  ON p.idProduto = e.idProduto_fk AND p.status = 'Em Atividade' AND p.idProduto = " + txtIdProduto.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {
                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgProdutos_Entrada.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto encontrado");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            }

        }
    }
}



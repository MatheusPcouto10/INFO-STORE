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
using AvaliacaoA1.Model;
using AvaliacaoA1.Session;
namespace AvaliacaoA1.View
{
    public partial class FormHistoricoEntradas : Form
    {
        public int idEntrada;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public FormHistoricoEntradas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
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

                    cmd.CommandText = @"SELECT e.idEntradas, u.nome, p.nomeProduto, 
                                           e.qtdEntrada, e.dataEntrada, e.precoEntrada, e.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Entradas AS e INNER JOIN dbo.Usuarios AS u 
	                                       ON e.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p 
                                           ON e.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON e.idFornecedor_fk = f.idFornecedor AND e.idEntradas = " + txtPesquisa.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgEntradas.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Não encontrado");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            } 
        }

        private void dgEntradas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgEntradas.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
        }

        private void CarregarDataGrid()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT e.idEntradas, u.nome, p.nomeProduto, 
                                           e.qtdEntrada, e.dataEntrada, e.precoEntrada, e.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Entradas AS e INNER JOIN dbo.Usuarios AS u
	                                       ON e.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p
                                           ON e.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON e.idFornecedor_fk = f.idFornecedor";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgEntradas.DataSource = dt; // Preenche o DataGridView
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
        private void dgEntradas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgEntradas.Columns)
            {
                switch (coluna.Name)
                {
                    case "idEntradas":
                        coluna.Width = 50;
                        coluna.HeaderText = "ID";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nome":
                        coluna.Width = 150;
                        coluna.HeaderText = "Usuário";
                        break;
                    case "nomeProduto":
                        coluna.Width = 150;
                        coluna.HeaderText = "Produto";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "qtdEntrada":
                        coluna.Width = 80;
                        coluna.HeaderText = "Quantidade de Entrada";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "precoEntrada":
                        coluna.Width = 80;
                        coluna.HeaderText = "Preço de Entrada";
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "dataEntrada":
                        coluna.Width = 100;
                        coluna.HeaderText = "Data de Entrada";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "editar":
                        coluna.Width = 40;
                        coluna.DisplayIndex = 8;
                        break;
                    case "idFornecedor_fk":
                        coluna.Width = 80;
                        coluna.HeaderText = "Código do Fornecedor";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeFantasia":
                        coluna.Width = 150;
                        coluna.HeaderText = "Fornecedor";
                        break;
                    default:
                        break;
                }
            }
        }

        private void CarregarDataGridProdutos_Entradas()
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

        private void dgEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar o id para editar
            idEntrada = Convert.ToInt32(dgEntradas.Rows[e.RowIndex].Cells["idEntradas"].Value.ToString());

            //verificar qual a coluna clicada é a de editar
            if (dgEntradas.Columns[e.ColumnIndex] == dgEntradas.Columns["editar"])
            {
                try
                {
                    cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, e.qtdDisponivel, e.precoAtual
                                        FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                        ON p.idProduto = e.idProduto_fk AND p.nomeProduto =  '"
                                        + dgEntradas.Rows[e.RowIndex].Cells["nomeProduto"].Value.ToString() + "'";

                    cmd.Connection = conexao.Conectar();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        // Cria uma tabela genérica
                        DataTable dt = new DataTable();
                        dt.Load(dr); // Carrega os dados para o DataTable
                        dgProdutos_Entrada.DataSource = dt; // Preenche o DataGridView
                        DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();
                        chk.Value = true;

                    }
                    else
                    {
                        MessageBox.Show("erro");
                    }
                    txtPrecoEntrada.Text = dgEntradas.Rows[e.RowIndex].Cells["precoEntrada"].Value.ToString();
                    dtDataEntrada.Text = dgEntradas.Rows[e.RowIndex].Cells["dataEntrada"].Value.ToString();
                    txtQuantidadeEntrada.Text = dgEntradas.Rows[e.RowIndex].Cells["qtdEntrada"].Value.ToString();
                    txtIdFornecedor.Text = dgEntradas.Rows[e.RowIndex].Cells["idFornecedor_fk"].Value.ToString();
                    txtNomeFantasia.Text = dgEntradas.Rows[e.RowIndex].Cells["nomeFantasia"].Value.ToString();

                    tabControl1.SelectedIndex = 1;
                    btnSalvarEntrada.Enabled = true;
                    conexao.Desconectar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex);
                }
            }
        }

        private void FormHistoricoEntradas_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            this.CarregarDataGridProdutos_Entradas();
            this.btnSalvarEntrada.Enabled = false;
        }


        private void btnSalvarEntrada_Click(object sender, EventArgs e)
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
                entradas.idFornecedor = Convert.ToInt32(txtIdFornecedor.Text);
                entradas.idUsuario = UsuarioSession.idUsuario;

                entradas.update(entradas, idEntrada);
                MessageBox.Show("Remessa alterada com sucesso!");
                tabControl1.SelectedIndex = 0;
                btnSalvarEntrada.Enabled = false;
                this.CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Campos não informados");
            }
        }

        private void btnPesquisaProdutos_Entrada_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e
                                  ON p.idProduto = e.idProduto_fk AND p.status = 'Em Atividade' AND p.idProduto = " + txtPesquisaEntrada.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    DataTable dt = new DataTable();

                    dt.Load(dr);
                    dgProdutos_Entrada.DataSource = dt;

                }
                else if (txtPesquisa.Text == null)
                {
                    this.CarregarDataGridProdutos_Entradas();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            conexao.Desconectar();
        }

        private void btnFormPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FormPesquisaFornecedor formPesquisaFornecedor = new FormPesquisaFornecedor();
            if (txtIdFornecedor.Text == "")
            {
                formPesquisaFornecedor.formAtual = "historicoEntradas";
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
                conexao.Desconectar();
            }
        }
    }
}

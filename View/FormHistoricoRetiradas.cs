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
    public partial class FormHistoricoRetiradas : Form
    {
        public int idRetiradas;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public FormHistoricoRetiradas()
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

                    cmd.CommandText = @"SELECT r.idRetiradas, u.nome, p.nomeProduto, 
                                           r.qtdRetirada, r.dataRetirada, r.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Retiradas AS r INNER JOIN dbo.Usuarios AS u 
	                                       ON r.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p 
                                           ON r.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON r.idFornecedor_fk = f.idFornecedor AND r.idRetiradas = " + txtPesquisa.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgRetiradas.DataSource = dt;

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

        private void btnFormPesquisa_Produtos_Click(object sender, EventArgs e)
        {
            FormPesquisaProduto formPesquisaProduto = new FormPesquisaProduto();
            if (txtIdProduto.Text == "")
            {
                formPesquisaProduto.formAtual = "historicoRetiradas";
                formPesquisaProduto.Show();
            }
            else
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
                        dgProdutos_Retiradas.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Produto encontrado");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            }
        }

        private void btnSalvarRetirada_Click(object sender, EventArgs e)
        {
            if ((txtQuantidadeRetirada.Text != "") && (txtIdFornecedor.Text != "") && (bool.Parse(dgProdutos_Retiradas.CurrentRow.Cells[0].FormattedValue.ToString()) == true))
            {
                Retiradas retiradas = new Retiradas();

                foreach (DataGridViewRow check in dgProdutos_Retiradas.Rows)
                {
                    if ((bool)check.Cells[0].FormattedValue)
                    {
                        retiradas.idProduto = Convert.ToInt32(check.Cells[1].Value.ToString());
                    }
                }
                retiradas.qtdRetirada = Convert.ToInt32(txtQuantidadeRetirada.Text);
                retiradas.dataRetirada = dtDataRetirada.Value;
                retiradas.idUsuario = UsuarioSession.idUsuario;
                retiradas.idFornecedor = Convert.ToInt32(txtIdFornecedor.Text);

                retiradas.update(retiradas, idRetiradas);
                tabControl1.SelectedIndex = 0;
                btnSalvarRetirada.Enabled = false;
                this.CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Campos não informados");
            }
        }
        private void CarregarDataGridProdutos_Retiradas()
        {
            try
            {
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
                    dgProdutos_Retiradas.DataSource = dt; // Preenche o DataGridView
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

        private void CarregarDataGrid()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT r.idRetiradas, u.nome, p.nomeProduto, 
                                           r.qtdRetirada, r.dataRetirada, r.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Retiradas AS r INNER JOIN dbo.Usuarios AS u 
	                                       ON r.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p 
                                           ON r.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON r.idFornecedor_fk = f.idFornecedor";

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgRetiradas.DataSource = dt; // Preenche o DataGridView
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

        private void dgRetiradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar o id para editar
            idRetiradas = Convert.ToInt32(dgRetiradas.Rows[e.RowIndex].Cells["idRetiradas"].Value.ToString());

            //verificar qual a coluna clicada é a de editar
            if (dgRetiradas.Columns[e.ColumnIndex] == dgRetiradas.Columns["editar"])
            {
                try
                {
                    cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, e.qtdDisponivel, e.precoAtual
                                        FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                        ON p.idProduto = e.idProduto_fk AND p.nomeProduto =  '"
                                        + dgRetiradas.Rows[e.RowIndex].Cells["nomeProduto"].Value.ToString() + "'";

                    cmd.Connection = conexao.Conectar();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        // Cria uma tabela genérica
                        DataTable dt = new DataTable();
                        dt.Load(dr); // Carrega os dados para o DataTable
                        dgProdutos_Retiradas.DataSource = dt; // Preenche o DataGridView
                        DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();
                        chk.Value = true;

                    }
                    else
                    {
                        MessageBox.Show("erro");
                    }

                    dtDataRetirada.Text = dgRetiradas.Rows[e.RowIndex].Cells["dataRetirada"].Value.ToString();
                    txtQuantidadeRetirada.Text = dgRetiradas.Rows[e.RowIndex].Cells["qtdRetirada"].Value.ToString();
                    txtIdFornecedor.Text = dgRetiradas.Rows[e.RowIndex].Cells["idFornecedor_fk"].Value.ToString();
                    txtNomeFantasia.Text = dgRetiradas.Rows[e.RowIndex].Cells["nomeFantasia"].Value.ToString();
                    txtNomeProduto.Text = dgRetiradas.Rows[e.RowIndex].Cells["nomeProduto"].Value.ToString();
                    txtIdProduto.Text = dgProdutos_Retiradas.Rows[0].Cells["idProduto"].Value.ToString();

                    tabControl1.SelectedIndex = 1;
                    btnSalvarRetirada.Enabled = true;
                    conexao.Desconectar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex);
                }
            }
        }

        private void dgRetiradas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgRetiradas.Columns)
            {
                switch (coluna.Name)
                {
                    case "idRetiradas":
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
                    case "qtdRetirada":
                        coluna.Width = 80;
                        coluna.HeaderText = "Quantidade Retirada";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "dataRetirada":
                        coluna.Width = 120;
                        coluna.HeaderText = "Data de Retirada";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "editar":
                        coluna.Width = 40;
                        coluna.DisplayIndex = 7;
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

        private void dgRetiradas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgRetiradas.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
        }

        private void dgProdutos_Retiradas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgProdutos_Retiradas.Columns)
            {
                switch (coluna.Name)
                {
                    case "idProduto":
                        coluna.Width = 70;
                        coluna.HeaderText = "Código";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeProduto":
                        coluna.Width = 230;
                        coluna.HeaderText = "Produto";
                        break;
                    case "qtdDisponivel":
                        coluna.Width = 70;
                        coluna.HeaderText = "Quantidade Disponível";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "precoAtual":
                        coluna.Width = 110;
                        coluna.HeaderText = "Preço Atual";
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "selecionar":
                        coluna.Width = 70;
                        break;
                    case "nomeSubCategoria":
                        coluna.Width = 100;
                        coluna.HeaderText = "Sub-Categoria";
                        break;
                    case "nomeCategoria":
                        coluna.Width = 100;
                        coluna.HeaderText = "Categoria";
                        break;
                    default:
                        break;
                }
            }
        }

        private void FormHistoricoRetiradas_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            this.CarregarDataGridProdutos_Retiradas();
            btnSalvarRetirada.Enabled = false;
        }

        private void btnFormPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FormPesquisaFornecedor formPesquisaFornecedor = new FormPesquisaFornecedor();
            if (txtIdFornecedor.Text == "")
            {
                formPesquisaFornecedor.formAtual = "historicoRetiradas";
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
                    MessageBox.Show("Nenhum Fornecedor encontrado");
                }
                conexao.Desconectar();
            }
        }

        private void FormHistoricoRetiradas_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtIdFornecedor.Text != "")
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        this.btnFormPesquisaFornecedor_Click(null, null);
                        break;
                    default:
                        break;
                }
            }
            if (txtIdProduto.Text != "")
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        this.btnFormPesquisa_Produtos_Click(null, null);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

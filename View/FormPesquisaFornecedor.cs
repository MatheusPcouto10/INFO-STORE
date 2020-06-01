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
    public partial class FormPesquisaFornecedor : Form
    {
        Conexao conexao = new Conexao();
        public string formAtual { get; set; }

        public FormPesquisaFornecedor()
        {
            InitializeComponent();
        }

        private void btnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            if ((txtCnpj.Text == "") && (txtNomeFantasia.Text == "") && (txtNomeFornecedor.Text == "") && (txtIdFornecedor.Text == ""))
            {
                this.CarregarDataGridPesquisaFornecedor();
            }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                if ((txtCnpj.Text == "") && (txtNomeFantasia.Text == "") && (txtNomeFornecedor.Text == "") && (txtIdFornecedor.Text != ""))
                {
                    cmd.CommandText = @"SELECT idFornecedor, nomeFornecedor, nomeFantasia, cnpj, status
                                    FROM fornecedores WHERE status = 'Ativo' AND idFornecedor = " + txtIdFornecedor.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgPesquisa_Fornecedores.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Fornecedor encontrado");
                    }
                }
                else if ((txtCnpj.Text == "") && (txtNomeFantasia.Text == "") && (txtNomeFornecedor.Text != "") && (txtIdFornecedor.Text == ""))
                {
                    cmd.CommandText = @"SELECT idFornecedor, nomeFornecedor, nomeFantasia, cnpj, status
                                    FROM fornecedores WHERE status = 'Ativo' AND nomeFornecedor LIKE '%" + txtNomeFornecedor.Text + "%'";

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgPesquisa_Fornecedores.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Fornecedor encontrado");
                    }
                }
                else if ((txtCnpj.Text == "") && (txtNomeFantasia.Text != "") && (txtNomeFornecedor.Text == "") && (txtIdFornecedor.Text == ""))
                {
                    cmd.CommandText = @"SELECT idFornecedor, nomeFornecedor, nomeFantasia, cnpj, status 
                                    FROM fornecedores WHERE status = 'Ativo' AND nomeFantasia LIKE '%" + txtNomeFantasia.Text + "%'";

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgPesquisa_Fornecedores.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Fornecedor encontrado");
                    }
                }
                else if ((txtCnpj.Text != "") && (txtNomeFantasia.Text == "") && (txtNomeFornecedor.Text == "") && (txtIdFornecedor.Text == ""))
                {
                    cmd.CommandText = @"SELECT idFornecedor, nomeFornecedor, nomeFantasia, cnpj, status 
                                    FROM fornecedores WHERE status = 'Ativo' AND cnpj = " + txtCnpj.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgPesquisa_Fornecedores.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Fornecedor encontrado");
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

        private void FormPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            this.CarregarDataGridPesquisaFornecedor();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFantasia.Text = "";
            txtCnpj.Text = "";
            txtNomeFornecedor.Text = "";
            txtIdFornecedor.Text = "";
        }

        private void CarregarDataGridPesquisaFornecedor()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                cmd.Connection = conexao.Conectar();
                cmd.CommandText = "SELECT idFornecedor, nomeFornecedor, cnpj, status, nomeFantasia FROM fornecedores";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgPesquisa_Fornecedores.DataSource = dt; // Preenche o DataGridView
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

        private void dgPesquisa_Fornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formAtual == "cadastroEntradas")
            {
                (Application.OpenForms["FormCadastroEntradas"].Controls["txtIdFornecedor"] as TextBox).Text = txtIdFornecedor.Text;
                (Application.OpenForms["FormCadastroEntradas"].Controls["txtNomeFantasia"] as TextBox).Text = txtNomeFantasia.Text;
                this.Hide();
            }
            else if (formAtual == "cadastroRetiradas")
            {
                (Application.OpenForms["FormCadastroRetiradas"].Controls["txtIdFornecedor"] as TextBox).Text = txtIdFornecedor.Text;
                (Application.OpenForms["FormCadastroRetiradas"].Controls["txtNomeFantasia"] as TextBox).Text = txtNomeFantasia.Text;
                this.Hide();
            }
            else if (formAtual == "historicoEntradas")
            {
                (Application.OpenForms["FormHistoricoEntradas"].Controls["tabControl1"].Controls["telaEditar"].Controls["txtIdFornecedor"] as TextBox).Text = txtIdFornecedor.Text;
                (Application.OpenForms["FormHistoricoEntradas"].Controls["tabControl1"].Controls["telaEditar"].Controls["txtNomeFantasia"] as TextBox).Text = txtNomeFantasia.Text;
                this.Hide();
            }
            else if (formAtual == "historicoRetiradas")
            {
                (Application.OpenForms["FormHistoricoRetiradas"].Controls["tabControl1"].Controls["telaEditar"].Controls["txtIdFornecedor"] as TextBox).Text = txtIdFornecedor.Text;
                (Application.OpenForms["FormHistoricoRetiradas"].Controls["tabControl1"].Controls["telaEditar"].Controls["txtNomeFantasia"] as TextBox).Text = txtNomeFantasia.Text;
                this.Hide();
            }
        }

        private void dgPesquisa_Fornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeFantasia.Text = dgPesquisa_Fornecedores.Rows[e.RowIndex].Cells["nomeFantasia"].Value.ToString();
            txtIdFornecedor.Text = dgPesquisa_Fornecedores.Rows[e.RowIndex].Cells["idFornecedor"].Value.ToString();
            txtCnpj.Text = dgPesquisa_Fornecedores.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
            txtNomeFornecedor.Text = dgPesquisa_Fornecedores.Rows[e.RowIndex].Cells["nomeFornecedor"].Value.ToString();
        }

        private void dgPesquisa_Fornecedores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgPesquisa_Fornecedores.Columns)
            {
                switch (coluna.Name)
                {
                    case "idFornecedor":
                        coluna.Width = 50;
                        coluna.HeaderText = "ID";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeFornecedor":
                        coluna.Width = 180;
                        coluna.HeaderText = "Fornecedor";
                        break;
                    case "nomeFantasia":
                        coluna.Width = 180;
                        coluna.HeaderText = "Nome Fantasia";
                        break;
                    case "cnpj":
                        coluna.Width = 120;
                        coluna.HeaderText = "CNPJ";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "status":
                        coluna.Width = 80;
                        coluna.HeaderText = "Status";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
                        break;
                }
            }
        }

        private void FormPesquisaFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnPesquisarFornecedor_Click(null, null);
                    break;
                case Keys.Escape:
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}

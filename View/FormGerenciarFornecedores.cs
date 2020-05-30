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

namespace AvaliacaoA1.View
{
    public partial class FormGerenciarFornecedores : Form
    {
        public int idFornecedores;
        Conexao conexao = new Conexao();
        public FormGerenciarFornecedores()
        {
            InitializeComponent();
        }

        private void FormGerenciarFornecedores_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            btnSalvarFornecedor.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar o id para editar
            idFornecedores = Convert.ToInt32(dgFornecedores.Rows[e.RowIndex].Cells["idFornecedor"].Value.ToString());

            //verificar qual a coluna clicada é a de editar
            if (dgFornecedores.Columns[e.ColumnIndex] == dgFornecedores.Columns["editar"])
            {
                txtNomeFornecedor.Text = dgFornecedores.Rows[e.RowIndex].Cells["nomeFornecedor"].Value.ToString();
                txtNomeFantasia.Text = dgFornecedores.Rows[e.RowIndex].Cells["nomeFantasia"].Value.ToString();
                txtEmailFornecedor.Text = dgFornecedores.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtCnpj.Text = dgFornecedores.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
                txtTelefoneFornecedor.Text = dgFornecedores.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
                txtBairroFornecedor.Text = dgFornecedores.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
                txtQuadraFornecedor.Text = dgFornecedores.Rows[e.RowIndex].Cells["quadra"].Value.ToString();
                txtAlamedaFornecedor.Text = dgFornecedores.Rows[e.RowIndex].Cells["alameda"].Value.ToString();
                txtLoteFornecedor.Text = dgFornecedores.Rows[e.RowIndex].Cells["lote"].Value.ToString();
                cbStatus.Text = dgFornecedores.Rows[e.RowIndex].Cells["status"].Value.ToString();

                tabControl1.SelectedIndex = 1;
                btnSalvarFornecedor.Enabled = true;
            }
        }

        private void dgFornecedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgFornecedores.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
        }

        private void dgFornecedores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgFornecedores.Columns)
            {
                switch (coluna.Name)
                {
                    case "idFornecedor":
                        coluna.Width = 30;
                        coluna.HeaderText = "ID";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeFornecedor":
                        coluna.Width = 120;
                        coluna.HeaderText = "Fornecedor";
                        break;
                    case "nomeFantasia":
                        coluna.Width = 120;
                        coluna.HeaderText = "Nome Fantasia";
                        break;
                    case "email":
                        coluna.Width = 100;
                        coluna.HeaderText = "E-mail";
                        break;
                    case "cnpj":
                        coluna.Width = 80;
                        coluna.HeaderText = "CNPJ";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "status":
                        coluna.Width = 60;
                        coluna.HeaderText = "Status";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "telefone":
                        coluna.Width = 80;
                        coluna.HeaderText = "Telefone";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "bairro":
                        coluna.Width = 100;
                        coluna.HeaderText = "Bairro";
                        break;
                    case "quadra":
                        coluna.Width = 60;
                        coluna.HeaderText = "Quadra";
                        break;
                    case "alameda":
                        coluna.Width = 60;
                        coluna.HeaderText = "Alameda";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "lote":
                        coluna.Width = 60;
                        coluna.HeaderText = "Lote";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "editar":
                        coluna.Width = 40;
                        coluna.DisplayIndex = 11;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            if ((txtNomeFornecedor.Text != "") && (txtCnpj.Text != "") && (txtEmailFornecedor.Text != "") && (txtTelefoneFornecedor.Text != "") &&
              (txtNomeFantasia.Text != "") && (txtQuadraFornecedor.Text != "") && (txtAlamedaFornecedor.Text != "") && (txtLoteFornecedor.Text != ""))
            {
                fornecedor.nomeFantasia = txtNomeFantasia.Text;
                fornecedor.nomeFornecedor = txtNomeFornecedor.Text;
                fornecedor.lote = txtLoteFornecedor.Text;
                fornecedor.quadra = txtQuadraFornecedor.Text;
                fornecedor.status = cbStatus.Text;
                fornecedor.telefone = txtTelefoneFornecedor.Text;
                fornecedor.bairro = txtBairroFornecedor.Text;
                fornecedor.cnpj = txtCnpj.Text;
                fornecedor.alameda = txtAlamedaFornecedor.Text;
                fornecedor.email = txtEmailFornecedor.Text;

                fornecedor.update(fornecedor, idFornecedores);
                tabControl1.SelectedIndex = 0;
                btnSalvarFornecedor.Enabled = true;
                this.CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Informe os campos");
            }
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

                    cmd.CommandText = "SELECT * FROM fornecedores WHERE idFornecedor = " + txtPesquisa.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgFornecedores.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Fornecedor Encontrado");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            }
        }
        private void CarregarDataGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                cmd.Connection = conexao.Conectar();
                cmd.CommandText = "SELECT * FROM fornecedores";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgFornecedores.DataSource = dt; // Preenche o DataGridView
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
    }
}



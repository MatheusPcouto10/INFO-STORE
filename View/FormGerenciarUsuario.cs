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
    public partial class FormGerenciarUsuario : Form
    {
        public int idUsuario;
        Conexao conexao = new Conexao();

        public FormGerenciarUsuario()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AdministracaoUsuario_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            btnSalvarUsuario.Enabled = false;
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if ((txtNomeUsuario.Text != "") && (txtCpfUsuario.Text != "") && (txtEmailUsuario.Text != "") && (txtSenhaUsuario.Text != "") &&
                (txtTelefoneUsuario.Text != "") && (txtQuadraUsuario.Text != "") && (txtAlamedaUsuario.Text != "") && (txtLoteUsuario.Text != ""))
            {
                usuario.Nome = txtNomeUsuario.Text;
                usuario.CPF = txtCpfUsuario.Text;
                usuario.login.Email = txtEmailUsuario.Text;
                usuario.login.Senha = txtSenhaUsuario.Text;
                usuario.TipoUsuario = cbTipoUsuario.Text;
                usuario.telefone = txtTelefoneUsuario.Text;
                usuario.dataNascimento = dtNascimento.Value;
                usuario.bairro = txtBairroUsuario.Text;
                usuario.quadra = txtQuadraUsuario.Text;
                usuario.alameda = txtAlamedaUsuario.Text;
                usuario.lote = txtLoteUsuario.Text;
                usuario.Status = cbStatus.Text;

                usuario.update(usuario, idUsuario);

                tabControl1.SelectedIndex = 0;
                btnSalvarUsuario.Enabled = false;
                this.CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Informe os campos");
            }
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar o id para editar
            idUsuario = Convert.ToInt32(dgUsuarios.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString());

            //verificar qual a coluna clicada é a de editar
            if (dgUsuarios.Columns[e.ColumnIndex] == dgUsuarios.Columns["editar"])
            {
                txtNomeUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtCpfUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                txtEmailUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtSenhaUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                txtTelefoneUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
                txtBairroUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
                txtQuadraUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["quadra"].Value.ToString();
                txtAlamedaUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["alameda"].Value.ToString();
                txtLoteUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["lote"].Value.ToString();
                dtNascimento.Text = dgUsuarios.Rows[e.RowIndex].Cells["dataNascimento"].Value.ToString();
                cbTipoUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["tipoUsuario"].Value.ToString();
                cbStatus.Text = dgUsuarios.Rows[e.RowIndex].Cells["status"].Value.ToString();

                tabControl1.SelectedIndex = 1;
                btnSalvarUsuario.Enabled = true;
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

                    cmd.CommandText = "SELECT * FROM usuarios WHERE idUsuario = " + txtPesquisa.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgUsuarios.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum Usuário Encontrado");
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
                cmd.CommandText = "SELECT * FROM usuarios";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgUsuarios.DataSource = dt; // Preenche o DataGridView
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

        private void dgUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgUsuarios.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
        }

        private void dgUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgUsuarios.Columns)
            {
                switch (coluna.Name)
                {
                    case "idUsuario":
                        coluna.Width = 30;
                        coluna.HeaderText = "ID";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nome":
                        coluna.Width = 120;
                        coluna.HeaderText = "Nome";
                        break;
                    case "cpf":
                        coluna.Width = 80;
                        coluna.HeaderText = "CPF";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "email":
                        coluna.Width = 100;
                        coluna.HeaderText = "E-mail";
                        break;
                    case "senha":
                        coluna.Width = 60;
                        coluna.HeaderText = "Senha";
                        break;
                    case "tipoUsuario":
                        coluna.Width = 80;
                        coluna.HeaderText = "Tipo de Usuário";
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
                    case "dataNascimento":
                        coluna.Width = 80;
                        coluna.HeaderText = "Data de Nascimento";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "editar":
                        coluna.Width = 40;
                        coluna.DisplayIndex = 13;
                        break;
                    default:
                        break;
                }
            }
        }

        private void FormGerenciarUsuario_KeyDown(object sender, KeyEventArgs e)
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


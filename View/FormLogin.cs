using AvaliacaoA1.View;
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

namespace AvaliacaoA1
{
    public partial class FormLogin : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM usuarios where email LIKE '" + txtLogin.Text +
                               "' AND senha LIKE '" + txtSenha.Text + "'";

            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    FormMenu formMenu = new FormMenu();
                    FormCadastroEntradas formCadastroEntradas = new FormCadastroEntradas();

                    UsuarioSession.tipoUsuario = dr[5].ToString();
                    UsuarioSession.idUsuario = Convert.ToInt32(dr[0].ToString());
                    UsuarioSession.nomeUsuario = dr[1].ToString().Substring(0, 9);
                    string statusUsuario = dr[6].ToString();

                    if (statusUsuario.Equals("Ativo"))
                    {
                        formMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("O Usuário informado está inativo");
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretos!");
                    this.btnLimpar_Click(null, null);
                }
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnEntrar_Click(null, null);
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void checkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}


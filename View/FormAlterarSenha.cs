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
    public partial class FormAlterarSenha : Form
    {

        public FormAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            try
            {
                cmd.CommandText = "SELECT senha FROM usuarios where idUsuario = " + UsuarioSession.idUsuario;
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr.GetString(0) == txtSenhaAtual.Text)
                    {
                        if (txtNovaSenha.Text == txtConfirmarNovaSenha.Text)
                        {
                            conexao.Desconectar();
                            cmd.CommandText = "UPDATE usuarios SET senha = '" + txtNovaSenha.Text +
                                              "' WHERE idUsuario = " + UsuarioSession.idUsuario;

                            cmd.Connection = conexao.Conectar();
                            cmd.ExecuteNonQuery();
                            conexao.Desconectar();
                            MessageBox.Show("Senha alterada com sucesso!");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("A nova senha não corresponde!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A senha atual está incorreta!");
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void FormAlterarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnSalvar_Click(null, null);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}

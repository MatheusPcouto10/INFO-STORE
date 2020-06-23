using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliacaoA1.Session;

namespace AvaliacaoA1
{
    public partial class FormCadastroUsuario : Form
    {
        Usuario usuario = new Usuario();
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeUsuario.Text = "";
            txtCpfUsuario.Text = "";
            txtEmailUsuario.Text = "";
            txtSenhaUsuario.Text = "";
            txtConfirmarSenha.Text = "";
            cbTipoUsuario.Text = "";
            txtAlamedaUsuario.Text = "";
            txtBairroUsuario.Text = "";
            txtLoteUsuario.Text = "";
            txtQuadraUsuario.Text = "";
            txtTelefoneUsuario.Text = "";
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if ((txtNomeUsuario.Text != "") && (txtCpfUsuario.Text != "") && (txtEmailUsuario.Text != "") && (txtSenhaUsuario.Text != "") && 
                (txtTelefoneUsuario.Text != "") && (txtQuadraUsuario.Text != "") && (txtAlamedaUsuario.Text != "") && (txtLoteUsuario.Text != ""))
            {
                usuario.Nome = txtNomeUsuario.Text;
                usuario.CPF = txtCpfUsuario.Text;
                usuario.Login.Email = txtEmailUsuario.Text;
                usuario.Login.Senha = txtSenhaUsuario.Text;
                usuario.TipoUsuario = cbTipoUsuario.Text;
                usuario.telefone = txtTelefoneUsuario.Text;
                usuario.dataNascimento = dtNascimento.Value;
                usuario.bairro = txtBairroUsuario.Text;
                usuario.quadra = txtQuadraUsuario.Text;
                usuario.alameda = txtAlamedaUsuario.Text;
                usuario.lote = txtLoteUsuario.Text;
                usuario.Status = "Ativo";

                try
                {
                    if (txtConfirmarSenha.Text == txtSenhaUsuario.Text)
                    {
                        usuario.create(usuario);
                        this.btnLimpar_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Senha não correspondente!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Informe os campos");
            }


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
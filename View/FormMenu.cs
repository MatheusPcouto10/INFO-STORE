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
using AvaliacaoA1.View;
using AvaliacaoA1.Session;

namespace AvaliacaoA1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

        }

        private void linkCadastroUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroUsuario formCadastroUsuario = new FormCadastroUsuario();
            formCadastroUsuario.Show();
        }

        private void linkGerenciarUsuarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGerenciarUsuario formGerenciarUsuario = new FormGerenciarUsuario();
            formGerenciarUsuario.Show();
        }

        private void linkCadastroProduto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.Show();

        }

        private void linkEntradas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroEntradas formCadastroEntradas = new FormCadastroEntradas();
            formCadastroEntradas.Show();
        }

        private void linkRetiradas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroRetiradas formCadastroRetiradas = new FormCadastroRetiradas();
            formCadastroRetiradas.Show();
        }

        private void linkEstoque_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEstoque formEstoque = new FormEstoque();
            formEstoque.Show();

        }

        private void linkHistEntradas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHistoricoEntradas formHistoricoEntradas = new FormHistoricoEntradas();
            formHistoricoEntradas.Show();
        }
        
        private void linkHistRetiradas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHistoricoRetiradas formHistoricoRetiradas = new FormHistoricoRetiradas();
            formHistoricoRetiradas.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void FormMenu_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo ao INFO STORE!");
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFormAlterarSenha_Click(object sender, EventArgs e)
        {
            FormAlterarSenha formAlterarSenha = new FormAlterarSenha();
            formAlterarSenha.Show();
        }

        private void btnFormSobre_Click(object sender, EventArgs e)
        {
            FormSobre formSobre = new FormSobre();
            formSobre.Show();
        }

        private void linkCadastroFornecedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroFornecedor formCadastroFornecedor = new FormCadastroFornecedor();
            formCadastroFornecedor.Show();
        }

        private void linkGerenciarFornecedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGerenciarFornecedores formGerenciarFornecedores = new FormGerenciarFornecedores();
            formGerenciarFornecedores.Show();
        }

        private void cadastrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCategoria formCadastroCategoria = new FormCadastroCategoria();
            formCadastroCategoria.Show();
        }

        private void cadastrarSubCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroSubCategoria formCadastroSubCategoria = new formCadastroSubCategoria();
            formCadastroSubCategoria.Show();
        }

        private void controleAcesso()
        {
            if (UsuarioSession.tipoUsuario.Equals("Funcionário"))
            {
                this.linkCadastroUsuario.Enabled = false;
                this.linkGerenciarUsuarios.Enabled = false;
                this.btnCategoria_SubCategoria.Enabled = false;
                this.linkCadastroFornecedor.Enabled = false;
                this.linkGerenciarFornecedores.Enabled = false;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.labelTipoUsuarioLogado.Text = UsuarioSession.tipoUsuario;
            this.labelIdUsuarioLogado.Text = UsuarioSession.idUsuario.ToString();
            this.labelUsuarioLogado.Text = UsuarioSession.nomeUsuario;
            this.controleAcesso();
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.btnSair_Click(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}


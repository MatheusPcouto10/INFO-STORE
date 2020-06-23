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

namespace AvaliacaoA1.View.FiltrosRelatoriosForms
{
    public partial class FiltroRelatorioProdutos : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public FiltroRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void btnImprimirRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorioProduto form = new FormRelatorioProduto();

            if (cbStatus.Text != "Selecione..." && cbCategoria.Text != "Selecione..." && cbSubCategoria.Text != "Selecione...")
            {
                form.comando = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, 
                                           p.descricao, p.preco, p.imagem, p.status,
                                           e.qtdDisponivel, e.precoAtual
                                           FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                           ON p.idProduto = e.idProduto_fk 
                                           INNER JOIN dbo.SubCategorias AS s 
                                           ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                           ON s.idCategoria_fk = c.idCategoria WHERE p.status = '" + cbStatus.Text +
                                           "' AND c.nomeCategoria = '" + cbCategoria.Text +
                                           "' AND s.nomeSubCategoria = '" + cbSubCategoria.Text + "'";
                form.Show();
            }
            else if (cbCategoria.Text != "Selecione..." && cbSubCategoria.Text != "Selecione...")
            {
                form.comando = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, 
                                           p.descricao, p.preco, p.imagem, p.status,
                                           e.qtdDisponivel, e.precoAtual
                                           FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                           ON p.idProduto = e.idProduto_fk 
                                           INNER JOIN dbo.SubCategorias AS s 
                                           ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                           ON s.idCategoria_fk = c.idCategoria WHERE c.nomeCategoria = '" + cbCategoria.Text +
                                           "' AND s.nomeSubCategoria = '" + cbSubCategoria.Text + "'";
                form.Show();
            }
            else if (cbStatus.Text != "Selecione...")
            {
                form.comando = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, 
                                           p.descricao, p.preco, p.imagem, p.status,
                                           e.qtdDisponivel, e.precoAtual
                                           FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                           ON p.idProduto = e.idProduto_fk 
                                           INNER JOIN dbo.SubCategorias AS s 
                                           ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                           ON s.idCategoria_fk = c.idCategoria WHERE p.status = '" + cbStatus.Text + "'";
                form.Show();
            }
            else if (cbCategoria.Text != "Selecione...")
            {
                form.comando = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, 
                                           p.descricao, p.preco, p.imagem, p.status,
                                           e.qtdDisponivel, e.precoAtual
                                           FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                           ON p.idProduto = e.idProduto_fk 
                                           INNER JOIN dbo.SubCategorias AS s 
                                           ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                           ON s.idCategoria_fk = c.idCategoria WHERE c.nomeCategoria = '" + cbCategoria.Text + "'";
                form.Show();
            }
            else if (cbSubCategoria.Text != "Selecione...")
            {
                form.comando = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, 
                                           p.descricao, p.preco, p.imagem, p.status,
                                           e.qtdDisponivel, e.precoAtual
                                           FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                           ON p.idProduto = e.idProduto_fk 
                                           INNER JOIN dbo.SubCategorias AS s 
                                           ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                           ON s.idCategoria_fk = c.idCategoria WHERE s.nomeSubCategoria = '" + cbSubCategoria.Text + "'";
                form.Show();
            }
            else
            {
                form.comando = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, 
                                           p.descricao, p.preco, p.imagem, p.status,
                                           e.qtdDisponivel, e.precoAtual
                                           FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                           ON p.idProduto = e.idProduto_fk 
                                           INNER JOIN dbo.SubCategorias AS s 
                                           ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                           ON s.idCategoria_fk = c.idCategoria";
                form.Show();
            }
        }
        private void preencheComboBoxCategorias()
        {
            cmd.CommandText = "SELECT * FROM categorias";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbCategoria.DisplayMember = "nomeCategoria";
                cbCategoria.ValueMember = "idCategoria";
                cbCategoria.DataSource = dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        private void preencheComboBoxSubCategorias()
        {
            cmd.CommandText = "SELECT * FROM subcategorias";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbSubCategoria.DisplayMember = "nomeSubCategoria";
                cbSubCategoria.ValueMember = "idSubCategorias";
                cbSubCategoria.DataSource = dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbSubCategoria.Text = "Selecione...";
            cbStatus.Text = "Selecione...";
            cbCategoria.Text = "Selecione...";
        }

        private void FiltroRelatorioProdutos_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxCategorias();
            this.preencheComboBoxSubCategorias();
            cbSubCategoria.Text = "Selecione...";
            cbCategoria.Text = "Selecione...";
        }
    }
}

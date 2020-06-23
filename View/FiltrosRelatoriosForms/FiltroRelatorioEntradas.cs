using AvaliacaoA1.View.RelatoriosForm;
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
    public partial class FiltroRelatorioEntradas : Form
    {
        Conexao conexao = new Conexao();
        public FiltroRelatorioEntradas()
        {
            InitializeComponent();
        }

        private void btnImprimirRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorioEntradas form = new FormRelatorioEntradas();

            if (txtIdFornecedor.Text != "" && txtIdProduto.Text != "")
            {
                form.comando = @"SELECT e.idEntradas, u.nome, p.nomeProduto, 
                                           e.qtdEntrada, e.dataEntrada, e.precoEntrada, e.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Entradas AS e INNER JOIN dbo.Usuarios AS u
	                                       ON e.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p
                                           ON e.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON e.idFornecedor_fk = f.idFornecedor WHERE e.idProduto_fk = '" + txtIdProduto.Text +
                                           "' AND e.idFornecedor_fk = '" + txtIdFornecedor.Text +
                                           "' AND e.dataEntrada BETWEEN '" + dtDataInicial.Value + "' AND '" + dtDataFinal.Value + "'";
                form.Show();
            }
            else if (txtIdFornecedor.Text != "")
            {
                form.comando = @"SELECT e.idEntradas, u.nome, p.nomeProduto, 
                                           e.qtdEntrada, e.dataEntrada, e.precoEntrada, e.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Entradas AS e INNER JOIN dbo.Usuarios AS u
	                                       ON e.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p
                                           ON e.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON e.idFornecedor_fk = f.idFornecedor WHERE e.idFornecedor_fk = '" + txtIdFornecedor.Text +
                                           "' AND e.dataEntrada BETWEEN '" + dtDataInicial.Value + "' AND '" + dtDataFinal.Value + "'"; ;
                form.Show();
            }
            else if (txtIdProduto.Text != "")
            {
                form.comando = @"SELECT e.idEntradas, u.nome, p.nomeProduto, 
                                           e.qtdEntrada, e.dataEntrada, e.precoEntrada, e.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Entradas AS e INNER JOIN dbo.Usuarios AS u
	                                       ON e.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p
                                           ON e.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON e.idFornecedor_fk = f.idFornecedor WHERE e.idProduto_fk = '" + txtIdProduto.Text +
                                           "' AND e.dataEntrada BETWEEN '" + dtDataInicial.Value + "' AND '" + dtDataFinal.Value + "'";
                form.Show();
            }
            else if (txtIdFornecedor.Text == "" && txtIdProduto.Text == "")
            {
                form.comando = @"SELECT e.idEntradas, u.nome, p.nomeProduto, 
                                           e.qtdEntrada, e.dataEntrada, e.precoEntrada, e.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Entradas AS e INNER JOIN dbo.Usuarios AS u
	                                       ON e.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p
                                           ON e.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON e.idFornecedor_fk = f.idFornecedor WHERE e.dataEntrada BETWEEN '" + dtDataInicial.Value + "' AND '" + dtDataFinal.Value + "'";
                form.Show();
            }
            else
            {
                form.comando = @"SELECT e.idEntradas, u.nome, p.nomeProduto, 
                                           e.qtdEntrada, e.dataEntrada, e.precoEntrada, e.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Entradas AS e INNER JOIN dbo.Usuarios AS u
	                                       ON e.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p
                                           ON e.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON e.idFornecedor_fk = f.idFornecedor";
                form.Show();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdFornecedor.Text = "";
            txtIdProduto.Text = "";
            txtNomeFantasia.Text = "";
            txtNomeProduto.Text = "";
        }

        private void btnFormPesquisa_Produto_Click(object sender, EventArgs e)
        {
            FormPesquisaProduto formPesquisaProduto = new FormPesquisaProduto();
            if (txtIdProduto.Text == "")
            {
                formPesquisaProduto.formAtual = "filtroRelatorioEntradas";
                formPesquisaProduto.Show();
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = conexao.Conectar();

                    cmd.CommandText = @"SELECT idProduto, nomeProduto, 
                                        FROM[dbo].[Produtos] WHERE status = 'Em Atividade' AND idProduto = " + txtIdProduto.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtIdProduto.Text = dr[0].ToString();
                        txtNomeProduto.Text = dr[1].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto encontrado");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            }
        }

        private void btnFormPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FormPesquisaFornecedor formPesquisaFornecedor = new FormPesquisaFornecedor();
            if (txtIdFornecedor.Text == "")
            {
                formPesquisaFornecedor.formAtual = "filtroRelatorioEntradas";
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
                    MessageBox.Show("Nenhum fornecedor encontrado");
                }
                conexao.Desconectar();
            }
        }
    }
}

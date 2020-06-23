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
    public partial class FiltroRelatorioRetiradas : Form
    {
        Conexao conexao = new Conexao();
        public FiltroRelatorioRetiradas()
        {
            InitializeComponent();
        }

        private void btnImprimirRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorioRetiradas form = new FormRelatorioRetiradas();

            if (txtIdFornecedor.Text != "" && txtIdProduto.Text != "")
            {
                form.comando = @"SELECT r.idRetiradas, u.nome, p.nomeProduto, 
                                           r.qtdRetirada, r.dataRetirada, r.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Retiradas AS r INNER JOIN dbo.Usuarios AS u 
	                                       ON r.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p 
                                           ON r.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON r.idFornecedor_fk = f.idFornecedor WHERE r.idFornecedor_fk = '" + txtIdFornecedor.Text +
                                           "' AND r.idProduto_fk = '" + txtIdProduto.Text + 
                                           "' AND r.dataRetirada BETWEEN '" + dtDataInicial.Value + "' AND '" + dtDataFinal.Value + "'";
                form.Show();
            }
            else if (txtIdFornecedor.Text != "")
            {
                form.comando = @"SELECT r.idRetiradas, u.nome, p.nomeProduto, 
                                           r.qtdRetirada, r.dataRetirada, r.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Retiradas AS r INNER JOIN dbo.Usuarios AS u 
	                                       ON r.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p 
                                           ON r.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON r.idFornecedor_fk = f.idFornecedor WHERE r.idFornecedor_fk = '" + txtIdFornecedor.Text +
                                           "' AND r.dataRetirada BETWEEN '" + dtDataInicial.Value + "' AND '" + dtDataFinal.Value + "'";
                form.Show();
            }
            else if (txtIdProduto.Text != "")
            {
                form.comando = @"SELECT r.idRetiradas, u.nome, p.nomeProduto, 
                                           r.qtdRetirada, r.dataRetirada, r.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Retiradas AS r INNER JOIN dbo.Usuarios AS u 
	                                       ON r.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p 
                                           ON r.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON r.idFornecedor_fk = f.idFornecedor WHERE r.idProduto_fk = '" + txtIdProduto.Text +
                                           "' AND r.dataRetirada BETWEEN '" + dtDataInicial.Value + "' AND '" + dtDataFinal.Value + "'";
                form.Show();
            }
            else if (txtIdFornecedor.Text == "" && txtIdProduto.Text == "")
            {
                form.comando = @"SELECT r.idRetiradas, u.nome, p.nomeProduto, 
                                           r.qtdRetirada, r.dataRetirada, r.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Retiradas AS r INNER JOIN dbo.Usuarios AS u 
	                                       ON r.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p 
                                           ON r.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON r.idFornecedor_fk = f.idFornecedor WHERE r.dataRetirada BETWEEN '" + dtDataInicial.Value + "' AND '" + dtDataFinal.Value + "'";
                form.Show();
            }
            else
            {
                form.comando = @"SELECT r.idRetiradas, u.nome, p.nomeProduto, 
                                           r.qtdRetirada, r.dataRetirada, r.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Retiradas AS r INNER JOIN dbo.Usuarios AS u 
	                                       ON r.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p 
                                           ON r.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON r.idFornecedor_fk = f.idFornecedor";
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
                formPesquisaProduto.formAtual = "filtroRelatorioRetiradas";
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
                formPesquisaFornecedor.formAtual = "filtroRelatorioRetiradas";
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

﻿using AvaliacaoA1.Model;
using AvaliacaoA1.Session;
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
    public partial class FormCadastroRetiradas : Form
    {
        public int idProduto;
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public FormCadastroRetiradas()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e
                                  ON p.idProduto = e.idProduto_fk AND p.status = 'Em Atividade' AND p.idProduto LIKE '%" + txtPesquisa.Text + "%'";

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    DataTable dt = new DataTable();

                    dt.Load(dr);
                    dgProdutos_Retirada.DataSource = dt;

                }
                else if (txtPesquisa.Text == null)
                {
                    this.CarregarDataGrid();
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

        private void CarregarDataGrid()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, e.qtdDisponivel, e.precoAtual
                                  FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                  ON p.idProduto = e.idProduto_fk AND p.status = 'Em Atividade'";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgProdutos_Retirada.DataSource = dt; // Preenche o DataGridView
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

        private void btnDespacharProduto_Click(object sender, EventArgs e)
        {
            if ((txtQuantidadeRetirada.Text != "") && (bool.Parse(dgProdutos_Retirada.CurrentRow.Cells[0].FormattedValue.ToString()) == true))
            {
                Retiradas retiradas = new Retiradas();

                foreach (DataGridViewRow check in dgProdutos_Retirada.Rows)
                {
                    if ((bool)check.Cells[0].FormattedValue)
                    {
                        retiradas.idProduto = Convert.ToInt32(check.Cells[1].Value.ToString());
                    }
                }
                retiradas.qtdRetirada = Convert.ToInt32(txtQuantidadeRetirada.Text);
                retiradas.dataRetirada = dtDataRetirada.Value;
                retiradas.idUsuario = UsuarioSession.idUsuario;
                retiradas.idFornecedor = Convert.ToInt32(txtIdFornecedor.Text);
                retiradas.create(retiradas);
                this.btnLimpar_Click(null, null);
                MessageBox.Show("Remessa despachada com sucesso!");
                this.CarregarDataGrid();
            }
            else
            {
                MessageBox.Show("Campos não informados");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtQuantidadeRetirada.Text = "";
            txtPesquisa.Text = "";
            txtIdFornecedor.Text = "";
            txtNomeFantasia.Text = "";
        }


        private void FormCadastroRetiradas_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
        }

        private void dgProdutos_Retirada_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgProdutos_Retirada.Columns)
            {
                switch (coluna.Name)
                {
                    case "idProduto":
                        coluna.Width = 100;
                        coluna.HeaderText = "Código";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nomeProduto":
                        coluna.Width = 230;
                        coluna.HeaderText = "Produto";
                        break;
                    case "qtdDisponivel":
                        coluna.Width = 100;
                        coluna.HeaderText = "Quantidade Disponível";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "precoAtual":
                        coluna.Width = 130;
                        coluna.HeaderText = "Preço Atual";
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "selecionar":
                        coluna.Width = 100;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFormPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FormPesquisaFornecedor formPesquisaFornecedor = new FormPesquisaFornecedor();
            if (txtIdFornecedor.Text == "")
            {
                formPesquisaFornecedor.formAtual = "cadastroRetiradas";
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
                conexao.Desconectar();
            }

        }
    }
}

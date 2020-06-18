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
    public partial class FormRelatorioProduto : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public FormRelatorioProduto()
        {
            InitializeComponent();
        }
        private void CarregarDataGrid()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT p.idProduto, p.nomeProduto, c.nomeCategoria, s.nomeSubCategoria, 
                                           p.descricao, p.preco, p.imagem, p.status,
                                           e.qtdDisponivel, e.precoAtual
                                           FROM[dbo].[Produtos] AS p INNER JOIN dbo.Estoque AS e 
                                           ON p.idProduto = e.idProduto_fk 
                                           INNER JOIN dbo.SubCategorias AS s 
                                           ON p.idSubCategoria_fk = s.idSubCategorias INNER JOIN dbo.Categorias AS c
                                           ON s.idCategoria_fk = c.idCategoria";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetRelatorio", dt));
                }
                else
                {
                    MessageBox.Show("erro");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
            conexao.Desconectar();
        }

        private void FormRelatorioProduto_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            this.reportViewer1.RefreshReport();
        }
    }
}

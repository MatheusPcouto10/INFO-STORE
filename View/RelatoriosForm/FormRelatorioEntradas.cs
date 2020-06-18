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

namespace AvaliacaoA1.View.RelatoriosForm
{
    public partial class FormRelatorioEntradas : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public FormRelatorioEntradas()
        {
            InitializeComponent();
        }
        private void CarregarDataGrid()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT e.idEntradas, u.nome, p.nomeProduto, 
                                           e.qtdEntrada, e.dataEntrada, e.precoEntrada, e.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Entradas AS e INNER JOIN dbo.Usuarios AS u
	                                       ON e.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p
                                           ON e.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON e.idFornecedor_fk = f.idFornecedor";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetRelatorioEntradas", dt));
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
        private void FormRelatorioEntradas_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            this.reportViewer1.RefreshReport();
        }
    }
}

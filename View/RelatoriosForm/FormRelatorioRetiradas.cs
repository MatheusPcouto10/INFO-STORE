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
    public partial class FormRelatorioRetiradas : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public FormRelatorioRetiradas()
        {
            InitializeComponent();
        }
        private void CarregarDataGrid()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT r.idRetiradas, u.nome, p.nomeProduto, 
                                           r.qtdRetirada, r.dataRetirada, r.idFornecedor_fk, f.nomeFantasia
                                           FROM dbo.Retiradas AS r INNER JOIN dbo.Usuarios AS u 
	                                       ON r.idUsuario_fk = u.idUsuario INNER JOIN dbo.Produtos AS p 
                                           ON r.idProduto_fk = p.idProduto INNER JOIN dbo.Fornecedores AS f
                                           ON r.idFornecedor_fk = f.idFornecedor";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetRelatorioRetiradas", dt));
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

        private void FormRelatorioRetiradas_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            this.reportViewer1.RefreshReport();
        }
    }
}

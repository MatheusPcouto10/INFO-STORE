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
    public partial class FormRelatorioFornecedores : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public FormRelatorioFornecedores()
        {
            InitializeComponent();
        }
        private void CarregarDataGrid()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT * FROM fornecedores";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetRelatorioFornecedores", dt));
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
        private void FormRelatorioFornecedores_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
            this.reportViewer1.RefreshReport();
        }
    }
}

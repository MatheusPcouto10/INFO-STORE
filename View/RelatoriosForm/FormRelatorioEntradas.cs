﻿using System;
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
        public string comando;
        public FormRelatorioEntradas()
        {
            InitializeComponent();
        }
        private void CarregarRelatorio()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = comando;


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
                    MessageBox.Show("Não foi encontrado");
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
            this.CarregarRelatorio();
            this.reportViewer1.RefreshReport();
        }
    }
}

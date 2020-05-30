using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoA1
{
    class Conexao
    {
        SqlConnection conexao = new SqlConnection();
        public Conexao()
        {
            //conexao.ConnectionString = "Data Source=NOTE-EBENILDE\\SQLEXPRESS;Initial Catalog=Loja-Informatica;Integrated Security=True";
            conexao.ConnectionString = "Data Source=LAPTOP-QP8C0L2V\\SQLEXPRESS;Initial Catalog=Loja-Informatica;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}

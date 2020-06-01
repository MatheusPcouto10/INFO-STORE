using AvaliacaoA1.IDao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoA1.Model
{
    class Categorias : IDaoCategorias<Categorias>
    {
        public int idCategoria { get; set; }
        public String nomeCategoria { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public void create(Categorias t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO categorias(nomeCategoria) " +
                                  "values('" + t.nomeCategoria + "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Categoria Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Categorias findById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Categorias t, int id)
        {
            try
            {
                cmd.CommandText = "UPDATE categorias SET nomeCategoria = '" + t.nomeCategoria +
                                                                     "' WHERE idCategoria LIKE '" + idCategoria + "'";
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Categoria atualizada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}

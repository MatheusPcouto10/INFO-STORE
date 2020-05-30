using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoA1
{
    class SubCategorias : IDaoSubCategorias<SubCategorias>
    {
        public int idSubCategoria { get; set; }
        public String nomeSubCategoria { get; set; }
        public int idCategoria_fk { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public void create(SubCategorias t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO subcategorias(nomeSubCategoria, idCategoria_fk) " +
                                  "values('" + t.nomeSubCategoria + "', '" + t.idCategoria_fk + "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void delete(int id)
        {
            
        }

        public SubCategorias findById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(SubCategorias t, int idSubCategorias)
        {
            try
            {
                cmd.CommandText = "UPDATE subcategorias SET nomeSubCategoria = '" + t.nomeSubCategoria +
                                                                     "', idCategoria_fk = '" + t.idCategoria_fk +
                                                                     "' WHERE idProduto LIKE '" + idSubCategorias + "'";
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Sub-Categoria atualizada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}

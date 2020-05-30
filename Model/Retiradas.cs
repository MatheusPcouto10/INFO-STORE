using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliacaoA1.IDao;
using AvaliacaoA1.Session;

namespace AvaliacaoA1.Model
{
    class Retiradas : IDaoRetiradas<Retiradas>
    {
        public int idRetiradas { get; set; }
        public int idUsuario { get; set; }
        public int idProduto { get; set; }
        public DateTime dataRetirada { get; set; }
        public int qtdRetirada { get; set; }
        public int idFornecedor { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public Produtos produto = new Produtos();
        public Produtos Produtos
        {
            get => this.produto;
            set => this.produto = value;
        }

        public Usuario usuario = new Usuario();
        public Usuario Usuario
        {
            get => this.usuario;
            set => this.usuario = value;
        }

        public void create(Retiradas t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO retiradas(idUsuario_fk, idProduto_fk, dataRetirada, qtdRetirada, idFornecedor_fk) " +
                                  "values('" + t.idUsuario + "', '" + t.idProduto + "', '"+ t.dataRetirada + "', '" + t.qtdRetirada + "', '" + t.idFornecedor + "')";

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
            throw new NotImplementedException();
        }

        public Retiradas findById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Retiradas t, int idRetiradas)
        {
            try
            {
                cmd.CommandText = "UPDATE retiradas SET idUsuario_fk = '" + UsuarioSession.idUsuario +
                                                   "', idProduto_fk = '" + t.idProduto +
                                                   "', dataRetirada = '" + t.dataRetirada +
                                                   "', qtdRetirada = '" + t.qtdRetirada +
                                                   "', idFornecedor_fk = '" + t.idFornecedor +
                                                   "' WHERE idRetiradas LIKE '" + idRetiradas + "'";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}

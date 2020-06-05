using AvaliacaoA1.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaliacaoA1.Session;
using AvaliacaoA1.IDao;

namespace AvaliacaoA1.Model
{
    class Entradas : IDaoEntradas<Entradas>
    {
        public int idEntradas { get; set; }
        public int idUsuario { get; set; }
        public int idProduto { get; set; }
        public DateTime dataEntrada { get; set; }
        public int qtdEntrada { get; set; }
        public decimal precoEntrada { get; set; }
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

        public void create(Entradas t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO entradas(idUsuario_fk, idProduto_fk, dataEntrada, qtdEntrada, precoEntrada, idFornecedor_fk) " +
                                  "values('" + t.idUsuario + "', '" + t.idProduto + "', '" + t.dataEntrada + "', '" + t.qtdEntrada
                                  + "','" + t.precoEntrada + "','" + t.idFornecedor + "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Remessa adicionada com sucesso!");
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

        public Entradas findById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Entradas t, int idEntradas)
        {
            try
            {

                cmd.CommandText = "UPDATE entradas SET idUsuario_fk = '" + UsuarioSession.idUsuario +
                                                   "', idProduto_fk = '" + t.idProduto +
                                                   "', dataEntrada = '" + t.dataEntrada +
                                                   "', qtdEntrada = '" + t.qtdEntrada +
                                                   "', precoEntrada = '" + t.precoEntrada +
                                                   "', idFornecedor_fk = '" + t.idFornecedor +
                                                   "' WHERE idEntradas = " + idEntradas;

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Remessa alterada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void update(Entradas t)
        {
            throw new NotImplementedException();
        }
    }
}

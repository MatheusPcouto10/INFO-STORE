using AvaliacaoA1.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoA1
{
    class Produtos : IDaoProdutos<Produtos>
    {
        public int idProduto { get; set; }
        public String nomeProduto { get; set; }
        public String descricao { get; set; }
        public decimal preco { get; set; }
        public String imagem { get; set; }
        public String Status { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public SubCategorias subCategorias = new SubCategorias();
        public SubCategorias SubCategorias
        {
            get => this.subCategorias;
            set => this.subCategorias = value;
        }

        public void create(Produtos t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO produtos(nomeProduto, idSubCategoria_fk, descricao, preco, imagem, status) values('" + t.nomeProduto + "', '" + t.subCategorias.idSubCategoria + "', '"
                                                                                                       + t.descricao + "', '" + t.preco
                                                                                                       + "','" + t.imagem + "','" + t.Status + "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Produto cadastrado com sucesso!");
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

        public Produtos findById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Produtos t, int idProduto)
        {
            try
            {
                cmd.CommandText = "UPDATE produtos SET nomeProduto = '" + t.nomeProduto +
                                                                     "', idSubCategoria_fk = '" + t.subCategorias.idSubCategoria +
                                                                     "', descricao = '" + t.descricao +
                                                                     "', preco = '" + t.preco +
                                                                     "', imagem = '" + t.imagem+
                                                                     "', status = '" + t.Status +
                                                                     "' WHERE idProduto LIKE '" + idProduto + "'";
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Produto atualizado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}

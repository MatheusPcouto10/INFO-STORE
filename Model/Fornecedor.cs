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
    class Fornecedor : IDaoFornecedor<Fornecedor>
    {
        public int idFornecedor { get; set; }
        public String nomeFornecedor { get; set; }
        public String telefone { get; set; }
        public String email { get; set; }
        public String cnpj { get; set; }
        public String status { get; set; }
        public String bairro { get; set; }
        public String quadra { get; set; }
        public String alameda { get; set; }
        public String lote { get; set; }
        public String nomeFantasia { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public void create(Fornecedor t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO fornecedores(nomeFornecedor, telefone, email, cnpj, status, bairro, quadra, alameda, lote, nomeFantasia) " +
                                  "values('" + t.nomeFornecedor + "', '" + t.telefone + "', '" + t.email + "', '" 
                                             + t.cnpj + "', '" + t.status + "', '" + t.bairro + "', '" 
                                             + t.quadra + "', '" + t.alameda + "', '" + t.lote + "', '" + t.nomeFantasia + "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void update(Fornecedor t, int idFornecedor)
        {
            try
            {
                cmd.CommandText = "UPDATE fornecedores SET nomeFornecedor = '" + t.nomeFornecedor +
                                                                 "', telefone = '" + t.telefone +
                                                                 "', email = '" + t.email +
                                                                 "', cnpj = '" + t.cnpj +
                                                                 "', status = '" + t.status +
                                                                 "', bairro = '" + t.bairro +
                                                                 "', quadra = '" + t.quadra +
                                                                 "', alameda = '" + t.alameda +
                                                                 "', lote = '" + t.lote +
                                                                 "', nomeFantasia = '" + t.nomeFantasia +
                                                                 "' WHERE idFornecedor LIKE '" + idFornecedor + "'";
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Fornecedor atualizado com sucesso!");

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

        public Fornecedor findById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

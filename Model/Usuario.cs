using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoA1
{
    class Usuario : IDaoUsuario<Usuario>
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public String TipoUsuario { get; set; }
        public String Status { get; set; }
        public DateTime dataNascimento { get; set; }
        public String telefone { get; set; }
        public String bairro { get; set; }
        public String quadra { get; set; }
        public String alameda { get; set; }
        public String lote { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public Login login = new Login();
        public Login Login
        {
            get => this.login;
            set => this.login = value;
        }

        public void create(Usuario t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO usuarios(nome, cpf, email, senha, tipoUsuario, status, dataNascimento, telefone, bairro, quadra, alameda, lote) " +
                                  "values('"+t.Nome+"', '"+t.CPF+ "', '"  + t.login.Email + "', '" + t.login.Senha + 
                                          "','" + t.TipoUsuario + "', '" + t.Status + "', '" + t.dataNascimento + 
                                          "', '" + t.telefone + "', '" + t.bairro + "', '" + t.quadra + 
                                          "', '" + t.alameda + "', '" + t.lote +  "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void delete(int id)
        {
        }

        public Usuario findById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Usuario t, int idUsuario)
        {
            try
            {
                cmd.CommandText = "UPDATE usuarios SET nome = '" + t.Nome + "', cpf = '" + t.CPF +
                                                                 "', email = '" + t.login.Email + 
                                                                 "', senha = '" + t.login.Senha +
                                                                 "', tipoUsuario = '" + t.TipoUsuario +
                                                                 "', telefone = '" + t.telefone +
                                                                 "', bairro = '" + t.bairro +
                                                                 "', quadra = '" + t.quadra +
                                                                 "', alameda = '" + t.alameda +
                                                                 "', lote = '" + t.lote +
                                                                 "', status = '" + t.Status +
                                                                 "' WHERE idUsuario LIKE '" + idUsuario + "'";
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Usuário atualizado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}

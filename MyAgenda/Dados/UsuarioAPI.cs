using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MyAgenda.Entidades;

namespace MyAgenda.Dados
{
    class UsuarioAPI
    {
        const string C_CONEXAO = @"Data Source=DESKTOP-J789RM6; Initial Catalog=my_agenda; User ID=DESKTOP-J789RM6\leticiapc; Trusted_Connection=True";

        public Usuario BuscarUsuario(string email)
        {
            Usuario usuario = new Usuario();

            string query = "SELECT * FROM USUARIO WHERE EMAIL = @EMAIL";

            SqlConnection conn = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuario.IdUsuario = long.Parse(reader["id"].ToString());
                    usuario.Nome = reader["nome"].ToString();
                    usuario.Email = reader["email"].ToString();
                    usuario.Senha = reader["senha"].ToString();
                    usuario.DataNascimento = Convert.ToDateTime(reader["data_nascimento"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return usuario;
        }
    }
}

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
    class ListaAfazeresAPI
    {
        const string C_CONEXAO = @"Data Source=DESKTOP-J789RM6; Initial Catalog=my_agenda; User ID=DESKTOP-J789RM6\leticiapc; Trusted_Connection=True";

        public List<ListaAfazeres> CarregaListasAfazeres()
        {
            List<ListaAfazeres> listas = new List<ListaAfazeres>();

            string query = "SELECT * FROM LISTA_AFAZERES";

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
                    ListaAfazeres lista = new ListaAfazeres();
                    lista.Titulo = reader["titulo"].ToString();
                    lista.DataCriacao = Convert.ToDateTime(reader["criacao"].ToString());
                    listas.Add(lista);
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

            return listas;
        }

        public void AdicionaLista(ListaAfazeres lista)
        {
            string query = "INSERT INTO LISTA_AFAZERES (TITULO, USUARIO, CRIACAO) VALUES (@TITULO, @USUARIO, @CRIACAO)";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("TITULO", lista.Titulo));
                cmd.Parameters.Add(new SqlParameter("USUARIO", lista.Usuario.IdUsuario));
                cmd.Parameters.Add(new SqlParameter("CRIACAO", lista.DataCriacao));

                cmd.ExecuteNonQuery();
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
        }
    }
}

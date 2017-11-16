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
    class EventoAPI
    {
        const string C_CONEXAO = @"Data Source=DESKTOP-J789RM6; Initial Catalog=my_agenda; User ID=DESKTOP-J789RM6\leticiapc; Trusted_Connection=True";

        public List<Evento> CarregaEventos()
        {
            List<Evento> eventos = new List<Evento>();

            string query = "SELECT * FROM EVENTO";

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
                    Evento evento = new Evento();
                    evento.Titutlo = reader["titulo"].ToString();
                    evento.Descricao = reader["descricao"].ToString();
                    evento.DataHoraInicio = Convert.ToDateTime(reader["inicio"].ToString());
                    evento.DataHoraTermino = Convert.ToDateTime(reader["final"].ToString());
                    eventos.Add(evento);
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

            return eventos;
        }

        public void AdicionaEvento(Evento evento)
        {
            string query = "INSERT INTO EVENTO (USUARIO, TITULO, DESCRICAO, INICIO, FINAL) VALUES (@USUARIO, @TITULO, @DESCRICAO, @INICIO, @FINAL)";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("USUARIO", 1));
                cmd.Parameters.Add(new SqlParameter("TITULO", evento.Titutlo));
                cmd.Parameters.Add(new SqlParameter("DESCRICAO", evento.Descricao));
                cmd.Parameters.Add(new SqlParameter("INICIO", evento.DataHoraInicio));
                cmd.Parameters.Add(new SqlParameter("FINAL", evento.DataHoraTermino));

                cmd.ExecuteNonQuery();                
            }
            catch (Exception e)
            {
                Console.Write(e.Message);                
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void ExcluirEvento(Evento evento)
        {
            string query = "INSERT INTO EVENTO (USUARIO, TITULO, DESCRICAO, INICIO, FINAL) VALUES (@USUARIO, @TITULO, @DESCRICAO, @INICIO, @FINAL)";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("USUARIO", 1));
                cmd.Parameters.Add(new SqlParameter("TITULO", evento.Titutlo));
                cmd.Parameters.Add(new SqlParameter("DESCRICAO", evento.Descricao));
                cmd.Parameters.Add(new SqlParameter("INICIO", evento.DataHoraInicio));
                cmd.Parameters.Add(new SqlParameter("FINAL", evento.DataHoraTermino));

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
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

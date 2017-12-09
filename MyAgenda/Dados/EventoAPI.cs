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

        private UsuarioAPI _usuarioAPI = new UsuarioAPI();

        public List<Evento> CarregaEventos()
        {
            List<Evento> eventos = new List<Evento>();

            string query = "SELECT * FROM EVENTO ORDER BY INICIO ASC";

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
                    evento.IdEvento = long.Parse(reader["id"].ToString());
                    evento.Titutlo = reader["titulo"].ToString();
                    evento.Descricao = reader["descricao"].ToString();
                    evento.DataHoraInicio = Convert.ToDateTime(reader["inicio"].ToString());
                    evento.DataHoraTermino = Convert.ToDateTime(reader["final"].ToString());
                    evento.Usuario = new Usuario();
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

        public Evento BuscarEvento(long idEvento)
        {
            Evento evento = new Evento();

            string query = "SELECT * FROM EVENTO WHERE ID = @ID";

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

                cmd.Parameters.Add(new SqlParameter("ID", idEvento));

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    evento.IdEvento = long.Parse(reader["id"].ToString());
                    evento.Titutlo = reader["titulo"].ToString();
                    evento.Descricao = reader["descricao"].ToString();
                    evento.DataHoraInicio = Convert.ToDateTime(reader["inicio"].ToString());
                    evento.DataHoraTermino = Convert.ToDateTime(reader["final"].ToString());
                    evento.Usuario = new Usuario();
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

            return evento;
        }

        public void AdicionaEvento(Evento evento)
        {
            string query = "INSERT INTO EVENTO (USUARIO, TITULO, DESCRICAO, INICIO, FINAL, CONCLUIDO) VALUES (@USUARIO, @TITULO, @DESCRICAO, @INICIO, @FINAL, @CONCLUIDO)";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("USUARIO", 2));
                cmd.Parameters.Add(new SqlParameter("TITULO", evento.Titutlo));
                cmd.Parameters.Add(new SqlParameter("DESCRICAO", evento.Descricao));
                cmd.Parameters.Add(new SqlParameter("INICIO", evento.DataHoraInicio));
                cmd.Parameters.Add(new SqlParameter("FINAL", evento.DataHoraTermino));
                cmd.Parameters.Add(new SqlParameter("CONCLUIDO", "N"));

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

        public void EditarEvento(Evento eventoAntigo, Evento eventoAtualizado)
        {
            string query = "UPDATE EVENTO SET TITULO = @TITULO, DESCRICAO = @DESCRICAO, INICIO = @INICIO, FINAL = @FINAL, CONCLUIDO = @CONCLUIDO WHERE ID = @ID";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("TITULO", eventoAtualizado.Titutlo));
                cmd.Parameters.Add(new SqlParameter("DESCRICAO", eventoAtualizado.Descricao));
                cmd.Parameters.Add(new SqlParameter("INICIO", eventoAtualizado.DataHoraInicio));
                cmd.Parameters.Add(new SqlParameter("FINAL", eventoAtualizado.DataHoraTermino));
                cmd.Parameters.Add(new SqlParameter("CONCLUIDO", "N"));
                cmd.Parameters.Add(new SqlParameter("ID", eventoAntigo.IdEvento));

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
            string query = "DELETE FROM EVENTO WHERE ID = @ID";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("ID", evento.IdEvento));

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

        public void ConcluirEvento(Evento evento)
        {
            string query = "UPDATE EVENTO SET CONCLUIDO = @CONCLUIDO WHERE ID = @ID";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("CONCLUIDO", "S"));
                cmd.Parameters.Add(new SqlParameter("ID", evento.IdEvento));

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

        public List<Evento> BuscaInformacoesDeEventosParaEmissaoDeAlerta()
        {
            List<Evento> eventos = new List<Evento>();

            string query = "SELECT * FROM EVENTO WHERE CONCLUIDO = @CONCLUIDO ORDER BY INICIO ASC";

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
                cmd.Parameters.Add(new SqlParameter("CONCLUIDO", "N"));

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Evento evento = new Evento();
                    evento.IdEvento = long.Parse(reader["id"].ToString());
                    evento.Titutlo = reader["titulo"].ToString();
                    evento.Descricao = reader["descricao"].ToString();
                    evento.DataHoraInicio = Convert.ToDateTime(reader["inicio"].ToString());
                    evento.DataHoraTermino = Convert.ToDateTime(reader["final"].ToString());
                    evento.Usuario = new Usuario();
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
    }
}

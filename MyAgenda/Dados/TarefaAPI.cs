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
    class TarefaAPI
    {
        const string C_CONEXAO = @"Data Source=DESKTOP-J789RM6; Initial Catalog=my_agenda; User ID=DESKTOP-J789RM6\leticiapc; Trusted_Connection=True";

        public List<Tarefa> CarregaTarefas(string listaAfazeres)
        {
            List<Tarefa> tarefas = new List<Tarefa>();

            string query = "SELECT * FROM TAREFA WHERE LISTA = @LISTA AND USUARIO = 1 ORDER BY CONCLUIDO ASC";

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
                cmd.Parameters.Add(new SqlParameter("LISTA", listaAfazeres));

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tarefa tarefa = new Tarefa();
                    tarefa.Lista = new ListaAfazeres();
                    tarefa.Titulo = reader["titulo"].ToString();
                    tarefa.Data = Convert.ToDateTime(reader["mdata"].ToString());
                    tarefa.Usuario = new Usuario();
                    tarefas.Add(tarefa);
                }
            }
            catch (Exception e) {
                Console.Write(e);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return tarefas;
        }

        public void AdicionaTarefa(Tarefa tarefa)
        {
            string query = "INSERT INTO TAREFA (LISTA, USUARIO, TITULO, MDATA, CONCLUIDO) VALUES (@LISTA, @USUARIO, @TITULO, @MDATA, @CONCLUIDO)";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("LISTA", tarefa.Lista.Titulo));
                cmd.Parameters.Add(new SqlParameter("USUARIO", 2));
                cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));
                cmd.Parameters.Add(new SqlParameter("MDATA", tarefa.Data));
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

        public void EditarTarefa(Tarefa tarefaAntiga, Tarefa tarefaAtualizada)
        {
            string query = "UPDATE TAREFA SET LISTA = @LISTA, USUARIO = @USUARIO, TITULO = @TITULONOVO, MDATA = @MDATA, CONCLUIDO = @CONCLUIDO WHERE TITULO = @TITULOANTIGO AND USUARIO = 1 AND LISTA = @LISTAANTIGA";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("LISTA", "Tarefas da Faculdade"));
                cmd.Parameters.Add(new SqlParameter("USUARIO", 1));
                cmd.Parameters.Add(new SqlParameter("TITULONOVO", tarefaAtualizada.Titulo));
                cmd.Parameters.Add(new SqlParameter("MDATA", tarefaAtualizada.Data));
                cmd.Parameters.Add(new SqlParameter("TITULOANTIGO", tarefaAntiga.Titulo));
                cmd.Parameters.Add(new SqlParameter("LISTAANTIGA", "Tarefas da Faculdade"));
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

        public void ExcluirTarefa(Tarefa tarefa)
        {
            string query = "DELETE FROM TAREFA WHERE TITULO = @TITULO";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));

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

        public bool IsTarefaConcluida(string tituloTarefa, string nomeLista)
        {
            Tarefa tarefa = new Tarefa();

            string query = "SELECT CONCLUIDO FROM TAREFA WHERE LISTA = @LISTA AND TITULO = @TITULO";

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
                cmd.Parameters.Add(new SqlParameter("LISTA", nomeLista));
                cmd.Parameters.Add(new SqlParameter("TITULO", tituloTarefa));

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["concluido"].ToString().Equals("S"))
                    {
                        tarefa.IsConcluida = true;
                    }
                    else
                    {
                        tarefa.IsConcluida = false;
                    }
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

            return tarefa.IsConcluida;
        }

        public Tarefa BuscarTarefa(string tituloTarefa, string nomeLista)
        {
            Tarefa tarefa = new Tarefa();

            string query = "SELECT * FROM TAREFA WHERE TAREFA = @TAREFA AND LISTA = @LISTA";

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

                cmd.Parameters.Add(new SqlParameter("TAREFA", tituloTarefa));
                cmd.Parameters.Add(new SqlParameter("LISTA", nomeLista));

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tarefa.Titulo = reader["titulo"].ToString();
                    tarefa.Data = Convert.ToDateTime(reader["mdata"].ToString());

                    ListaAfazeres listaAfazeres = new ListaAfazeres();
                    listaAfazeres.Titulo = reader["lista"].ToString();

                    string isConcluida = reader["concluida"].ToString();

                    if (isConcluida.Equals("S"))
                    {
                        tarefa.IsConcluida = true;
                    } 
                    else
                    {
                        tarefa.IsConcluida = false;
                    }
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

            return tarefa;
        }

        public void ConcluirTarefa(Tarefa tarefa)
        {
            string query = "UPDATE TAREFA SET CONCLUIDO = @CONCLUIDO WHERE TITULO = @TITULO";

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
                cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));

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

        public void DesconcluirTarefa(Tarefa tarefa)
        {
            string query = "UPDATE TAREFA SET CONCLUIDO = @CONCLUIDO WHERE TITULO = @TITULO";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(C_CONEXAO);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("CONCLUIDO", "N"));
                cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));

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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MyAgenda.Entidades;

namespace MyAgenda.Dados
{
    class EventoAPI
    {
        const string STRING_CONEXAO = @"Data Source=tcp:allexhome.ddns.net,1433;Initial Catalog=my_agenda;MultipleActiveResultSets=true;User ID=sa;Password=mYaGeNdA2017";

        private SqlConnection _conexao = null;
        private UsuarioAPI _usuarioAPI = UsuarioAPI.GetInstance();

        /// <summary>
        /// Abre a conexão com o banco de dados
        /// </summary>
        /// <returns></returns>
        private bool _abreConexao()
        {
            if (_conexao == null)
            {
                _conexao = new SqlConnection(STRING_CONEXAO);
            }

            try
            {
                _conexao.Open();
                return true;
            }
            catch
            {

                if (_conexao.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    try
                    {
                        _conexao = new SqlConnection("Server=localhost;Database=my_agenda;MultipleActiveResultSets=true;Integrated Security=true");
                        _conexao.Open();
                        return true;
                    }
                    catch { }
                }

                return false;
            }
        }

        /// <summary>
        /// Fecha a conexão com o banco de dados
        /// </summary>
        /// <returns></returns>
        private bool _fechaConexao()
        {
            try
            {
                _conexao.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<Evento> CarregaEventos()
        {
            List<Evento> eventos = new List<Evento>();

            string query = "SELECT * FROM EVENTO ORDER BY INICIO ASC";
            
            SqlDataReader reader = null;

            if (_abreConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);

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

                _fechaConexao();
            }

            return eventos;
        }

        public Evento BuscarEvento(long idEvento)
        {
            Evento evento = new Evento();

            string query = "SELECT * FROM EVENTO WHERE ID = @ID";

            SqlDataReader reader = null;

            if (_abreConexao())
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand(query, _conexao);

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

                _fechaConexao();
            }

            return evento;
        }

        public void AdicionaEvento(Evento evento)
        {
            string query = "INSERT INTO EVENTO (USUARIO, TITULO, DESCRICAO, INICIO, FINAL, CONCLUIDO) VALUES (@USUARIO, @TITULO, @DESCRICAO, @INICIO, @FINAL, @CONCLUIDO)";


            if (_abreConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);
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

                _fechaConexao();

            }
        }

        public void EditarEvento(Evento eventoAntigo, Evento eventoAtualizado)
        {
            string query = "UPDATE EVENTO SET TITULO = @TITULO, DESCRICAO = @DESCRICAO, INICIO = @INICIO, FINAL = @FINAL, CONCLUIDO = @CONCLUIDO WHERE ID = @ID";
            
            if (_abreConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);
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

                _fechaConexao();
            }
        }

        public void ExcluirEvento(Evento evento)
        {
            string query = "DELETE FROM EVENTO WHERE ID = @ID";

            if (_abreConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);
                    cmd.Parameters.Add(new SqlParameter("ID", evento.IdEvento));

                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

                _fechaConexao();
            }
        }

        public void ConcluirEvento(Evento evento)
        {
            string query = "UPDATE EVENTO SET CONCLUIDO = @CONCLUIDO WHERE ID = @ID";

            if (_abreConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);
                    cmd.Parameters.Add(new SqlParameter("CONCLUIDO", "S"));
                    cmd.Parameters.Add(new SqlParameter("ID", evento.IdEvento));

                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

                _fechaConexao();
            }
        }

        public List<Evento> BuscaInformacoesDeEventosParaEmissaoDeAlerta()
        {
            List<Evento> eventos = new List<Evento>();

            string query = "SELECT * FROM EVENTO WHERE CONCLUIDO = @CONCLUIDO ORDER BY INICIO ASC";
            
            SqlDataReader reader = null;

            if (_abreConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);
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

                _fechaConexao();
            }

            return eventos;
        }
    }
}

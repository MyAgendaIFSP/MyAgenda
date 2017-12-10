using MyAgenda.Entidades;
using MyAgenda.Controladores.Geral;
using MyAgenda.Modelos.Geral;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyAgenda.Dados
{
    class TarefaAPI
    {
        private string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private SqlConnection _conexao = null;

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
                //throw new NotImplementedException();
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

        public List<Tarefa> CarregaTarefas(string listaAfazeres)
        {
            List<Tarefa> tarefas = new List<Tarefa>();

            string query = "SELECT * FROM TAREFA WHERE LISTA = @LISTA AND USUARIO = @USUARIO ORDER BY CONCLUIDO ASC";
            
            SqlDataReader reader = null;

            if (_abreConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _conexao);
                    cmd.Parameters.Add(new SqlParameter("LISTA", listaAfazeres));

                    UsuarioController usuarioController = UsuarioController.GetInstance();
                    UsuarioModel usuarioModel = usuarioController.GetModelo();

                    cmd.Parameters.Add(new SqlParameter("USUARIO", usuarioModel.Id));

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Tarefa tarefa = new Tarefa();
                        tarefa.Lista = new ListaAfazeres();
                        tarefa.Titulo = reader["titulo"].ToString();
                        tarefa.Data = Convert.ToDateTime(reader["mdata"].ToString());
                        tarefa.Usuario = usuarioModel;

                        tarefas.Add(tarefa);
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }

                _fechaConexao();
            }

            return tarefas;
        }

        public void AdicionaTarefa(Tarefa tarefa)
        {
            string query = "INSERT INTO TAREFA (LISTA, USUARIO, TITULO, MDATA, CONCLUIDO) VALUES (@LISTA, @USUARIO, @TITULO, @MDATA, @CONCLUIDO)";

            if (_abreConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);
                    cmd.Parameters.Add(new SqlParameter("LISTA", tarefa.Lista.Titulo));
                    cmd.Parameters.Add(new SqlParameter("USUARIO", tarefa.Usuario.Id));
                    cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));
                    cmd.Parameters.Add(new SqlParameter("MDATA", tarefa.Data));
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

        public void EditarTarefa(Tarefa tarefaAntiga, Tarefa tarefaAtualizada)
        {
            string query = "UPDATE TAREFA SET LISTA = @LISTA, USUARIO = @USUARIO, TITULO = @TITULONOVO, MDATA = @MDATA, CONCLUIDO = @CONCLUIDO WHERE TITULO = @TITULOANTIGO AND USUARIO = @USUARIO AND LISTA = @LISTAANTIGA";

            if (_abreConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _conexao);
<<<<<<< HEAD
                    cmd.Parameters.Add(new SqlParameter("LISTA", tarefaAtualizada.Lista));

                    UsuarioController usuarioController = UsuarioController.GetInstance();
                    UsuarioModel usuarioModel = usuarioController.GetModelo();

                    cmd.Parameters.Add(new SqlParameter("USUARIO", usuarioModel.Id));

=======
                    cmd.Parameters.Add(new SqlParameter("LISTA", "Lista da Faculdade"));
                    cmd.Parameters.Add(new SqlParameter("USUARIO", tarefaAtualizada.Usuario.Id));
>>>>>>> 75ddb59bbb8f8c097e3293e647581f57a7172978
                    cmd.Parameters.Add(new SqlParameter("TITULONOVO", tarefaAtualizada.Titulo));
                    cmd.Parameters.Add(new SqlParameter("MDATA", tarefaAtualizada.Data));
                    cmd.Parameters.Add(new SqlParameter("TITULOANTIGO", tarefaAntiga.Titulo));
                    cmd.Parameters.Add(new SqlParameter("LISTAANTIGA", tarefaAntiga.Lista));
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

        public void ExcluirTarefa(Tarefa tarefa)
        {
            string query = "DELETE FROM TAREFA WHERE TITULO = @TITULO AND LISTA = @LISTA AND USUARIO = @USUARIO";

            if (_abreConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _conexao);
                    cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));
                    cmd.Parameters.Add(new SqlParameter("LISTA", tarefa.Lista));


                    UsuarioController usuarioController = UsuarioController.GetInstance();
                    UsuarioModel usuarioModel = usuarioController.GetModelo();

                    cmd.Parameters.Add(new SqlParameter("USUARIO", usuarioModel.Id));

                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

                _fechaConexao();
            }
        }

        public bool IsTarefaConcluida(string tituloTarefa, string nomeLista)
        {
            Tarefa tarefa = new Tarefa();

            string query = "SELECT CONCLUIDO FROM TAREFA WHERE LISTA = @LISTA AND TITULO = @TITULO AND USUARIO = @USUARIO";
            
            SqlDataReader reader = null;

            if (_abreConexao())
            {

                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);
                    cmd.Parameters.Add(new SqlParameter("LISTA", nomeLista));
                    cmd.Parameters.Add(new SqlParameter("TITULO", tituloTarefa));

                    UsuarioController usuarioController = UsuarioController.GetInstance();
                    UsuarioModel usuarioModel = usuarioController.GetModelo();

                    cmd.Parameters.Add(new SqlParameter("USUARIO", usuarioModel.Id));

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

                _fechaConexao();
            }

            return tarefa.IsConcluida;
        }

        public Tarefa BuscarTarefa(string tituloTarefa, string nomeLista)
        {
            Tarefa tarefa = new Tarefa();

            string query = "SELECT * FROM TAREFA WHERE TAREFA = @TAREFA AND LISTA = @LISTA AND USUARIO = @USUARIO";
            
            SqlDataReader reader = null;

            if (_abreConexao())
            {

                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);

                    cmd.Parameters.Add(new SqlParameter("TAREFA", tituloTarefa));
                    cmd.Parameters.Add(new SqlParameter("LISTA", nomeLista));

                    UsuarioController usuarioController = UsuarioController.GetInstance();
                    UsuarioModel usuarioModel = usuarioController.GetModelo();

                    cmd.Parameters.Add(new SqlParameter("USUARIO", usuarioModel.Id));

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

                _fechaConexao();
            }

            return tarefa;
        }

        public void ConcluirTarefa(Tarefa tarefa)
        {
            string query = "UPDATE TAREFA SET CONCLUIDO = @CONCLUIDO WHERE TITULO = @TITULO AND LISTA = @LISTA AND USUARIO = @USUARIO";

            if (_abreConexao())
            {

                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);
                    cmd.Parameters.Add(new SqlParameter("CONCLUIDO", "S"));
                    cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));
                    cmd.Parameters.Add(new SqlParameter("LISTA", tarefa.Lista));

                    UsuarioController usuarioController = UsuarioController.GetInstance();
                    UsuarioModel usuarioModel = usuarioController.GetModelo();

                    cmd.Parameters.Add(new SqlParameter("USUARIO", usuarioModel.Id));

                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

                _fechaConexao();
            }
        }

        public void DesconcluirTarefa(Tarefa tarefa)
        {
            string query = "UPDATE TAREFA SET CONCLUIDO = @CONCLUIDO WHERE TITULO = @TITULO AND LISTA = @LISTA AND USUARIO = @USUARIO";

            if (_abreConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _conexao);
                    cmd.Parameters.Add(new SqlParameter("CONCLUIDO", "N"));
                    cmd.Parameters.Add(new SqlParameter("TITULO", tarefa.Titulo));
                    cmd.Parameters.Add(new SqlParameter("LISTA", tarefa.Lista));

                    UsuarioController usuarioController = UsuarioController.GetInstance();
                    UsuarioModel usuarioModel = usuarioController.GetModelo();

                    cmd.Parameters.Add(new SqlParameter("USUARIO", usuarioModel.Id));

                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

                _fechaConexao();
            }
        }
    }
}

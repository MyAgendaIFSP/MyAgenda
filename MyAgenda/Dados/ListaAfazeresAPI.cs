using MyAgenda.Entidades;
using MyAgenda.Controladores.Geral;
using MyAgenda.Modelos.Geral;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MyAgenda.Dados
{
    class ListaAfazeresAPI
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

        public List<ListaAfazeres> CarregaListasAfazeres()
        {
            List<ListaAfazeres> listas = new List<ListaAfazeres>();

            string query = "SELECT * FROM LISTA_AFAZERES WHERE USUARIO = @USUARIO ORDER BY TITULO ASC";
            
            SqlDataReader reader = null;

            if (_abreConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);

                    UsuarioController usuarioController = UsuarioController.GetInstance();
                    UsuarioModel usuarioModel = usuarioController.GetModelo();

                    cmd.Parameters.Add(new SqlParameter("USUARIO", usuarioModel.Id));

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListaAfazeres lista = new ListaAfazeres();
                        lista.Titulo = reader["titulo"].ToString();
                        lista.DataCriacao = Convert.ToDateTime(reader["criacao"].ToString());
                        lista.Usuario = usuarioModel;

                        listas.Add(lista);
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }

                _fechaConexao();
            }

            return listas;
        }

        public string GetNomePrimeiraListaDeAfazeres()
        {
            List<ListaAfazeres> listas = new List<ListaAfazeres>();

            string query = "SELECT * FROM LISTA_AFAZERES WHERE USUARIO = @USUARIO ORDER BY TITULO ASC";
            
            SqlDataReader reader = null;

            if (_abreConexao())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(query, _conexao);

                    UsuarioController usuarioController = UsuarioController.GetInstance();
                    UsuarioModel usuarioModel = usuarioController.GetModelo();

                    cmd.Parameters.Add(new SqlParameter("USUARIO", usuarioModel.Id));

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListaAfazeres lista = new ListaAfazeres();
                        lista.Titulo = reader["titulo"].ToString();
                        lista.DataCriacao = Convert.ToDateTime(reader["criacao"].ToString());
                        lista.Usuario = usuarioModel;

                        listas.Add(lista);
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }

                _fechaConexao();
            }

            if (listas.Count > 0)
            {
                return listas.ElementAt(0).Titulo.ToString();
            }
            else
            {
                return null;
            }
        }

        public void AdicionaLista(ListaAfazeres lista)
        {
            string query = "INSERT INTO LISTA_AFAZERES (TITULO, USUARIO, CRIACAO) VALUES (@TITULO, @USUARIO, @CRIACAO)";

            if (_abreConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _conexao);
                    cmd.Parameters.Add(new SqlParameter("TITULO", lista.Titulo));
                    cmd.Parameters.Add(new SqlParameter("USUARIO", lista.Usuario.Id));
                    cmd.Parameters.Add(new SqlParameter("CRIACAO", lista.DataCriacao));

                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }

                _fechaConexao();
            }
        }
    }
}

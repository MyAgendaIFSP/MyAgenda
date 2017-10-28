using MyAgenda.Controladores.ListaContatos;
using MyAgenda.Modelos.ListaContatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Database
{
    class ContatosAPI
    {

        private readonly string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private static ContatosAPI _instancia = null;

        private SqlConnection _conexao = null;

        public static ContatosAPI GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new ContatosAPI();
            }

            return _instancia;
        }

        private ContatosAPI()
        {
            STRING_CONEXAO = @"Data Source=tcp:allexhome.ddns.net;Initial Catalog=my_agenda;MultipleActiveResultSets=true;User ID=sa;Password=mYaGeNdA2017";
        }

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

        /// <summary>
        /// Busca uma contato no banco de dados
        /// </summary>
        /// <param name="busca">nome/email que será buscado</param>
        /// <returns></returns>
        public List<ContatoController> BuscaContato(string busca)
        {
            if (_abreConexao())
            {
                List<ContatoController> contatos = new List<ContatoController>();

                SqlCommand cmd = new SqlCommand("select id, nome, email, [ip] from usuario where usuario.nome like @busca or email like @busca;", _conexao);
                cmd.Parameters.AddWithValue("@busca", busca);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {
                        int id = (int)rdr["id"];
                        string nome = rdr["nome"].ToString();
                        string email = rdr["email"].ToString();
                        string ip = rdr["ip"].ToString();
                        UsuarioAPI.EEstadoUsuario estado = (UsuarioAPI.EEstadoUsuario)rdr["estado"];

                        contatos.Add(new ContatoController(new ContatoModelo(id, nome, email, estado, ip)));
                    }

                }
                _fechaConexao();

                return contatos;
            }

            return null;
        }

        /// <summary>
        /// Obtém os contatos de um usuário
        /// </summary>
        /// <param name="uid">id do usuario</param>
        /// <returns></returns>
        public List<ContatoController> CarregaItensMatriz(int uid)
        {
            if (_abreConexao())
            {
                List<ContatoController> contatos = new List<ContatoController>();

                SqlCommand cmd = new SqlCommand("GetContatos", _conexao);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario_id", uid);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int id = (int)rdr["id"];
                        string nome = rdr["nome"].ToString();
                        string email = rdr["email"].ToString();
                        string ip = rdr["ip"].ToString();
                        UsuarioAPI.EEstadoUsuario estado = (UsuarioAPI.EEstadoUsuario)rdr["estado"];

                        contatos.Add(new ContatoController(new ContatoModelo(id, nome, email, estado, ip)));
                    }

                }
                _fechaConexao();

                return contatos;
            }

            return null;
        }

    }
}

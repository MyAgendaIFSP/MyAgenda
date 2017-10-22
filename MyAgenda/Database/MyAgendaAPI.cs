using MyAgenda.Controladores.MatrizTempo;
using MyAgenda.Modelos.Geral;
using MyAgenda.Seguranca;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Database
{
    class MyAgendaAPI
    {
        private const string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private static MyAgendaAPI _instancia = null;

        private SqlConnection _conexao = null;

        public static MyAgendaAPI GetInstance()
        {
            if(_instancia == null)
            {
                _instancia = new MyAgendaAPI();
            }

            return _instancia;
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
        /// Verifica se o email existe nos registros
        /// </summary>
        /// <param name="email">email a ser verificado</param>
        /// <returns></returns>
        public bool EmailExiste(string email)
        {
            if (_abreConexao())
            {

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM usuario WHERE email LIKE @email;", _conexao);
                cmd.Parameters.AddWithValue("@email", email);

                int qtd = (int)cmd.ExecuteScalar();

                _fechaConexao();

                return qtd > 0;
            }

            return false;
        }

        /// <summary>
        /// Autentica um usuário no sistema
        /// </summary>
        /// <param name="email">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>Modelo do usuário</returns>
        public UsuarioModel AutenticaUsuario(string email, string senha)
        {
            Criptografia cripto = new Criptografia();
            bool autorizado = cripto.VerificaSenha(_getSenha(email), senha, _getSalt(email));

            if (autorizado)
            {
                UsuarioModel u = _getUsuario(email);
                return u;
            }

            return null;
        }

        /// <summary>
        /// Obtém o modelo de um usuário
        /// </summary>
        /// <param name="email">email do usuário</param>
        /// <returns></returns>
        private UsuarioModel _getUsuario(string email)
        {
            if (_abreConexao())
            {
                int id = _getUserId(email);
                UsuarioModel usuario = null;
                MatrizController matriz;

                if(id < 0)
                {
                    return null;
                }
                
                SqlCommand cmd = new SqlCommand("GetModeloUsuario", _conexao);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user_id", id);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {
                        int uid = (int) rdr["id"];
                        int matrizId = (int)rdr["matriz"];
                        string nome = rdr["nome"].ToString();
                        string d = rdr["matriz_inicializacao"].ToString();
                        DateTime dtNasc = DateTime.Parse(rdr["data_nascimento"].ToString());
                        DateTime matInit = DateTime.Parse(rdr["matriz_inicializacao"].ToString());
                        DateTime matUtili = DateTime.Parse(rdr["matriz_ulti_utilizacao"].ToString());

                        matriz = MatrizController.GetInstance(matrizId, matInit, matUtili);
                        usuario = new UsuarioModel(uid, nome, dtNasc, matriz);
                    }
                    
                }
                _fechaConexao();

                return usuario;
            }

            return null;
        }

        /// <summary>
        /// Obtém o id do usuário
        /// </summary>
        /// <param name="email">email do usuário</param>
        /// <returns></returns>
        private int _getUserId(string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT id FROM usuario WHERE email LIKE @email;", _conexao);
            cmd.Parameters.AddWithValue("@email", email);

            int id = (int)cmd.ExecuteScalar();
            
            return id;
        }

        /// <summary>
        /// Obtém o salt da senha do usuário no banco de dados
        /// </summary>
        /// <param name="email">email do usuário</param>
        /// <returns></returns>
        private string _getSalt(string email)
        {
            if (_abreConexao())
            {

                SqlCommand cmd = new SqlCommand("SELECT salt FROM usuario WHERE email LIKE @email;", _conexao);
                cmd.Parameters.AddWithValue("@email", email);

                string salt = (string)cmd.ExecuteScalar();

                _fechaConexao();
                return salt;
            }

            return null;
        }

        /// <summary>
        /// Obtém a senha do usuário no banco de dados
        /// </summary>
        /// <param name="email">email do usuário</param>
        /// <returns></returns>
        private string _getSenha(string email)
        {
            if (_abreConexao())
            {

                SqlCommand cmd = new SqlCommand("SELECT senha FROM usuario WHERE email LIKE @email;", _conexao);
                cmd.Parameters.AddWithValue("@email", email);

                string senha = (string)cmd.ExecuteScalar();

                _fechaConexao();
                return senha;
            }

            return null;
        }
    }
}

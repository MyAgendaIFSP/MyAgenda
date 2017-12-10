using MyAgenda.Modelos.Geral;
using MyAgenda.Seguranca;
using System.Data.SqlClient;

namespace MyAgenda.Dados
{
    public class UsuarioAPI
    {
        private string STRING_CONEXAO = "Server=localhost;Database=my_agenda;Integrated Security=true";

        private static UsuarioAPI _instancia = null;

        private SqlConnection _conexao = null;

        public enum EEstadoUsuario { ONLINE = 1, OFFLINE }

        public static UsuarioAPI GetInstance()
        {
            if(_instancia == null)
            {
                _instancia = new UsuarioAPI();
            }

            return _instancia;
        }

        private UsuarioAPI()
        {
            /*IpFixoSqnApi.Api server = new IpFixoSqnApi.Api();
            string maq = server.AuthUsuario("allex123", "123456");
            string ip = server.GetAddress(maq);
            
            STRING_CONEXAO = @"Data Source=tcp:" + ip + @";Initial Catalog=my_agenda;MultipleActiveResultSets=true;User ID=sa;Password=mYaGeNdA2017";*/

            STRING_CONEXAO = @"Data Source=tcp:allexhome.ddns.net,1433;Initial Catalog=my_agenda;MultipleActiveResultSets=true;User ID=sa;Password=mYaGeNdA2017";
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
                //throw new NotImplementedException();
                _conexao.Open();
                return true;
            }
            catch
            {
                
                if(_conexao.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    try {
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

        public bool VerificaConexao()
        {
            return _abreConexao();
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

                if (id < 0)
                {
                    return null;
                }

                SqlCommand cmd = new SqlCommand("GetModeloUsuario", _conexao);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user_id", id);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    try
                    {
                        while (rdr.Read())
                        {
                            int uid = (int)rdr["id"];
                            string nome = rdr["nome"].ToString();

                            usuario = new UsuarioModel(uid, nome);
                        }
                    }
                    catch { }
                }
                _fechaConexao();

                return usuario;
            }

            return null;
        }

        private UsuarioModel _getUsuario(int uid)
        {
            if (_abreConexao())
            {
                UsuarioModel usuario = null;

                if (uid < 0)
                {
                    return null;
                }

                SqlCommand cmd = new SqlCommand("GetModeloUsuario", _conexao);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@user_id", uid);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    try
                    {
                        while (rdr.Read())
                        {
                            string nome = rdr["nome"].ToString();
                            
                            usuario = new UsuarioModel(uid, nome);
                        }
                    }
                    catch { }
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
        /// <param name="lembrar">manter o usuário logado no sistema</param>
        /// <returns>Modelo do usuário</returns>
        public UsuarioModel AutenticaUsuario(string email, string senha, bool lembrar)
        {
            Criptografia cripto = new Criptografia();
            bool autorizado = cripto.VerificaSenha(_getSenha(email), senha, _getSalt(email));

            if (autorizado)
            {
                UsuarioModel u = _getUsuario(email);

                try
                {
                    _lembrarUsuario(u.Id, lembrar);
                }
                catch { }

                _abreSessao(u.Id);

                return u;
            }

            return null;
        }

        /// <summary>
        /// Marca o usuário para login automático
        /// </summary>
        /// <param name="uid">id do usuário</param>
        /// <param name="lembrar"></param>
        /// <returns></returns>
        private bool _lembrarUsuario(int uid, bool lembrar)
        {
            if (_abreConexao())
            {
                SqlCommand cmd = new SqlCommand("UPDATE usuario SET lembrar = @lembrar WHERE usuario.id = @id", _conexao);
                cmd.Parameters.AddWithValue("@id", uid);
                cmd.Parameters.AddWithValue("@lembrar", ((lembrar) ? 1 : 0));

                int qtd = (int)cmd.ExecuteNonQuery();

                _fechaConexao();

                if(qtd > 0)
                {
                    Properties.Settings configs = Properties.Settings.Default;
                    configs.LembrarLogin = lembrar;
                    configs.UsuarioLembrado = (lembrar) ? uid : 0;
                    configs.Save();
                }

                return qtd > 0;
            }

            return false;
        }

        /// <summary>
        /// Encerra a sessão de um usuario
        /// </summary>
        /// <param name="uid">id do usuárioque será deslogado</param>
        /// <returns></returns>
        public bool Logoff(int uid, bool manterEstadoLembrar)
        {
            if (_abreConexao())
            {
                SqlCommand cmd;

                if (manterEstadoLembrar)
                {
                    cmd = new SqlCommand("UPDATE usuario SET estado = @estado WHERE usuario.id = @id", _conexao);
                }
                else
                {
                    cmd = new SqlCommand("UPDATE usuario SET lembrar = 0, estado = @estado WHERE usuario.id = @id", _conexao);
                }

                cmd.Parameters.AddWithValue("@id", uid);
                cmd.Parameters.AddWithValue("@estado", (int) EEstadoUsuario.OFFLINE);

                int qtd = (int)cmd.ExecuteNonQuery();

                _fechaConexao();

                if (qtd > 0 && !manterEstadoLembrar)
                {
                    Properties.Settings configs = Properties.Settings.Default;
                    configs.LembrarLogin = false;
                    configs.UsuarioLembrado = 0;
                    configs.Save();
                }

                return qtd > 0;
            }

            return false;
        }

        /// <summary>
        /// Abre uma sessão de um usuário lembrado
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public UsuarioModel Login(int uid)
        {
            if (_abreConexao())
            {
                if (_abreSessao(uid))
                {
                    UsuarioModel u = _getUsuario(uid);
                    return u;
                }
                                
            }

            return null;
        }

        /// <summary>
        /// Marca a sessão de um usuário como ativa
        /// </summary>
        /// <param name="uid">id do usuário</param>
        /// <returns></returns>
        private bool _abreSessao(int uid)
        {
            if (_abreConexao())
            {
                SqlCommand cmd = new SqlCommand("UPDATE usuario SET estado = @estado WHERE usuario.id = @id", _conexao);
                cmd.Parameters.AddWithValue("@id", uid);
                cmd.Parameters.AddWithValue("@estado", (int)EEstadoUsuario.ONLINE);

                int qtd = (int)cmd.ExecuteNonQuery();

                _fechaConexao();
                
                return qtd > 0;

            }

            return false;
        }
                
    }
}

using MyAgenda.Dados;
using MyAgenda.Modelos.Geral;

namespace MyAgenda.Controladores.Geral
{
    public class UsuarioController
    {

        private UsuarioModel _modelo;

        private static UsuarioController _instancia = null;
        
        private UsuarioAPI _api;

        public bool IsAutenticado { get; set; }

        public static UsuarioController GetInstance()
        {
            if(_instancia == null)
            {
                _instancia = new UsuarioController();
            }

            return _instancia;
        }

        private UsuarioController()
        {
            IsAutenticado = false;
            _api = UsuarioAPI.GetInstance();
        }

        public UsuarioModel GetModelo()
        {
            return _modelo;
        }

        /// <summary>
        /// Autentica o usuário no sistema
        /// </summary>
        /// <returns></returns>
        public bool Autentica(string email, string senha, bool lembrar)
        {
            //Autenticar usuário no banco de dados
            if (_verificaEmail(email))
            {
                _modelo = _api.AutenticaUsuario(email, senha, lembrar);
                IsAutenticado = _modelo != null;
                return IsAutenticado;
            }

            return false;
        }

        /// <summary>
        /// Finaliza a sessão de um usuário, mas não muda i estado de lembrar
        /// </summary>
        /// <returns></returns>
        public bool EncerraSessao()
        {
            IsAutenticado = false;
            return _api.Logoff(_modelo.Id, true);
        }

        /// <summary>
        /// Finaliza a sessão do usuário e reseta a opção de lembrar login. 
        /// </summary>
        /// <returns></returns>
        public bool EncerraSessaoDefinitivo()
        {
            IsAutenticado = false;
            return _api.Logoff(_modelo.Id, false);
        }

        public bool AbreSessaoLembrada()
        {
            Properties.Settings configs = Properties.Settings.Default;
            _modelo = _api.Login(configs.UsuarioLembrado);
            IsAutenticado = _modelo != null;
            return IsAutenticado;
        }

        private bool _verificaEmail(string email)
        {
            //Checar se o email existe
            return _api.EmailExiste(email);
        }
        
    }
}

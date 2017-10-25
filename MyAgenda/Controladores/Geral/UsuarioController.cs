using MyAgenda.Database;
using MyAgenda.Modelos.Geral;

namespace MyAgenda.Controladores.Geral
{
    public class UsuarioController
    {

        private UsuarioModel _modelo;

        private static UsuarioController _instancia = null;
        
        private MyAgendaAPI _api;

        public bool IsAutenticado { get; set; } = false;

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
            _api = MyAgendaAPI.GetInstance();
        }
        
        /// <summary>
        /// Autentica o usuário no sistema
        /// </summary>
        /// <returns></returns>
        public bool Autentica(string email, string senha)
        {
            //Autenticar usuário no banco de dados
            if (_verificaEmail(email))
            {
                _modelo = _api.AutenticaUsuario(email, senha);
                IsAutenticado = _modelo != null;
                return IsAutenticado;
            }

            return false;
        }

        private bool _verificaEmail(string email)
        {
            //Checar se o email existe
            return _api.EmailExiste(email);
        }

    }
}

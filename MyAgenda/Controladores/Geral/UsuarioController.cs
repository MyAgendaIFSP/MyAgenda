using MyAgenda.Modelos.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Controladores.Geral
{
    class UsuarioController
    {

        private UsuarioModel _modelo;

        private static UsuarioController _instancia = null;

        public static UsuarioController GetInstance()
        {
            if(_instancia == null)
            {
                _instancia = new UsuarioController();
            }

            return _instancia;
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
                return true;
            }

            return false;
        }

        private bool _verificaEmail(string email)
        {
            //Checar se o email existe
            return true;
        }

    }
}

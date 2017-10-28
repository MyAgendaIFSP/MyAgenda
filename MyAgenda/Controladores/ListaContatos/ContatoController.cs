using MyAgenda.Modelos.ListaContatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Controladores.ListaContatos
{

    class ContatoController
    {

        private ContatoModelo _modelo { get; set; }

        public ContatoController(ContatoModelo modelo)
        {
            _modelo = modelo;
        }

        public ContatoModelo GetModelo()
        {
            return _modelo;
        }
    }
}

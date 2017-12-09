using MyAgenda.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Modelos.ListaContatos
{
    public class ContatoModelo
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public UsuarioAPI.EEstadoUsuario Estado { get; set; }

        public ContatoModelo(int id, string nome, string email, UsuarioAPI.EEstadoUsuario estado)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Estado = estado;
        }

    }
}

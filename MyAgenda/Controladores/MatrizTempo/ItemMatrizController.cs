using MyAgenda.Componentes.MatrizTempo;
using MyAgenda.Database;
using MyAgenda.Modelos.MatrizTempo;
using System.Drawing;

namespace MyAgenda.Controladores.MatrizTempo
{
    public class ItemMatrizController
    {
        private MatrizTempoAPI _api;

        private ItemMatrizModel _modelo;

        public ItemMatrizController(ItemMatrizModel item)
        {
            _modelo = item;
            _api = MatrizTempoAPI.GetInstance();
        }

        public ItemMatrizModel GetModel()
        {
            return _modelo;
        }

        public bool MarcarItemInativo()
        {
            if (_api.MarcarItemMatrizInativo(_modelo.Id))
            {
                _modelo.Ativo = false;
                return true;
            }

            return false;
        }
        
        internal bool MarcarItemAtivo()
        {
            if (_api.MarcarItemMatrizAtivo(_modelo.Id))
            {
                _modelo.Ativo = true;
                return true;
            }

            return false;
        }
        
    }
}

using MyAgenda.Modelos.MatrizTempo;

namespace MyAgenda.Controladores.MatrizTempo
{
    public class ItemMatrizController
    {

        private ItemMatrizModel _item;

        public ItemMatrizController(ItemMatrizModel item)
        {
            _item = item;
        }

        public ItemMatrizModel GetModel()
        {
            return _item;
        }

        public bool MarcarItemInativo()
        {
            //Marcar o item como inativo no banco
            _item.Ativo = false;

            return true;
        }
        
        internal bool MarcarItemAtivo()
        {
            //Marcar o item como ativo no banco de dados
            _item.Ativo = true;

            return true;
        }
    }
}

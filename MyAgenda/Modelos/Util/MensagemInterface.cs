using MyAgenda.Modelos;
using System;
using System.Windows.Forms;

namespace MyAgenda.Modelos.Util
{
    public class MensagemInterface
    {
        public void MensagemCancelar()
        {
         
            DialogResult result = MessageBox.Show(Constantes.C_MESSAGE, Constantes.C_TIPE ,
                                     Constantes.C_BUTTONS, Constantes.C_ICON);

           if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // FECHA A APLICAÇÃO
                Application.Exit();
            }

        }
    }
}
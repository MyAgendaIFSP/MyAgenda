using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgenda.Modelos.Util
{
    public class ConversorHoras
    {
        public String MinuteToHour(int value)
        {
            String valorFormatado;
            if(value < 60)
            {
                valorFormatado = value.ToString();
            }
            else
            {
                valorFormatado = value / 60 + "h" + value % 60;
            }
            //MessageBox.Show(valorFormatado.ToString());
            return valorFormatado;
            
        }
    }
}

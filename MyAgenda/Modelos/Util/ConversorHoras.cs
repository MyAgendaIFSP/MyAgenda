using System;

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
                valorFormatado = value / 60 + ":" + value % 60;
            }
            //MessageBox.Show(valorFormatado.ToString());
            return valorFormatado;
            
        }

        public String SecondsToMinute(int value)
        {
            String valorFormatado;
            if (value < 60)
            {
                valorFormatado = "00:" + value.ToString();
            }
            else
            {
                valorFormatado = (value / 60).ToString() + ":" + ((value % 60 < 10)? "0" + (value % 60).ToString() : (value % 60).ToString());
            }
            //MessageBox.Show(valorFormatado.ToString());
            return valorFormatado;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Indicators
{
    public class Protoсol
    {
        public enum Protocols : int
        {
            /*Нумерованный список с протоколами для связи с терминалами*/
            Keli,
            TenzoM,
            p643
        }

        /// <summary>
        /// Массив со всеми протоколами
        /// </summary>
        public static readonly string[] protocols = new string[] { "keli", "TenzoM", "6.43" };
        
        /// <summary>
        /// Обьект компорта, настроенный и открытый
        /// </summary>
        private SerialPort serialPort;

        /// <summary>
        /// Класс для выбора протокола работы 
        /// </summary>
        /// <param name="port">Открытый настроенный компорт</param>
        public Protoсol (SerialPort port) {         
            this.serialPort = port;
        }

        
        /// <summary>
        /// Метод для загрузки нужного протоколы, возвращает класс работы с терминалом
        /// </summary>
        /// <param name="protokol"> Enum  с выбранным протоколом</param>
        /// <returns></returns>
        public Indikator GetIndikator(int protokol ) {

            switch (protokol)
            {
                case (int)Protocols.Keli:
                    return new KeliXK3109(serialPort);                    
                case (int)Protocols.TenzoM:
                    return null;
                    break;
                case (int)Protocols.p643:
                    return null;
                    break;
                default:
                    return null;
            }


        }

    }
}

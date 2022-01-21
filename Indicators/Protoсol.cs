﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Indicators
{
    public class Protoсol
    {
        /// <summary>
        /// Общий класс для выбора протокола
        /// </summary>
        public enum Protocols : int
        {
            /*
             * Нумерованный список с протоколами для связи с терминалами,
             * нужен для проверки условий при инициализации нужного протокола
             * порядок названий протоколов должен соответствовать порядку 
             * в массиве с названиями протоколов
             */

            Keli,
            TenzoM,
            p643
        }

        /// <summary>
        /// Массив со всеми протоколами
        /// индекс элемента данного массива служит номером для выбора нужного индекатора
        /// из метода GetIndicator()
        /// </summary>
        public static readonly string[] protocols = new string[] { "keli k9", "TenzoM", "6.43" };
        
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
        /// Метод для загрузки нужного протокола
        /// </summary>
        /// <param name="protokol"> Индекс элемента из массива с названиями протоколов</param>
        /// <returns> Возвращает класс работы с терминалом </returns>
        public Indikator GetIndicator(int protokol ) {

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

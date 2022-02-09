using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace IOmoduls
{
    /// <summary>
    /// Класс для выбора модуля ввода вывода
    /// </summary>
    public class DeviceIO
    {
        /// <summary>
        /// Массив всех модулей ввода/вывода
        /// порядковый номер выбранного модуля в этом массиве нужно передать в метод getDevice();
        /// </summary>
        public static string[] devicesName = new string[] { "ПР200 prime 2.0", "ПР200 v 6.0" };
        

        /// <summary>
        /// Метод выбора модуля ввода/вывода
        /// </summary>
        /// <param name="nameDevice"> Порядковый номер дмодуля в массиве с названиями модуля deviceName</param>
        /// <param name="port"> Ком порт, открытый и настроенный </param>
        /// <returns>Класс для работы с модулем ввода/вывода</returns>
        public static  ModulIO getDevice(int nameDevice, SerialPort port) {
            switch (nameDevice) { 
                case 0:
                    return new PR200vPrime20(port);
                case 1:
                    return new PR200v6(port);

                default: return null;
            }
                     
        }
    }
}

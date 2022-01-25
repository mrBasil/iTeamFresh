using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace IOmoduls
{
    public class DeviceIO
    {
        /// <summary>
        /// Массив всех модулей ввода/вывода
        /// порядковый номер выбранного модуля в этом массиве нужно передать в метод getDevice();
        /// </summary>
        public static string[] devicesName = new string[] { "ПР200 v5" };
        

        /// <summary>
        /// Метод выбора модуля ввода/вывода
        /// </summary>
        /// <param name="nameDevice"> Порядковый номер дмодуля в массиве с названиями модуля deviceName</param>
        /// <param name="port"> Ком порт, открытый и настроенный </param>
        /// <returns></returns>
        public static  ModulIO getDevice(int nameDevice, SerialPort port) {
            switch (nameDevice) { 
                case 0:
                    return new PR200v5(port);
                    break;

                default: return null;
            }
                     
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using IOmoduls;
using Indicators;
using System.Threading;

namespace iTeamFresh
{
    internal class MainClas
    {
        public Indikator indicator { get; set; }
        public ModulIO modulIO { get; set; }
        

        /// <summary>
        /// Онсовной класс программы который дает доступ ко всем исполнительным механизмам и базе данных
        /// Здесь подгружается бизнес логика
        /// </summary>
        public MainClas() {
            /*
             * вот в этом месте будет осуществляться комплектация программы
             * здест должен быть код который будет подгружать все нужные классы согласно лицензии            
             */
            //SetIndicator();

            //SetIOmodul();
            
        }   
        /// <summary>
        /// Метод для выбора индикаторы для работы с данным проектом
        /// </summary>
        public void SetIndicator()
        {
            /* Вот в этом месте нужно дернуть инфу из конфига, настроить ком порт и вызвать нужный протокол */

            SerialPort sp = new SerialPort("COM3", 9600);
            sp.Open();

            indicator =  Protoсol.GetIndicator((int)Protoсol.Protocols.TenzoM643, sp);
            
            

            
        }
        public void SetIOmodul() {
            SerialPort sp = new SerialPort("COM3", 9600);
            sp.Open();

            modulIO = DeviceIO.getDevice(0, sp);

        }   
    }
}

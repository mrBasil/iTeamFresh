using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

using Indicators;

namespace iTeamFresh
{
    internal class MainClas
    {
        public Indikator indicator { get; set; }

        /// <summary>
        /// Онсовной класс программы который дает доступ ко всем исполнительным механизмам и базе данных
        /// </summary>
        public MainClas() {
            /*
             * вот в этом месте будет осуществляться комплектация программы
             * здест должен быть код который будет подгружать все нужные классы согласно лицензии            
             */
            
        }   

        
        public void setIndicator()
        {
            /* Вот в этом месте нужно дернуть инфу из конфига, настроить ком порт и вызвать нужный протокол */

            SerialPort sp = new SerialPort("COM4", 9600);
            sp.Open();

            Protoсol prot = new Protoсol(sp);

            indicator = prot.GetIndicator((int)Protoсol.Protocols.Keli);

            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using IOmoduls;
using Indicators;
using System.Threading;
using System.Windows.Forms;


namespace iTeamFresh
{
    internal class MainClas
    {
        public Indikator indicator { get; set; }
        public ModulIO modulIO { get; set; }
        public DataBase.WeighingRepository wr { get; }

        /// <summary>
        /// Укороченная запись для получения конфигураций
        /// </summary>
        private Properties.Settings set = Properties.Settings.Default;        

        /// <summary>
        /// Онсовной класс программы который дает доступ ко всем исполнительным механизмам и базе данных
        /// Здесь подгружается бизнес логика
        /// </summary>
        public MainClas() 
        {
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
            try
            {
                SerialPort sp = new SerialPort(set.indicator_com, set.indicator_buadeRate);
                sp.Open();
                indicator = Protoсol.GetIndicator(set.indicator_protoсol, sp);
                indicator.IntervalStab = (set.indicator_time_stab) * 1000;
            }
            catch
            {
                MessageBox.Show("Беда с портом индикатора");            
            }           
            
        }

        /// <summary>
        /// Метод выбора модуля вворда/вывода
        /// </summary>
        public void SetIOmodul() {            
            try
            {
                SerialPort sp = new SerialPort(set.IO_com, set.IO_budeRate);
                sp.Open();
                modulIO = DeviceIO.getDevice(set.IO_protoсol, sp);
                Console.WriteLine(modulIO.GetType() + " ");
            }
            catch
            {
                MessageBox.Show("Беда с портом модуля ввода/вывода");
            }            
        }   
    }
}

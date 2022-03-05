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
using FirebirdSql.Data.FirebirdClient;
using Languages;
using DataBase;

namespace iTeamFresh
{
    internal class MainClas
    {
        public event LangugeChange changeLanguage;
        //Database = @"C:\Users\user\Desktop\for\tf_db.fdb",
        /// <summary>
        /// Строка подключения к базе данных
        /// </summary>
        private FbConnectionStringBuilder con = new FbConnectionStringBuilder()
        {
            DataSource = "localhost",
            UserID = "SYSDBA",
            Password = "masterkey",
            Port = 3050,
            Database = Environment.CurrentDirectory + @"\tf_db.fdb",
            Charset = "win1251",
            Pooling = false          

        };
        public Indikator indicator { get; set; }
        public ModulIO modulIO { get; set; }
        public WeighingRepository wr { get; }
        /// <summary>
        /// Язык приложения
        /// </summary>
        public Language language { get; set; }

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
            wr = new WeighingRepository(con.ConnectionString);
            SetIndicator();

            //SetIOmodul();

            SetLanguage();
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
        public void SetIOmodul()
        {
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

        /// <summary>
        /// Установка языка приложения
        /// </summary>
        public void SetLanguage()
        {
            // Вот тут нужно определить со сменой языков
            if (changeLanguage != null)
                changeLanguage();
            language = new Russian();
        }


        //*****************-------- DataBase ----------*********************

        public CargoRepository GetCargoRepository() {

            return new CargoRepository(con.ConnectionString);
        }

        public WeighingRepository GetWeighingRepository() {
            return new WeighingRepository(con.ConnectionString);
        }

        public ClientRepository GetClientRepository() {
            return new ClientRepository(con.ConnectionString);
        }
    }
}

using Indicators;

namespace IOmoduls.Algorithms
{
    public delegate void TransportPosition();
    /// <summary>
    /// Абстрактный класс для всех алгоритмов урпавления системой
    /// </summary>
    public abstract class Algorithm
    {
        /// <summary>
        /// Общий класс для всех алгоритмов
        /// </summary>
        /// <param name="indikator">Настроенный и подключенный индикатор</param>
        /// <param name="modulIO">Настроенный и подключеный модуль ввода/вывода</param>
        public Algorithm(Indikator indikator, ModulIO modulIO) { 
            this.indikator = indikator; 
            this.modulVV = modulIO;
        }

        /// <summary>
        /// Событие начала заезда машины на весы
        /// </summary>
        public abstract event TransportPosition TransportBeforScales;
        /// <summary>
        /// Событие готовности машины для взвешивания
        /// </summary>
        public abstract event TransportPosition TransportOnScales;
        /// <summary>
        /// Событие окончания взвешивания
        /// </summary>
        public abstract event TransportPosition TransoprtAfterScales;
        /// <summary>
        /// Модуль управления исполнительными механизмами
        /// </summary>
        protected readonly ModulIO modulVV;
        /// <summary>
        /// Индикатор весовой
        /// </summary>
        protected readonly Indikator indikator;
        /// <summary>
        /// Флаг работы в автоматическом режиме
        /// </summary>        
        public bool flagAutoRegime { get; set; }
        /// <summary>
        /// Порого веса, при котором считать что  автомобиль заехал на весы
        /// </summary>
        public int WeightThreshold { get; set; } = 200;
        /// <summary>
        /// Флаг разрешения на съезд с весов
        /// </summary>
        public bool FlagWaitingForPermissionToLeave { get; set; }



    }
}

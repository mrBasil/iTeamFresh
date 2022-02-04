using System.IO.Ports;
using Indicators;

namespace Indicators.Scoreboards
{
    /// <summary>
    /// Абстрактный класс табло для всех табло
    /// </summary>
    public abstract class Scoreboard
    {
        protected SerialPort port;
        protected Indikator indikator;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="port"> Открытый и настроенный ком порт</param>
        /// <param name="indikator">Индикатор который передает вес</param>
        public Scoreboard(SerialPort port, Indikator indikator ) { 
            this.port = port;
            this.indikator = indikator;
        }
        /// <summary>
        /// Интервал отправки данных на табло в мили секундах. 
        /// По умолчанию 200мс то есть 5 раз в секунду.
        /// </summary>
        public int TimeTransmit { get; set; } = 200;

        

    }
}

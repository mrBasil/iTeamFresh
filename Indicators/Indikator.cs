using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Indicators
{
    /// <summary>
    /// Общий класс для всех индикаторов
    /// </summary>
    public abstract class Indikator
    {     
        /// <summary>
        /// Интервал времени на установление стабильности в милли секундах 
        /// </summary>
        public abstract int IntervalStab { get; set; }

        public abstract SerialPort ComPort { get; set; }

        /// <summary>
        /// Вес в int
        /// </summary>
        public abstract int Weight { get; set; }
        /// <summary>
        /// Количество знаков после запятой
        /// </summary>
        public abstract int CharactersAfterDot { get; set; }
        /// <summary>
        /// Флаг стабильности
        /// </summary>
        public abstract bool Stab { get;  set; }

        /// <summary>
        /// Метод обнуления веса на терминале, работает только в случаее если протокол запрос/ответный
        /// </summary>
        public abstract void SetZero();
    }
}

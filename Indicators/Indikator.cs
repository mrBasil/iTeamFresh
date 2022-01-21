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

        public abstract SerialPort ComPort { get; set; }

        /// <summary>
        /// Свойство Вес в int
        /// </summary>
        public abstract int Weight { get; set; }
        public abstract int CharactersAfterDot { get; set; }

        public abstract bool Stab { get;  set; }

        public abstract void SetZero();
    }
}

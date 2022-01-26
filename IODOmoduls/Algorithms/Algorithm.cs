using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOmoduls.Algorithms
{
    /// <summary>
    /// Абстрактный класс для всех алгоритмов урпавления системой
    /// </summary>
    public abstract class Algorithm
    {
        /// <summary>
        /// Модуль управления исполнительными механизмами
        /// </summary>
        public ModulIO ModulVV { get; set; }
        /// <summary>
        /// Флаг работы в автоматическом режиме
        /// </summary>
        public bool flagAutoRegime { get; set; }
        /// <summary>
        /// Порого веса, при котором считать что  автомобиль заехал на весы
        /// </summary>
        public int WeightThreshold { get; set; } = 200;



    }
}

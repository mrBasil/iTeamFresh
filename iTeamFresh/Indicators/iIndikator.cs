using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTeamFresh.Indicators
{
    internal interface iIndikator
    {
        /// <summary>
        /// Вес с прибора без учета позиции запятой
        /// </summary>
        int Weight { get; set; }

        /// <summary>
        /// Индикация стабилизации
        /// </summary>
        bool Stabilization { get; set; }

        /// <summary>
        /// Обнуление 
        /// </summary>
        void SetToZero();
         

    }
}

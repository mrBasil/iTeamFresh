using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTeamFresh.Scoreboards
{
    internal interface iScoreboard
    {
        /// <summary>
        /// Вес без учета позиции запятой
        /// </summary>
        int Weight { get; set; }

        /// <summary>
        /// Колличество знаков после запятой
        /// </summary>
        int PlaceDot { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTeamFresh.DevicesIO
{
    internal interface iGeneralIO
    {
        

        /// <summary>
        /// Состояние светофора внешнего красного
        /// </summary>
        bool RedOut { get; set; }
        /// <summary>
        /// Состояние светофора внутреннего красного
        /// </summary>
        bool RedIn { get; set; }
        /// <summary>
        /// Состояние светофора внешнего зеленого
        /// </summary>
        bool GreenOut { get; set; }
        /// <summary>
        /// Состояние светофора внутреннего зеленого
        /// </summary>
        bool GreenInt { get; set; }

        /// <summary>
        /// Состояние левого шлакбаума 1 поднят, 0 опущен
        /// </summary>
        bool LeftBarrier { get; set; }

        /// <summary>
        /// Состояние левого шлакбаума 1 поднят, 0 опущен
        /// </summary>
        bool RightBarrier { get; set; }



        /// <summary>
        /// Состояние левого датчика положения 1 пересечен, 0 не пересечен
        /// </summary>
        bool SensorLeft { get;  set; }

        /// <summary>
        /// Состояние правого датчика положения 1 пересечен, 0 не пересечен
        /// </summary>
        bool SensorRight { get;  set; }
    }
}

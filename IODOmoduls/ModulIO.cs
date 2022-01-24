using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODOmoduls
{
    
    public abstract class ModulIO
    {
        protected bool redOut;
        protected bool redIn;
        protected bool greenOut;
        protected bool greenIn;
        protected bool leftBarrier;
        protected bool rightBarrier;
        protected bool sensorLeft;
        protected bool sensorRight;

        /// <summary>
        /// Состояние светофора красный внешний
        /// </summary>
        public abstract bool RedOut { get; set; }
        /// <summary>
        /// Состояние светофора красный внутренний
        /// </summary>
        public abstract bool RedIn { get; set; }
        /// <summary>
        /// Состояние светофора зеленый внешний
        /// </summary>
        public abstract bool GreenOut
        {
            get;
            set;
        }
        /// <summary>
        /// Состояние светофора зеленый внутренний
        /// </summary>
        public abstract bool GreenIn
        {
            get;
            set;
        }
        /// <summary>
        /// Состояние шлакбаума с лева
        /// </summary>
        public abstract bool LeftBarrier
        {
            get;
            set;
        }
        /// <summary>
        /// Состояние шлакбаума с права
        /// </summary>
        public abstract bool RightBarrier
        {
            get;
            set;
        }
        /// <summary>
        /// Состояние датчика положени с лева
        /// </summary>
        public abstract bool SensorLeft
        {
            get;
            protected set;
        }
        /// <summary>
        /// Состояние датчика положения с права
        /// </summary>
        public abstract bool SensorRight
        {
            get;
            protected set;
        }



    }
}

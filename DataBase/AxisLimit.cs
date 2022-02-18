using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class AxisLimit
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// имя записи в справочнике
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// количество осей для записи
        /// </summary>
        public int COUNTING_AXES { get; set; }
        public int WEIGHT_AXLE_1 { get; set; }
        public int WEIGHT_AXLE_2 { get; set; }
        public int WEIGHT_AXLE_3 { get; set; }
        public int WEIGHT_AXLE_4 { get; set; }
        public int WEIGHT_AXLE_5 { get; set; }
        public int WEIGHT_AXLE_6 { get; set; }
        public int WEIGHT_AXLE_7 { get; set; }
        public int WEIGHT_AXLE_8 { get; set; }
        public int WEIGHT_AXLE_9 { get; set; }
        public int WEIGHT_AXLE_10 { get; set; }
        /// <summary>
        /// примечание к записи
        /// </summary>
        public string NOTE { get; set; }

    }
}

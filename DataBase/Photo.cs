using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Photo
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// номер камеры
        /// </summary>
        public int NUMBER_CAM{ get; set; }
        /// <summary>
        /// номер id главной таблицы
        /// </summary>
        public int ID_WEIGHING{ get; set; }
        /// <summary>
        /// номер взвешивания
        /// </summary>
        public int NUMBER_WEIGHING { get; set; }
        /// <summary>
        /// номер ТС
        /// </summary>
        public string NUMBER_TRANSPORT { get; set; }
        /// <summary>
        /// картинка
        /// </summary>
        public byte[] IMAGE { get; set; }

    }
}

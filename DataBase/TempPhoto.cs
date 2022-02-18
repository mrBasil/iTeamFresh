using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class TempPhoto
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// номер камеры
        /// </summary>
        public int NUMBER_CAM { get; set; }
        /// <summary>
        /// номер id временной таблицы
        /// </summary>
        public int ID_TEMP_WEIGHING { get; set; }
        /// <summary>
        /// изображение
        /// </summary>
        public byte[] TEMP_IMAGE { get; set; }
    }
}

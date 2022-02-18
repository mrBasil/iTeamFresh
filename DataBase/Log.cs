using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Log
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// вреям записи
        /// </summary>
        public DateTime DATE_LOGGING { get; set; }
        /// <summary>
        /// авторизированный пользователь
        /// </summary>
        public string USER { get; set; }
        /// <summary>
        /// ссылка на тип изменений
        /// </summary>
        public int LINK_OF_CHANGE { get; set; }
        /// <summary>
        /// запись изменения
        /// </summary>
        public string lOGGING { get; set; }
    }
}

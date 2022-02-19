using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class User
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// имя пользователя
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// пароль
        /// </summary>
        public string PASSWORD { get; set; }
        /// <summary>
        /// группа доступа (1 админ, 2 оператор)
        /// </summary>
        public int GROUP { get; set; }
        /// <summary>
        /// примечание к записи
        /// </summary>
        public string NOTE { get; set; }
    }
}

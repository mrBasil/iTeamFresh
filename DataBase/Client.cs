using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Client
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// название организации
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// адрес
        /// </summary>
        public string ADDRESS { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        public string INN { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        public string KPP { get; set; }
        /// <summary>
        /// ОГРН
        /// </summary>
        public string OGRN { get; set; }
        /// <summary>
        /// ЕГРЮЛ
        /// </summary>
        public string EGRUL { get; set; }
        /// <summary>
        /// примечание к записи
        /// </summary>
        public string NOTE { get; set; }
    }
}

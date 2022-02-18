using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    /// <summary>
    /// Класс представляющий таблицу Cargo
    /// </summary>
    public class Cargo
    {

        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// имя груза
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// артикул груза
        /// </summary>
        public string ARTICLE_NUMBER { get; set; }
        /// <summary>
        /// сорность %
        /// </summary>
        public float DIRT { get; set; }
        /// <summary>
        /// цена 
        /// </summary>
        public float PRICE { get; set; }
        /// <summary>
        /// отправитель - справочник клиентов
        /// </summary>
        public int CARGO_SENDER_LINK { get; set; }
        /// <summary>
        /// получатель - справочник клиентов
        /// </summary>
        public int CARGO_RECIPIENT_LINK { get; set; }
        /// <summary>
        /// перевозчик - справочник клиентов
        /// </summary>
        public int CARGO_CARRIER_LINK { get; set; }
        /// <summary>
        /// поставщик - справочник клиентов
        /// </summary>
        public int CARGO_SUPPLIER_LINK { get; set; }
        /// <summary>
        /// примечание к записи
        /// </summary>
        public string NOTE { get; set; }


    }
}

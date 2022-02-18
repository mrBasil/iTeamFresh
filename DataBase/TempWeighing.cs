using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class TempWeighing
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// время взвешивания
        /// </summary>
        public DateTime TIME_WEIGHING { get; set; }
        /// <summary>
        /// статус взвешивания (завершен / пропущен)
        /// </summary>
        public int STATUS_WEIGHING { get; set; }
        /// <summary>
        /// номер ТС
        /// </summary>
        public string NUMBER_TRANSPORT { get; set; }
        /// <summary>
        /// номер прицепа
        /// </summary>
        public string NUMBER_TRAILER { get; set; }
        /// <summary>
        /// модель
        /// </summary>
        public string MODEL_TRANSPORT { get; set; }
        /// <summary>
        /// имя водителя
        /// </summary>
        public string DRIVER { get; set; }
        /// <summary>
        /// вес взвешивания
        /// </summary>
        public int WEIGHT { get; set; }
        /// <summary>
        /// имя пользователя проводившего взвешивание
        /// </summary>
        public string USER { get; set; }
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
    }
}

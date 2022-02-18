using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Transport
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Вес тары
        /// </summary>
        public int TARRA { get; set; }
        /// <summary>
        /// Номер транспорта
        /// </summary>
        public string NUMBER_TRANSPORT { get; set; }
        /// <summary>
        /// Номер прицепа
        /// </summary>
        public string NUMBER_TRAILER { get; set; }
        /// <summary>
        /// Имя водителя
        /// </summary>
        public string DRIVER { get; set; }
        /// <summary>
        /// Модель транспорта
        /// </summary>
        public string MODEL_TRANSPORT { get; set; }
        /// <summary>
        /// ссылка на справочник груза
        /// </summary>
        public int CARGO_LINK { get; set; }
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
        /// ссылка на справочник лимитов осей
        /// </summary>
        public int AXIS_LIMITS_LINK { get; set; }
        /// <summary>
        /// количество осей
        /// </summary>
        public int COUNTING_AXES { get; set; }
        /// <summary>
        /// метка
        /// </summary>
        public string RFID { get; set; }
        /// <summary>
        /// примечание к записи
        /// </summary>
        public string NOTE { get; set; }


}
}

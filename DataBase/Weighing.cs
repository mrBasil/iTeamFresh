using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Weighing
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int? ID { get; set; }
        /// <summary>
        /// тип взвешивани (ручной / автоматический )
        /// </summary>
        public int? TYPE { get; set; }
        /// <summary>
        /// статус взвешивания ( в процессе / готов )
        /// </summary>
        public int? STATUS { get; set; }
        /// <summary>
        /// режим взвешивания ( статика / динамика) 
        /// </summary>
        public int? MODE_WEIGHING { get; set; }
        /// <summary>
        /// дата первого взвешивания
        /// </summary>
        public DateTime DATE_FIRST_WEIGHING { get; set; }
        /// <summary>
        /// дата второго взвешивания
        /// </summary>
        public DateTime DATE_SECOND_WEIGHING { get; set; }
        /// <summary>
        /// вес первого взвешивания
        /// </summary>
        public int? WEIGHT_FIRST_WEIGHING { get; set; }
        /// <summary>
        /// вес второго взвешивания
        /// </summary>
        public int? WEIGHT_SECOND_WEIGHING { get; set; }
        /// <summary>
        /// вес тарры
        /// </summary>
        public int? WEIGHT_TARRA { get; set; }
        /// <summary>
        /// вес брутто
        /// </summary>
        public int? WEIGHT_BRUTTO { get; set; }
        /// <summary>
        /// вес нетто
        /// </summary>
        public int? WEIGHT_NETTO { get; set; }
        /// <summary>
        /// сорность в %
        /// </summary>
        public float? DIRT { get; set; }
        /// <summary>
        /// цена взвешенного груза
        /// </summary>
        public float? PRICE_WEIGHTED_CARGO { get; set; }
        /// <summary>
        /// цена для расчета груза
        /// </summary>
        public float? PRICE_FOR_CARGO_CALCULATION { get; set; }
        /// <summary>
        /// номер ТС
        /// </summary>
        public string NUMBER_TRANSPORT { get; set; }
        /// <summary>
        /// номер прицепа
        /// </summary>
        public string NUMBER_TRAILER { get; set; }
        /// <summary>
        /// Модель траспорта
        /// </summary>
        public string MODEL_TRANSPORT { get; set; }
        /// <summary>
        /// Имя водителя
        /// </summary>
        public string DRIVER { get; set; }
        /// <summary>
        /// ссылка на справочник груза
        /// </summary>
        public int? CARGO_LINK { get; set; }
        /// <summary>
        /// отправитель - справочник клиентов
        /// </summary>
        public int? CARGO_SENDER_LINK { get; set; }
        /// <summary>
        /// получатель - справочник клиентов
        /// </summary>
        public int? CARGO_RECIPIENT_LINK { get; set; }
        /// <summary>
        /// перевозчик - справочник клиентов
        /// </summary>
        public int? CARGO_CARRIER_LINK { get; set; }
        /// <summary>
        /// поставщик - справочник клиентов
        /// </summary>
        public int? CARGO_SUPPLIER_LINK { get; set; }
        /// <summary>
        /// имя пользователя первого взвешивания
        /// </summary>
        public string USER_FIRST_WEIGHING { get; set; }
        /// <summary>
        /// имя пользователя второго взвешивания
        /// </summary>
        public string USER_SECOND_WEIGHING { get; set; }
        /// <summary>
        /// номер документа взвешивания
        /// </summary>
        public int? NUMBER_OF_DOCUMNET { get; set; }
        /// <summary>
        /// серия документа взвешивания
        /// </summary>
        public string SERIES_OF_DOCUMENT { get; set; }
        

    }
}

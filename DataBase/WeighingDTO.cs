using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    /// <summary>
    /// Класс для отображенияданных на главном экране
    /// </summary>
    public class WeighingDTO:Weighing
    {

        
        /// <summary>
        /// ссылка на справочник груза
        /// </summary>
        public string Cargo { get; set; }
        /// <summary>
        /// отправитель - справочник клиентов
        /// </summary>
        public string Sender{ get; set; }
        /// <summary>
        /// получатель - справочник клиентов
        /// </summary>
        public string Recipient { get; set; }
        /// <summary>
        /// перевозчик - справочник клиентов
        /// </summary>
        public string Carrier { get; set; }
        /// <summary>
        /// поставщик - справочник клиентов
        /// </summary>
        public string Suplier { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    /// <summary>
    /// Для отображения в таблице на странице журнала Грузов
    /// </summary>
    public class CargoDTO:Cargo
    {       
        /// <summary>
        /// отправитель - имя из спарвочника клиентов
        /// </summary>
        public string Sender { get; set; }
        /// <summary>
        /// получатель - имя из спарвочника клиентов
        /// </summary>
        public string Recipient { get; set; }
        /// <summary>
        /// перевозчик - имя из спарвочника клиентов
        /// </summary>
        public string Carrier { get; set; }
        /// <summary>
        /// поставщик - имя из спарвочника клиентов
        /// </summary>
        public string Suplier { get; set; }
       
    }
}

using FirebirdSql.Data.FirebirdClient;
using System.Linq;
using Dapper;
using System.Collections.Generic;

namespace DataBase
{
    /// <summary>
    /// Класс для работы с таблицей WEIGHINGS
    /// </summary>
    public class WeighingRepository
    {
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици WEIGHINGS
        /// </summary>
        /// <param name="conectionString"> Строка подключения к базе данных </param>
        public WeighingRepository(string conectionString) {
            /*
            FbConnectionStringBuilder con = new FbConnectionStringBuilder()
            {
                DataSource = "localhost",
                UserID = "SYSDBA",
                Password = "masterkey",
                Port = 3050,
                Database = @"C:\Users\user\Desktop\for\tf_db.fdb",
                Charset = "win1251",
                Pooling = false

            };
            */
            this.conectionString = conectionString;
            //this.conectionString = con.ConnectionString;

           
        }
        /// <summary>
        /// Получение взвешивания по id
        /// </summary>
        /// <param name="id"> порядковый номер взвешивания в таблице Weighings</param>
        /// <returns>Возвращает смапленный класс Weighing </returns>
        public Weighing GetWeighing(int id) {

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Weighing>("SELECT * FROM Weighings WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици WEIGHINGS в виде списка классов Weighing
        /// </summary>
        /// <returns>Список List классов Weighing </returns>
        public List<Weighing> GetWeighing() {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Weighing>("SELECT * FROM Weighings ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу WEIGHINGS
        /// </summary>
        /// <param name="weighing">Класс Weighing </param>
        public void InsertWeighing(Weighing weighing) {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO WEIGHINGS (
                                       TYPE,
                                       STATUS,
                                       MODE_WEIGHING,  
                                       DATE_FIRST_WEIGHING,
                                       DATE_SECOND_WEIGHING,
                                       WEIGHT_FIRST_WEIGHING,
                                       WEIGHT_SECOND_WEIGHING,
                                       WEIGHT_TARRA,
                                       WEIGHT_BRUTTO,
                                       WEIGHT_NETTO,
                                       DIRT,
                                       PRICE_WEIGHTED_CARGO,
                                       PRICE_FOR_CARGO_CALCULATION,
                                       NUMBER_TRANSPORT,
                                       NUMBER_TRAILER,
                                       MODEL_TRANSPORT,
                                       DRIVER,
                                       CARGO_LINK,
                                       CARGO_SENDER_LINK,
                                       CARGO_RECIPIENT_LINK,
                                       CARGO_CARRIER_LINK,
                                       CARGO_SUPPLIER_LINK,
                                       USER_FIRST_WEIGHING,
                                       USER_SECOND_WEIGHING,
                                       NUMBER_OF_DOCUMNET,
                                       SERIES_OF_DOCUMENT)
                                       VALUES (
                                                @TYPE,
                                                @STATUS,
                                                @MODE_WEIGHING,
                                                @DATE_FIRST_WEIGHING,
                                                @DATE_SECOND_WEIGHING,
                                                @WEIGHT_FIRST_WEIGHING,
                                                @WEIGHT_SECOND_WEIGHING,
                                                @WEIGHT_TARRA,@WEIGHT_BRUTTO,
                                                @WEIGHT_NETTO,@DIRT,
                                                @PRICE_WEIGHTED_CARGO,
                                                @PRICE_FOR_CARGO_CALCULATION,
                                                @NUMBER_TRANSPORT,
                                                @NUMBER_TRAILER,
                                                @MODEL_TRANSPORT,
                                                @DRIVER,
                                                @CARGO_LINK,
                                                @CARGO_SENDER_LINK,
                                                @CARGO_RECIPIENT_LINK,
                                                @CARGO_CARRIER_LINK,                                               
                                                @CARGO_SUPPLIER_LINK,
                                                @USER_FIRST_WEIGHING,
                                                @USER_SECOND_WEIGHING,
                                                @NUMBER_OF_DOCUMNET,
                                                @SERIES_OF_DOCUMENT)";

                db.Execute(insertQuery, weighing);
                
            };

        }
        /// <summary>
        /// Удаление строки из базы WEIGHINGS
        /// </summary>
        /// <param name="id"> Номер ID </param>
        public void DeleteWeighing(int id) {
            using (FbConnection db = new FbConnection(conectionString))
            {
                 db.Execute("DELETE FROM WEIGHINGS WHERE ID = @ID", new { ID = id });
            };
        }
        /// <summary>
        /// Обновдение в таблице WEIGHINGS
        /// </summary>
        /// <param name="weighing">Экземпляр класса Weighing</param>
        public void UpdateWeighing(Weighing weighing) {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"UPDATE WEIGHINGS SET 
                                       TYPE = @TYPE ,
                                       STATUS = @STATUS,
                                       MODE_WEIGHING = @MODE_WEIGHING,  
                                       DATE_FIRST_WEIGHING = @DATE_FIRST_WEIGHING,
                                       DATE_SECOND_WEIGHING = @DATE_SECOND_WEIGHING,
                                       WEIGHT_FIRST_WEIGHING = @WEIGHT_FIRST_WEIGHING,
                                       WEIGHT_SECOND_WEIGHING = @WEIGHT_SECOND_WEIGHING,
                                       WEIGHT_TARRA = @WEIGHT_TARRA,
                                       WEIGHT_BRUTTO = @WEIGHT_BRUTTO,
                                       WEIGHT_NETTO = @WEIGHT_NETTO,
                                       DIRT = @DIRT,
                                       PRICE_WEIGHTED_CARGO = @PRICE_WEIGHTED_CARGO,
                                       PRICE_FOR_CARGO_CALCULATION = @PRICE_FOR_CARGO_CALCULATION,
                                       NUMBER_TRANSPORT = @NUMBER_TRANSPORT,
                                       NUMBER_TRAILER = @NUMBER_TRAILER,
                                       MODEL_TRANSPORT = @MODEL_TRANSPORT,
                                       DRIVER = @DRIVER,
                                       CARGO_LINK = @CARGO_LINK,
                                       CARGO_SENDER_LINK = @CARGO_SENDER_LINK,
                                       CARGO_RECIPIENT_LINK = @CARGO_RECIPIENT_LINK,
                                       CARGO_CARRIER_LINK = @CARGO_CARRIER_LINK,
                                       CARGO_SUPPLIER_LINK = @CARGO_SUPPLIER_LINK,
                                       USER_FIRST_WEIGHING = @USER_FIRST_WEIGHING,
                                       USER_SECOND_WEIGHING = @USER_SECOND_WEIGHING,
                                       NUMBER_OF_DOCUMNET = @NUMBER_OF_DOCUMNET,
                                       SERIES_OF_DOCUMENT = @SERIES_OF_DOCUMENT 
                                       WHERE ID = @ID";


                db.Execute(insertQuery, weighing);
            }

        }
    }
}

using FirebirdSql.Data.FirebirdClient;
using System.Linq;
using Dapper;
using System.Collections.Generic;
using System;

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





        //********************************* Получение  из таблици ****************

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
        /// Возвращает список взвешиваний между датами
        /// </summary>
        /// <param name="firstWeighing">Дата начала запроса</param>
        /// <param name="secondWeighing">Дата конца запроса</param>
        /// <returns></returns>
        public List<Weighing> GetWeighing(DateTime firstWeighing, DateTime secondWeighing) {
            string date1 = firstWeighing.ToString();
            string date2 = secondWeighing.ToString();

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Weighing>("SELECT * FROM Weighings WHERE DATE_FIRST_WEIGHING >= @date1 AND DATE_SECOND_WEIGHING <= @date2", new { date1, date2 }).ToList();
            };

        }
        /// <summary>
        /// Возвращает список WeighingDTO для отображения на главной странице
        /// </summary>
        /// <param name="firstWeighing"></param>
        /// <param name="secondWeighing"></param>
        /// <returns></returns>
        public List<WeighingDTO> GetWeighingDTO(DateTime firstWeighing, DateTime secondWeighing) {
            string date1 = firstWeighing.ToString();
            string date2 = secondWeighing.ToString();

            string insertQuery = @"SELECT
                                       w.TYPE,
                                       w.ID,
                                       w.STATUS,
                                       w.MODE_WEIGHING,  
                                       w.DATE_FIRST_WEIGHING,
                                       w.DATE_SECOND_WEIGHING,
                                       w.WEIGHT_FIRST_WEIGHING,
                                       w.WEIGHT_SECOND_WEIGHING,
                                       w.WEIGHT_TARRA,
                                       w.WEIGHT_BRUTTO,
                                       w.WEIGHT_NETTO,
                                       w.DIRT,
                                       w.PRICE_WEIGHTED_CARGO,
                                       w.PRICE_FOR_CARGO_CALCULATION,
                                       w.NUMBER_TRANSPORT,
                                       w.NUMBER_TRAILER,
                                       w.MODEL_TRANSPORT,
                                       w.DRIVER,                                       
                                       w.USER_FIRST_WEIGHING,
                                       w.USER_SECOND_WEIGHING,
                                       w.NUMBER_OF_DOCUMNET,
                                       w.SERIES_OF_DOCUMENT,
                                       c.NAME AS Cargo,
                                       cl1.Name AS Sender,
                                       cl2.Name AS Recipient,
                                       cl3.NAME AS Carrier,
                                       cl4.NAME AS Suplier
                                    FROM Weighings w 
                                        INNER JOIN CARGO c ON c.ID = w.CARGO_LINK 
                                        INNER JOIN CLIENTS cl1 ON cl1.ID = w.CARGO_SENDER_LINK
                                        INNER JOIN CLIENTS cl2 ON cl2.ID = w.CARGO_RECIPIENT_LINK
                                        INNER JOIN CLIENTS cl3 ON cl3.ID = w.CARGO_CARRIER_LINK
                                        INNER JOIN CLIENTS cl4 ON cl4.ID = w.CARGO_SUPPLIER_LINK                                    
                                    WHERE DATE_FIRST_WEIGHING >= @date1 AND DATE_SECOND_WEIGHING <= @date2";

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<WeighingDTO>(insertQuery, new { date1, date2 }).ToList();
            };
        }




        //********************************* Вставка в таблицу ****************


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

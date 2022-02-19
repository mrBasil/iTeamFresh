using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace DataBase
{
    /// <summary>
    /// КЛасс для работы с таблицей TEMP_WEIGHINGS
    /// </summary>
    public class TempWeighingRepository
    {
        /// <summary>
        /// Строрка подключения к базе данных
        /// </summary>
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици TEMP_WEIGHINGS
        /// </summary>
        /// <param name="conectionString"></param>
        public TempWeighingRepository(string conectionString)
        {

            this.conectionString = conectionString;

        }
        /// <summary>
        /// Метод для получения строки из таблици TEMP_PHOTOS по ID
        /// </summary>
        /// <param name="id"> int номер в таблице TEMP_PHOTOS </param>
        /// <returns>экземпляр класса TempPhoto</returns>
        public TempWeighing GetTempWeighing(int id)
        {

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<TempWeighing>("SELECT * FROM TEMP_WEIGHINGS WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици TEMP_WEIGHINGS в виде списка классов TempWeighing
        /// </summary>
        /// <returns>Список List классов TempWeighing </returns>
        public List<TempWeighing> GetTempWeighing()
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<TempWeighing>("SELECT * FROM TEMP_WEIGHINGS ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу TEMP_WEIGHINGS
        /// </summary>
        /// <param name="temWeighing">Класс экземпляр класса TempWeighing</param>
        public void InsertTempWeighing(TempWeighing tempWeighing)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO TEMP_WEIGHINGS (                                       
                                        TIME_WEIGHING,
                                        STATUS_WEIGHING,
                                        NUMBER_TRANSPORT,
                                        NUMBER_TRAILER,
                                        MODEL_TRANSPORT,
                                        DRIVER,
                                        WEIGHT,
                                        USER,
                                        CARGO_SENDER_LINK,
                                        CARGO_RECIPIENT_LINK,
                                        CARGO_CARRIER_LINK,
                                        CARGO_SUPPLIER_LINK)
                                       VALUES (
                                                @TIME_WEIGHING,
                                                @STATUS_WEIGHING,
                                                @NUMBER_TRANSPORT,
                                                @NUMBER_TRAILER,
                                                @MODEL_TRANSPORT,
                                                @DRIVER,
                                                @WEIGHT,
                                                @USER,
                                                @CARGO_SENDER_LINK,
                                                @CARGO_RECIPIENT_LINK,
                                                @CARGO_CARRIER_LINK,
                                                @CARGO_SUPPLIER_LINK)";

                db.Execute(insertQuery, tempWeighing);

            };

        }
        /// <summary>
        /// Удаление строки из таблицы TEMP_WEIGHINGS
        /// </summary>
        /// <param name="id">Идентификатор в таблице TEMP_WEIGHINGS</param>
        public void DeleteTempWeighing(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM TEMP_WEIGHINGS WHERE ID = @ID", new { ID = id });
            };
        }

        /// <summary>
        /// Обновдение в таблице TEMP_WEIGHINGS
        /// </summary>
        /// <param name="tempWeighing"> Класс TempWeighing</param>
        public void UpdateTempWeighint(TempWeighing tempWeighing)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"UPDATE TEMP_WEIGHINGS SET 
                                        TIME_WEIGHING = @TIME_WEIGHING,
                                        STATUS_WEIGHING = @STATUS_WEIGHING,
                                        NUMBER_TRANSPORT = @NUMBER_TRANSPORT,
                                        NUMBER_TRAILER = @NUMBER_TRAILER,
                                        MODEL_TRANSPORT = @MODEL_TRANSPORT,
                                        DRIVER = @DRIVER,
                                        WEIGHT = @WEIGHT,
                                        USER = @USER,
                                        CARGO_SENDER_LINK = @CARGO_SENDER_LINK,
                                        CARGO_RECIPIENT_LINK = @CARGO_RECIPIENT_LINK,
                                        CARGO_CARRIER_LINK = @CARGO_CARRIER_LINK,
                                        CARGO_SUPPLIER_LINK = @CARGO_SUPPLIER_LINK
                                        WHERE ID = @ID";

                db.Execute(insertQuery, tempWeighing);
            }

        }
    }
}

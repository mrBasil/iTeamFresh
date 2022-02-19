using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace DataBase
{
    public class TransportRepository
    {
        /// <summary>
        /// Строрка подключения к базе данных
        /// </summary>
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици TRANSPORTS
        /// </summary>
        /// <param name="conectionString"></param>
        public TransportRepository(string conectionString)
        {

            this.conectionString = conectionString;

        }
        /// <summary>
        /// Метод для получения строки из таблици TRANSPORTS по ID
        /// </summary>
        /// <param name="id"> int номер в таблице TRANSPORTS </param>
        /// <returns>экземпляр класса Transport</returns>
        public Transport GetTransport(int id)
        {

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Transport>("SELECT * FROM TRANSPORTS WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици TRANSPORTS в виде списка классов Transport
        /// </summary>
        /// <returns>Список List классов Transport </returns>
        public List<Transport> GetTransport()
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Transport>("SELECT * FROM TRANSPORTS ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу TRANSPORTS
        /// </summary>
        /// <param name="transport">Класс экземпляр класса Transport</param>
        public void InsertTransport(Transport transport)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO TRANSPORTS (                                       
                                        TARRA,
                                        NUMBER_TRANSPORT,
                                        NUMBER_TRAILER,
                                        DRIVER,
                                        MODEL_TRANSPORT,
                                        CARGO_LINK,
                                        CARGO_SENDER_LINK,
                                        CARGO_RECIPIENT_LINK,
                                        CARGO_CARRIER_LINK,
                                        CARGO_SUPPLIER_LINK,
                                        AXIS _LIMITS_LINK,
                                        COUNTING_AXES,
                                        RFID,
                                        NOTE)
                                       VALUES (
                                                @TARRA,
                                                @NUMBER_TRANSPORT,
                                                @NUMBER_TRAILER,
                                                @DRIVER,
                                                @MODEL_TRANSPORT,
                                                @CARGO_LINK,
                                                @CARGO_SENDER_LINK,
                                                @CARGO_RECIPIENT_LINK,
                                                @CARGO_CARRIER_LINK,
                                                @CARGO_SUPPLIER_LINK,
                                                @AXIS _LIMITS_LINK,
                                                @COUNTING_AXES,
                                                @RFID,
                                                @NOTE)";

                db.Execute(insertQuery, transport);

            };

        }
        /// <summary>
        /// Удаление строки из таблицы TRANSPORTS
        /// </summary>
        /// <param name="id">Идентификатор в таблице TRANSPORTS</param>
        public void DeleteTransport(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM TRANSPORTS WHERE ID = @ID", new { ID = id });
            };
        }
    }
}

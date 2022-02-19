using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace DataBase
{
    public class LogRepository
    {
        /// <summary>
        /// Строрка подключения к базе данных
        /// </summary>
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици Log
        /// </summary>
        /// <param name="conectionString"> Строка подключения к базе данных </param>
        public LogRepository(string conectionString) {
            this.conectionString = conectionString;
        }
        /// <summary>
        /// Метод для получения строки из таблици Log по ID
        /// </summary>
        /// <param name="id"> int номер в таблице Log</param>
        /// <returns></returns>
        public Log GetLog(int id)
        {

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Log>("SELECT * FROM LOG WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици Log в виде списка классов Log
        /// </summary>
        /// <returns>Список List классов Log </returns>
        public List<Log> GetLog()
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Log>("SELECT * FROM LOG ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу Log
        /// </summary>
        /// <param name="log">Класс Log</param>
        public void InsertLog(Log log)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO LOG (                                       
                                        DATE_LOGGING,
                                        USER,
                                        LINK_OF_CHANGE,
                                        lOGGING)
                                       VALUES (
                                                @DATE_LOGGING,
                                                @USER,
                                                @LINK_OF_CHANGE,
                                                @lOGGING)";

                db.Execute(insertQuery, log);

            };

        }
        /// <summary>
        /// Удаление строки из таблицы Log
        /// </summary>
        /// <param name="id">Идентификаторв таблице Log</param>
        public void DeleteLog(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM LOG WHERE ID = @ID", new { ID = id });
            };
        }
    }
}  

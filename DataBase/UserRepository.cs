using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace DataBase
{
    public class UserRepository
    {
        /// <summary>
        /// Строрка подключения к базе данных
        /// </summary>
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици USERS
        /// </summary>
        /// <param name="conectionString"></param>
        public UserRepository(string conectionString)
        {
            this.conectionString = conectionString;
        }
        /// <summary>
        /// Метод для получения строки из таблици USERS по ID
        /// </summary>
        /// <param name="id"> int номер в таблице USERS </param>
        /// <returns>экземпляр класса User</returns>
        public User GetUser(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<User>("SELECT * FROM USERS WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици USERS в виде списка классов User
        /// </summary>
        /// <returns>Список List классов User </returns>
        public List<User> GetUser()
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<User>("SELECT * FROM USERS ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу USERS
        /// </summary>
        /// <param name="user">Экземпляр класса User</param>
        public void InsertUser(User user)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO USERS (                                       
                                        NAME,
                                        PASSWORD,
                                        GROUP,
                                        NOTE)
                                       VALUES (
                                        @NAME,
                                        @PASSWORD,
                                        @GROUP,
                                        @NOTE
                                                )";

                db.Execute(insertQuery, user);

            };

        }
        /// <summary>
        /// Удаление строки из таблицы USERS
        /// </summary>
        /// <param name="id">Идентификатор в таблице USERS</param>
        public void DeleteUser(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM USERS WHERE ID = @ID", new { ID = id });
            };
        }
    }
}

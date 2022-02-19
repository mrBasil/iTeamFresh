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
    /// Класс для работы с таблицей CLIENTS
    /// </summary>
    public class ClientRepository
    {
        /// <summary>
        /// Строрка подключения к базе данных
        /// </summary>
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици CLIENTS
        /// </summary>
        /// <param name="conectionString"> Строка подключения к базе данных </param>
        public ClientRepository(string conectionString)
        {
           
            this.conectionString = conectionString;
            
        }
        /// <summary>
        /// Метод для получения строки из таблици CLIENTS по ID
        /// </summary>
        /// <param name="id"> int номер в таблице Client</param>
        /// <returns></returns>
        public Client GetClient(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Client>("SELECT * FROM CLIENTS WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици CLIENTS в виде списка классов Client
        /// </summary>
        /// <returns>Список List классов Client </returns>
        public List<Client> GetClient()
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Client>("SELECT * FROM CLIENTS ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу Clients
        /// </summary>
        /// <param name="client">Класс Client</param>
        public void InsertClient(Client client)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO CLIENTS (                                       
                                        NAME,
                                        ADDRESS,
                                        INN,
                                        KPP,
                                        OGRN,
                                        EGRUL,
                                        NOTE)
                                       VALUES (
                                                @NAME,
                                                @ADDRESS,
                                                @INN,
                                                @KPP,
                                                @OGRN,
                                                @EGRUL,
                                                @NOTE)";

                db.Execute(insertQuery, client);

            };

        }
        /// <summary>
        /// Удаление строки из таблицы CLIENTS
        /// </summary>
        /// <param name="id">Идентификатор в таблице CLIENTS</param>
        public void DeleteClient(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM CLIENTS WHERE ID = @ID", new { ID = id });
            };
        }
        /// <summary>
        /// Обновдение в таблице CLIENTS
        /// </summary>
        /// <param name="client"> Класс Client</param>
        public void UpdateClient(Client client)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"UPDATE CLIENTS SET 
                                        NAME = @NAME,
                                        ADDRESS = @ADDRESS,
                                        INN = @INN,
                                        KPP = @KPP,
                                        OGRN = @OGRN,
                                        EGRUL = @EGRUL,
                                        NOTE = @NOTE
                                        WHERE ID = @ID";

                db.Execute(insertQuery,client);
            }

        }
    }
}

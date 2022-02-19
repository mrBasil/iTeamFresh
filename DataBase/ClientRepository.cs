using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace DataBase
{
    public class ClientRepository
    {
        /// <summary>
        /// Строрка подключения к базе данных
        /// </summary>
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици Clients
        /// </summary>
        /// <param name="conectionString"> Строка подключения к базе данных </param>
        public ClientRepository(string conectionString)
        {
           
            this.conectionString = conectionString;
            
        }
        /// <summary>
        /// Метод для получения строки из таблици Clients по ID
        /// </summary>
        /// <param name="id"> int номер в таблице Cargo</param>
        /// <returns></returns>
        public Cargo GetClient(int id)
        {

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Cargo>("SELECT * FROM CLIENTS WHERE Id = @id", new { id }).FirstOrDefault();
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
        /// Удаление строки из таблицы Clients
        /// </summary>
        /// <param name="id">Идентификатор в таблице Clients</param>
        public void DeleteClient(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM CLIENTS WHERE ID = @ID", new { ID = id });
            };
        }
    }
}

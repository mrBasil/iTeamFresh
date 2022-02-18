using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataBase
{
    /// <summary>
    /// Класс для работы с таблицей Cargo
    /// </summary>
    public class CargoRepository
    {
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици Cargo
        /// </summary>
        /// <param name="conectionString"> Строка подключения к базе данных </param>
        public CargoRepository(string conectionString)
        {

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
            //this.conectionString = conectionString;
            this.conectionString = con.ConnectionString;
        }
        /// <summary>
        /// Метод для получения строки из таблици Cargo по ID
        /// </summary>
        /// <param name="id"> int номер в таблице Cargo</param>
        /// <returns></returns>
        public Cargo GetCargo(int id)
        {

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Cargo>("SELECT * FROM CARGO WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици Cargo в виде списка классов Cargo
        /// </summary>
        /// <returns>Список List классов Cargo </returns>
        public List<Cargo> GetCargo()
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Cargo>("SELECT * FROM CARGO ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу Cargo
        /// </summary>
        /// <param name="cargo">Класс Cargo</param>
        public void InsertCargo(Cargo cargo)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO CARGO (                                       
                                        NAME,
                                        ARTICLE_NUMBER,
                                        DIRT,
                                        PRICE,
                                        CARGO_SENDER_LINK,
                                        CARGO_RECIPIENT_LINK,
                                        CARGO_CARRIER_LINK,
                                        CARGO_SUPPLIER_LINK,
                                        NOTE)
                                       VALUES (
                                                @NAME,
                                                @ARTICLE_NUMBER,
                                                @DIRT,
                                                @PRICE,
                                                @CARGO_SENDER_LINK,
                                                @CARGO_RECIPIENT_LINK,
                                                @CARGO_CARRIER_LINK,
                                                @CARGO_SUPPLIER_LINK,
                                                @NOTE)";

                db.Execute(insertQuery, cargo);

            };

        }
        /// <summary>
        /// Удаление строки из таблицы Cargo
        /// </summary>
        /// <param name="id">Идентификаторв таблице Cargo</param>
        public void DeleteCargo(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM CARGO WHERE ID = @ID", new { ID = id });
            };
        }
    }
}

﻿using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataBase
{
    /// <summary>
    /// Класс для работы с таблицей CARGO
    /// </summary>
    public class CargoRepository
    {
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици CARGO
        /// </summary>
        /// <param name="conectionString"> Строка подключения к базе данных </param>
        public CargoRepository(string conectionString)
        {           
            this.conectionString = conectionString;            
        }
        /// <summary>
        /// Метод для получения строки из таблици CARGO по ID
        /// </summary>
        /// <param name="id"> int номер в таблице CARGO</param>
        /// <returns></returns>
        public Cargo GetCargo(int id)
        {

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Cargo>("SELECT * FROM CARGO WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици CARGO в виде списка классов Cargo
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
        /// <summary>
        /// Обновдение в таблице CARGO
        /// </summary>
        /// <param name="cargo"> Класс Cargo</param>
        public void UpdateCargo(Cargo cargo)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"UPDATE CARGO SET 
                                        NAME = @NAME,
                                        ARTICLE_NUMBER = @ARTICLE_NUMBER,
                                        DIRT = @DIRT,
                                        PRICE = @PRICE,
                                        CARGO_SENDER_LINK = @CARGO_SENDER_LINK,
                                        CARGO_RECIPIENT_LINK = @CARGO_RECIPIENT_LINK,
                                        CARGO_CARRIER_LINK = @CARGO_CARRIER_LINK,
                                        CARGO_SUPPLIER_LINK = @CARGO_SUPPLIER_LINK
                                        NOTE = @NOTE
                                        WHERE ID = @ID";


                db.Execute(insertQuery, cargo);
            }

        }
    }
}
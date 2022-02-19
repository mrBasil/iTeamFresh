using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace DataBase
{
    public class PhotoRepository
    {
        /// <summary>
        /// Строрка подключения к базе данных
        /// </summary>
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици Photos
        /// </summary>
        /// <param name="conectionString"> Строка подключения к базе данных </param>
        public PhotoRepository(string conectionString)
        {
            this.conectionString = conectionString;
        }
        /// <summary>
        /// Метод для получения строки из таблици Photos по ID
        /// </summary>
        /// <param name="id"> int номер в таблице Photos</param>
        /// <returns></returns>
        public Photo GetPhoto(int id)
        {            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Photo>("SELECT * FROM PHOTOS WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици Photos в виде списка классов Photo
        /// </summary>
        /// <returns>Список List классов Photo </returns>
        public List<Photo> GetPhoto()
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<Photo>("SELECT * FROM PHOTOS ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу PHOTOS
        /// </summary>
        /// <param name="cargo">Класс Photo</param>
        public void InsertPhoto(Photo photo)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO PHOTOS (                                       
                                        NUMBER_CAM,
                                        ID_WEIGHING,
                                        NUMBER_WEIGHING,
                                        NUMBER_TRANSPORT,
                                        IMAGE)
                                       VALUES (
                                                @NUMBER_CAM,
                                                @ID_WEIGHING,
                                                @NUMBER_WEIGHING,
                                                @NUMBER_TRANSPORT,
                                                @IMAGE)";

                db.Execute(insertQuery, photo);

            };

        }
        /// <summary>
        /// Удаление строки из таблицы PHOTOS
        /// </summary>
        /// <param name="id">Идентификатор в таблице PHOTOS</param>
        public void DeletePhoto(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM PHOTOS WHERE ID = @ID", new { ID = id });
            };
        }
    }
}

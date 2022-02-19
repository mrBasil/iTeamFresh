using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace DataBase
{
    public class TempPhotoRepository
    {
        /// <summary>
        /// Строрка подключения к базе данных
        /// </summary>
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици TempPhotos
        /// </summary>
        /// <param name="conectionString"></param>
        public TempPhotoRepository(string conectionString)
        {

            this.conectionString = conectionString;

        }
        /// <summary>
        /// Метод для получения строки из таблици TEMP_PHOTOS по ID
        /// </summary>
        /// <param name="id"> int номер в таблице TEMP_PHOTOS </param>
        /// <returns>экземпляр класса TempPhoto</returns>
        public TempPhoto GetTempPhoto(int id)
        {

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<TempPhoto>("SELECT * FROM TEMP_PHOTOS WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици TEMP_PHOTOS в виде списка классов TempPhoto
        /// </summary>
        /// <returns>Список List классов TempPhoto </returns>
        public List<TempPhoto> GetTempPhoto()
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<TempPhoto>("SELECT * FROM TEMP_PHOTOS ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу TEMP_PHOTOS
        /// </summary>
        /// <param name="tempPhoto">Класс экземпляр класса TempPhoto</param>
        public void InsertTempPhoto(TempPhoto tempPhoto)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO TEMP_PHOTOS (                                       
                                        NUMBER_CAM,
                                        ID_TEMP_WEIGHING,
                                        TEMP_IMAGE)
                                       VALUES (
                                                @NUMBER_CAM,
                                                @ID_TEMP_WEIGHING,
                                                @TEMP_IMAGE)";

                db.Execute(insertQuery, tempPhoto);

            };

        }
        /// <summary>
        /// Удаление строки из таблицы TEMP_PHOTOS
        /// </summary>
        /// <param name="id">Идентификатор в таблице TEMP_PHOTOS</param>
        public void DeleteTempPhoto(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM TEMP_PHOTOS WHERE ID = @ID", new { ID = id });
            };
        }
    }
}

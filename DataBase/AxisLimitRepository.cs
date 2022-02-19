using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataBase
{
    internal class AxisLimitRepository
    {
        private string conectionString;
        /// <summary>
        /// Класс дает доступ к методам CRUD для таблици Weighing
        /// </summary>
        /// <param name="conectionString"> Строка подключения к базе данных </param>
        public AxisLimitRepository(string conectionString)
        {            
            this.conectionString = conectionString;
        }
        /// <summary>
        /// Получение строки из таблици AXIS_LIMITS по id
        /// </summary>
        /// <param name="id"> порядковый номер  в таблице AXIS_LIMITS</param>
        /// <returns>Возвращает смапленный класс AxisLimit </returns>
        public AxisLimit GetAxisLimit(int id)
        {

            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<AxisLimit>("SELECT * FROM AXIS_LIMITS WHERE Id = @id", new { id }).FirstOrDefault();
            };
        }
        /// <summary>
        /// Получение всех элементов таблици AXIS_LIMITS в виде списка классов AxisLimit
        /// </summary>
        /// <returns>Список List классов AxisLimit </returns>
        public List<AxisLimit> GetAxisLimit()
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                return db.Query<AxisLimit>("SELECT * FROM AXIS_LIMITS ").ToList();
            };
        }
        /// <summary>
        /// Вставка новой строки в таблицу AXIS_LIMITS
        /// </summary>
        /// <param name="axisLimit">Класс AxisLimit</param>
        public void InsertAxisLimit(AxisLimit axisLimit)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"INSERT INTO AXIS_LIMITS (
                                       NAME,
                                       COUNTING_AXES,
                                       WEIGHT_AXLE_1,
                                       WEIGHT_AXLE_2,
                                       WEIGHT_AXLE_3,
                                       WEIGHT_AXLE_4,
                                       WEIGHT_AXLE_5,
                                       WEIGHT_AXLE_6,
                                       WEIGHT_AXLE_7,
                                       WEIGHT_AXLE_8,
                                       WEIGHT_AXLE_9,
                                       WEIGHT_AXLE_10,
                                       NOTE)
                                       VALUES (
                                       @NAME,
                                       @COUNTING_AXES,
                                       @WEIGHT_AXLE_1,
                                       @WEIGHT_AXLE_2,
                                       @WEIGHT_AXLE_3,
                                       @WEIGHT_AXLE_4,
                                       @WEIGHT_AXLE_5,
                                       @WEIGHT_AXLE_6,
                                       @WEIGHT_AXLE_7,
                                       @WEIGHT_AXLE_8,
                                       @WEIGHT_AXLE_9,
                                       @WEIGHT_AXLE_10,
                                       @NOTE)";

                db.Execute(insertQuery, axisLimit);

            };

        }
        /// <summary>
        /// Удаление строки из базы AXIS_LIMITS
        /// </summary>
        /// <param name="id"> Номер ID </param>
        public void DeleteAxisLimit(int id)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                db.Execute("DELETE FROM AXIS_LIMITS WHERE ID = @ID", new { ID = id });
            };
        }
        /// <summary>
        /// Обновдение в таблице Axis_Limit
        /// </summary>
        /// <param name="axisLimit"> Класс AxisLimit</param>
        public void UpdateAxisLimit(AxisLimit axisLimit)
        {
            using (FbConnection db = new FbConnection(conectionString))
            {
                string insertQuery = @"UPDATE AXIS_LIMITS SET 
                                        NAME = @NAME,
                                        COUNTING_AXES = @COUNTING_AXES,
                                        WEIGHT_AXLE_1 = @WEIGHT_AXLE_1,
                                        WEIGHT_AXLE_2 = @WEIGHT_AXLE_2,
                                        WEIGHT_AXLE_3 = @WEIGHT_AXLE_3,
                                        WEIGHT_AXLE_4 = @WEIGHT_AXLE_4,
                                        WEIGHT_AXLE_5 = @WEIGHT_AXLE_5,
                                        WEIGHT_AXLE_6 = @WEIGHT_AXLE_6,
                                        WEIGHT_AXLE_7 = @WEIGHT_AXLE_7,
                                        WEIGHT_AXLE_8 = @WEIGHT_AXLE_8,
                                        WEIGHT_AXLE_9 = @WEIGHT_AXLE_9,
                                        WEIGHT_AXLE_10 = @WEIGHT_AXLE_10,
                                        NOTE = @NOTE
                                        WHERE ID = @ID";


                db.Execute(insertQuery, axisLimit);
            }

        }
    }
}

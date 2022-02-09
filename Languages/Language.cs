using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages
{
    public abstract class Language
    {
        /// <summary>
        /// Вес
        /// </summary>
        public abstract string Weight { get; }
        /// <summary>
        /// Кнопка обнуления
        /// </summary>
        public abstract string btnZero { get; }
        /// <summary>
        /// Настройки
        /// </summary>
        public abstract string Settings { get; }
        /// <summary>
        /// Кнопка сохранить
        /// </summary>
        public abstract string btnSave { get; }
    }

}

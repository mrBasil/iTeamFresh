using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages
{
    /// <summary>
    /// Класс описывающий языковые контролы
    /// </summary>
    public abstract class Language
    {
        // Языковые метки для  Weighing Form --- *********************************************** ---

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
        /// <summary>
        /// Меню Weighing
        /// </summary>
        public abstract string menueToolStripMenuItem { get; }
        public abstract string settingsToolStripMenuItem { get; }
        public abstract string logToolStripMenuItem { get; }
        public abstract string exitToolStripMenuItem { get; }

        // Языковые метки для Settings Form ---*******************************************---


    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages
{
    /// <summary>
    /// Русский язык
    /// </summary>
    public class Russian : Language
    {
        public override string Weight { get { return "Вес"; } }

        public override string btnZero { get { return "Обнулить"; }}

        public override string Settings { get { return "Настройки"; } }

        public override string btnSave { get { return "Сохранить"; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages
{
    /// <summary>
    /// Английский язык
    /// </summary>
    internal class English : Language
    {
        public override string Weight { get { return "Weight"; } }

        public override string btnZero { get { return "Zero"; } }

        public override string Settings { get { return "Settings"; } }

        public override string btnSave { get { return "Save"; } }
    }
}

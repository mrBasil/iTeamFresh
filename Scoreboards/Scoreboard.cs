using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Scoreboards
{
    public abstract class Scoreboard
    {
        public abstract int weight { get; set; }
        public abstract int numberCharsAfterDot { get; set; } 

        public abstract SerialPort port { get; set; }
    }
}

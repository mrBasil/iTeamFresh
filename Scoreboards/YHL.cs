using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoreboards
{
    public class YHL : Scoreboard
    {
        public override int weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int numberCharsAfterDot { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override SerialPort port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

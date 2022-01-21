using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indicators
{
    internal class KeliXK3109 : Indikator


    { 
        private SerialPort comPort;

        public KeliXK3109(SerialPort serialPort) {
            comPort = serialPort;            
        }
        public override SerialPort ComPort { get { return comPort; } set { comPort = value; } }
        public override int Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int CharactersAfterDot { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Stab { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void SetZero()
        {
            
        }
        
    }
}

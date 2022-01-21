using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using iTeamFresh.DevicesIO;
using Indicators;

namespace iTeamFresh
{
    internal class MainClas
    {
        public PR200 pr { get; set; } = new PR200(new SerialPort());

        private Protoсol prot = new Protoсol(new SerialPort());

        public Indikator indicator { get; set; }

        public void setIndicator() 
        {
            var protForIndicator = Protoсol.Protocols.Keli;

            indicator = prot.GetIndicator((int)protForIndicator);
        }
        
    }
}

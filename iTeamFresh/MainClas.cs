using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using iTeamFresh.DevicesIO;

namespace iTeamFresh
{
    internal class MainClas
    {
        public PR200 pr { get; set; } = new PR200(new SerialPort());
        
        
    }
}

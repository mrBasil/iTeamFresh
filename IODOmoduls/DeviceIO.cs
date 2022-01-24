using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace IODOmoduls
{
    public class DeviceIO
    {
        public string[] devicesName = new string[] { "ПР200 v5", "MB110", "Arduino v1.0" };
        public SerialPort port { get; set; }

        public ModulIO getDevice(int nameDevice) {
            switch (nameDevice) { 
                case 0:
                    return new PR200v5(port);
                    break;            
            }
            return null;          
        }
    }
}

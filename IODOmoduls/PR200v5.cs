
using System.Threading;
using Modbus.Device;
using System.IO.Ports;
using System;

namespace IODOmoduls
{
    public class PR200v5:ModulIO
    {

        private static IModbusSerialMaster master;

        private static byte slaveId = 5;
        

        private static int DI;
        private static int DO;

        /// <summary>
        /// Работа с ПР200 с прошивкой версия 5
        /// </summary>
        /// <param name="port"> Открытый настроенный COM порт</param>
        public PR200v5(SerialPort port) {
            if(port.IsOpen)
                master = ModbusSerialMaster.CreateRtu(port);           
        }

        public override bool RedOut { get { GetDO(); return redOut; } set { redOut = value; SetDO(); } }
        public override bool RedIn { get { GetDO(); return redIn; } set { redIn = value; SetDO(); } }
        public override bool GreenOut { get { GetDO(); return greenOut; } set { greenOut = value; SetDO(); } }
        public override bool GreenIn { get { GetDO(); return greenIn; } set { greenIn = value; SetDO(); } }
        public override bool LeftBarrier { get { GetDO(); return leftBarrier; } set { leftBarrier = value; SetDO(); } }
        public override bool RightBarrier { get { GetDO(); return rightBarrier; } set { rightBarrier = value; SetDO(); } }
        public override bool SensorLeft { get { GetDI(); return sensorLeft; } protected set { sensorLeft = value; } }
        public override bool SensorRight { get { GetDI(); return sensorRight; } protected set { sensorRight = value; } }

        private void  GetDO() {
           
            DO = master.ReadInputRegisters(slaveId, 513, 1)[0];

            if ((DO & 1) == 1)
                redIn = true;
            
            else redIn = false;

            if ((DO & 2) == 2)
                greenOut = true;
            else greenOut = false;

            if ((DO & 4) == 4)
                redIn = true;
            else redIn = false;

            if ((DO & 8) == 8)
                greenIn = true;
            else greenIn = false;

            if ((DO & 16) == 16)
                leftBarrier = true;
            else leftBarrier = false;

            if ((DO & 32) == 32)
                rightBarrier = true;
            else rightBarrier = false;           


            
        
        }

        private void GetDI() {
            DI = master.ReadInputRegisters(slaveId, 512, 1)[0];
            Console.WriteLine(DI);
            if ((DI & 1) == 1)
                sensorLeft = true;

            else sensorLeft = false;

            if ((DI & 2) == 2)
                sensorRight = true;
            else sensorRight = false;            

        }

        private void SetDO() {
            int temp = 0;

            if (redOut)
                temp = temp | 1;
            if (greenOut)
                temp = temp | 2;
            if (redIn)
                temp = temp | 4;
            if (greenIn)
                temp = temp | 8;
            if (leftBarrier)
                temp = temp | 16;
            if (rightBarrier)
                temp = temp | 32;          


            
           master.WriteSingleRegister(slaveId, 513, Convert.ToUInt16(temp));


        }


    }
}

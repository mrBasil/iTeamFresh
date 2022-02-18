
using System.Threading;
using Modbus.Device;
using System.IO.Ports;
using System;

namespace IOmoduls
{
    /// <summary>
    /// Класс для работы с ПР200 v prime 2.0
    /// </summary>
    public class PR200vPrime20:ModulIO
    {

        private static IModbusSerialMaster master;
        private byte slaveId = 5;       

        private static int DI;
        private static int DO;

        /// <summary>
        /// Работа с ПР200 с прошивкой версия prime 2.0
        /// </summary>
        /// <param name="port"> Открытый настроенный COM порт</param>
        public PR200vPrime20(SerialPort port, byte slaveId = 5) {
            this.slaveId = slaveId;
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

            if ((DO & 2) == 2)
                redOut = true;
            
            else redOut = false;

            if ((DO & 4) == 4)
                greenOut = true;
            else greenOut = false;

            if ((DO & 8) == 8)
                redIn = true;
            else redIn = false;

            if ((DO & 16) == 16)
                greenIn = true;
            else greenIn = false;

            if ((DO & 32) == 32)
                leftBarrier = true;
            else leftBarrier = false;

            if ((DO & 64) == 64)
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
                temp = temp | 2;
            if (greenOut)
                temp = temp | 4;
            if (redIn)
                temp = temp | 8;
            if (greenIn)
                temp = temp | 16;
            if (leftBarrier)
                temp = temp | 32;
            if (rightBarrier)
                temp = temp | 64;          


            
           master.WriteSingleRegister(slaveId, 513, Convert.ToUInt16(temp));


        }


    }
}

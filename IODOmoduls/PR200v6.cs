using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus.Device;
using System.IO.Ports;

namespace IOmoduls
{
    /// <summary>
    /// Класс для работы с ПР200 v 6.0
    /// </summary>
    public class PR200v6 : ModulIO
    {
        private static IModbusSerialMaster master;

        private static byte slaveId = 5;

        /// <summary>
        /// Класс для работы с ПР200 v 6.0
        /// </summary>
        public PR200v6(SerialPort port)
        {
            if (port.IsOpen)
                master = ModbusSerialMaster.CreateRtu(port);
        }

        public override bool RedOut { get { return GetDO(1); } set { SetDo(1, value); } }
        public override bool RedIn { get { return GetDO(3); } set { SetDo(3, value); } }
        public override bool GreenOut { get { return GetDO(2); } set { SetDo(2, value); } }
        public override bool GreenIn { get { return GetDO(4); } set { SetDo(4, value); } }
        public override bool LeftBarrier { get { return GetDO(5); } set { SetDo(5, value); } }
        public override bool RightBarrier { get { return GetDO(6); } set { SetDo(6, value); } }
        public override bool SensorLeft { get { return GetDI(1); } protected set { } }
        public override bool SensorRight { get { return GetDI(2); } protected set { } }

        private bool GetDO(int numberDO)
        {
            switch (numberDO)
            {
                case 1:
                    return checkDo(master.ReadInputRegisters(slaveId, 512, 1)[0]);
                case 2:
                    return checkDo(master.ReadInputRegisters(slaveId, 513, 1)[0]);
                case 3:
                    return checkDo(master.ReadInputRegisters(slaveId, 514, 1)[0]);
                case 4:
                    return checkDo(master.ReadInputRegisters(slaveId, 515, 1)[0]);
                case 5:
                    return checkDo(master.ReadInputRegisters(slaveId, 516, 1)[0]);
                case 6:
                    return checkDo(master.ReadInputRegisters(slaveId, 517, 1)[0]);
                case 7:
                    return checkDo(master.ReadInputRegisters(slaveId, 518, 1)[0]);
                case 8:
                    return checkDo(master.ReadInputRegisters(slaveId, 519, 1)[0]);

                default: return false;

            }

        }

        private bool checkDo(ushort v)
        {
            if (v > 0) { return true; } else { return false; }
        }

        private void SetDo(int numberDO, bool volue)
        {
            if (volue)
            {
                switch (numberDO)
                {
                    case 1:
                        master.WriteSingleRegister(slaveId, 512, 1);
                        break;
                    case 2:
                        master.WriteSingleRegister(slaveId, 513, 1);
                        break;
                    case 3:
                        master.WriteSingleRegister(slaveId, 514, 1);
                        break;
                    case 4:
                        master.WriteSingleRegister(slaveId, 515, 1);
                        break;
                    case 5:
                        master.WriteSingleRegister(slaveId, 516, 1);
                        break;
                    case 6:
                        master.WriteSingleRegister(slaveId, 517, 1);
                        break;
                    case 7:
                        master.WriteSingleRegister(slaveId, 518, 1);
                        break;
                    case 8:
                        master.WriteSingleRegister(slaveId, 519, 1);
                        break;


                }
            }
            else
            {
                switch (numberDO)
                {
                    case 1:
                        master.WriteSingleRegister(slaveId, 512, 0);
                        break;
                    case 2:
                        master.WriteSingleRegister(slaveId, 513, 0);
                        break;
                    case 3:
                        master.WriteSingleRegister(slaveId, 514, 0);
                        break;
                    case 4:
                        master.WriteSingleRegister(slaveId, 515, 0);
                        break;
                    case 5:
                        master.WriteSingleRegister(slaveId, 516, 0);
                        break;
                    case 6:
                        master.WriteSingleRegister(slaveId, 517, 0);
                        break;
                    case 7:
                        master.WriteSingleRegister(slaveId, 518, 0);
                        break;
                    case 8:
                        master.WriteSingleRegister(slaveId, 519, 0);
                        break;
                }

            }






        }

        private bool GetDI(int numberDI) {
            var temp = master.ReadInputRegisters(slaveId, 520, 1)[0];
            //Console.WriteLine("reg 520 = " + temp);
            if (temp != 0)
                switch (numberDI)
                {
                    case 1:
                        if ((temp | 1) == 1)
                            return true;
                        else return false;

                    case 2:
                        if ((temp | 2) == 2)
                            return true;
                        else return false;
                    case 3:
                        if ((temp | 4) == 4)
                            return true;
                        else return false;
                    case 4:
                        if ((temp | 8) == 8)
                            return true;
                        else return false;
                    case 5:
                        if ((temp | 16) == 16)
                            return true;
                        else return false;
                    case 6:
                        if ((temp | 32) == 32)
                            return true;
                        else return false;
                    case 7:
                        if ((temp | 64) == 64)
                            return true;
                        else return false;
                    case 8:
                        if ((temp | 128) == 128)
                            return true;
                        else return false;

                    default: return false;
                }
            else return false;
        }

    }
}

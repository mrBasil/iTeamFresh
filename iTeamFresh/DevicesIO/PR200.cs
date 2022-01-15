﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace iTeamFresh.DevicesIO
{
    internal class PR200 : iGeneralIO

    {

        public PR200(SerialPort port)
        {
            this.port = port;
        }

        public SerialPort port { get; set; }

        private bool redOut;
        private bool greenOut;
        private bool redIn;
        private bool greenIn;

        private bool leftBarrier;
        private bool rightBarrier;

        private bool sensorRight;
        private bool sensorLef;

        public bool RedOut { get { return redOut; } set { redOut = value; setIO(); } } 

        public bool RedIn { get { return redIn; } set { redIn = value; setIO(); } }
        public bool GreenOut { get { return greenOut; } set { greenOut = value; setIO(); } }
        public bool GreenInt { get { return greenIn; } set { greenIn = value; setIO(); } }
        public bool LeftBarrier { get { return leftBarrier; } set { leftBarrier = value; setIO(); } }
        public bool RightBarrier { get { return rightBarrier; } set { rightBarrier = value; setIO(); } }

        public bool SensorLeft { get { return sensorLef; } set { sensorLef = value; } }
        public bool SensorRight { get { return sensorRight; } set { sensorRight = value; } }

        /// <summary>
        /// Какой - то метод который будет включать и выключать дискретные входы
        /// </summary>
        private void setIO()
        {
            Console.WriteLine(" Отправил в ПР команду на включение светофора");
        }
    }
}
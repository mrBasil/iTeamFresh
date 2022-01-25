using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Threading;

namespace Indicators
{
    public class TenzoM643 : Indikator
    {
        private bool flagAutorization;

        private Timer timer = new Timer();
        private int intervalStab;

        public TenzoM643(SerialPort port) {
            
            if (port != null)
            {
                ComPort = port;
                ComPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                Console.WriteLine(port.PortName);
                SetAvtorization();

                timer.Interval = 3000;
                timer.Elapsed += checkStabForTimer;
            }

        }

        public override int IntervalStab 
        { 
            get { return intervalStab; } 
            set { timer.Interval = value; intervalStab = value; }
        }
        private void setWeightFromBuffer(byte[] buffer) {

            if (buffer[0] == 255 && buffer.Length == 1)
            {
                flagAutorization = true;
                GetWeight();

            }
            else if (buffer.Length == 9)
            {

                string tempWeight = string.Empty;
                int coef = 1;

                for (int i = 1; i < 8; i++)
                {
                    if (buffer[i] == '.')
                    {
                        switch (i)
                        {
                            case 6:
                                CharactersAfterDot = 1;
                                break;
                            case 5:
                                CharactersAfterDot = 2;
                                break;
                            case 4:
                                CharactersAfterDot = 3;
                                break;
                            case 3:
                                CharactersAfterDot = 4;
                                break;
                        }

                    }
                    else if (buffer[i] == '-')
                    {
                        coef = (-1);
                    }
                    else
                    {
                        switch (Convert.ToChar(buffer[i])) {

                            case '0':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            case '1':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            case '2':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            case '3':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            case '4':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            case '5':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            case '6':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            case '7':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            case '8':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            case '9':
                                tempWeight = tempWeight + Convert.ToChar(buffer[i]);
                                break;

                            
                        }
                        

                    }


                }

                checkStabForNewWeight(tempWeight);

                Weight = Convert.ToInt32(tempWeight) * coef;

                GetWeight();

            }
            else {
                GetWeight();
            }
            
        
        }
        private Queue<int> stabQueue = new Queue<int>(15);
        private void checkStabForNewWeight(string weightStr)
        {
            /* метод для проверки на НЕСТАБИЛЬНОСТЬ
             * если вес не равен предидущему то флаг стабильности встает в false останавливает таймер проверки на стабильность
             * если вес равен предидущему то запускает таймер проверки на стабильность
             */

            var tempWeight =Convert.ToInt32(weightStr);

            stabQueue.Enqueue(tempWeight); // кладет новый вес в очередь

            if (Weight != tempWeight)
            {
                Stab = false;
                stabQueue.Clear();
                timer.Stop();
            }
            else
            {
                timer.Start();
            }


        }

        private void checkStabForTimer(object sender, ElapsedEventArgs e)
        {
            /* метод для обработки события таймера для проверки на стабильность по времени */

            if (stabQueue.Count > 0 && stabQueue.Average() == Weight)
            {
                Stab = true;
                stabQueue.Clear();

            }
            else
            {
                Stab = false;
                stabQueue.Clear();
            }

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer;
            int buffer_size;

            SerialPort sp = (SerialPort)sender;
            buffer_size = sp.BytesToRead;
            buffer = new Byte[buffer_size];
            sp.Read(buffer, 0, buffer_size);

            setWeightFromBuffer(buffer);
            
        }

        private void SetAvtorization() {
            while (!flagAutorization) {

                ComPort.Write(new byte[] { 0x2, 0x1, 0x30, 0x30, 0x30, 0x31 }, 0, 6);
                Thread.Sleep(1000);

            }
            
        }

        private void GetWeight() {
            ComPort.Write(new byte[] { 16 }, 0, 1);
        }



        public override SerialPort ComPort { get; set; }
        public override int Weight { get; set; }
        public override int CharactersAfterDot { get ; set ; }
        public override bool Stab { get ; set; }

        public override void SetZero()
        {
            if (ComPort != null) {
                ComPort.Write(new byte[] { 0xD }, 0, 1);            
            }
        }



    }
}

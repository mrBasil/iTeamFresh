using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;

using System.Timers;

namespace Indicators
{
    internal class KeliXK3109 : Indikator


    {
        private Timer timer = new Timer();

        private SerialPort comPort;

        private int weight = 999999;
        private bool stab;

        private int intervalStab = 3000;
        
        /// <summary>
        /// Класс для работы с идикаторами keliXK3109
        /// </summary>
        /// <param name="serialPort">Настроенный и открытый ком порт</param>
        public KeliXK3109(SerialPort serialPort ) 
        {
            
            comPort = serialPort;            
            comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            timer.Interval = intervalStab;
            timer.Elapsed += checkStabForTimer;
                        
        }

        public override int IntervalStab 
        { 
            get { return intervalStab; } 
            set { timer.Interval = value; intervalStab = value; } 
        } 


        public override SerialPort ComPort { get { return comPort; } set { comPort = value; } }


        public override int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public override int CharactersAfterDot { get; set; }
        public override bool Stab 
        {
            get { return stab; }
            set { stab = value; }
        }

        public override void SetZero()
        {
            /*
             здесь нихрена нет так как протокол односторонний
             */
        }



        /*Механика работы с ком портом и расшифровка посылки протокола keli k9*/

        private List<byte> message = new List<byte>();
        public void addNewData(byte[] dataFromPort)
            {

                if (message.Count < 12)
                {
                    message.AddRange(dataFromPort);
                }

                else
                {
                    
                    setWeight();
                    message.Clear();
                    message.AddRange(dataFromPort);
                }

            }
        private void setWeight()
            {
                string weightString = "";

                for (int i = 0; i < 12; i++)
                {
                    switch (i)
                    {
                        case 0:
                            break;
                        case 1:
                            weightString = weightString + Convert.ToChar(message[i]);
                            break;
                        case 2:
                            weightString = weightString + Convert.ToChar(message[i]);
                            break;
                        case 3:
                            weightString = weightString + Convert.ToChar(message[i]);
                            break;
                        case 4:
                            weightString = weightString + Convert.ToChar(message[i]);
                            break;
                        case 5:
                            weightString = weightString + Convert.ToChar(message[i]);
                            break;
                        case 6:
                            weightString = weightString + Convert.ToChar(message[i]);
                            break;
                        case 7:
                            weightString = weightString + Convert.ToChar(message[i]);
                            break;
                        case 8:
                            CharactersAfterDot = Convert.ToInt16(Convert.ToChar(message[i]).ToString());
                            break;

                        case 9:

                            break;
                        case 10:

                            break;
                        case 11:

                            break;
                    }
                }


            checkStabForNewWeight(weightString);                

            weight = Convert.ToInt32(weightString);
            
            

            } // метод преобразования посылки в вес и проверка на стабильность
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer;
            int buffer_size;

            SerialPort sp = (SerialPort)sender;
            buffer_size = sp.BytesToRead;
            buffer = new Byte[buffer_size];
            sp.Read(buffer, 0, buffer_size);        

            addNewData(buffer);

        } // событие наличия данных в порту

        /* проверка на стабильность*/

        private Queue<int> stabQueue = new Queue<int>(15) ;
        private void checkStabForNewWeight(string weightStr) {
            /* метод для проверки на НЕСТАБИЛЬНОСТЬ
             * если вес не равен предидущему то флаг стабильности встает в false останавливает таймер проверки на стабильность
             * если вес равен предидущему то запускает таймер проверки на стабильность
             */

            var tempWeight = Convert.ToInt32(weightStr);

            stabQueue.Enqueue(tempWeight); // кладет новый вес в очередь

            if (weight != tempWeight)
            {
                stab = false;
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

             if (stabQueue.Count > 0 && stabQueue.Average() == weight)
                {
                    stab = true;
                    stabQueue.Clear();
                    
                } else
                    {
                        stab = false;
                        stabQueue.Clear();
                    }           
            
        }

    }



    
}

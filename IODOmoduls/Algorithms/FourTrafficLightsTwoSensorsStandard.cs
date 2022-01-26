using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Indicators;


namespace IOmoduls.Algorithms
{
    public delegate void TransportЗosition();
    /// <summary>
    /// 4 светофора, 2 датчика положения двусторонний проезд, стандартный алгоритм
    /// </summary>
    internal class FourTrafficLightsTwoSensorsStandard:Algorithm
    {
        /// <summary>
        /// Событие полного заезда транспорта на весы и стабилизации веса
        /// </summary>
        public event TransportЗosition TransportOnScales;
        /// <summary>
        /// Настроенный индикатор
        /// </summary>
        private Indikator indikator;       

        private bool flagProezd;

        private bool flagTransportIsArrival;
        private bool flagTransportIsDeparture;

        public FourTrafficLightsTwoSensorsStandard(Indikator indikator)
        {
            this.indikator = indikator; 
            
        }

        private void ManagerTraffic() {
            while (true) {

                if (flagAutoRegime) {
                    AutoTraffic();                
                }
            
            
            }
        
        }

        private void AutoTraffic() {

            if (!flagProezd && !ModulVV.SensorLeft || !ModulVV.SensorRight && indikator.Weight > WeightThreshold ) 
            {

                ModulVV.RedOut = true;
                ModulVV.GreenOut = false;
                ModulVV.RedIn = true;
                ModulVV.GreenIn = true;

                flagProezd = true;
                flagTransportIsArrival = true;
            
            }

            if (flagProezd && flagTransportIsArrival && indikator.Weight > WeightThreshold && !indikator.Stab) 
            {
                ModulVV.RedIn = true;
                ModulVV.GreenIn = false;
            }

            if (flagProezd && flagTransportIsArrival && indikator.Weight > WeightThreshold && indikator.Stab) 
            {                
                if(TransportOnScales!= null)
                    TransportOnScales();
                
                flagTransportIsArrival = false;                
            } 

            
            
        }


    }
}

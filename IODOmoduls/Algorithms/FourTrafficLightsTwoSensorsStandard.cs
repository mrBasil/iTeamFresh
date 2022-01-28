using Indicators;


namespace IOmoduls.Algorithms
{
    
    /// <summary>
    /// 4 светофора, 2 датчика положения двусторонний проезд, стандартный алгоритм
    /// </summary>
    public class FourTrafficLightsTwoSensorsStandard:Algorithm
    {  
               

        private bool flagProezd;
        private bool flagTransportIsArrival;
        private bool flagTransportIsDeparture;

        public override event TransportPosition TransportOnScales;
        public override event TransportPosition TransportBeforScales;
        public override event TransportPosition TransoprtAfterScales;

        public FourTrafficLightsTwoSensorsStandard(Indikator indikator, ModulIO modulIO) : base(indikator, modulIO) { }        

        private void ManagerTraffic() {
            while (true) 
            {
                if (flagAutoRegime)
                {
                    AutoTraffic();                
                }             
            }        
        }

        private void AutoTraffic() {

            
            
            
        }


    }
}

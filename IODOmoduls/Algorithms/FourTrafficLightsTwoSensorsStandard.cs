using Indicators;


namespace IOmoduls.Algorithms
{

    /// <summary>
    /// 4 светофора, 2 датчика положения двусторонний проезд, стандартный алгоритм
    /// </summary>
    public class FourTrafficLightsTwoSensorsStandard : Algorithm
    {

        /// <summary>
        /// Флаг проезд в процессе
        /// </summary>
        private bool flagProezd;
        /// <summary>
        /// Флаг наличия транспорта на вьезде
        /// </summary>
        private bool flagTransportIsArrival;
        /// <summary>
        /// Флаг наличия транспорта на выезде
        /// </summary>
        private bool flagTransportIsDeparture;
        /// <summary>
        /// Флаг полного заезда на весы 
        /// </summary>
        private bool flagTranspoetOnScales;

        public override event TransportPosition TransportOnScales;
        public override event TransportPosition TransportBeforScales;
        public override event TransportPosition TransoprtAfterScales;

        public FourTrafficLightsTwoSensorsStandard(Indikator indikator, ModulIO modulIO) : base(indikator, modulIO)
        {

            ManagerTraffic();
        }

        private void ManagerTraffic()
        {
            while (true)
            {
                if (flagAutoRegime)
                {
                    AutoTraffic();
                }
            }
        }

        private void AutoTraffic()
        {

            if (!flagProezd && !modulVV.SensorLeft || !modulVV.SensorRight && indikator.Weight > WeightThreshold)
            {
                /* Отлавливаем начало проезад */
                if (TransoprtAfterScales != null)
                    TransoprtAfterScales();

                flagTransportIsArrival = true;
                flagProezd = true;

                modulVV.RedOut = true;
                modulVV.GreenOut = false;
                modulVV.RedIn = true;
                modulVV.GreenIn = true;

            }
            else if (flagProezd && modulVV.SensorLeft && modulVV.SensorRight && flagTransportIsArrival)
            {
                /*отлавливаем полный заезд автомобиля на весы */
                modulVV.GreenIn = false;
                modulVV.RedIn = true;
                modulVV.RedOut = true;
                modulVV.GreenOut = false;

                flagTransportIsArrival = false;

            }
            else if (!flagTransportIsArrival && modulVV.SensorRight && modulVV.SensorLeft && indikator.Stab && flagProezd && !flagTranspoetOnScales && !FlagWaitingForPermissionToLeave)
            {
                /* Отлавливаем событие стабилизации веса когда машина на весах*/
                if (TransportOnScales != null)
                    TransportOnScales();
                flagTranspoetOnScales = true;


            }
            else if (FlagWaitingForPermissionToLeave && flagProezd && flagTranspoetOnScales)
            {

                modulVV.GreenIn = true;
                modulVV.RedIn = false;
                flagTranspoetOnScales = false;
                flagTransportIsDeparture = true;

            }
            else if (!flagTranspoetOnScales && FlagWaitingForPermissionToLeave && 
                flagProezd && flagTransportIsDeparture && !modulVV.SensorRight || !modulVV.SensorRight) { 
                
                
            }


        }
    }
}

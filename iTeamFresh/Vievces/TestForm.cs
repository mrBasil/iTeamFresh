using System;
using System.Drawing;
using System.Windows.Forms;
using Indicators;
using IOmoduls;
using System.IO.Ports;
using System.Threading;

namespace iTeamFresh.Vievces
{
    public partial class TestForm : Form
    {

        

        private MainClas mc = Program.mc;
        private Indikator indikator;

        public TestForm()
        {
            InitializeComponent();
                     
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            // как создать с ноля строку в таблице
            DataBase.Weighing weighing = new DataBase.Weighing() {
                TYPE = 1,
                STATUS = 2,
                MODE_WEIGHING = 1,
                DATE_FIRST_WEIGHING = DateTime.Now,
                DATE_SECOND_WEIGHING = DateTime.Now,
                WEIGHT_FIRST_WEIGHING = 5000,
                WEIGHT_SECOND_WEIGHING = 8000,
                WEIGHT_TARRA = 1000,
                WEIGHT_BRUTTO = 5000,
                WEIGHT_NETTO = 100,
                DIRT = 12,
                PRICE_WEIGHTED_CARGO = 500,
                PRICE_FOR_CARGO_CALCULATION = 100,
                NUMBER_TRANSPORT = "h152eu102RUS",
                NUMBER_TRAILER = "hh5421102RUS",
                MODEL_TRANSPORT = "Galez",
                DRIVER = "Tarasov S",
                CARGO_LINK = 1,
                CARGO_SENDER_LINK = 1,
                CARGO_RECIPIENT_LINK = 1,
                CARGO_CARRIER_LINK = 1,
                CARGO_SUPPLIER_LINK = 1,
                USER_FIRST_WEIGHING = "Potapov S.V.",
                USER_SECOND_WEIGHING = "Kuzmin E.V.",
                NUMBER_OF_DOCUMNET = 22222,
                SERIES_OF_DOCUMENT = "yyya"

            };



            DataBase.WeighingRepository wr = new DataBase.WeighingRepository(" 123");

            DataBase.Weighing we = wr.GetWeighing(2);

            we.DRIVER = "Tarasov S";
            we.USER_FIRST_WEIGHING = "Kolesnikov A";
            we.USER_SECOND_WEIGHING = "Matveich ";

            wr.UpdateWeighing(we);

            foreach (var temp in wr.GetAllWeighing()) {
                Console.WriteLine(temp.DRIVER);
            }
            


        }

        

    }
}

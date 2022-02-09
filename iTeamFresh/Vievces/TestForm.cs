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
        private ModulIO modul;

        public TestForm()
        {
            InitializeComponent();
            modul = mc.modulIO;           
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {                   

                bool left = modul.SensorLeft;
                bool right = modul.SensorRight;
                Console.WriteLine(left + " " + right);      
            


        }

        private void UpdateLabel(object sender, EventArgs e)
        {            
        }

    }
}

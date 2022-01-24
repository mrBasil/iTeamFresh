using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Indicators;
using IODOmoduls;
using System.IO.Ports;

namespace iTeamFresh.Vievces
{
    public partial class TestForm : Form
    {

        private Timer timer = new Timer();

        private MainClas mc = Program.mc;
        private Indikator indikator;

        public TestForm()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(UpdateLabel);
            timer.Interval = 50;
            timer.Start();

            
            indikator = mc.indicator;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();

            ModulIO pr = new PR200v5(port);
            Console.WriteLine(pr.SensorLeft);
            pr.GreenOut = true;            
            
            Console.WriteLine(pr.SensorRight);
            Console.WriteLine(pr.GreenOut);
        }
        private void UpdateLabel(object sender, EventArgs e) {
                    
                

           
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTeamFresh.Vievces
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        private void CrosLeftSensor() {

            Console.WriteLine("Событие пересечения левого датчика");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var pr = Program.mc.pr;
            pr.CrosSensorLeft += CrosLeftSensor;
            pr.SensorLeft = true;

        }
    }
}

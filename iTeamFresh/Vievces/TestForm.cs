using System;
using System.Drawing;
using System.Windows.Forms;
using Indicators;
using IOmoduls;
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
            if(indikator!=null)
                timer.Tick += new EventHandler(UpdateLabel);

            timer.Interval = 50;
            timer.Start();

            
            indikator = mc.indicator;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            indikator.SetZero();
        }

        private void UpdateLabel(object sender, EventArgs e) {

            if (indikator.Stab)
            {
                lb_weight.ForeColor = Color.Green;
                lb_weight.Text = indikator.Weight + " kg";
            }
            else {

                lb_weight.ForeColor = Color.Gray;
                lb_weight.Text = indikator.Weight + " kg";
            }
            
        }

    }
}

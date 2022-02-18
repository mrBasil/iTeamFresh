using System;
using IOmoduls;
using Indicators;
using System.Windows.Forms;
using System.Drawing;

namespace iTeamFresh.Vievces
{
    public partial class MnemoShemForm : Form
    {
        private MainClas mc = Program.mc;
        private ModulIO IO;
        private Indikator indikator;

        Timer timer = new Timer();
        Timer timerTraffic = new Timer();

        public MnemoShemForm()
        {
            InitializeComponent();  
            
            IO = mc.modulIO;
            indikator = mc.indicator;

            timer.Interval = 200;
            timerTraffic.Interval = 200;

            if (indikator != null)
            {
                timer.Tick += updateLabel;
                timer.Start();
            }
            else
            {
                lb_weight.Text = "####";
            }


            if (IO != null)
            {
                setTraffickVisible(true);

                timerTraffic.Tick += updateLight;
                timerTraffic.Start();
            }
            else
            {
                setTraffickVisible(false);
            }

            
        }

        private void updateLight(object sender, EventArgs e)
        {
            if (IO.RedOut)
                btn_redOut.Image = Properties.Resources.красный1;
            else btn_redOut.Image = Properties.Resources.серый1;

            if (IO.GreenOut)
                btn_greenOut.Image = Properties.Resources.зеленый1;
            else btn_greenOut.Image = Properties.Resources.серый1;

            if (IO.RedIn)
                btn_redIn.Image = Properties.Resources.красный1;
            else btn_redIn.Image = Properties.Resources.серый1;

            if (IO.GreenIn)
                btn_greenIn.Image = Properties.Resources.зеленый1;
            else btn_greenIn.Image = Properties.Resources.серый1;

        }

        private void updateLabel(object sender, EventArgs e)
        {
            lb_weight.Text = indikator.Weight + "";
            if (indikator.Stab)
            {
                lb_weight.ForeColor = Color.Blue;

            }
            else {
                lb_weight.ForeColor = Color.Black;
            }
        }

        private void setTraffickVisible(bool flag) {
            if (flag)
            {
                btn_redOut.Visible = true;
                btn_greenOut.Visible = true;
                btn_redIn.Visible = true;
                btn_greenIn.Visible = true;
            }
            else 
            {
                btn_redOut.Visible = false;
                btn_greenOut.Visible = false;
                btn_redIn.Visible = false;
                btn_greenIn.Visible = false;
            }            
        }

        private void lb_weight_Click(object sender, EventArgs e)
        {
            if (indikator != null)
                indikator.SetZero();
        }

        private void btn_redOut_Click(object sender, EventArgs e)
        {
            bool redOut = IO.RedOut;
            if (redOut)
            {
                IO.RedOut = false;
            }
            else IO.RedOut = true;
            
        }

        private void btn_greenOut_Click(object sender, EventArgs e)
        {
            bool GreenOut = IO.GreenOut;
            if (GreenOut)
            {
                IO.GreenOut = false;
            }
            else IO.GreenOut = true;

        }

        private void btn_redIn_Click(object sender, EventArgs e)
        {
            bool redIn = IO.RedIn;
            if (redIn)
            {
                IO.RedIn = false;
            }
            else IO.RedIn = true;
        }

        private void btn_greenIn_Click(object sender, EventArgs e)
        {
            bool GreenIn = IO.GreenIn;
            if (GreenIn)
            {
                IO.GreenIn = false;
            }
            else IO.GreenIn = true;
        }
    }
}

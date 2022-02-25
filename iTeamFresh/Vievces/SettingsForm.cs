using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Indicators;
using IOmoduls;

namespace iTeamFresh.Vievces
{
    public partial class SettingsForm : Form
    {
        MainClas mc = Program.mc;
        
        public SettingsForm()
        {
            InitializeComponent();

            InitSettingsControlsIndicator();
        }

        /// <summary>
        /// Инициализация всех контролов на вкладке на панели настроек индикатора
        /// </summary>
        private void InitSettingsControlsIndicator() 
        {
            var settings = Properties.Settings.Default;

            comboBox_com.Items.AddRange(SerialPort.GetPortNames());
            comboBox_com.SelectedItem = settings.indicator_com;

            comboBox_Idic_prot.Items.AddRange(Protoсol.protocols);
            comboBox_Idic_prot.SelectedIndex = settings.indicator_protoсol;


            comboBox_com_budeRate.Items.AddRange(new string[] { "9600", "19200", "4800", "38400" });
            comboBox_com_budeRate.SelectedItem = settings.indicator_buadeRate.ToString();

            num_time_stab.Value = settings.indicator_time_stab;
        }

        private void btn_save_indic_settings_Click(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;

            if(comboBox_com.SelectedItem != null)
            {
                settings.indicator_com = comboBox_com.SelectedItem.ToString();
                settings.indicator_protoсol = comboBox_Idic_prot.SelectedIndex;
                settings.indicator_time_stab = Convert.ToInt32(num_time_stab.Value);
                settings.indicator_buadeRate = int.Parse(comboBox_com_budeRate.SelectedItem.ToString());

            }
           else {
                MessageBox.Show("В поле COM порт пусто");
            }
            

            
        }



        //***************************---------- IO Page ----------************************

        /// <summary>
        /// Инициализация всех контролов на панели настроек модуля IO
        /// </summary>
        private void InitSettingsControlsIO()
        {
            var settings = Properties.Settings.Default;
            comboBox_com_IO.Items.Add(DeviceIO.devicesName);
            

            comboBox_com_IO.Items.Add(SerialPort.GetPortNames());
            comboBox_BuadeRate_IO.Items.Add(new string[] { "9600", "19200", "38400", "4800" });

        }
        private void btn_save_IO_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            InitSettingsControlsIO();
            InitSettingsDataBase();
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
                settings.Save();
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
            comboBox_device_IO.Items.AddRange(DeviceIO.devicesName);
            comboBox_device_IO.SelectedItem = settings.IO_device;

            comboBox_com_IO.Items.AddRange(SerialPort.GetPortNames());
            comboBox_com_IO.SelectedItem = settings.IO_com;

            comboBox_BuadeRate_IO.Items.AddRange(new string[] { "9600", "19200", "38400", "4800" });
            comboBox_BuadeRate_IO.SelectedItem = settings.IO_budeRate.ToString();

            
        }
        private void btn_save_IO_Click(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;

            if (comboBox_com_IO.SelectedItem != null)
            {
                settings.IO_com = comboBox_com_IO.SelectedItem.ToString();
                settings.IO_budeRate = int.Parse(comboBox_BuadeRate_IO.SelectedItem.ToString());
                settings.IO_device = comboBox_device_IO.SelectedItem.ToString();
                settings.Save();
            }
            else {

                MessageBox.Show("Поле ком порт пусто");
            }
        }
        // ******************* -------------- DataBase --------------- ***********************
        
        private void InitSettingsDataBase() {
            var settings = Properties.Settings.Default;
            tb_path.Text = settings.path_DB;
        }
        private void btn_file_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            tb_path.Text = openFileDialog.FileName;
        }

        private void btn_save_DB_page_Click(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            if (tb_path.Text.Length > 0) { 
                settings.path_DB = tb_path.Text;
                settings.Save();
            }
            else
            {

                MessageBox.Show("Путь к базе данных не выбран");
            }
        }
    }
}

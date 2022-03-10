using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;

namespace iTeamFresh.Vievces
{
    public partial class WeighingsForm : Form
    {
        private MainClas mc = Program.mc;
        private WeighingRepository weighingRepository;
        
        public WeighingsForm()
        {
            InitializeComponent();

            mc.changeLanguage += UpdateLanguge;

            UpdateLanguge();

            LoadDataInDataGride(new object(), new EventArgs());

            monthCalendar.DateSelected += LoadDataInDataGride;
             
            
        }

        /// <summary>
        /// Загружает данные из таблици взвешиваний
        /// </summary>
        private void LoadDataInDataGride(object sender, EventArgs e) {
            //Console.WriteLine("Метод LoadDataInDataGride сработал ");
            
                weighingRepository = mc.GetWeighingRepository();
                dataGridView1.DataSource = weighingRepository.GetWeighingDTO(monthCalendar.SelectionStart, monthCalendar.SelectionEnd);
            
            
        }


        /// <summary>
        /// Смена языка
        /// </summary>
        public void UpdateLanguge() {
              
            Languages.Language ln = mc.language;

            menueToolStripMenuItem.Text = ln.menueToolStripMenuItem;
            settingsToolStripMenuItem.Text = ln.settingsToolStripMenuItem;
            logToolStripMenuItem.Text = ln.logToolStripMenuItem;
            exitToolStripMenuItem.Text = ln.exitToolStripMenuItem;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new Vievces.SettingsForm();
            settingsForm.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var logForm = new Vievces.LogForm();
            logForm.Show(); 

        }

        

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var clientDirectory = new Vievces.ClientsDirectoryForm();
            //clientDirectory.Show();
            var frmDir = new Directory.DirectoryForm(mc.GetClientRepository());
            frmDir.ShowDialog();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var cargoForm = new CargoDirectoryForm();
            //cargoForm.Show();
            var frmDir = new Directory.DirectoryForm(mc.GetCargoRepository());
            frmDir.ShowDialog();


        }

        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDir = new Directory.DirectoryForm(mc.GetTransportRepository());
            frmDir.ShowDialog();
        }
    }
}

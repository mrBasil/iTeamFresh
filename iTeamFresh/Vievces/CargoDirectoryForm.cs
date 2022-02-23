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
    public partial class CargoDirectoryForm : Form
    {
        MainClas mc = Program.mc;
       

        public CargoDirectoryForm()
        {
            InitializeComponent();
            var cargoRepo = mc.GetCargoRepository();

            dataGridView1.DataSource = cargoRepo.GetCargo() ;

        }
    }
}

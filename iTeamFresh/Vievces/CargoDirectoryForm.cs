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
        CargoRepository cargoRepository; 

        public CargoDirectoryForm()
        {
            InitializeComponent();
            cargoRepository = mc.GetCargoRepository();

            dataGridView1.DataSource = cargoRepository.GetCargoDTO() ;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            List<CargoDTO> tempList = cargoRepository.GetCargoDTO();
            tempList.Add(new CargoDTO());
            dataGridView1.DataSource = tempList;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var tempCargo = (List<CargoDTO>)dataGridView1.DataSource;
            Cargo t = tempCargo[tempCargo.Count - 1];
            cargoRepository.InsertCargo(t);

            List<CargoDTO> tempList = cargoRepository.GetCargoDTO();
            tempList.Add(new CargoDTO());
            dataGridView1.DataSource = tempList;

        }
    }
}

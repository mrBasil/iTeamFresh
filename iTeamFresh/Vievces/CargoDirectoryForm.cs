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

            dataGridView1.DataSource =  cargoRepository.GetCargo() ;
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            List<Cargo> tempList = cargoRepository.GetCargo();
            tempList.Add(new Cargo());
            dataGridView1.DataSource = tempList;
            

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var tempCargo = (List<Cargo>)dataGridView1.DataSource;
            Cargo t = tempCargo[tempCargo.Count - 1];
            cargoRepository.InsertCargo(t);

            List<Cargo> tempList = cargoRepository.GetCargo();            
            dataGridView1.DataSource = tempList;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int? selectedRows = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            if (selectedRows != null)
            {
                cargoRepository.DeleteCargo(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                dataGridView1.DataSource = cargoRepository.GetCargo();
            }
            else {

                MessageBox.Show("chouse the Rowse");
            }
            
            
        }
                
    }
}

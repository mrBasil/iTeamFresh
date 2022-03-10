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
using iTeamFresh.Vievces;

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
        private void updateDataGrid(object sender, EventArgs e) {
            dataGridView1.DataSource = cargoRepository.GetCargo();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            Form cargoEdit = new CargoEditForm(new Cargo());
            cargoEdit.Show();
            cargoEdit.FormClosed += updateDataGrid;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var cargo = dataGridView1.SelectedRows[0].DataBoundItem as Cargo;
            Form cargoEdit = new CargoEditForm(cargo);
            cargoEdit.Show();
            cargoEdit.FormClosed += updateDataGrid;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            int selectedRows = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            if (selectedRows != null)
            {
                DialogResult result = MessageBox.Show("delete?*", string.Format("delete the cargo : {0}*", cargoRepository.GetCargo(selectedRows).NAME, MessageBoxButtons.YesNo));
                if (result == DialogResult.Yes)
                {
                    cargoRepository.DeleteCargo(selectedRows);
                    dataGridView1.DataSource = cargoRepository.GetCargo();
                }
                else {
                    Console.WriteLine("No");
                }
            }
            else {

                MessageBox.Show("chouse the Rowse");
            }
            
            
        }
                
    }
}

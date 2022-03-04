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
    public partial class ClientsDirectoryForm : Form
    {
        MainClas mc = Program.mc;

        ClientRepository clientRepository;

        public ClientsDirectoryForm()
        {
            InitializeComponent();

            clientRepository = mc.GetClientRepository();

            dataGridView1.DataSource = clientRepository.GetClient();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var clientEditForm = new ClientForms.ClientEditForm(new Client());
            clientEditForm.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            var client = dataGridView1.SelectedRows[0].DataBoundItem as Client;
            var clietnEditForm = new ClientForms.ClientEditForm(client);
            clietnEditForm.Show();
            
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}

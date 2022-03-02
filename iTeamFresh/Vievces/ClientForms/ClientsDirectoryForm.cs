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
            
            var clietns = clientRepository.GetClient();
            clietns.Add(new Client());
            dataGridView1.DataSource = clietns;
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            var tempClientS = (List<Client>)dataGridView1.DataSource;
            Client client = tempClientS.Last();
            
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}

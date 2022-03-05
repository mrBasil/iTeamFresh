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

namespace iTeamFresh.Vievces.ClientForms
{
    public partial class ClientEditForm : Form
    {
        private Client client;

        public ClientEditForm()
        {
            InitializeComponent();
            SetAll();
        }

        public ClientEditForm(Client client) 
        {
            InitializeComponent();
            this.client = client;
            SetAll();
        }

        private void SetAll() 
        {
            textBox_name.Text = client.NAME;
            textBox_inn.Text = client.INN;
            textBox_KPP.Text = client.KPP;
            textBox_egrul.Text = client.EGRUL;
            textBox_adress.Text = client.ADDRESS;
            textBox_note.Text = client.NOTE;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}

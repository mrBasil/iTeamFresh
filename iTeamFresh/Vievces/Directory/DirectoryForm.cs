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

namespace iTeamFresh.Vievces.Directory
{
    public partial class DirectoryForm : Form
    {
        DataBase.CargoRepository CargoRepository;
        DataBase.ClientRepository ClientRepository;
        DataBase.TransportRepository TransportRepository;
        int indexDirectory=0; //Числовое представление справочника
                            // 1-Cargo, 2-Client , 3-Transport , 4-Operators 
        public DirectoryForm(DataBase.CargoRepository data)
        {
            InitializeComponent();
            dgvDirectory.AutoGenerateColumns = false;
            dgvDirectory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Visible = false
            });
            dgvDirectory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NAME",
                HeaderText = "Название",
                Visible = true
            });
            dgvDirectory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ARTICLE_NUMBER",
                HeaderText = "Артикл",
                Visible = true
            });
            CargoRepository = data;
            indexDirectory = 1;
            dgvDirectory.DataSource = data.GetCargo();
        }
        public DirectoryForm(DataBase.ClientRepository data)
        {
            InitializeComponent();
            dgvDirectory.AutoGenerateColumns = false;
            dgvDirectory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Visible = false
            });
            dgvDirectory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NAME",
                HeaderText = "Название",
                Visible = true
            });
            dgvDirectory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "INN",
                HeaderText = "ИНН",
                Visible = true
            });
            ClientRepository = data;
            indexDirectory = 2;
            dgvDirectory.DataSource = data.GetClient();
        }
        public DirectoryForm(DataBase.TransportRepository data)
        {
            InitializeComponent();
            dgvDirectory.AutoGenerateColumns = false;
            dgvDirectory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Visible = false
            });
            dgvDirectory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NUMBER_TRANSPORT",
                HeaderText = "Номер ТС",
                Visible = true
            });
            dgvDirectory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DRIVER",
                HeaderText = "Водитель",
                Visible = true
            });
            TransportRepository = data;
            indexDirectory = 3;
            dgvDirectory.DataSource = data.GetTransport();
        }        
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            switch (indexDirectory)
            {
                case 1:
                    var frmCargoEdit = new CargoEditForm(new Cargo());
                    frmCargoEdit.FormClosed += (object s, FormClosedEventArgs args) => // Получение события закрытия страницы 
                    {
                        dgvDirectory.DataSource = CargoRepository.GetCargo();
                    };
                    frmCargoEdit.ShowDialog();                    
                    break;
                case 2:
                    var frmClientEdit = new ClientForms.ClientEditForm(new Client());
                    frmClientEdit.FormClosed += (object s, FormClosedEventArgs args) => // Получение события закрытия страницы 
                    {
                        dgvDirectory.DataSource = ClientRepository.GetClient();
                    };
                    frmClientEdit.ShowDialog();                    
                    break;
                case 3:
                    dgvDirectory.DataSource = TransportRepository.GetTransport();
                    break;
                case 4:

                    break;
            }           
        }
    }
}

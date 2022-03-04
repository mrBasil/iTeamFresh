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
    public partial class CargoEditForm : Form
    {
        MainClas mc = Program.mc;
        CargoRepository cargoRepository;
        private Cargo cargo;        

        public CargoEditForm()
        {
            cargoRepository = mc.GetCargoRepository();
            InitializeComponent();

            GetAllClients();
        }

        public CargoEditForm(Cargo cargo)
        {
            this.cargo = cargo;
            cargoRepository = mc.GetCargoRepository();
            InitializeComponent();

            GetAllClients();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cargo.NAME = textBox_name.Text;

            cargo.DIRT = textBox_dirt.TextLength > 0 ? float.Parse(textBox_dirt.Text) : 0;

            cargo.PRICE = textBox_price.TextLength > 0 ? float.Parse(textBox_price.Text) : 0;

            cargo.ARTICLE_NUMBER = textBox_articul.TextLength > 0 ? textBox_articul.Text : null;

            cargo.NOTE = textBox_note.TextLength > 0 ? textBox_note.Text : null;

            try
            {
                cargo.CARGO_CARRIER_LINK = int.Parse(comboBox_carrier.SelectedValue != null ? comboBox_carrier.SelectedValue.ToString() : null);

                cargo.CARGO_RECIPIENT_LINK = int.Parse(comboBox_recipient.SelectedValue.ToString());

                cargo.CARGO_SENDER_LINK = int.Parse(comboBox_sender.SelectedValue.ToString());

                cargo.CARGO_SUPPLIER_LINK = int.Parse(comboBox_suplier.SelectedValue.ToString());
            }
            catch {
                Console.WriteLine("Короче значение в комбобоксах не определены для ссылок на справочники клиентов CargoEditForm btn_save");
            }

            if (cargo.ID == null)
                cargoRepository.InsertCargo(cargo);
            else
                cargoRepository.UpdateCargo(cargo);

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetAllClients() {

            var clientRepository = mc.GetClientRepository();            

            comboBox_sender.DataSource = clientRepository.GetClient();
            comboBox_suplier.DataSource = clientRepository.GetClient();
            comboBox_recipient.DataSource = clientRepository.GetClient();
            comboBox_carrier.DataSource = clientRepository.GetClient();

            if (cargo.ID != null) 
            {  
                if(cargo.CARGO_SUPPLIER_LINK != null)
                    comboBox_suplier.SelectedValue = cargo.CARGO_SUPPLIER_LINK;
                if(cargo.CARGO_SENDER_LINK != null)
                    comboBox_sender.SelectedValue = cargo.CARGO_SENDER_LINK;
                if(cargo.CARGO_RECIPIENT_LINK != null)
                    comboBox_recipient.SelectedValue = cargo.CARGO_RECIPIENT_LINK;
                if(cargo.CARGO_CARRIER_LINK != null)
                    comboBox_carrier.SelectedValue = cargo.CARGO_CARRIER_LINK;            
            }
            textBox_articul.Text = cargo.ARTICLE_NUMBER;
            textBox_dirt.Text = cargo.DIRT+"";
            textBox_price.Text = cargo.PRICE + "";
            textBox_name.Text = cargo.NAME;
            textBox_note.Text = cargo.NOTE;
        }
    }
}

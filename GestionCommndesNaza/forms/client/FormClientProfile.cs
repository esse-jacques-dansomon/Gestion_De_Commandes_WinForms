using GestionCommndesNaza.models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.client
{
    public partial class FormClientProfile : Form
    {

        public Client ClientConnected;

        public FormClientProfile(Client clientConnectedOP)
        {
            InitializeComponent();
            ClientConnected = clientConnectedOP;
            this.loadUserInformations();
            loadAdresseDataGriewView();

            this.userInformationsForm1.OnEdit += (ss, ee) =>
            {
                this.loadUserInformations();
            };

        }

        private void FormClientProfile_Load(object sender, EventArgs e)
        {
            adressForm.OnSaveButton += (ss, ee) =>
            {
                loadAdresseDataGriewView();
            };

        }

        void loadAdresseDataGriewView()
        {
            Model1Container container = new Model1Container();
            this.DataGridViewAddresses.AutoGenerateColumns = false;
            this.DataGridViewAddresses.DataSource = container.Addresses.Where(s => s.ClientId == ClientConnected.Id).ToArray();
        }

        void loadUserInformations()
        {
            this.userInfoCard.cardUserName.Text = ClientConnected.Firstname + " " + ClientConnected.Lastname;
            this.userInfoCard.cardUserPhone.Text = ClientConnected.Phone;
            this.userInfoCard.cardUserRoleName.Text = ClientConnected.Role;
            this.userInformationsForm1.SetUserInfo(ClientConnected);
            if (ClientConnected.Avatar != null)
            {
                this.userInfoCard.CardUserAvatarButton.Image = utils.ImageUtils.convertByteToImage(ClientConnected.Avatar);
            }
            //Statitiques nombre de commnades
            this.dansboardCardOrder.Libelle.Text = "Number of Orders";
            this.dansboardCardOrder.LibelleValue.Text = ClientConnected.Orders.Count.ToString() + " orders";
            //Statitiques solde
            this.dansboardCardSlde.Libelle.Text = "Solde";
            this.dansboardCardSlde.LibelleValue.Text = ClientConnected.Solde.ToString() + "$";
            //Statitiques nombre de commnade du mois
            this.dansboardCardIOrderMonth.Libelle.Text = "Orders of Month";
            this.dansboardCardOrder.LibelleValue.Text = ClientConnected.Orders.Count.ToString() + " orders";
            //Statitiques solde
            this.dansboardCardMessages.Libelle.Text = "Message";
            this.dansboardCardSlde.LibelleValue.Text = ClientConnected.Solde.ToString() + "$";
        }

        private void DataGridViewAddresses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewAddresses.Rows[e.RowIndex];
                string  m0 = row.Cells[0].Value.ToString();
                string m1 = row.Cells[1].Value.ToString();
                string m2 = row.Cells[2].Value.ToString();
                string m3 = row.Cells[3].Value.ToString();
                this.adressForm.bindForm(new Address
                {
                    Zone = m0,
                    City = m1,
                    Country = m2,
                    PostCode = m3
                });


            }
        }
    }

}

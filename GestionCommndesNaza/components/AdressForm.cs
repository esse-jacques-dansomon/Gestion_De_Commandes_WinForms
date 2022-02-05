using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using System;
using System.Windows.Forms;

namespace GestionCommndesNaza.components
{
    public partial class AdressForm : UserControl
    {
        public event EventHandler OnSaveButton = null;

        private Model1Container container = new Model1Container();

        public AdressForm()
        {
            InitializeComponent();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        public void AdresseSavebutton_Click(object sender, EventArgs e)
        {
            if (adresseZone.Text == null || AdresseCountry.SelectedItem == null)
            {
                MessageBox.Show("Le champ Zone ne peut pas etre nul");
            }
            else
            {
                Address adresse = new Address
                {
                    City = adresseCity.Text,
                    Country = AdresseCountry.SelectedItem.ToString(),
                    Zone = adresseZone.Text,
                    PostCode = AdressePostal.Text,
                    //Client = (Client)FormLogin.userConnected,
                    ClientId = FormLogin.userConnected.Id
                };
                this.container.Addresses.Add(adresse);
                container.SaveChanges();
                this.OnSaveButton.Invoke(sender, e);

                MessageBox.Show($"Adresse bien ajouter { AdresseCountry.SelectedItem.ToString()}");

            }

        }

        public void bindForm(Address address)
        {
            adresseCity.Text = address.City;
            AdresseCountry.SelectedItem = address.Country;
            adresseZone.Text = address.Zone;
            AdressePostal.Text = address.PostCode;
        }
    }
}

using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using GestionCommndesNaza.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.client
{
    public partial class FormClientCheckout : Form
    {
        public event EventHandler OnMakeOrserSuccess = null;

        public FormClientCheckout()
        {
            InitializeComponent();
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            if(this.guna2ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une adresse");
            }
            else
            {
                Address adresse = (Address)this.guna2ComboBox1.SelectedItem;
                CartService cartService = new CartService();
                string refo = cartService.MakeOrder(adresse, this.moreInformations.Text, double.Parse(PriceTotal.Text.Replace("$", "").ToString()));
                OnMakeOrserSuccess.Invoke(sender, e);

                this.Close();
            }
        }


    }
}

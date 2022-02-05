using GestionCommndesNaza.forms.client;
using GestionCommndesNaza.models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionCommndesNaza.components
{
    public partial class OrderDetailtem : UserControl
    {
        public event EventHandler OnRemove = null;
        private double priceUnitaire;
        private Product product;

        public OrderDetailtem(Product product)
        {
            InitializeComponent();
            this.product = product;
            Libelle = product.Libelle;
            Price = product.Price.ToString("C2");
            Qte = 1;
            PriceUnitaire = product.Price;
        }

        public String Libelle { get => this.labalProductName.Text; set => this.labalProductName.Text = value; }
        public String Price { get => this.labelPriceUnitaire.Text; set => this.labelPriceUnitaire.Text = value; }
        public int Qte { get => int.Parse(this.QteUpdateButton.Value.ToString()); set => QteUpdateButton.Value = value; }
        public double PriceUnitaire { get => priceUnitaire; set => priceUnitaire = value; }
        public Product Product { get => product; set => product = value; }

        private void PemoveProductInCart_Click(object sender, EventArgs e)
        {
            //OnSelect.Invoke(this, e);
            OnRemove.Invoke(this, e);
            FormClientDashboard.Panier.Remove(this);
        }
        private void QteUpdateButton_ValueChanged(object sender, EventArgs e)
        {
            //OnSelect.Invoke(this, e);
            OnRemove.Invoke(this, e);
            Price = (product.Price * Qte).ToString("C2");
            FormClientDashboard.totalPanier = FormClientDashboard.Panier.Sum(s => double.Parse(s.Price.Replace("$", "").ToString()));
        }
    }



}

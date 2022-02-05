using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using GestionCommndesNaza.utils;
using System;
using System.Windows.Forms;

namespace GestionCommndesNaza.components
{
    public partial class OrderOfClient : UserControl
    {
        private Order order;
        public event EventHandler OnSelect = null;
        public event EventHandler OnPayClick = null;
        public event EventHandler OnChangeE = null;
        private Model1Container container = new Model1Container();


        public OrderOfClient(Order order)
        {
            InitializeComponent();
            this.Order = order;
            container = new Model1Container();
            loadOrder();
        }

        void loadOrder()
        {
            Ref = order.Reference;
            Total = order.Total.ToString("C2");
            Statut = order.Statut;
            OrderedAt = $"{order.CreatedAt.Value.Date.Day}-{order.CreatedAt.Value.Date.Month}-{order.CreatedAt.Value.Date.Year}";
            if (order.Statut == "Éffectue")
                this.ButtonCancel.Enabled = true;
            if (order.Statut == "Livrer")
                this.ButtonRecue.Enabled = true;
            if (order.Statut == "Recue")
                this.ButtonPay.Enabled = true;
            if (Order.Statut == "Termine" || Order.Statut == "Payer")
                this.ButtonIvoice.Enabled = true;
        }

        public string Ref { get => labelReference.Text; set => labelReference.Text = value; }
        public string Total { get => labelTotal.Text; set => labelTotal.Text = value; }
        public string Statut { get => labelSatatus.Text; set => labelSatatus.Text = value; }
        public string OrderedAt { get => labelDate.Text; set => labelDate.Text = value; }
        public Order Order { get => this.order; set => this.order = value; }

        private void OrderOfClient_Click(object sender, EventArgs e)
        {
            OnSelect.Invoke(this, e);
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            changeStatusOrder("Recue");
            this.ButtonRecue.Enabled = false;
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            OrderPayement userControl11 = new OrderPayement(this.Order);
            Form window = new Form();
            window.Controls.Add(userControl11);
            window.StartPosition = FormStartPosition.CenterScreen;
            window.Size = userControl11.Size;
            window.FormBorderStyle = FormBorderStyle.None;
            window.ShowDialog();
            changeStatusOrder("Payer");
            this.ButtonPay.Enabled = false;
            this.ButtonIvoice.Enabled = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            changeStatusOrder("Annuler");
            this.ButtonCancel.Enabled = false;
        }


        void changeStatusOrder(string statut)
        {
            Order ord = container.Orders.Find(order.Id);
            ord.Statut = statut;
            container.SaveChanges();
            MessageBox.Show("Etat de commnde bien modifié");
            this.order = ord;
            this.Validate();
            this.ValidateChildren();
            loadOrder();
        }

        private void ButtonIvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voici votre Recue");

        }
    }
}

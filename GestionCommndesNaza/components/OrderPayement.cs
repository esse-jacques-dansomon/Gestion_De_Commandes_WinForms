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

namespace GestionCommndesNaza.components
{
    public partial class OrderPayement : UserControl
    {

        private Order order1;
        public event EventHandler OnPay = null;
        private Model1Container container = new Model1Container();

        public OrderPayement(Order order)
        {
            InitializeComponent();
            order1 = order;
            container = new Model1Container();
            ReferenceOrder.Text = order.Reference;
            PriceTotal.Text = order.Total.ToString("C1");
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            Order od = container.Orders.Find(order1.Id);
            Payment payement = new Payment
            {
                Order = od,
                Amount = od.Total,
                Type = comboBoxType.SelectedItem.ToString(),
                Reference = ReferencePayememt.Text,
                Numero = numero.Text,
                PaidAt = DateTime.Now
            };
            container.Payments.Add(payement);
            container.SaveChanges();
            MessageBox.Show("Paiment Reussie");
            //Envoie de Mail
            string email = FormLogin.userConnected.Login;
            string name = $"{ FormLogin.userConnected.Lastname}   { FormLogin.userConnected.Firstname}";
            string objet = $"Paiment de la Commande Ref {order1.Reference}  Chez Naza";
            string message = $"Le Paiment de votre commande de reference {order1.Reference} á eté bien acceptée ";
            EmailSender.SendMail(email, name, objet, message);
            //envoie mail admin
        }

    }

}

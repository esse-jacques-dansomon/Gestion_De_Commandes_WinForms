using GestionCommndesNaza.components;
using GestionCommndesNaza.forms.client;
using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace GestionCommndesNaza.utils
{
    class CartService
    {
        /*
         * CART = SESSION['cart']
         * CART =
         * [
         *      productId1 => OrderDetailtem1
         *      productId2 => OrderDetailtem2
         *      productId3 => OrderDetailtem3
         * ]
         */
        private Model1Container container = new Model1Container();

        private static Dictionary<Int32, OrderDetailtem> cart = new Dictionary<Int32, OrderDetailtem>();
        public void addToCard(OrderDetailtem w, int qte = 1)
        {
            if (CartService.cart.ContainsKey(w.Product.Id))
                w.Qte += qte;
            else
                CartService.cart.Add(w.Product.Id, w);

        }


        public void removeFromCart()
        {

        }


        public void getCart()
        {

        }

        public string MakeOrder(Address adress, string moreInformations, double total)
        {

            string orderRef = Faker.Identification.BulgarianPin();
            if (FormClientDashboard.Panier.Count > 0)
            {
                Order oder = new Order
                {
                    MoreInformations = moreInformations,
                    ClientId = FormLogin.userConnected.Id,
                    CreatedAt = DateTime.Now,
                    SubTotal = total,
                    Taxe = 0.18,
                    Total = total * 0.18 + total,
                    Statut = "Éffectue",
                    Reference = orderRef,
                    Description = "Vortre commnde á été bien recué"
                };

                // MessageBox.Show($" Make Order {  total }");
                container.Orders.Add(oder);
                foreach (OrderDetailtem item in FormClientDashboard.Panier)
                {
                    OrderDetail orderDetail = new OrderDetail
                    {
                        OrderId = oder.Id,
                        ProductId = item.Product.Id,
                        Qantity = (short)item.Qte,
                    };
                    container.OrderDetails.Add(orderDetail);
                }
               container.SaveChanges();
                //Envoie de Mail
                string email = FormLogin.userConnected.Login;
                string name = $"{ FormLogin.userConnected.Lastname}   { FormLogin.userConnected.Firstname}";
                string objet = "Commande Chez Naza";
                string message = $"Votre commande de reference {orderRef} á eté bien acceptée " +
                    $" et sera bientot expedidié á l'adresse {adress.Zone} ";
                EmailSender.SendMail(email, name, objet, message);
            }
            return orderRef;

        }

    }


}

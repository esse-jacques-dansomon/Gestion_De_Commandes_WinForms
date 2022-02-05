using GestionCommndesNaza.components;
using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using GestionCommndesNaza.service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.client
{
    public partial class FormClientOrdersAndPaies : Form
    {
        private IService service = fabrique.Fabrique.GetServiceInstance();
        private Model1Container container;
        private Client client = (Client)FormLogin.userConnected;
        public FormClientOrdersAndPaies()
        {
            InitializeComponent();
            client = (Client)FormLogin.userConnected;
            Model1Container container = new Model1Container();
            List<Order> orders = container.Orders.Where(o => o.ClientId == FormLogin.userConnected.Id).OrderByDescending(o => o.CreatedAt).ToList();
            LoadOrderFlowLayoutPanel(orders);
            loadPayementDetailsGridView();
        }

        public void LoadOrderFlowLayoutPanel(List<Order> orders)
        {
            foreach (Order order in orders)
            {
                OrderOfClient orderOfClient = new OrderOfClient(order);
                flowLayoutPanel1.Controls.Add(orderOfClient);
                orderOfClient.OnSelect += (ss, ee) =>
                {
                    loadOrderDetailsGridView(orderOfClient.Order);
                };

                orderOfClient.OnChangeE += (ss, ee) =>
                {
                   // LoadOrderFlowLayoutPanel(orders);
                    loadOrderDetailsGridView(orderOfClient.Order);
                    loadPayementDetailsGridView();
                };
            }
        }

        private void loadOrderDetailsGridView(Order order)
        {
            dataGridViewOrderDetails.Rows.Clear();

            foreach (OrderDetail orderDetail in order.OrderDetails)
            {
                dataGridViewOrderDetails.Rows.Add(
                new Object[] 
                    { orderDetail.Product.Libelle,
                        orderDetail.Product.Price.ToString("C2"),
                        orderDetail.Qantity,
                        (orderDetail.Qantity * orderDetail.Product.Price).ToString("C2")
                }
               );

            }
        }

        private void loadPayementDetailsGridView()
        {
            //PayementDatagriewView.Rows.Clear();

            Model1Container container = new Model1Container();

            List<Order> orders = container.Orders.Where(o => o.ClientId == FormLogin.userConnected.Id)
                .Where(o => o.Statut == "Payer")
                .OrderByDescending(o => o.Payment.PaidAt).ToList();
            foreach (Order pay in orders)
            {
                PayementDatagriewView.Rows.Add(
                new Object[]
                { 
                    pay.Reference??"",
                    pay.Payment.Reference,
                    pay.Total.ToString("C2")??"",
                    pay.Payment.Type??"",
                    pay.Payment.Numero??"",
                    pay.Payment.PaidAt.GetValueOrDefault(pay.CreatedAt.Value),
                }
               );

            }
        }
    }
}

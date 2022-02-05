using GestionCommndesNaza.models;
using GestionCommndesNaza.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.manager
{
    public partial class FormManagerOrders : Form
    {
        private IService service = fabrique.Fabrique.GetServiceInstance();
        Model1Container container = new Model1Container();
        private List<Product> products = new List<Product>();
        private Order orderSeleted;

        public FormManagerOrders()
        {
            InitializeComponent();
            //this.gunaAdvenceButton1.Enabled = false;
            loadOrderDataGridView(service.searchOrdersByEtat("En Attente de Packding"));
        }

        void loadOrderDataGridView(List<Order> listesOrder)
        {
            this.dataGridViewOrders.DataSource = null;
            if (listesOrder.Count == 0)
                MessageBox.Show("Pas de order avec ce filtre");
            else
            {
                this.dataGridViewOrders.AutoGenerateColumns = false;
                this.dataGridViewOrders.DataSource = listesOrder.ToArray();
            }
  
        }


        void loadOrderDetailsGridView(Order order)
        {
            dataGridViewProductsQte.Rows.Clear();
            products.Clear();
            if (order != null)
            {
                foreach (OrderDetail orderDetail in order.OrderDetails)
                {
                    string statut = (orderDetail.Qantity > orderDetail.Product.Stock) ? "No Diponible" : "Diponible";
                    if (orderDetail.Qantity > orderDetail.Product.Stock)
                    {
                        orderDetail.Product.Statut = "EN RUPTURE DE STOCK";
                        products.Add(orderDetail.Product);
                    }
                    dataGridViewProductsQte.Rows.Add(
                    new Object[]
                    {
                        orderDetail.Product.Libelle,
                        orderDetail.Product.Stock,
                        orderDetail.Qantity,
                        statut
                    }
                   );

                }
            }

        }

        void loadComboxBod()
        {
            this.ComboBoxDelivers.DataSource = container.Users.Where(u => u.Role == "ROLE_DELIVER").ToArray();
        }


        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Order order = container.Orders.Find(orderSeleted.Id);
            order.Statut = "A Livrer";
            order.Description = "En Attent de livraison";
            //Update du solde du client
            Client client = (Client)container.Users.Find(order.ClientId);
            client.Solde += order.Total;
            //Recuperer un Deliver
            Deliver deliver = (Deliver)this.ComboBoxDelivers.SelectedItem;

            Deliver deliverSelected = (Deliver)container.Users.Find(deliver.Id);
            //order.Delivery.
            Delivery delivery = new Delivery
            {
                Date = DateTime.Now,
                Order = order,
                Deliver = deliverSelected,
                DeliverId = deliverSelected.Id,
            };
            container.Deliveries.Add(delivery);
            //FIn Order delivery
            order.Delivery = delivery;
            container.SaveChanges();

            //Reduire le stock
            foreach (OrderDetail orderDetail in order.OrderDetails)
            {
                Product p = container.Products.Find(orderDetail.ProductId);
                p.Stock = p.Stock - orderDetail.Qantity;
                container.SaveChanges();
            }
            //FIn reduire commande

            MessageBox.Show("Livraison Bien Progamee");
            loadOrderDataGridView(service.searchOrdersByEtat("En Attente de Packding"));

        }

        private void dataGridViewOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderSeleted = (Order)dataGridViewOrders.Rows[e.RowIndex].DataBoundItem;
            if (orderSeleted != null)
            {
                loadOrderDetailsGridView(orderSeleted);
                loadComboxBod();
            }
        }

        private void ComboBoxFiltreOrderByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statut = this.ComboBoxFiltreOrderByStatus.SelectedItem.ToString();
            MessageBox.Show(statut);
            this.loadOrderDataGridView(service.searchOrdersByEtat(statut));
            if(statut == "Stock Indisponible")
            {
                this.gunaAdvenceButton1.Enabled = false;
            }else
                this.gunaAdvenceButton1.Enabled = true;

        }
    }
}

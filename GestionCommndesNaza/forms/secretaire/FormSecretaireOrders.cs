using GestionCommndesNaza.models;
using GestionCommndesNaza.service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.secretaire
{
    public partial class FormSecretaireOrders : Form
    {
        private IService service = fabrique.Fabrique.GetServiceInstance();
        Model1Container container = new Model1Container();
        private List<Product> products = new List<Product>();
        private Order orderSeleted;
        public FormSecretaireOrders()
        {
            InitializeComponent();
            this.gunaAdvenceButton1.Enabled = false;

            loadOrderDataGridView(service.searchOrdersByEtat("Éffectue"));

        }

        void loadOrderDataGridView(List<Order> listesOrder)
        {
            this.dataGridViewOrders.DataSource = null;
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.DataSource = listesOrder.ToArray();
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
            List<string> status = new List<string>();
            this.ComboBoxOrderStatut.DataSource = null;
            if (products.Count > 0)
                status.Add("Stock Indisponible");
            else
                status.Add("En Attente de Packding");
            this.ComboBoxOrderStatut.DataSource = status.ToArray();
            this.ComboBoxOrderStatut.Enabled = false;
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderSeleted = (Order)dataGridViewOrders.Rows[e.RowIndex].DataBoundItem;
            if (orderSeleted != null)
            {
                this.gunaAdvenceButton1.Enabled = true;
                loadOrderDetailsGridView(orderSeleted);
                loadComboxBod();
            }
            else
                this.gunaAdvenceButton1.Enabled = false;


        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            string statut = ComboBoxOrderStatut.SelectedItem.ToString();
            Order order = container.Orders.Find(orderSeleted.Id);
            order.Statut = statut;
            order.Description = this.textBoxOrderMessage.Text;
            container.SaveChanges();
            String listProductRupeStock = "";
            if (products.Count == 0)
                MessageBox.Show(statut); //Envoie de Mail
            else
            {
                MessageBox.Show(listProductRupeStock); //Changement de status des produits
                foreach (Product product in this.products)
                {
                    listProductRupeStock += $"\n Product : {product.Libelle} ";
                    Product p = container.Products.Find(product.Id);
                    p.Statut = "Rupture de Stock";
                   // product.Statut = "Rupture de Stock";
                }
                container.SaveChanges();

                listProductRupeStock += $"Ref Commnade : {order.Reference}";
                products.Clear();
                MessageBox.Show(listProductRupeStock);

            }

            orderSeleted = null;
            this.gunaAdvenceButton1.Enabled = false;
            this.loadOrderDataGridView(service.searchOrdersByEtat("Éffectue"));
            this.loadOrderDetailsGridView(orderSeleted);
        }
    }

}

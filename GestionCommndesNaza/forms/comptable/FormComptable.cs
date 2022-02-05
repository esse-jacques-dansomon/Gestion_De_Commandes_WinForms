using GestionCommndesNaza.forms.security;
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

namespace GestionCommndesNaza.forms.comptable
{
    public partial class FormComptable : Form
    {
        private IService service = fabrique.Fabrique.GetServiceInstance();
        Model1Container container = new Model1Container();
        private List<Product> products = new List<Product>();
        private Order orderSeleted;
        public FormComptable()
        {
            InitializeComponent();
            loadOrderDataGridView(service.searchOrdersByEtat("A Livrer"));
            loadPaymentDataGridView();
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

        void loadPaymentDataGridView()
        {
            this.DataGridViewPayament.DataSource = null;
            this.DataGridViewPayament.AutoGenerateColumns = false;
            this.DataGridViewPayament.DataSource = container.Payments.ToArray();

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statut = this.gunaComboBox1.SelectedItem.ToString();
            this.loadOrderDataGridView(service.searchOrdersByEtat(statut));
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderSeleted = (Order)dataGridViewOrders.Rows[e.RowIndex].DataBoundItem;
            DialogResult dialogResult = MessageBox.Show($"Confirmer que la commande est recue? ", "Suppression", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Order order = container.Orders.Find(orderSeleted.Id);
                if (order.Statut == "A Livrer")
                {
                    order.Statut = "Livrer";
                    container.SaveChanges();
                    MessageBox.Show("Etat de commande bien modifie");
                }

                MessageBox.Show("Operation impoossible");

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operation annuler");

            }
        }
    }
}

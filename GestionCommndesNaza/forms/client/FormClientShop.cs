using GestionCommndesNaza.components;
using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.client
{
    public partial class FormClientShop : Form
    {
        private Client ClientConnected;
        private Model1Container container = new Model1Container();
        private List<Product> dbProducts;
        private int thumbsPerPage = 20;
        private int currentPageOn = 1;
        private int pageTotal;

        public FormClientShop(Client client)
        {
            InitializeComponent();
            ClientConnected = client;
            initialise();

        }

        void initialise()
        {
            dbProducts = container.Products.ToList();
            var opopo = Math.Ceiling(decimal.Parse(dbProducts.Count.ToString()) / thumbsPerPage);
            pageTotal = int.Parse(opopo.ToString());
            this.comboBoxCategory.DataSource = container.Categories.ToList();
          //  comboBoxCategory.DisplayMember = "Libelle";

            if (FormClientDashboard.Panier.Count > 0)
            {
                RechargeCart();
                CalculTotal();
            }
        }

        private void FormClientShop_Load(object sender, EventArgs e)
        {
            ClientConnected = (Client)FormLogin.userConnected;
            loadProduct(dbProducts);
            initialise();

        }

        void loadProduct(List<Product> listePoducts)
        {
            if (listePoducts.Count == 0)
            {
                listePoducts = dbProducts;
            }
            this.flowLayoutShopPanel.Controls.Clear();
            for (int i = (this.currentPageOn - 1) * thumbsPerPage; i < (currentPageOn * thumbsPerPage) - 1; i++)
            {
                if (i < listePoducts.Count)
                {
                    addProductItem(listePoducts[i]);
                }
            }
            var opopo = Math.Ceiling(decimal.Parse(listePoducts.Count.ToString()) / thumbsPerPage);
            pageTotal = int.Parse(opopo.ToString());
            this.currentPage.Text = $"{currentPageOn} / {pageTotal}  ";
            this.CalculTotal();

            return;

        }

        private void addProductItem(Product product)
        {
            ProductItem w = new ProductItem(product);
            flowLayoutShopPanel.Controls.Add(w);

            w.Onselect += (ss, ee) =>
            {
                foreach (OrderDetailtem item in FormClientDashboard.Panier)
                {
                    if (item.Libelle == w.Libelle)
                    {
                        item.Qte += 1;
                        CalculTotal();
                        return;
                    }

                }
                OrderDetailtem odi = new OrderDetailtem(w.Product);
                this.flowLayoutPanelOderDetailItem.Controls.Add(odi);
                FormClientDashboard.Panier.Add(odi);
                CalculTotal();
                odi.OnRemove += (ss1, ee1) =>
                {

                    this.RechargeCart();
                    CalculTotal();
                };

            };

        }
        void CalculTotal()
        {
            double total2 = FormClientDashboard.Panier.Sum(s => double.Parse(s.Price.Replace("$", "").ToString()));
            int carttotalItems = FormClientDashboard.Panier.Sum(s => s.Qte);
            FormClientDashboard.totalPanierItems = total2;
            FormClientDashboard.totalPanierItems = carttotalItems;
            this.totalPrice.Text = total2.ToString("C2");
            this.totalCartItems.Text = carttotalItems.ToString();
            if (carttotalItems == 0)
                this.ButtonOrder.Enabled = false;
            else
                this.ButtonOrder.Enabled = true;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in this.flowLayoutShopPanel.Controls)
            {
                var productItem = (ProductItem)item;
                productItem.Visible = productItem.Libelle.ToLower().ToLower().Contains(txtSearch.Text.ToLower().Trim());
            }
        }

        private void RechargeCart()
        {
            this.flowLayoutPanelOderDetailItem.Controls.Clear();
            foreach (OrderDetailtem item in FormClientDashboard.Panier)
            {
                this.flowLayoutPanelOderDetailItem.Controls.Add(item);
            }
            this.CalculTotal();
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            this.CalculTotal();
        }

        private void suiv_Click(object sender, EventArgs e)
        {

            if (this.currentPageOn < pageTotal)
                this.currentPageOn += 1;
            else
                this.currentPageOn = 1;
            loadProduct(dbProducts);

        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (this.currentPageOn > 1)
                this.currentPageOn -= 1;
            else
                this.currentPageOn = this.pageTotal;
            loadProduct(dbProducts);

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category a = (Category)comboBoxCategory.SelectedItem;
            loadProduct(a.Products.ToList());
        }

        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            this.comboBoxCategory.DataSource = container.Categories.ToList();
            this.currentPageOn = 1;

            loadProduct(dbProducts);

        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            FormClientCheckout userControl11 = new FormClientCheckout();
            userControl11.OnMakeOrserSuccess += (ss, ee) =>
            {

                clearCart();
                MessageBox.Show("Votre commande est bien enregistre");

            };

            if (this.ClientConnected.Addresses.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter une adresse avent de continuer");
            }
            else
            {
                userControl11.StartPosition = FormStartPosition.CenterScreen;
                userControl11.guna2ComboBox1.DataSource = this.ClientConnected.Addresses.ToArray();
                userControl11.guna2ComboBox1.DisplayMember = "Zone"; // column name that you need to display as text
                userControl11.PriceTotal.Text = FormClientDashboard.Panier.Sum(s => double.Parse(s.Price.Replace("$", "").ToString())).ToString();
                userControl11.ShowDialog();
            }

        }

        void clearCart()
        {
            flowLayoutPanelOderDetailItem.Controls.Clear();
            FormClientDashboard.Panier.Clear();
            FormClientDashboard.totalPanier = 0;
            FormClientDashboard.totalPanierItems = 0;
            this.totalCartItems.Text = "0";
            this.totalPrice.Text = "0";
        }
    }
}

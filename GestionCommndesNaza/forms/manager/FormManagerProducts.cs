using GestionCommndesNaza.models;
using GestionCommndesNaza.service;
using GestionCommndesNaza.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.manager
{
    public partial class FormManagerProducts : Form
    {
        private IService service = fabrique.Fabrique.GetServiceInstance();
        private Product productSelected;
        private List<Image> images = new List<Image>();
        private Model1Container container = new Model1Container();
        public FormManagerProducts()
        {
            InitializeComponent();
            loadProductDatagridView(service.searchAllProduct().OrderByDescending(p => p.Id).Take(20).ToList());
        }
        void loadProductDatagridView(List<Product> products)
        {
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.DataSource = products.ToArray();
            this.loadComboBoXCategorie();
        }

        void clearForm()
        {
            ProductCategoryCombobox.SelectedItem = null;
            this.ProductDescription.Clear();
            this.ProductLibelle.Clear();
            this.ProductPrice.Clear();
            this.ProductQteSeuil.Clear();
            this.ProductQteStock.Clear();
        }

        void loadComboBoXCategorie()
        {
            this.ProductCategoryCombobox.DataSource = container.Categories.ToArray();
        }
        void bindForm(Product product)
        {
            ProductCategoryCombobox.SelectedItem = product.Category;
            this.ProductDescription.Text = product.Description;
            this.ProductLibelle.Text = product.Libelle;
            this.ProductPrice.Text = product.Price.ToString();
            this.ProductQteSeuil.Text = product.QuantitySeuil.ToString();
            this.ProductQteStock.Text = product.Stock.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Multiselect = true;
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;.*.png;)|*.jpg;*.jpeg;.*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                opnfd.FileNames.ToList().ForEach(file =>
                {
                    this.PicturesBox.Image = new Bitmap(opnfd.FileName);
                    images.Add(new Bitmap(opnfd.FileName));
                    MessageBox.Show($"{i}");
                    i++;
                });
            }

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productSelected = (Product)this.guna2DataGridView1.Rows[e.RowIndex].DataBoundItem;
            bindForm(productSelected);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Category cat = (Category)this.ProductCategoryCombobox.SelectedItem;
            Product product = new Product
            {
                Libelle = ProductLibelle.Text,
                Description = ProductDescription.Text,
                Category = cat,
                Price = double.Parse(ProductPrice.Text),
                QuantitySeuil = int.Parse(ProductQteSeuil.Text),
                Stock = int.Parse(ProductQteStock.Text),
                CreatedAt = DateTime.Now,
                Statut = "Stock",
            };
            container.Products.Add(product);
            foreach (Image img in images)
            {
                Picture picture = new Picture
                {
                    Image = ImageUtils.convertImageToByte(img),
                    ProductId = product.Id,
                    Product = product,
                };
                container.Pictures.Add(picture);

            }
            container.SaveChanges();
            loadProductDatagridView(service.searchAllProduct().OrderByDescending(p => p.Id).Take(20).ToList());
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Category cat = (Category)this.ProductCategoryCombobox.SelectedItem;
            if (productSelected != null)
            {
                Product pop = container.Products.Find(productSelected.Id);
                pop.Libelle = ProductLibelle.Text;
                pop.Description = ProductDescription.Text;
                pop.Category = cat;
                pop.Price = double.Parse(ProductPrice.Text);
                pop.QuantitySeuil = int.Parse(ProductQteSeuil.Text);
                pop.Stock = int.Parse(ProductQteStock.Text);
                pop.CreatedAt = DateTime.Now;
                pop.Statut = "Stock";
                container.SaveChanges();
                loadProductDatagridView(service.searchAllProduct().OrderByDescending(p => p.Id).Take(20).ToList());

                MessageBox.Show("Produit bien modifie");
                this.clearForm();
                this.productSelected = null;

            }
            loadProductDatagridView(service.searchAllProduct().OrderByDescending(p => p.Id).Take(20).ToList());


        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (productSelected != null)
            {
                DialogResult dialogResult = MessageBox.Show( $"Confirmer la suppression du produit {productSelected.Libelle} ? ", "Suppression", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Product p = container.Products.Find(productSelected.Id);
                    container.Pictures.RemoveRange(p.Pictures);
                    container.Products.Remove(p);
                    container.SaveChanges();
                    MessageBox.Show("Produit bien Suprime");
                    this.clearForm();
                    this.productSelected = null;
                    loadProductDatagridView(service.searchAllProduct().OrderByDescending(pop => pop.Id).Take(20).ToList());

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Produit NON Suprime");

                }

            }
            else
                MessageBox.Show("Produit n'existe pas");



        }
    }

}

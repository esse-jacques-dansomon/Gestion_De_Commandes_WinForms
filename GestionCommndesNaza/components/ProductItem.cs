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
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace GestionCommndesNaza.components
{
    public partial class ProductItem : UserControl

    {
        /**
         * 
         * 
         */
        public event EventHandler Onselect = null;

        private Product product;

        public ProductItem()
        {
            InitializeComponent();
        }
        public ProductItem(Product product1)
        {
            InitializeComponent();
            this.product = product1;
            Libelle = product.Libelle;
            CategoryName = product.Category.Libelle;
            Price = product.Price.ToString("C2");
            if (product.Pictures.Count > 0)
            {
                Image = ImageUtils.convertByteToImage(product.Pictures.First().Image);

            }
        }

        public String Libelle { get => this.title.Text; set => this.title.Text = value; }
        public String CategoryName { get => this.category.Text; set => this.category.Text = value; }
        public String Price { get => this.txtPrice.Text; set => this.txtPrice.Text = value; }
        public Product Product { get => this.product; set => this.product = value; }
        public Image Image { get => this.imageBox.Image; set => this.imageBox.Image = value; }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Onselect.Invoke(this, e);
        }

        private void ButtonDetailProduct_Click(object sender, EventArgs e)
        {
            ProductDetailControl userControl11 = new ProductDetailControl(this.product);
            Form window = new Form();
            window.Controls.Add(userControl11);
            window.StartPosition = FormStartPosition.CenterScreen;
            window.Size = userControl11.Size;
            window.FormBorderStyle = FormBorderStyle.None;
            window.ShowDialog();
        }
    }
}

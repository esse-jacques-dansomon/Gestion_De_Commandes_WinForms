using GestionCommndesNaza.models;
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
    public partial class ProductDetailControl : UserControl
    {
        public ProductDetailControl(Product product)
        {
            InitializeComponent();
            this.productName.Text = product.Libelle;
            this.productName2.Text = product.Libelle;
            this.productDescription.Text = product.Description;
            this.productCategory.Text = product.Category.Libelle;
            this.productPrice.Text = $"{product.Price} $";
            foreach(var picture in product.Pictures)
            {
                flowLayoutPanel1.Controls.Add(new pictureBoxControle(picture.Image));
            }
        }

        private void ButtonAddToCart_Click(object sender, EventArgs e)
        {

        }


    }
}

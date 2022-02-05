
namespace GestionCommndesNaza.components
{
    partial class ProductItem
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.Label();
            this.ButtonDetailProduct = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addToCartButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.title = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 311);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.imageBox);
            this.panel2.Controls.Add(this.category);
            this.panel2.Controls.Add(this.ButtonDetailProduct);
            this.panel2.Controls.Add(this.addToCartButton);
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 309);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(10, 225);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(35, 13);
            this.category.TabIndex = 8;
            this.category.Text = "label1";
            // 
            // ButtonDetailProduct
            // 
            this.ButtonDetailProduct.AnimationHoverSpeed = 0.07F;
            this.ButtonDetailProduct.AnimationSpeed = 0.03F;
            this.ButtonDetailProduct.BaseColor = System.Drawing.Color.Transparent;
            this.ButtonDetailProduct.BorderColor = System.Drawing.Color.Black;
            this.ButtonDetailProduct.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ButtonDetailProduct.CheckedBorderColor = System.Drawing.Color.Black;
            this.ButtonDetailProduct.CheckedForeColor = System.Drawing.Color.White;
            this.ButtonDetailProduct.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ButtonDetailProduct.CheckedImage")));
            this.ButtonDetailProduct.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ButtonDetailProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDetailProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonDetailProduct.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonDetailProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDetailProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonDetailProduct.Image = global::GestionCommndesNaza.Properties.Resources.eye_32pxbLACK;
            this.ButtonDetailProduct.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonDetailProduct.LineColor = System.Drawing.Color.White;
            this.ButtonDetailProduct.Location = new System.Drawing.Point(57, 272);
            this.ButtonDetailProduct.Name = "ButtonDetailProduct";
            this.ButtonDetailProduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonDetailProduct.OnHoverBorderColor = System.Drawing.Color.White;
            this.ButtonDetailProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonDetailProduct.OnHoverImage = null;
            this.ButtonDetailProduct.OnHoverLineColor = System.Drawing.Color.DodgerBlue;
            this.ButtonDetailProduct.OnPressedColor = System.Drawing.Color.Beige;
            this.ButtonDetailProduct.Size = new System.Drawing.Size(38, 30);
            this.ButtonDetailProduct.TabIndex = 7;
            this.ButtonDetailProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonDetailProduct.Click += new System.EventHandler(this.ButtonDetailProduct_Click);
            // 
            // addToCartButton
            // 
            this.addToCartButton.AnimationHoverSpeed = 0.07F;
            this.addToCartButton.AnimationSpeed = 0.03F;
            this.addToCartButton.BaseColor = System.Drawing.Color.Transparent;
            this.addToCartButton.BorderColor = System.Drawing.Color.Black;
            this.addToCartButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.addToCartButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.addToCartButton.CheckedForeColor = System.Drawing.Color.White;
            this.addToCartButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("addToCartButton.CheckedImage")));
            this.addToCartButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addToCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addToCartButton.FocusedColor = System.Drawing.Color.Empty;
            this.addToCartButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Image = global::GestionCommndesNaza.Properties.Resources.add_shopping_cart_48px;
            this.addToCartButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addToCartButton.LineColor = System.Drawing.Color.White;
            this.addToCartButton.Location = new System.Drawing.Point(6, 272);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addToCartButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.addToCartButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addToCartButton.OnHoverImage = global::GestionCommndesNaza.Properties.Resources.add_shopping_cart_32pxwhite;
            this.addToCartButton.OnHoverLineColor = System.Drawing.Color.DodgerBlue;
            this.addToCartButton.OnPressedColor = System.Drawing.Color.Beige;
            this.addToCartButton.Size = new System.Drawing.Size(38, 30);
            this.addToCartButton.TabIndex = 6;
            this.addToCartButton.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(8, 244);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(148, 21);
            this.title.TabIndex = 2;
            this.title.Text = "Avion Air Foce x015";
            // 
            // imageBox
            // 
            this.imageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageBox.Image = ((System.Drawing.Image)(resources.GetObject("imageBox.Image")));
            this.imageBox.Location = new System.Drawing.Point(6, 2);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(244, 217);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 9;
            this.imageBox.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.CheckedState.Parent = this.txtPrice;
            this.txtPrice.CustomImages.Parent = this.txtPrice;
            this.txtPrice.FillColor = System.Drawing.Color.Transparent;
            this.txtPrice.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(102, 275);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(148, 27);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.Text = "$ 400 000 ";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel1);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(261, 311);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton ButtonDetailProduct;
        private Guna.UI.WinForms.GunaAdvenceButton addToCartButton;
        private System.Windows.Forms.Label title;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.PictureBox imageBox;
        private Guna.UI2.WinForms.Guna2Button txtPrice;
    }
}

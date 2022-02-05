
namespace GestionCommndesNaza.components
{
    partial class OrderDetailtem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailtem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PemoveProductInCart = new Guna.UI.WinForms.GunaAdvenceButton();
            this.labelPriceUnitaire = new System.Windows.Forms.Label();
            this.QteUpdateButton = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labalProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QteUpdateButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labalProductName);
            this.panel1.Controls.Add(this.QteUpdateButton);
            this.panel1.Controls.Add(this.PemoveProductInCart);
            this.panel1.Controls.Add(this.labelPriceUnitaire);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 59);
            this.panel1.TabIndex = 0;
            // 
            // PemoveProductInCart
            // 
            this.PemoveProductInCart.AnimationHoverSpeed = 0.07F;
            this.PemoveProductInCart.AnimationSpeed = 0.03F;
            this.PemoveProductInCart.BaseColor = System.Drawing.Color.Transparent;
            this.PemoveProductInCart.BorderColor = System.Drawing.Color.Black;
            this.PemoveProductInCart.CheckedBaseColor = System.Drawing.Color.Gray;
            this.PemoveProductInCart.CheckedBorderColor = System.Drawing.Color.Black;
            this.PemoveProductInCart.CheckedForeColor = System.Drawing.Color.White;
            this.PemoveProductInCart.CheckedImage = ((System.Drawing.Image)(resources.GetObject("PemoveProductInCart.CheckedImage")));
            this.PemoveProductInCart.CheckedLineColor = System.Drawing.Color.DimGray;
            this.PemoveProductInCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PemoveProductInCart.FocusedColor = System.Drawing.Color.Empty;
            this.PemoveProductInCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PemoveProductInCart.ForeColor = System.Drawing.Color.White;
            this.PemoveProductInCart.Image = global::GestionCommndesNaza.Properties.Resources.Remove_48px;
            this.PemoveProductInCart.ImageSize = new System.Drawing.Size(20, 20);
            this.PemoveProductInCart.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.PemoveProductInCart.Location = new System.Drawing.Point(4, 10);
            this.PemoveProductInCart.Name = "PemoveProductInCart";
            this.PemoveProductInCart.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.PemoveProductInCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PemoveProductInCart.OnHoverForeColor = System.Drawing.Color.White;
            this.PemoveProductInCart.OnHoverImage = global::GestionCommndesNaza.Properties.Resources.trash_can_32pxWhite;
            this.PemoveProductInCart.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.PemoveProductInCart.OnPressedColor = System.Drawing.Color.Black;
            this.PemoveProductInCart.Size = new System.Drawing.Size(40, 40);
            this.PemoveProductInCart.TabIndex = 3;
            this.PemoveProductInCart.Click += new System.EventHandler(this.PemoveProductInCart_Click);
            // 
            // labelPriceUnitaire
            // 
            this.labelPriceUnitaire.AutoSize = true;
            this.labelPriceUnitaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPriceUnitaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceUnitaire.Location = new System.Drawing.Point(48, 30);
            this.labelPriceUnitaire.Name = "labelPriceUnitaire";
            this.labelPriceUnitaire.Size = new System.Drawing.Size(56, 16);
            this.labelPriceUnitaire.TabIndex = 5;
            this.labelPriceUnitaire.Text = "10.000 $";
            // 
            // QteUpdateButton
            // 
            this.QteUpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.QteUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QteUpdateButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QteUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QteUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QteUpdateButton.DisabledState.Parent = this.QteUpdateButton;
            this.QteUpdateButton.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.QteUpdateButton.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.QteUpdateButton.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QteUpdateButton.FocusedState.Parent = this.QteUpdateButton;
            this.QteUpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QteUpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.QteUpdateButton.Location = new System.Drawing.Point(230, 9);
            this.QteUpdateButton.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.QteUpdateButton.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QteUpdateButton.Name = "QteUpdateButton";
            this.QteUpdateButton.ShadowDecoration.Parent = this.QteUpdateButton;
            this.QteUpdateButton.Size = new System.Drawing.Size(71, 41);
            this.QteUpdateButton.TabIndex = 7;
            this.QteUpdateButton.ThousandsSeparator = true;
            this.QteUpdateButton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QteUpdateButton.ValueChanged += new System.EventHandler(this.QteUpdateButton_ValueChanged);
            // 
            // labalProductName
            // 
            this.labalProductName.BorderThickness = 0;
            this.labalProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labalProductName.DefaultText = "Exemple de nom de produit tres long";
            this.labalProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.labalProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.labalProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labalProductName.DisabledState.Parent = this.labalProductName;
            this.labalProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labalProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labalProductName.FocusedState.Parent = this.labalProductName;
            this.labalProductName.ForeColor = System.Drawing.Color.DimGray;
            this.labalProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labalProductName.HoverState.Parent = this.labalProductName;
            this.labalProductName.Location = new System.Drawing.Point(44, 9);
            this.labalProductName.Name = "labalProductName";
            this.labalProductName.PasswordChar = '\0';
            this.labalProductName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.labalProductName.PlaceholderText = "";
            this.labalProductName.SelectedText = "";
            this.labalProductName.ShadowDecoration.Parent = this.labalProductName;
            this.labalProductName.Size = new System.Drawing.Size(186, 18);
            this.labalProductName.TabIndex = 8;
            // 
            // OrderDetailtem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "OrderDetailtem";
            this.Size = new System.Drawing.Size(306, 59);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QteUpdateButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton PemoveProductInCart;
        public System.Windows.Forms.Label labelPriceUnitaire;
        private Guna.UI2.WinForms.Guna2NumericUpDown QteUpdateButton;
        private Guna.UI2.WinForms.Guna2TextBox labalProductName;
    }
}

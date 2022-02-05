
namespace GestionCommndesNaza.components
{
    partial class OrderPayement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPayement));
            this.PriceTotal = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ReferenceOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReferencePayememt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonOrder = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numero = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PriceTotal
            // 
            this.PriceTotal.AutoSize = true;
            this.PriceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PriceTotal.Location = new System.Drawing.Point(89, 99);
            this.PriceTotal.Name = "PriceTotal";
            this.PriceTotal.Size = new System.Drawing.Size(112, 18);
            this.PriceTotal.TabIndex = 9;
            this.PriceTotal.Text = "10 000 0000000";
            this.PriceTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.numero);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.ReferenceOrder);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.ReferencePayememt);
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.Controls.Add(this.PriceTotal);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.ButtonOrder);
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.comboBoxType);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(277, 392);
            this.guna2ShadowPanel1.TabIndex = 2;
            // 
            // ReferenceOrder
            // 
            this.ReferenceOrder.AutoSize = true;
            this.ReferenceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ReferenceOrder.Location = new System.Drawing.Point(90, 64);
            this.ReferenceOrder.Name = "ReferenceOrder";
            this.ReferenceOrder.Size = new System.Drawing.Size(30, 17);
            this.ReferenceOrder.TabIndex = 13;
            this.ReferenceOrder.Text = "Ref";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ref";
            // 
            // ReferencePayememt
            // 
            this.ReferencePayememt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReferencePayememt.DefaultText = "";
            this.ReferencePayememt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReferencePayememt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReferencePayememt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReferencePayememt.DisabledState.Parent = this.ReferencePayememt;
            this.ReferencePayememt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReferencePayememt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReferencePayememt.FocusedState.Parent = this.ReferencePayememt;
            this.ReferencePayememt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReferencePayememt.HoverState.Parent = this.ReferencePayememt;
            this.ReferencePayememt.Location = new System.Drawing.Point(21, 229);
            this.ReferencePayememt.Name = "ReferencePayememt";
            this.ReferencePayememt.PasswordChar = '\0';
            this.ReferencePayememt.PlaceholderText = "";
            this.ReferencePayememt.SelectedText = "";
            this.ReferencePayememt.ShadowDecoration.Parent = this.ReferencePayememt;
            this.ReferencePayememt.Size = new System.Drawing.Size(224, 30);
            this.ReferencePayememt.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 40);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Paiement ";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(242, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 28);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(21, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total";
            // 
            // ButtonOrder
            // 
            this.ButtonOrder.AnimationHoverSpeed = 0.07F;
            this.ButtonOrder.AnimationSpeed = 0.03F;
            this.ButtonOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonOrder.BorderColor = System.Drawing.Color.Black;
            this.ButtonOrder.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ButtonOrder.CheckedBorderColor = System.Drawing.Color.Black;
            this.ButtonOrder.CheckedForeColor = System.Drawing.Color.White;
            this.ButtonOrder.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ButtonOrder.CheckedImage")));
            this.ButtonOrder.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ButtonOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonOrder.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonOrder.ForeColor = System.Drawing.Color.White;
            this.ButtonOrder.Image = global::GestionCommndesNaza.Properties.Resources.add_shopping_cart_32pxwhite;
            this.ButtonOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonOrder.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonOrder.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonOrder.Location = new System.Drawing.Point(0, 348);
            this.ButtonOrder.Name = "ButtonOrder";
            this.ButtonOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonOrder.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonOrder.OnHoverImage = null;
            this.ButtonOrder.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonOrder.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonOrder.Size = new System.Drawing.Size(277, 44);
            this.ButtonOrder.TabIndex = 6;
            this.ButtonOrder.Text = "PAYER ";
            this.ButtonOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonOrder.Click += new System.EventHandler(this.ButtonOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(19, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Type de Paiement";
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FillColor = System.Drawing.Color.Snow;
            this.comboBoxType.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxType.FocusedState.Parent = this.comboBoxType;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.HoverState.Parent = this.comboBoxType;
            this.comboBoxType.ItemHeight = 20;
            this.comboBoxType.Items.AddRange(new object[] {
            "Wave",
            "Orange Money",
            "Wari,",
            "Western",
            "Virement",
            "PayPal"});
            this.comboBoxType.ItemsAppearance.Parent = this.comboBoxType;
            this.comboBoxType.Location = new System.Drawing.Point(22, 160);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.ShadowDecoration.Parent = this.comboBoxType;
            this.comboBoxType.Size = new System.Drawing.Size(223, 26);
            this.comboBoxType.TabIndex = 2;
            // 
            // numero
            // 
            this.numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numero.DefaultText = "";
            this.numero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numero.DisabledState.Parent = this.numero;
            this.numero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numero.FocusedState.Parent = this.numero;
            this.numero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numero.HoverState.Parent = this.numero;
            this.numero.Location = new System.Drawing.Point(26, 295);
            this.numero.Name = "numero";
            this.numero.PasswordChar = '\0';
            this.numero.PlaceholderText = "";
            this.numero.SelectedText = "";
            this.numero.ShadowDecoration.Parent = this.numero;
            this.numero.Size = new System.Drawing.Size(224, 30);
            this.numero.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(24, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numero";
            // 
            // OrderPayement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "OrderPayement";
            this.Size = new System.Drawing.Size(278, 392);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label PriceTotal;
        public Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaAdvenceButton ButtonOrder;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2ComboBox comboBoxType;
        private System.Windows.Forms.Label ReferenceOrder;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox ReferencePayememt;
        public Guna.UI2.WinForms.Guna2TextBox numero;
        public System.Windows.Forms.Label label4;
    }
}

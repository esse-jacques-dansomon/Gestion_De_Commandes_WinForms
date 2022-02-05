
namespace GestionCommndesNaza.components
{
    partial class OrderOfClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderOfClient));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ButtonPay = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ButtonRecue = new Guna.UI.WinForms.GunaAdvenceButton();
            this.labelReference = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSatatus = new System.Windows.Forms.Label();
            this.ButtonIvoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.gunaLabel1.Location = new System.Drawing.Point(5, 1);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(28, 19);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Ref";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(83, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(181, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(264, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Statut";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AnimationHoverSpeed = 0.07F;
            this.ButtonCancel.AnimationSpeed = 0.03F;
            this.ButtonCancel.BaseColor = System.Drawing.Color.Red;
            this.ButtonCancel.BorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ButtonCancel.CheckedBorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.CheckedForeColor = System.Drawing.Color.White;
            this.ButtonCancel.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.CheckedImage")));
            this.ButtonCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonCancel.Enabled = false;
            this.ButtonCancel.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.Image")));
            this.ButtonCancel.ImageSize = new System.Drawing.Size(0, 0);
            this.ButtonCancel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonCancel.Location = new System.Drawing.Point(417, 31);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonCancel.OnHoverImage = null;
            this.ButtonCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonCancel.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonCancel.Size = new System.Drawing.Size(49, 22);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonPay
            // 
            this.ButtonPay.AnimationHoverSpeed = 0.07F;
            this.ButtonPay.AnimationSpeed = 0.03F;
            this.ButtonPay.BaseColor = System.Drawing.Color.Lime;
            this.ButtonPay.BorderColor = System.Drawing.Color.Black;
            this.ButtonPay.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ButtonPay.CheckedBorderColor = System.Drawing.Color.Black;
            this.ButtonPay.CheckedForeColor = System.Drawing.Color.White;
            this.ButtonPay.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ButtonPay.CheckedImage")));
            this.ButtonPay.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ButtonPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonPay.Enabled = false;
            this.ButtonPay.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonPay.ForeColor = System.Drawing.Color.White;
            this.ButtonPay.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPay.Image")));
            this.ButtonPay.ImageSize = new System.Drawing.Size(0, 0);
            this.ButtonPay.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonPay.Location = new System.Drawing.Point(418, 3);
            this.ButtonPay.Name = "ButtonPay";
            this.ButtonPay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonPay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonPay.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonPay.OnHoverImage = null;
            this.ButtonPay.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonPay.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonPay.Size = new System.Drawing.Size(48, 22);
            this.ButtonPay.TabIndex = 4;
            this.ButtonPay.Text = "Pay";
            this.ButtonPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // ButtonRecue
            // 
            this.ButtonRecue.AnimationHoverSpeed = 0.07F;
            this.ButtonRecue.AnimationSpeed = 0.03F;
            this.ButtonRecue.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ButtonRecue.BorderColor = System.Drawing.Color.Black;
            this.ButtonRecue.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ButtonRecue.CheckedBorderColor = System.Drawing.Color.Black;
            this.ButtonRecue.CheckedForeColor = System.Drawing.Color.White;
            this.ButtonRecue.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ButtonRecue.CheckedImage")));
            this.ButtonRecue.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ButtonRecue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonRecue.Enabled = false;
            this.ButtonRecue.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonRecue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRecue.ForeColor = System.Drawing.Color.White;
            this.ButtonRecue.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRecue.Image")));
            this.ButtonRecue.ImageSize = new System.Drawing.Size(0, 0);
            this.ButtonRecue.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonRecue.Location = new System.Drawing.Point(361, 30);
            this.ButtonRecue.Name = "ButtonRecue";
            this.ButtonRecue.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonRecue.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonRecue.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonRecue.OnHoverImage = null;
            this.ButtonRecue.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonRecue.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonRecue.Size = new System.Drawing.Size(50, 22);
            this.ButtonRecue.TabIndex = 6;
            this.ButtonRecue.Text = "Reçue";
            this.ButtonRecue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonRecue.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // labelReference
            // 
            this.labelReference.AutoSize = true;
            this.labelReference.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelReference.Location = new System.Drawing.Point(6, 31);
            this.labelReference.Name = "labelReference";
            this.labelReference.Size = new System.Drawing.Size(42, 16);
            this.labelReference.TabIndex = 7;
            this.labelReference.Text = "PO150";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelTotal.Location = new System.Drawing.Point(82, 31);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(80, 16);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "$ 100 .000 000";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelDate.Location = new System.Drawing.Point(179, 31);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(62, 16);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "02.02.2020";
            // 
            // labelSatatus
            // 
            this.labelSatatus.AutoSize = true;
            this.labelSatatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelSatatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelSatatus.Location = new System.Drawing.Point(263, 31);
            this.labelSatatus.Name = "labelSatatus";
            this.labelSatatus.Size = new System.Drawing.Size(51, 16);
            this.labelSatatus.TabIndex = 10;
            this.labelSatatus.Text = "Effectué";
            // 
            // ButtonIvoice
            // 
            this.ButtonIvoice.AnimationHoverSpeed = 0.07F;
            this.ButtonIvoice.AnimationSpeed = 0.03F;
            this.ButtonIvoice.BaseColor = System.Drawing.Color.Black;
            this.ButtonIvoice.BorderColor = System.Drawing.Color.Black;
            this.ButtonIvoice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ButtonIvoice.CheckedBorderColor = System.Drawing.Color.Black;
            this.ButtonIvoice.CheckedForeColor = System.Drawing.Color.White;
            this.ButtonIvoice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ButtonIvoice.CheckedImage")));
            this.ButtonIvoice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ButtonIvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonIvoice.Enabled = false;
            this.ButtonIvoice.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonIvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonIvoice.ForeColor = System.Drawing.Color.White;
            this.ButtonIvoice.Image = ((System.Drawing.Image)(resources.GetObject("ButtonIvoice.Image")));
            this.ButtonIvoice.ImageSize = new System.Drawing.Size(0, 0);
            this.ButtonIvoice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonIvoice.Location = new System.Drawing.Point(362, 3);
            this.ButtonIvoice.Name = "ButtonIvoice";
            this.ButtonIvoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ButtonIvoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonIvoice.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonIvoice.OnHoverImage = null;
            this.ButtonIvoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ButtonIvoice.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonIvoice.Size = new System.Drawing.Size(48, 22);
            this.ButtonIvoice.TabIndex = 11;
            this.ButtonIvoice.Text = "Ivoice";
            this.ButtonIvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonIvoice.Click += new System.EventHandler(this.ButtonIvoice_Click);
            // 
            // OrderOfClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ButtonIvoice);
            this.Controls.Add(this.labelSatatus);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelReference);
            this.Controls.Add(this.ButtonRecue);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "OrderOfClient";
            this.Size = new System.Drawing.Size(474, 54);
            this.Click += new System.EventHandler(this.OrderOfClient_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton ButtonPay;
        private Guna.UI.WinForms.GunaAdvenceButton ButtonCancel;
        private Guna.UI.WinForms.GunaAdvenceButton ButtonRecue;
        private System.Windows.Forms.Label labelReference;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSatatus;
        private Guna.UI.WinForms.GunaAdvenceButton ButtonIvoice;
    }
}


namespace GestionCommndesNaza.components
{
    partial class DansboardCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DansboardCard));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.LibelleValue = new Guna.UI.WinForms.GunaLabel();
            this.Libelle = new Guna.UI.WinForms.GunaLabel();
            this.image = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.gunaPanel1);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 50;
            this.gunaShadowPanel1.ShadowShift = 3;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(207, 47);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel1.Controls.Add(this.LibelleValue);
            this.gunaPanel1.Controls.Add(this.Libelle);
            this.gunaPanel1.Controls.Add(this.image);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(207, 47);
            this.gunaPanel1.TabIndex = 1;
            // 
            // LibelleValue
            // 
            this.LibelleValue.AutoSize = true;
            this.LibelleValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LibelleValue.ForeColor = System.Drawing.Color.DimGray;
            this.LibelleValue.Location = new System.Drawing.Point(64, 26);
            this.LibelleValue.Name = "LibelleValue";
            this.LibelleValue.Size = new System.Drawing.Size(55, 15);
            this.LibelleValue.TabIndex = 2;
            this.LibelleValue.Text = "20 orders";
            // 
            // Libelle
            // 
            this.Libelle.AutoSize = true;
            this.Libelle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Libelle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Libelle.Location = new System.Drawing.Point(60, 3);
            this.Libelle.Name = "Libelle";
            this.Libelle.Size = new System.Drawing.Size(129, 20);
            this.Libelle.TabIndex = 1;
            this.Libelle.Text = "Order Completed";
            // 
            // image
            // 
            this.image.AnimationHoverSpeed = 0.07F;
            this.image.AnimationSpeed = 0.03F;
            this.image.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.image.BorderColor = System.Drawing.Color.Black;
            this.image.CheckedBaseColor = System.Drawing.Color.Gray;
            this.image.CheckedBorderColor = System.Drawing.Color.Black;
            this.image.CheckedForeColor = System.Drawing.Color.White;
            this.image.CheckedImage = ((System.Drawing.Image)(resources.GetObject("image.CheckedImage")));
            this.image.CheckedLineColor = System.Drawing.Color.DimGray;
            this.image.DialogResult = System.Windows.Forms.DialogResult.None;
            this.image.FocusedColor = System.Drawing.Color.Empty;
            this.image.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.image.ForeColor = System.Drawing.Color.White;
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.ImageSize = new System.Drawing.Size(30, 30);
            this.image.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.image.Location = new System.Drawing.Point(6, 2);
            this.image.Name = "image";
            this.image.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.image.OnHoverBorderColor = System.Drawing.Color.Black;
            this.image.OnHoverForeColor = System.Drawing.Color.White;
            this.image.OnHoverImage = null;
            this.image.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.image.OnPressedColor = System.Drawing.Color.Black;
            this.image.Size = new System.Drawing.Size(50, 42);
            this.image.TabIndex = 0;
            // 
            // DansboardCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "DansboardCard";
            this.Size = new System.Drawing.Size(207, 47);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        public Guna.UI.WinForms.GunaLabel LibelleValue;
        public Guna.UI.WinForms.GunaLabel Libelle;
        public Guna.UI.WinForms.GunaAdvenceButton image;
        public Guna.UI.WinForms.GunaPanel gunaPanel1;
    }
}


namespace GestionCommndesNaza.forms.client
{
    partial class FormClientDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientDashboard));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.PagePanel = new Guna.UI.WinForms.GunaPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.seacchButton = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClientAvatar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ActiveLocalisation = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.MessageButton = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.LogoutButton = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.PayementsButton = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.ShopButton = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.ProfileButton = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaPanel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.ActiveLocalisation);
            this.gunaPanel1.Controls.Add(this.gunaAdvenceTileButton1);
            this.gunaPanel1.Controls.Add(this.MessageButton);
            this.gunaPanel1.Controls.Add(this.LogoutButton);
            this.gunaPanel1.Controls.Add(this.PayementsButton);
            this.gunaPanel1.Controls.Add(this.ShopButton);
            this.gunaPanel1.Controls.Add(this.ProfileButton);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(93, 679);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // PagePanel
            // 
            this.PagePanel.Location = new System.Drawing.Point(107, 67);
            this.PagePanel.Name = "PagePanel";
            this.PagePanel.Size = new System.Drawing.Size(939, 606);
            this.PagePanel.TabIndex = 5;
            this.PagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PagePanel_Paint);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.seacchButton);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.ClientName);
            this.guna2ShadowPanel1.Controls.Add(this.ClientAvatar);
            this.guna2ShadowPanel1.Controls.Add(this.gunaAdvenceButton1);
            this.guna2ShadowPanel1.Controls.Add(this.gunaControlBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(-1, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1064, 53);
            this.guna2ShadowPanel1.TabIndex = 6;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Client";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.Location = new System.Drawing.Point(72, 12);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(95, 15);
            this.ClientName.TabIndex = 16;
            this.ClientName.Text = "Esse Jacques";
            this.ClientName.Click += new System.EventHandler(this.ClientName_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1029, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(30, 22);
            this.gunaControlBox1.TabIndex = 12;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // seacchButton
            // 
            this.seacchButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.seacchButton.BorderRadius = 10;
            this.seacchButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seacchButton.DefaultText = "rechercher";
            this.seacchButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.seacchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.seacchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seacchButton.DisabledState.Parent = this.seacchButton;
            this.seacchButton.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seacchButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.seacchButton.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seacchButton.FocusedState.Parent = this.seacchButton;
            this.seacchButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seacchButton.HoverState.Parent = this.seacchButton;
            this.seacchButton.IconRight = global::GestionCommndesNaza.Properties.Resources.search_50px;
            this.seacchButton.Location = new System.Drawing.Point(820, 11);
            this.seacchButton.Name = "seacchButton";
            this.seacchButton.PasswordChar = '\0';
            this.seacchButton.PlaceholderText = "";
            this.seacchButton.SelectedText = "";
            this.seacchButton.SelectionStart = 10;
            this.seacchButton.ShadowDecoration.Parent = this.seacchButton;
            this.seacchButton.Size = new System.Drawing.Size(189, 25);
            this.seacchButton.TabIndex = 13;
            this.seacchButton.TextChanged += new System.EventHandler(this.seacchButton_TextChanged);
            // 
            // ClientAvatar
            // 
            this.ClientAvatar.AnimationHoverSpeed = 0.07F;
            this.ClientAvatar.AnimationSpeed = 0.03F;
            this.ClientAvatar.BaseColor = System.Drawing.Color.Transparent;
            this.ClientAvatar.BorderColor = System.Drawing.Color.Black;
            this.ClientAvatar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ClientAvatar.CheckedBorderColor = System.Drawing.Color.Black;
            this.ClientAvatar.CheckedForeColor = System.Drawing.Color.White;
            this.ClientAvatar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ClientAvatar.CheckedImage")));
            this.ClientAvatar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ClientAvatar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClientAvatar.FocusedColor = System.Drawing.Color.Empty;
            this.ClientAvatar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientAvatar.ForeColor = System.Drawing.Color.White;
            this.ClientAvatar.Image = global::GestionCommndesNaza.Properties.Resources.users_128px;
            this.ClientAvatar.ImageSize = new System.Drawing.Size(30, 30);
            this.ClientAvatar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ClientAvatar.Location = new System.Drawing.Point(22, 4);
            this.ClientAvatar.Name = "ClientAvatar";
            this.ClientAvatar.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.ClientAvatar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ClientAvatar.OnHoverForeColor = System.Drawing.Color.White;
            this.ClientAvatar.OnHoverImage = null;
            this.ClientAvatar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ClientAvatar.OnPressedColor = System.Drawing.Color.Black;
            this.ClientAvatar.Size = new System.Drawing.Size(41, 38);
            this.ClientAvatar.TabIndex = 15;
            this.ClientAvatar.Click += new System.EventHandler(this.ClientAvatar_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(762, 11);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(37, 25);
            this.gunaAdvenceButton1.TabIndex = 14;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // ActiveLocalisation
            // 
            this.ActiveLocalisation.AnimationHoverSpeed = 0.07F;
            this.ActiveLocalisation.AnimationSpeed = 0.03F;
            this.ActiveLocalisation.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ActiveLocalisation.BorderColor = System.Drawing.Color.Black;
            this.ActiveLocalisation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ActiveLocalisation.FocusedColor = System.Drawing.Color.Empty;
            this.ActiveLocalisation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ActiveLocalisation.ForeColor = System.Drawing.Color.White;
            this.ActiveLocalisation.Image = ((System.Drawing.Image)(resources.GetObject("ActiveLocalisation.Image")));
            this.ActiveLocalisation.ImageSize = new System.Drawing.Size(0, 0);
            this.ActiveLocalisation.Location = new System.Drawing.Point(-1, 260);
            this.ActiveLocalisation.Name = "ActiveLocalisation";
            this.ActiveLocalisation.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ActiveLocalisation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ActiveLocalisation.OnHoverForeColor = System.Drawing.Color.White;
            this.ActiveLocalisation.OnHoverImage = null;
            this.ActiveLocalisation.OnPressedColor = System.Drawing.Color.Black;
            this.ActiveLocalisation.Size = new System.Drawing.Size(10, 58);
            this.ActiveLocalisation.TabIndex = 0;
            this.ActiveLocalisation.Click += new System.EventHandler(this.ActiveLocalisation_Click);
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.CheckedImage")));
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.Image = global::GestionCommndesNaza.Properties.Resources.sparkling_48px;
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(-1, 90);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(93, 77);
            this.gunaAdvenceTileButton1.TabIndex = 11;
            this.gunaAdvenceTileButton1.Text = "AGOE SHOP";
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // MessageButton
            // 
            this.MessageButton.AnimationHoverSpeed = 0.07F;
            this.MessageButton.AnimationSpeed = 0.03F;
            this.MessageButton.BackColor = System.Drawing.Color.Transparent;
            this.MessageButton.BaseColor = System.Drawing.Color.Transparent;
            this.MessageButton.BorderColor = System.Drawing.Color.Transparent;
            this.MessageButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.MessageButton.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.MessageButton.CheckedForeColor = System.Drawing.Color.Transparent;
            this.MessageButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("MessageButton.CheckedImage")));
            this.MessageButton.CheckedLineColor = System.Drawing.Color.Gray;
            this.MessageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MessageButton.FocusedColor = System.Drawing.Color.Empty;
            this.MessageButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold);
            this.MessageButton.ForeColor = System.Drawing.Color.DimGray;
            this.MessageButton.Image = global::GestionCommndesNaza.Properties.Resources.message_promotion_64px;
            this.MessageButton.ImageSize = new System.Drawing.Size(32, 32);
            this.MessageButton.LineColor = System.Drawing.Color.Transparent;
            this.MessageButton.Location = new System.Drawing.Point(1, 450);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.MessageButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MessageButton.OnHoverForeColor = System.Drawing.Color.White;
            this.MessageButton.OnHoverImage = null;
            this.MessageButton.OnHoverLineColor = System.Drawing.Color.Navy;
            this.MessageButton.OnPressedColor = System.Drawing.Color.Black;
            this.MessageButton.Size = new System.Drawing.Size(88, 59);
            this.MessageButton.TabIndex = 6;
            this.MessageButton.Text = "Message";
            this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.AnimationHoverSpeed = 0.07F;
            this.LogoutButton.AnimationSpeed = 0.03F;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BaseColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BorderColor = System.Drawing.Color.Transparent;
            this.LogoutButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.LogoutButton.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.LogoutButton.CheckedForeColor = System.Drawing.Color.Transparent;
            this.LogoutButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("LogoutButton.CheckedImage")));
            this.LogoutButton.CheckedLineColor = System.Drawing.Color.Gray;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogoutButton.FocusedColor = System.Drawing.Color.Empty;
            this.LogoutButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.DimGray;
            this.LogoutButton.Image = global::GestionCommndesNaza.Properties.Resources.sign_out_64px;
            this.LogoutButton.ImageSize = new System.Drawing.Size(32, 32);
            this.LogoutButton.LineColor = System.Drawing.Color.Transparent;
            this.LogoutButton.Location = new System.Drawing.Point(3, 558);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.LogoutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LogoutButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LogoutButton.OnHoverImage = null;
            this.LogoutButton.OnHoverLineColor = System.Drawing.Color.Navy;
            this.LogoutButton.OnPressedColor = System.Drawing.Color.Black;
            this.LogoutButton.Size = new System.Drawing.Size(87, 59);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // PayementsButton
            // 
            this.PayementsButton.AnimationHoverSpeed = 0.07F;
            this.PayementsButton.AnimationSpeed = 0.03F;
            this.PayementsButton.BackColor = System.Drawing.Color.Transparent;
            this.PayementsButton.BaseColor = System.Drawing.Color.Transparent;
            this.PayementsButton.BorderColor = System.Drawing.Color.Transparent;
            this.PayementsButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.PayementsButton.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.PayementsButton.CheckedForeColor = System.Drawing.Color.Transparent;
            this.PayementsButton.CheckedImage = global::GestionCommndesNaza.Properties.Resources.pay_128px;
            this.PayementsButton.CheckedLineColor = System.Drawing.Color.Gray;
            this.PayementsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayementsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PayementsButton.FocusedColor = System.Drawing.Color.Empty;
            this.PayementsButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayementsButton.ForeColor = System.Drawing.Color.DimGray;
            this.PayementsButton.Image = global::GestionCommndesNaza.Properties.Resources.pay_128px;
            this.PayementsButton.ImageSize = new System.Drawing.Size(32, 32);
            this.PayementsButton.LineColor = System.Drawing.Color.Transparent;
            this.PayementsButton.Location = new System.Drawing.Point(2, 350);
            this.PayementsButton.Name = "PayementsButton";
            this.PayementsButton.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.PayementsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PayementsButton.OnHoverForeColor = System.Drawing.Color.White;
            this.PayementsButton.OnHoverImage = null;
            this.PayementsButton.OnHoverLineColor = System.Drawing.Color.Navy;
            this.PayementsButton.OnPressedColor = System.Drawing.Color.Black;
            this.PayementsButton.Size = new System.Drawing.Size(88, 59);
            this.PayementsButton.TabIndex = 4;
            this.PayementsButton.Text = "Paies";
            this.PayementsButton.Click += new System.EventHandler(this.PayementsButton_Click);
            // 
            // ShopButton
            // 
            this.ShopButton.AnimationHoverSpeed = 0.07F;
            this.ShopButton.AnimationSpeed = 0.03F;
            this.ShopButton.BackColor = System.Drawing.Color.Transparent;
            this.ShopButton.BaseColor = System.Drawing.Color.Transparent;
            this.ShopButton.BorderColor = System.Drawing.Color.Transparent;
            this.ShopButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ShopButton.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.ShopButton.CheckedForeColor = System.Drawing.Color.Transparent;
            this.ShopButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ShopButton.CheckedImage")));
            this.ShopButton.CheckedLineColor = System.Drawing.Color.Gray;
            this.ShopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShopButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ShopButton.FocusedColor = System.Drawing.Color.Empty;
            this.ShopButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopButton.ForeColor = System.Drawing.Color.DimGray;
            this.ShopButton.Image = global::GestionCommndesNaza.Properties.Resources.shop_128px;
            this.ShopButton.ImageSize = new System.Drawing.Size(32, 32);
            this.ShopButton.LineColor = System.Drawing.Color.Transparent;
            this.ShopButton.Location = new System.Drawing.Point(1, 260);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.ShopButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ShopButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ShopButton.OnHoverImage = null;
            this.ShopButton.OnHoverLineColor = System.Drawing.Color.Navy;
            this.ShopButton.OnPressedColor = System.Drawing.Color.Black;
            this.ShopButton.Size = new System.Drawing.Size(87, 59);
            this.ShopButton.TabIndex = 3;
            this.ShopButton.Text = "Shop";
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.AnimationHoverSpeed = 0.07F;
            this.ProfileButton.AnimationSpeed = 0.03F;
            this.ProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.ProfileButton.BaseColor = System.Drawing.Color.Transparent;
            this.ProfileButton.BorderColor = System.Drawing.Color.Transparent;
            this.ProfileButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ProfileButton.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.ProfileButton.CheckedForeColor = System.Drawing.Color.Transparent;
            this.ProfileButton.CheckedImage = global::GestionCommndesNaza.Properties.Resources.Male_User_128px;
            this.ProfileButton.CheckedLineColor = System.Drawing.Color.Gray;
            this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProfileButton.FocusedColor = System.Drawing.Color.Empty;
            this.ProfileButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold);
            this.ProfileButton.ForeColor = System.Drawing.Color.DimGray;
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.ImageSize = new System.Drawing.Size(24, 24);
            this.ProfileButton.LineColor = System.Drawing.Color.Transparent;
            this.ProfileButton.Location = new System.Drawing.Point(1, 173);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.ProfileButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ProfileButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ProfileButton.OnHoverImage = null;
            this.ProfileButton.OnHoverLineColor = System.Drawing.Color.Navy;
            this.ProfileButton.OnPressedColor = System.Drawing.Color.Black;
            this.ProfileButton.Size = new System.Drawing.Size(91, 59);
            this.ProfileButton.TabIndex = 2;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // FormClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1060, 679);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.PagePanel);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientDashboard";
            this.gunaPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceTileButton ProfileButton;
        private Guna.UI.WinForms.GunaAdvenceTileButton LogoutButton;
        private Guna.UI.WinForms.GunaAdvenceTileButton PayementsButton;
        private Guna.UI.WinForms.GunaAdvenceTileButton ShopButton;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPanel PagePanel;
        private Guna.UI.WinForms.GunaAdvenceTileButton MessageButton;
        private Guna.UI.WinForms.GunaButton ActiveLocalisation;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox seacchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ClientName;
        private Guna.UI.WinForms.GunaAdvenceButton ClientAvatar;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}
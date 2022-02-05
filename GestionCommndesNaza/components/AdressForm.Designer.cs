
namespace GestionCommndesNaza.components
{
    partial class AdressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdressForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.adresseZone = new Guna.UI2.WinForms.Guna2TextBox();
            this.adresseCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.AdressePostal = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.AdresseCountry = new System.Windows.Forms.ComboBox();
            this.AdresseSavebutton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.AdresseSavebutton);
            this.panel1.Controls.Add(this.AdresseCountry);
            this.panel1.Controls.Add(this.AdressePostal);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.adresseCity);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.adresseZone);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 199);
            this.panel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(14, 46);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(47, 19);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "ZONE";
            // 
            // adresseZone
            // 
            this.adresseZone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresseZone.DefaultText = "";
            this.adresseZone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adresseZone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adresseZone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adresseZone.DisabledState.Parent = this.adresseZone;
            this.adresseZone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adresseZone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adresseZone.FocusedState.Parent = this.adresseZone;
            this.adresseZone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adresseZone.HoverState.Parent = this.adresseZone;
            this.adresseZone.Location = new System.Drawing.Point(15, 66);
            this.adresseZone.Name = "adresseZone";
            this.adresseZone.PasswordChar = '\0';
            this.adresseZone.PlaceholderText = "";
            this.adresseZone.SelectedText = "";
            this.adresseZone.ShadowDecoration.Parent = this.adresseZone;
            this.adresseZone.Size = new System.Drawing.Size(182, 27);
            this.adresseZone.TabIndex = 1;
            // 
            // adresseCity
            // 
            this.adresseCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresseCity.DefaultText = "";
            this.adresseCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adresseCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adresseCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adresseCity.DisabledState.Parent = this.adresseCity;
            this.adresseCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adresseCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adresseCity.FocusedState.Parent = this.adresseCity;
            this.adresseCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adresseCity.HoverState.Parent = this.adresseCity;
            this.adresseCity.Location = new System.Drawing.Point(212, 66);
            this.adresseCity.Name = "adresseCity";
            this.adresseCity.PasswordChar = '\0';
            this.adresseCity.PlaceholderText = "";
            this.adresseCity.SelectedText = "";
            this.adresseCity.ShadowDecoration.Parent = this.adresseCity;
            this.adresseCity.Size = new System.Drawing.Size(232, 27);
            this.adresseCity.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(210, 45);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(43, 19);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "VILLE";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(15, 103);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(43, 19);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "PAYS";
            // 
            // AdressePostal
            // 
            this.AdressePostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdressePostal.DefaultText = "";
            this.AdressePostal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdressePostal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdressePostal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdressePostal.DisabledState.Parent = this.AdressePostal;
            this.AdressePostal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdressePostal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdressePostal.FocusedState.Parent = this.AdressePostal;
            this.AdressePostal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdressePostal.HoverState.Parent = this.AdressePostal;
            this.AdressePostal.Location = new System.Drawing.Point(211, 122);
            this.AdressePostal.Name = "AdressePostal";
            this.AdressePostal.PasswordChar = '\0';
            this.AdressePostal.PlaceholderText = "";
            this.AdressePostal.SelectedText = "";
            this.AdressePostal.ShadowDecoration.Parent = this.AdressePostal;
            this.AdressePostal.Size = new System.Drawing.Size(234, 27);
            this.AdressePostal.TabIndex = 7;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(210, 100);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(61, 19);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "POSTAL";
            // 
            // AdresseCountry
            // 
            this.AdresseCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AdresseCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AdresseCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdresseCountry.FormattingEnabled = true;
            this.AdresseCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.AdresseCountry.Location = new System.Drawing.Point(16, 125);
            this.AdresseCountry.Name = "AdresseCountry";
            this.AdresseCountry.Size = new System.Drawing.Size(182, 24);
            this.AdresseCountry.TabIndex = 8;
            // 
            // AdresseSavebutton
            // 
            this.AdresseSavebutton.AnimationHoverSpeed = 0.07F;
            this.AdresseSavebutton.AnimationSpeed = 0.03F;
            this.AdresseSavebutton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AdresseSavebutton.BorderColor = System.Drawing.Color.Black;
            this.AdresseSavebutton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AdresseSavebutton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AdresseSavebutton.CheckedForeColor = System.Drawing.Color.White;
            this.AdresseSavebutton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AdresseSavebutton.CheckedImage")));
            this.AdresseSavebutton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AdresseSavebutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AdresseSavebutton.FocusedColor = System.Drawing.Color.Empty;
            this.AdresseSavebutton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.AdresseSavebutton.ForeColor = System.Drawing.Color.White;
            this.AdresseSavebutton.Image = ((System.Drawing.Image)(resources.GetObject("AdresseSavebutton.Image")));
            this.AdresseSavebutton.ImageSize = new System.Drawing.Size(0, 0);
            this.AdresseSavebutton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AdresseSavebutton.Location = new System.Drawing.Point(16, 161);
            this.AdresseSavebutton.Name = "AdresseSavebutton";
            this.AdresseSavebutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AdresseSavebutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AdresseSavebutton.OnHoverForeColor = System.Drawing.Color.White;
            this.AdresseSavebutton.OnHoverImage = null;
            this.AdresseSavebutton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AdresseSavebutton.OnPressedColor = System.Drawing.Color.Black;
            this.AdresseSavebutton.Size = new System.Drawing.Size(429, 26);
            this.AdresseSavebutton.TabIndex = 41;
            this.AdresseSavebutton.Text = "save";
            this.AdresseSavebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdresseSavebutton.Click += new System.EventHandler(this.AdresseSavebutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 43);
            this.panel2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "AJOUT D\'UNE NOUVELLE ADRESSE";
            // 
            // AdressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdressForm";
            this.Size = new System.Drawing.Size(457, 199);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2TextBox AdressePostal;
        public Guna.UI2.WinForms.Guna2TextBox adresseCity;
        public Guna.UI2.WinForms.Guna2TextBox adresseZone;
        public System.Windows.Forms.ComboBox AdresseCountry;
        public Guna.UI.WinForms.GunaAdvenceButton AdresseSavebutton;
        public System.Windows.Forms.Label label1;
    }
}

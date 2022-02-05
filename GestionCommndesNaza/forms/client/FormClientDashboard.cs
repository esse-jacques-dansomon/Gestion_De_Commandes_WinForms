using GestionCommndesNaza.components;
using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using System;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.client
{
    public partial class FormClientDashboard : Form
    {
        private Client ClientConnected { get; }

        public static System.Collections.Generic.List<OrderDetailtem> Panier = new System.Collections.Generic.List<OrderDetailtem>();
        public static double totalPanier;
        public static double totalPanierItems = 0;
        public FormClientDashboard(Client user)
        {
            InitializeComponent();
            this.Loadform(new FormClientShop(ClientConnected));
            ClientConnected = user;
            this.ClientName.Text = this.ClientConnected.Login;
            if (ClientConnected.Avatar != null)
            {
                //changment d'image
            }

        }


        private void clearChildren()
        {
            if (this.PagePanel.Controls.Count > 0)
                this.PagePanel.Controls.RemoveAt(0);
        }

        public void Loadform(object Form)
        {
            if (this.PagePanel.Controls.Count > 0)
                this.PagePanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PagePanel.Controls.Add(f);
            this.PagePanel.Tag = f;
            f.Show();
        }


        private void MakeHoverOnButton(object sender)
        {
            this.clearChildren();
            this.ActiveLocalisation.Location = ((Control)sender).Location;

        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            this.MakeHoverOnButton(sender);
            this.Loadform(new FormClientShop(ClientConnected));
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            this.MakeHoverOnButton(sender);
            this.Loadform(new FormClientProfile(ClientConnected));


        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
            form.Show();
        }

        private void PayementsButton_Click(object sender, EventArgs e)
        {
            this.MakeHoverOnButton(sender);
            this.Loadform(new FormClientOrdersAndPaies());
        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            this.MakeHoverOnButton(sender);
            this.Loadform(new FormClientOrdersAndPaies());


        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClientName_Click(object sender, EventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void ActiveLocalisation_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void PagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void seacchButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientAvatar_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

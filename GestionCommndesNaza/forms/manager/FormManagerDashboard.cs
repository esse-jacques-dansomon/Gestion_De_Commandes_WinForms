using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using GestionCommndesNaza.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.manager
{
    public partial class FormManagerDashboard : Form
    {
        private IService service = fabrique.Fabrique.GetServiceInstance();
        private Model1Container container = new Model1Container();
        private User user = FormLogin.userConnected;
        public FormManagerDashboard(User user)
        {
            InitializeComponent();
            this.UserName.Text = $"{user.Firstname}  {user.Lastname}";
            Loadform(new FormManagerProducts());
        }

        private void clearChildren()
        {
            if (this.PagePanel.Controls.Count > 0)
                this.PagePanel.Controls.RemoveAt(0);
        }
        private void MakeHoverOnButton(object sender)
        {
            this.clearChildren();
            this.ActiveLocalisation.Location = ((Control)sender).Location;

        }

        public void Loadform(object Form)
        {
            clearChildren();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PagePanel.Controls.Add(f);
            this.PagePanel.Tag = f;
            f.Show();
        }



        private void ProfileButton_Click(object sender, EventArgs e)
        {
            MakeHoverOnButton(sender);
            Loadform(new FormManagerProfile(user));
        }

        private void ButtonCategory_Click(object sender, EventArgs e)
        {
            MakeHoverOnButton(sender);
            Loadform(new FormManagerCategory());
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            MakeHoverOnButton(sender);
            Loadform(new FormManagerProducts());
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            MakeHoverOnButton(sender);
            Loadform(new FormManagerOrders());
        }
    }
}

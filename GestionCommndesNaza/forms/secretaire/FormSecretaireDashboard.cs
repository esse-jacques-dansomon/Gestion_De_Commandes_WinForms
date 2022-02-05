using GestionCommndesNaza.forms.client;
using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using System;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.secretaire
{

    public partial class FormSecretaireDashboard : Form
    {
        private User UserUserConnected { get; }

        public FormSecretaireDashboard(User user)
        {
            InitializeComponent();
            UserUserConnected = user;
            this.UserName.Text = $"{user.Firstname} {user.Lastname}";
            Loadform(new FormSecretaireOrders());

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
            Loadform(new FormSecretaireProfile(UserUserConnected));
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin form = new FormLogin();
            form.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            MakeHoverOnButton(sender);
            Loadform(new FormSecretaireOrders());
        }
    }
}

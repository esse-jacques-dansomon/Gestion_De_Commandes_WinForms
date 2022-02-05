using GestionCommndesNaza.forms.admin;
using GestionCommndesNaza.forms.client;
using GestionCommndesNaza.forms.comptable;
using GestionCommndesNaza.forms.manager;
using GestionCommndesNaza.forms.secretaire;
using GestionCommndesNaza.models;
using GestionCommndesNaza.service;
using System;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.security
{
    public partial class FormLogin : Form
    {
        private IService service = fabrique.Fabrique.GetServiceInstance();
        public static User userConnected = null;
        public FormLogin()
        {
            InitializeComponent();
            this.labelErrors.Hide();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string login = labelLogin.Text.Trim();
            string password = labelPassword.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login ou Mot de Passe Obligatoire",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                User user = this.service.searchUserByLoginAndPassword(this.labelLogin.Text, this.labelPassword.Text);

                if (user != null)
                {
                    this.labelErrors.Hide();
                    switch (user.Role)
                    {
                        case "ROLE_CLIENT":
                            this.Hide();
                            FormLogin.userConnected = (Client)user;
                            FormClientDashboard formClientShop = new FormClientDashboard((Client)user);
                            formClientShop.Show();
                            break;
                        case "ROLE_SECRETAIRE":
                            this.Hide();
                            FormLogin.userConnected = user;
                            FormSecretaireDashboard formSecretaireDashboard = new FormSecretaireDashboard(user);
                            formSecretaireDashboard.Show();
                            break;
                        case "ROLE_MANAGER":
                            this.Hide();
                            FormLogin.userConnected = user;
                            FormManagerDashboard formManagerDashboard = new FormManagerDashboard(user);
                            formManagerDashboard.Show();
                            break;
                        case "ROLE_COMPTABLE":
                            this.Hide();
                            FormLogin.userConnected = user;
                            FormComptable formCOmptable= new FormComptable();
                            formCOmptable.Show();
                            break;
                        case "ROLE_DELIVER":
                            // code block
                            break;
                        case "ROLE_ADMIN":
                            //Redirection vers la page Accueil
                            this.Hide();
                            FormAdminDashboard frm = new FormAdminDashboard(user);
                            frm.Show();
                            break;
                    }

                }
                else
                {
                    this.labelErrors.Show();
                }
            }

        }

        private void shopPassword(object sender, EventArgs e)
        {
            this.labelPassword.PasswordChar = (this.checkBoxShowPassword.Checked ? char.MinValue : '*');

        }

        private void buttonClearFileds_Click(object sender, EventArgs e)
        {
            this.labelErrors.Visible = false;
            this.labelLogin.Clear();
            this.labelPassword.Clear();
        }

        private void labelCreateAnewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }
    }
}

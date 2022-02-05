using FluentValidation.Results;
using GestionCommndesNaza.forms.client;
using GestionCommndesNaza.models;
using GestionCommndesNaza.service;
using GestionCommndesNaza.utils;
using GestionCommndesNaza.validators;
using System;
using System.Windows.Forms;

namespace GestionCommndesNaza.forms.security
{
    public partial class FormRegister : Form
    {
        private IService service = fabrique.Fabrique.GetServiceInstance();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.textPassword.PasswordChar = (this.checkBoxShowPassword.Checked ? char.MinValue : '*');
            this.textConfirmedPassword.PasswordChar = (this.checkBoxShowPassword.Checked ? char.MinValue : '*');

        }

        private void buttonClearFileds_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void buttonCreateNewAccount_Click(object sender, EventArgs e)
        {
            string passwordhash;
            if (this.textConfirmedPassword.Text != "" && this.textPassword.Text != "" && textConfirmedPassword.Text == textPassword.Text)
            {
                passwordhash = PasswordEncoder.hash(this.textPassword.Text);
            }
            else
            {
                passwordhash = null;

            }
            Client client = new Client()
            {
                Firstname = this.textFristanme.Text,
                Lastname = this.textLastanme.Text,
                Login = this.textLogin.Text,
                Password = passwordhash,
                Phone = this.textPhone.Text,
                CreatedAt = DateTime.Now,
                Role = "ROLE_CLIENT",
                Solde = 0,

            };
            ClientValidator clientValidator = new ClientValidator();
            ValidationResult result = clientValidator.Validate(client);
            if (result.IsValid == false)
            {
                string errorsText = "";
                foreach (ValidationFailure error in result.Errors)
                {
                    errorsText += error.ErrorMessage + "\n\n";
                }
                MessageBox.Show(errorsText, "Erreurs de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(" creation de compte en cours", "Commpte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Model1Container container = new Model1Container();
                container.Users.Add(client);
                container.SaveChanges();
                string message = $" Mr/mms {client.Lastname} {client.Firstname}  Votre Compte á été bien crée";
                EmailSender.SendMail(client.Login, client.Lastname + client.Firstname, "Creation de compte", message);
                MessageBox.Show(message, "Commpte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormClientDashboard formClientDashboard = new FormClientDashboard(client);
                formClientDashboard.Show();
            }

        }
    }
}

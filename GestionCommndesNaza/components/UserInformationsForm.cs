using GestionCommndesNaza.forms.security;
using GestionCommndesNaza.models;
using GestionCommndesNaza.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommndesNaza.components
{
    public partial class UserInformationsForm : UserControl
    {
        private User user;
        private Image Avatar;
        public event EventHandler OnEdit = null;

        public UserInformationsForm()
        {
            InitializeComponent();
        }

        public void SetUserInfo(User user)
        {
            this.user = user;
            Fistanme = user.Firstname;
            Lastname = user.Lastname;
            Login = user.Login;
            userInfoPhone.Text = "7+221 77 862 871 ";
            userInfoPhone.Enabled = false;

        }

        public void SetUserInfo(Client user)
        {
            this.user = user;
            Fistanme = user.Firstname;
            Lastname = user.Lastname;
            Login = user.Login;
            Phone = user.Phone;
        }


        public String Fistanme { get => this.userInfoFristanme.Text; set => this.userInfoFristanme.Text = value; }
        public String Lastname { get => this.userInfoLastname.Text; set => this.userInfoLastname.Text = value; }
        public String Login { get => this.userInfoLogin.Text; set => this.userInfoLogin.Text = value; }
        public String Password { get => this.userInfoPassword.Text; set => this.userInfoPassword.Text = value; }
        public String Phone { get => this.userInfoPhone.Text; set => this.userInfoPhone.Text = value; }

        private void ButtonUploadAvator_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                Avatar = this.userInfoPictureBox.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void UserInfoBuutonUpdate_Click(object sender, EventArgs e)
        {
            Model1Container container = new Model1Container();
            User userFound = container.Users.Find(user.Id);
            userFound.Firstname = Fistanme;
            userFound.Lastname = Lastname;
            if(Avatar != null)
                userFound.Avatar = ImageUtils.convertImageToByte(Avatar);
            container.SaveChanges();
            MessageBox.Show("Informations bien modifiées, vous devez vous reconneter");
            if (user.GetType() == typeof(User))
                SetUserInfo(userFound);
            else
                SetUserInfo((Client)userFound);
            FormLogin.userConnected = user;
            OnEdit.Invoke(this, e);


        }
        // public String bte[] { get => this.userInfoPassword.Text; set => this.userInfoPassword.Text = value; }
    }
}

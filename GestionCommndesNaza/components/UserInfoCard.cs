using GestionCommndesNaza.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommndesNaza.components
{
    public partial class UserInfoCard : UserControl
    {
        public UserInfoCard()
        {
            InitializeComponent();
        }
        public UserInfoCard(User user)
        {
            InitializeComponent();
            bindForm(user);
        }

        public void bindForm(User user)
        {
            cardUserRoleName.Text = user.Role;
            cardUserName.Text = user.Firstname;
            cardUserPhone.Visible = false;
        }

    }
}

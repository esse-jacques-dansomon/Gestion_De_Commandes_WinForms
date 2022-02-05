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

namespace GestionCommndesNaza.forms.manager
{
    public partial class FormManagerProfile : Form
    {
        public FormManagerProfile(User user)
        {
            InitializeComponent();
            this.userInformationsForm1.SetUserInfo(user);
            this.userInformationsForm1.OnEdit += (ee, ss) =>
            {
                this.userInformationsForm1.SetUserInfo(user);
            };
        }


    }
}

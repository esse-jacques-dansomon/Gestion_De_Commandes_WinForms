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

namespace GestionCommndesNaza.forms.secretaire
{
    public partial class FormSecretaireProfile : Form
    {
        public FormSecretaireProfile(User user)
        {
            InitializeComponent();
            this.userInformationsForm1.SetUserInfo(user);
            this.userInfoCard.bindForm(user);

            this.userInformationsForm1.OnEdit += (ss, ee) =>
            {
                this.userInfoCard.bindForm(user);
            };

        }
    }
}

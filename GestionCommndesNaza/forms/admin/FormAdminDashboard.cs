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

namespace GestionCommndesNaza.forms.admin
{
    public partial class FormAdminDashboard : Form
    {
        private User userconnected;
        public FormAdminDashboard(models.User user)
        {
            InitializeComponent();
            this.userconnected = user;
        }
    }
}

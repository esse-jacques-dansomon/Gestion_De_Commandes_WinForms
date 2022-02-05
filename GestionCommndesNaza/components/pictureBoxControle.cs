using GestionCommndesNaza.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GestionCommndesNaza.components
{
    public partial class pictureBoxControle : UserControl
    {

        public pictureBoxControle(byte[] image)
        {
            InitializeComponent();
            this.pictureBox1.Image = ImageUtils.convertByteToImage(image);
        }
    }
}

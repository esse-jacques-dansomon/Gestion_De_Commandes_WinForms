using GestionCommndesNaza.models;
using GestionCommndesNaza.service;
using GestionCommndesNaza.utils;
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
    public partial class FormManagerCategory : Form
    {
        private IService service = fabrique.Fabrique.GetServiceInstance();
        private Model1Container container = new Model1Container();
        private Category categorySelect;
        private Byte[] Avatar;

        public FormManagerCategory()
        {
            InitializeComponent();
            loadCategoryDataGridView(this.service.searchAllCategory());
        }


        void loadCategoryDataGridView(List<Category> categories)
        {
            this.guna2DataGridView1.DataSource = categories.ToArray();
            this.AddClick.Enabled = true;

        }

        private void AddClick_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                Libelle = this.textBoxLibelle.Text,
                Description = this.textBoxDescription.Text,
                Image = ImageUtils.convertImageToByte(this.guna2PictureBox1.Image),
            };
            container.Categories.Add(category);
            if(container.SaveChanges() > 0)
            {
                loadCategoryDataGridView(this.service.searchAllCategory());
                clearForm();
                MessageBox.Show("Category Bien AJoutée");
            }else
                MessageBox.Show("Tchalley une erreur s'est produite");
        }

        void clearForm()
        {
            this.textBoxLibelle.Clear();
            this.textBoxDescription.Clear();
                guna2PictureBox1.Image = null;
            guna2PictureBox1.Invalidate();
        }

        void LoadForm(Category category)
        {
            this.textBoxLibelle.Text = category.Libelle;
            this.textBoxDescription.Text = category.Description;
            this.guna2PictureBox1.Image = ImageUtils.convertByteToImage(category.Image);
        }


        private void UpdloadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;.*.png;)|*.jpg;*.jpeg;.*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                this.guna2PictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categorySelect = (Category)this.guna2DataGridView1.Rows[e.RowIndex].DataBoundItem;
            LoadForm(categorySelect);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if(this.categorySelect != null)
            {
                Category category = container.Categories.Find(categorySelect.Id);

                category.Libelle = textBoxLibelle.Text;
                category.Description = textBoxDescription.Text;
                ImageUtils.convertImageToByte(this.guna2PictureBox1.Image);
                container.SaveChanges();
                loadCategoryDataGridView(this.service.searchAllCategory());
                categorySelect = null;
                clearForm();
                MessageBox.Show("Category Bien Updated");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(categorySelect != null)
            {
 

                DialogResult dialogResult = MessageBox.Show("Suppression", $"Confirmer la suppression de la categorie {categorySelect.Libelle} ? ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Category category = container.Categories.Find(categorySelect.Id);
                    container.Categories.Remove(category);
                    container.SaveChanges();
                    MessageBox.Show("Categorie ete bien supprimée");
                    categorySelect = null;
                    loadCategoryDataGridView(this.service.searchAllCategory());
                    this.clearForm();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Categorie NON Suprimer");
                }

            }
            else
            {
                MessageBox.Show("Categorie n'existe pas ");
            }
        }
    }
}

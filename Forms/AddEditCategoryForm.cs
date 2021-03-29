using Cafe.Dao;
using Cafe.POJO;
using Cafe.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cafe.Forms
{
    public partial class form_add_edit_category : Form
    {
        Category editData;
        bool isUpdate = false;
        public form_add_edit_category()
        {
            InitializeComponent();
        }
        private void form_add_edit_category_Load(object sender, EventArgs e)
        {
            textBoxValidation();
        }
        private void btn_add_edit_category_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            CategoryDao categoryDao = new CategoryDao();
            category.Name = txt_cat_name.Text;
            category.Description = txt_cat_desc.Text;

            int returnId = 0;
            if (isUpdate)
            {
                category.Id = editData.Id;
                returnId = categoryDao.updateCategory(category);
            }
            else
            {
                returnId = categoryDao.insertCategory(category);
            }
            if (returnId != -1)
            {
                this.Close();
            }



        }

        public void passDataToEditForm(Category category)
        {
            editData = category;
            btn_add_edit_category.Text = "Redaktə et";
            isUpdate = true;
            txt_cat_desc.Text = category.Description;
            txt_cat_name.Text = category.Name;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cat_name_TextChanged(object sender, EventArgs e)
        {
            textBoxValidation();
        }

        private void textBoxValidation()
        {
            if (txt_cat_name.Text == "")
            {
                btn_add_edit_category.Enabled = false;
                txt_cat_name.BackColor = Color.Red;
            }
            else
            {
                btn_add_edit_category.Enabled = true;
                txt_cat_name.BackColor = default(Color);
            }
        }

      
    }
}

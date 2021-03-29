using Cafe.Dao;
using Cafe.POJO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe.Forms
{
    public partial class CategoryForm : Form
    {
        Category category;
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            lv_category.Columns.AddRange(new ColumnHeader[] {
            new ColumnHeader(){Text="Kateqoriya",Width=200},
            new ColumnHeader(){Text="ID",Width=0}

            });
            //categoryListInInterface();
            categoryListViewInInterface();
            btn_edit_category.Enabled = false;
            btn_delete_category.Enabled = false;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoryListViewInInterface()
        {
            lv_category.Items.Clear();
            CategoryDao categoryDao = new CategoryDao();
            List<Category> categories = categoryDao.getCateqogryList();
            foreach (Category category in categories)
            {
                var row = new String[] { category.Name, category.Id.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = category;

                lv_category.Items.Add(lvi);
            }
        }
        private void btn_delete_category_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(category.Name + " silməyə əminsinizmi?", "KAteqoriya", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CategoryDao categoryDao = new CategoryDao();
                int returnId = categoryDao.deleteCategory(category);
                if (returnId != 0 && returnId != null)
                {
                    //categoryListInInterface();
                    categoryListViewInInterface();
                    btn_delete_category.Enabled = false;
                    btn_edit_category.Enabled = false;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //categoryListInInterface();
            }
        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            form_add_edit_category add_Category = new form_add_edit_category();
            add_Category.ShowDialog();
            //categoryListInInterface();
            categoryListViewInInterface();
        }

        private void btn_edit_category_Click(object sender, EventArgs e)
        {
            form_add_edit_category edit_Category = new form_add_edit_category();
            edit_Category.passDataToEditForm(category);
            edit_Category.ShowDialog();
            //categoryListInInterface();
            categoryListViewInInterface();
            btn_delete_category.Enabled = false;
            btn_edit_category.Enabled = false;
        }


        private void lv_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_category.SelectedItems.Count > 0)
            {
                category = (Category)lv_category.SelectedItems[0].Tag;
                if (category.Id != 0 && category.Id != null)
                {
                    btn_edit_category.Enabled = true;
                    btn_delete_category.Enabled = true;
                }
            }
        }
    }
}

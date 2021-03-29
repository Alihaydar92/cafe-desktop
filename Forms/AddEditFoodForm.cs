using Cafe.Dao;
using Cafe.POJO;
using Cafe.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cafe.Forms
{
    public partial class form_add_edit_food : Form
    {
        FoodStuff addEditFoodStuff;
        bool isUpdate = false;
        Image foodImage;
        public form_add_edit_food()
        {
            InitializeComponent();
        }
        private void form_add_edit_food_Load(object sender, EventArgs e)
        {
            btn_add_edit_food.Enabled = categoryValidation();


            //category combo
            CategoryDao categoryDao = new CategoryDao();
            List<ComboItem> categories = categoryDao.getCategoryCombo();
            cb_category.Items.AddRange(categories.ToArray());
            if (isUpdate)
            {
                ComboUtil.setComboItemByValue(cb_category, addEditFoodStuff.Category.Id);
            }

        }
        private void btn_add_edit_food_Click(object sender, EventArgs e)
        {
            FoodStuff foodStuff = new FoodStuff();
            FoodStuffDao foodStuffDao = new FoodStuffDao();
            foodStuff.Name = txt_food_name.Text;
            foodStuff.Price = float.Parse(txt_food_price.Text);
            foodStuff.Cost = float.Parse(txt_food_cost.Text);
            foodStuff.Desc = txt_food_desc.Text;


            int categoryId = ComboUtil.getSelectedComboValue(cb_category);
            foodStuff.Category.Id = categoryId;
            int returnId;
            if (isUpdate)
            {
                foodStuff.Id = addEditFoodStuff.Id;
                returnId = foodStuffDao.updateFoodStuff(foodStuff);
            }
            else
            {
                returnId = foodStuffDao.insertFoodStuff(foodStuff);
            }

            if (returnId != -1)
            {
                this.Close();
            }
        }

        public void passFoodDataToEditForm(FoodStuff foodStuff)
        {
            btn_add_edit_food.Text = "Redaktə et";
            addEditFoodStuff = foodStuff;
            txt_food_name.Text = foodStuff.Name;
            txt_food_price.Text = foodStuff.Price.ToString();
            txt_food_cost.Text = foodStuff.Cost.ToString();
            txt_food_desc.Text = foodStuff.Desc;
            ComboUtil.setComboItemByValue(cb_category, foodStuff.Category.Id);

            isUpdate = true;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool categoryValidation()
        {
            bool btnEnabled = false;
            //val with all components for btn enabled
            if (txt_food_name.Text != "" && txt_food_price.Text != "" && txt_food_cost.Text != "" && cb_category.SelectedIndex != -1 && cb_category.Text != "")
            {
                btnEnabled = true;
            }
            else
            {
                btnEnabled = false;
            }

            //name val
            if (txt_food_name.Text != "")
            {

                txt_food_name.BackColor = default(Color);
            }
            else
            {
                txt_food_name.BackColor = Color.Red;
            }

            //price val
            if (txt_food_price.Text != "")
            {
                txt_food_price.BackColor = default(Color);
            }
            else
            {
                txt_food_price.BackColor = Color.Red;

            }

            //cost val
            if (txt_food_cost.Text != "")
            {
                txt_food_cost.BackColor = default(Color);
            }
            else
            {
                txt_food_cost.BackColor = Color.Red;

            }
            //category val
            if (cb_category.SelectedIndex != -1 && cb_category.Text != "")
            {

                cb_category.BackColor = default(Color);

            }
            else if (cb_category.SelectedIndex == -1 && cb_category.Text == "")
            {
                cb_category.BackColor = Color.Red;
            }
            return btnEnabled;
        }

        private void txt_food_name_TextChanged(object sender, EventArgs e)
        {
            btn_add_edit_food.Enabled = categoryValidation();
        }

        private void txt_food_price_TextChanged(object sender, EventArgs e)
        {
            btn_add_edit_food.Enabled = categoryValidation();
        }

        private void txt_food_cost_TextChanged(object sender, EventArgs e)
        {
            btn_add_edit_food.Enabled = categoryValidation();
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add_edit_food.Enabled = categoryValidation();
        }
    }
}

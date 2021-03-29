using Cafe.Dao;
using Cafe.POJO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Cafe.Forms
{
    public partial class FoodStuffForm : Form
    {
        FoodStuff foodStuff;
        DataTable foodDT = new DataTable();
        List<DTColumn> foodDTColumns = new List<DTColumn>();
        public FoodStuffForm()
        {
            InitializeComponent();
        }
        private void FoodStuffForm_Load(object sender, EventArgs e)
        {
            foodStuff = new FoodStuff();          
            foodStuffListOnInterface();
        }
      
        private void foodStuffListOnInterface()
        {
            FoodStuffDao foodStuffDao = new FoodStuffDao();
            List<FoodStuff> foodStuffs = foodStuffDao.listFoodStuffs();
            foodDT = foodStuffDao.getFoodDT(foodStuffs);
            dgv_food.DataSource = foodDT;
            btn_edit_food.Enabled = false;
            btn_delete_food.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_add_food_Click(object sender, EventArgs e)
        {
            form_add_edit_food formAddFood = new form_add_edit_food();
            formAddFood.ShowDialog();
            btn_edit_food.Enabled = false;
            btn_delete_food.Enabled = false;
            foodStuffListOnInterface();
        }

        private void btn_edit_food_Click(object sender, EventArgs e)
        {
            form_add_edit_food formEditFood = new form_add_edit_food();
            formEditFood.passFoodDataToEditForm(foodStuff);
            formEditFood.ShowDialog();
            btn_edit_food.Enabled = false;
            btn_delete_food.Enabled = false;
            foodStuffListOnInterface();
        }

        private void btn_delete_food_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(foodStuff.Name + " silməyə əminsinizmi?", "QİDA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FoodStuffDao foodStuffDao = new FoodStuffDao();
                int returnId = foodStuffDao.deleteFoodStuff(foodStuff);

                if (returnId != 0 && returnId != null)
                {
                    foodStuffListOnInterface();
                    btn_edit_food.Enabled = false;
                    btn_delete_food.Enabled = false;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void dgv_food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                DataGridViewRow selectedRow = dgv_food.Rows[index];
               foodStuff.Id = (int)selectedRow.Cells["id"].Value;
               foodStuff.Category.Id = (int)selectedRow.Cells["categoryId"].Value;
               foodStuff.Name = (string)selectedRow.Cells["foodName"].Value;
               foodStuff.Desc = (string)selectedRow.Cells["desc"].Value;
               foodStuff.Price = (float)selectedRow.Cells["price"].Value;
               foodStuff.Cost = (float)selectedRow.Cells["cost"].Value;
                if (foodStuff.Id != 0 && foodStuff != null)
                {
                    btn_edit_food.Enabled = true;
                    btn_delete_food.Enabled = true;
                }
            }
        }
    }
}

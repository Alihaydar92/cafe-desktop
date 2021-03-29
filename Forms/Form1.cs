using Cafe.Dao;
using Cafe.Forms;
using Cafe.POJO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form1 : Form
    {
        private DoubleClickButton button;
        Category category;
        //global tableID(stolun id-si)
        Table table;
        //global waiter
        //Waiter waiter;
        //data table totalGridColumns
        List<DTColumn> totalGridColumns = new List<DTColumn>();
        //total data table
        DataTable totalDT = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //table flow layout
            tableListOnInterface();
            btn_close_table.Enabled = false;
            //category flow layout
            categoryListOnInterface();
            flow_category.Enabled = false;

            //food stuff layout
            foodStuffListOnInterface();
            flow_food_stuffs.Enabled = false;

            //create columns
            totalGridColumns = createTotalDTColumns(totalGridColumns);

            for (int i = 0; i < totalGridColumns.Count; i++)
            {
                totalDT.Columns.Add(totalGridColumns[i].ColumnName, totalGridColumns[i].Type, totalGridColumns[i].Expression);
            }


            //yalniz count sutunundan basqa diger sutunlarin setrlerine  mudaxile etmek olmasin
            totalDT.Columns["id"].ReadOnly = true;
            totalDT.Columns["tableName"].ReadOnly = true;
            totalDT.Columns["foodName"].ReadOnly = true;
            totalDT.Columns["price"].ReadOnly = true;
            //totalDT.Columns["total"].ReadOnly = true;

            dataGridView_total.DataSource = totalDT;
            setGridViewParams(dataGridView_total);
        }

        //menu
        private void menu_strip_add_table_Click(object sender, EventArgs e)
        {
            TableForm1 tableForm = new TableForm1();
            tableForm.ShowDialog();
            tableListOnInterface();
            categoryListOnInterface();
            foodStuffListOnInterface();
        }
        private void menu_strip_add_category_Click(object sender, EventArgs e)
        {
            CategoryForm form_Category = new CategoryForm();
            form_Category.ShowDialog();
            categoryListOnInterface();
            tableListOnInterface();
            foodStuffListOnInterface();
        }


        private void menu_strip_add_food_Click(object sender, EventArgs e)
        {
            FoodStuffForm foodStuffForm = new FoodStuffForm();
            foodStuffForm.ShowDialog();
            tableListOnInterface();
            foodStuffListOnInterface();
            categoryListOnInterface();
        }
        //menu


        private void customTableComponentClick(object sender, EventArgs e)
        {
            totalDT.Clear();
            table = (Table)((CustomTable)sender).Tag;
            if (table.Id != 0 && table.Id != null && table.Total.Status)
            {
                flow_category.Enabled = true;
            }
            btn_close_table.Enabled = table.Total.Status;
            TableDetailsDao totalDao = new TableDetailsDao();
            List<TableDetails> totals = totalDao.getTableDetailsByTableId(table.Id);
            totalDT = totalDao.getTotalData(totals);
            dataGridView_total.DataSource = totalDT;
            panel_c.Enabled = table.Total.Status;
            panel_center.Enabled = table.Total.Status;
            lbl_table_name.Text = table.Name;
            if (table.Waiter != null)
            {
                lbl_waiter_name.Text = table.Waiter.Name;
            }
        }
        ToolStripMenuItem toolStripMenuItem;
        private void contextMenuStrip_open_table_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStrip_open_table.Items.Clear();

            WaiterDao waiterDao = new WaiterDao();

            List<Waiter> waiters = waiterDao.GetWaiters();

            foreach (var waiter in waiters)
            {
                toolStripMenuItem = new ToolStripMenuItem();
                this.contextMenuStrip_open_table.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem});
                toolStripMenuItem.Text = waiter.Name;
                toolStripMenuItem.Name = waiter.Name;
                toolStripMenuItem.Tag = waiter;
                //ContextMenuStrip subItem = new ContextMenuStrip(car);
                //tsm_table.DropDownItems.Add(subItem);
                toolStripMenuItem.Click += tsm_table_Click;
            }

            table = (Table)((sender as ContextMenuStrip).SourceControl as CustomTable).Tag;
            if (table.Total.Status)
            {
                contextMenuStrip_open_table.Enabled = false;
            }
            else
            {
                contextMenuStrip_open_table.Enabled = true;
            }

        }
        //click context open table
        #region tableclick

        private void tsm_table_Click(object sender, EventArgs e)
        {

            table.Waiter = (Waiter)((ToolStripMenuItem)sender).Tag;

            TotalDao totalDao = new TotalDao();
            MessageBox.Show("table open table id : " + table.Id + " name:" + table.Name + " waiter id:  " + table.Waiter.Id);
            int returnId = totalDao.insertTotal(table.Id, table.Waiter.Id);
            MessageBox.Show("returnId open table: " + returnId);
            if (returnId != 0 && returnId != null)
            {
                tableListOnInterface();
                lbl_table_name.Text = table.Name;
                lbl_waiter_name.Text = table.Waiter.Name;
            }
        }
        #endregion
        //button stolu bagla
        private void btnCategoryClick(object sender, EventArgs e)
        {
            category = (Category)((Button)sender).Tag;
            if (category.Id != 0 && category.Id != null)
            {
                flow_food_stuffs.Enabled = true;
            }
            FoodStuffDao foodStuffDao = new FoodStuffDao();
            List<FoodStuff> foodStuffs = foodStuffDao.getFoodStuffsByCategoryId(category.Id);
            foodStuffListOnInterface(foodStuffs);
        }

        private void btnFoodDoubleClick(object sender, EventArgs e)
        {

            TableDetails total = new TableDetails();
            FoodStuff foodStuff = (FoodStuff)((Button)sender).Tag;
            total.Table = table;
            total.FoodStuff = foodStuff;
            bool isHave = chekcIfRowExistInDtTotal(total, true);
            if (!isHave)
            {
                addToTotalDataTable(total);
            }


        }
        private void Row_Changed(object sender, DataRowChangeEventArgs e)
        {
            TableDetails total = new TableDetails();

            total.Table = table;

            total.FoodStuff.Name = (string)e.Row["foodName"];
            total.FoodStuff.Price = (float)e.Row["price"];
            total.Sum = (float)e.Row["total"];
            total.FoodQty = (int)e.Row["count"];
            //chekcIfRowExistInDtTotal(total, false);
        }

        private void foodStuffListOnInterface()
        {
            flow_food_stuffs.Controls.Clear();
            FoodStuffDao foodStuffsDao = new FoodStuffDao();
            List<FoodStuff> foodStuffs = foodStuffsDao.listFoodStuffs();
            foreach (FoodStuff food in foodStuffs)
            {
                //Button button = new Button();
                button = new DoubleClickButton();
                button.Size = new Size(200, 50);
                button.Tag = food;
                button.Text = food.Name;
                button.DoubleClick += new EventHandler(btnFoodDoubleClick);
                flow_food_stuffs.Controls.Add(button);
            }
        }
        private void foodStuffListOnInterface(List<FoodStuff> foodStuffs)
        {
            flow_food_stuffs.Controls.Clear();

            foreach (FoodStuff food in foodStuffs)
            {
                //Button button = new Button();
                button = new DoubleClickButton();
                button.Size = new Size(200, 50);
                button.Tag = food;
                button.Text = food.Name;
                //button.MouseClick += btnFoodDoubleClick;
                button.DoubleClick += new EventHandler(btnFoodDoubleClick);
                flow_food_stuffs.Controls.Add(button);
            }
        }
        public void tableListOnInterface()
        {
            flow_table.Controls.Clear();
            //table flow layout
            TableDao tableDao = new TableDao();
            List<Table> tables = tableDao.getTableList();
            foreach (Table table in tables)
            {
                CustomTable tableControl = new CustomTable();
                tableControl.Tag = table;
                tsm_table.Tag = table;

                tableControl.setTable(table);
                if (table.Total.Status)
                {
                    tsm_table.Enabled = false;
                    tableControl.BackColor = Color.Green;
                }
                else
                {
                    tsm_table.Enabled = true;
                    tableControl.BackColor = Color.Red;
                }

                tableControl.Click += customTableComponentClick;
                tableControl.ContextMenuStrip = this.contextMenuStrip_open_table;


                flow_table.Controls.Add(tableControl);
            }
        }
        public void categoryListOnInterface()
        {
            flow_category.Controls.Clear();
            CategoryDao categoryDao = new CategoryDao();
            List<Category> categories = categoryDao.getCateqogryList();
            foreach (Category c in categories)
            {
                Button button = new Button();
                button.Size = new Size(268, 50);
                button.Tag = c;
                button.Text = c.Name;
                button.Click += btnCategoryClick;
                //CustomCategory customCategory = new CustomCategory();
                //customCategory.Tag = c;
                //customCategory.setLabelName(c);
                //customCategory.setPic(c);
                //customCategory.Click += customCategoryClick;

                flow_category.Controls.Add(button);
            }
        }
        //datableye category kliki ile setrlerin elave edilmesi
        private void addToTotalDataTable(TableDetails tableDetails)
        {
            TableDetailsDao totalDao = new TableDetailsDao();
            tableDetails.FoodQty = 1;
            tableDetails.Sum = tableDetails.FoodQty * tableDetails.FoodStuff.Price;
            int returnId = totalDao.insertTableDetails(tableDetails);
            if (returnId != 0)
            {

                DataRow dataRow = totalDT.NewRow();
                dataRow["id"] = returnId;
                dataRow["tableName"] = tableDetails.Table.Name;
                dataRow["foodName"] = tableDetails.FoodStuff.Name;
                dataRow["count"] = 1;
                dataRow["price"] = tableDetails.FoodStuff.Price;
                dataRow["total"] = 0;
                totalDT.Rows.Add(dataRow);
                //if (tableDetails.Table.Status=true)
                //{

                //}
            }


        }
        private List<DTColumn> createTotalDTColumns(List<DTColumn> totalGridColumns)
        {
            totalGridColumns.Add(new DTColumn("id", "totalID", typeof(int), false, 1, ""));
            totalGridColumns.Add(new DTColumn("tableName", "Stol no.", typeof(string), true, 10, ""));
            totalGridColumns.Add(new DTColumn("foodName", "Qida adı", typeof(string), true, 10, ""));
            totalGridColumns.Add(new DTColumn("count", "Say", typeof(int), true, 5, ""));
            totalGridColumns.Add(new DTColumn("price", "Qiymət", typeof(float), true, 5, ""));
            totalGridColumns.Add(new DTColumn("total", "Cəm", typeof(float), true, 5, "[price] * [count]"));
            //totalDT.Columns["total"].Expression = "[count] * [price]";
            return totalGridColumns;
        }
        private void setGridViewParams(DataGridView dgv)
        {
            int totalWidth = 0;
            for (int i = 1; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = totalGridColumns[i - 1].ColumnCaption;
                dgv.Columns[i].Visible = totalGridColumns[i - 1].ColumnVisible;
                //dgv.Columns[i].MinimumWidth = totalGridColumns[i].MinimumWidth;
                //totalWidth = totalWidth + totalGridColumns[i].MinimumWidth;
            }
            //return totalWidth;
        }
        //eger elave edilmis data varsa yene elave etdikde yeni setr yox sadece cari setrin say sutununun  countu artir
        private bool chekcIfRowExistInDtTotal(TableDetails tableDetails, bool isDoubleClick)
        {

            bool isHave = false;

            foreach (DataRow allRow in totalDT.Select())
            {
                Console.WriteLine("allRow: " + allRow["foodName"]);
                if ((string)allRow["foodName"] == tableDetails.FoodStuff.Name)
                {
                    Console.WriteLine("allRow foodName== total.FoodStuff.Name  " + allRow["foodName"] + "  " + tableDetails.FoodStuff.Name);
                    if (isDoubleClick)
                    {
                        allRow["count"] = (int)allRow["count"] + 1;
                    }

                    tableDetails.FoodStuff.Price = (float)allRow["price"];
                    tableDetails.FoodQty = (int)allRow["count"];
                    tableDetails.Sum = (float)allRow["total"];
                    tableDetails.Id = (int)allRow["id"];
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-= " + allRow["foodName"] + "  " + allRow["total"] + " " + allRow["id"]);
                    TableDetailsDao totalDao = new TableDetailsDao();
                    //MessageBox.Show("total id : " + total.Id);
                    int returnId = totalDao.updateTableDetails(tableDetails);
                    isHave = true;
                    return isHave;
                    //break;
                }
                //break;
            }
            totalDT.RowChanged += new DataRowChangeEventHandler(Row_Changed);
            return isHave;
        }


        //secilmis setri silmek ucun event
        private void dataGridView_total_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TableDetailsDao tableDetailsDao = new TableDetailsDao();
            if (e.RowIndex == dataGridView_total.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dataGridView_total.Columns["btnDelete"].Index)
            {
                DataGridViewRow selectedRow = dataGridView_total.Rows[e.RowIndex];
                int tdId = (int)selectedRow.Cells["id"].Value;
                int retDeleteID = tableDetailsDao.deleteTableDetails(tdId);
                if (retDeleteID != 0 && retDeleteID != -1 && retDeleteID != null)
                {
                    totalDT.Rows[e.RowIndex].Delete();
                }

            }
        }


        private void btn_close_table_Click(object sender, EventArgs e)
        {
            TableDetailsDao totalDao = new TableDetailsDao();
            Total total = new Total();
            total.Status = false;
            total.TableId = table.Id;
            int returnId = totalDao.updateStatusTotal(total);
            MessageBox.Show("returnid close table: " + returnId);
            if (returnId != 0 && returnId != null)
            {
                tableListOnInterface();
                btn_close_table.Enabled = false;
                lbl_table_name.Text = "";
                lbl_waiter_name.Text = "";
                flow_category.Enabled = false;
                flow_food_stuffs.Enabled = false;
            }
            totalDT.Clear();
        }


    }
    public class DoubleClickButton : Button
    {
        public DoubleClickButton() : base()
        {
            // Set the style so a double click event occurs.
            SetStyle(ControlStyles.StandardClick |
                ControlStyles.StandardDoubleClick, true);
        }
    }
}

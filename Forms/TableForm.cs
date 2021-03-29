using Cafe.Dao;
using Cafe.POJO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cafe.Forms
{
    public partial class TableForm1 : Form
    {
        Table table;
        public TableForm1()
        {
            InitializeComponent();
        }
       
        private void TableForm_Load(object sender, EventArgs e)
        {
            lv_table.Columns.AddRange(new ColumnHeader[]
         {
                new ColumnHeader() {Text = "STOL",Width=140},
                new ColumnHeader() {Text = "ID",Width=0 }
         });
            //listview table
            tableListViewOnInterface();
            //tableListOnInterface();
            btn_edit_table.Enabled = false;
            btn_delete_table.Enabled = false;
        }
        private void btn_add_table_Click(object sender, EventArgs e)
        {
            form_add_edit_table form_Add = new form_add_edit_table();
            form_Add.ShowDialog();
            //tableListOnInterface();
            tableListViewOnInterface();
            btn_edit_table.Enabled = false;
            btn_delete_table.Enabled = false;
        }

        private void btn_edit_table_Click(object sender, EventArgs e)
        {

            form_add_edit_table form_Edit = new form_add_edit_table();
            form_Edit.passTableDataToEditForm(table);
            form_Edit.ShowDialog();
            //tableListOnInterface();
            tableListViewOnInterface();
            btn_edit_table.Enabled = false;
            btn_delete_table.Enabled = false;
        }

        private void btn_delete_table_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(table.Name + " silməyə əminsinizmi?", "STOL", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TableDao tableDao = new TableDao();
                int returnId = tableDao.deleteTable(table);
                if (returnId != 0 && returnId != null)
                {
                    //tableListOnInterface();
                    tableListViewOnInterface();
                    btn_edit_table.Enabled = false;
                    btn_delete_table.Enabled = false;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        public void tableListViewOnInterface()
        {

            lv_table.Items.Clear();
            //table flow layout
            TableDao tableDao = new TableDao();
            List<Table> tables = tableDao.getTableList();
            foreach (Table table in tables)
            {
                var row = new String[] { table.Name, table.Id.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = table;
                lv_table.Items.Add(lvi);

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_table.SelectedItems.Count > 0)
            {
                table = (Table)lv_table.SelectedItems[0].Tag;
                if (table.Id != 0 && table.Id != null)
                {
                    btn_edit_table.Enabled = true;
                    btn_delete_table.Enabled = true;
                }
            }

        }
    }
}

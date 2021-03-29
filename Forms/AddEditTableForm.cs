using Cafe.Dao;
using Cafe.POJO;
using Cafe.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cafe.Forms
{
    public partial class form_add_edit_table : Form
    {
        Table addEdittable;
        bool isUpdate = false;
        public form_add_edit_table()
        {
            InitializeComponent();
        }
        private void form_add_edit_table_Load(object sender, EventArgs e)
        {
            textBoxValidation();
        }

        private void btn_add_edit_table_Click(object sender, EventArgs e)
        {
            TableDao tableDao = new TableDao();
            Table table = new Table();
            table.Name = txt_table_name.Text;
            table.Description = txt_table_desc.Text;
            int returnId;
            if (isUpdate)
            {
                table.Id = addEdittable.Id;
                returnId = tableDao.updateTable(table);

            }
            else
            {
                returnId = tableDao.insertTable(table);
               
            }
            if (returnId != -1)
            {
                this.Close();
            }
            if (returnId == -9)
            {
                MessageBox.Show("Belə bir STOL adı mövcuddur");
            }
        }

        public void passTableDataToEditForm(Table table)
        {
            btn_add_edit_table.Text = "Redaktə et";
            addEdittable = table;
            txt_table_name.Text = addEdittable.Name;
            txt_table_desc.Text = addEdittable.Description;
            isUpdate = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_table_name_TextChanged(object sender, EventArgs e)
        {
            textBoxValidation();
        }

        private void textBoxValidation()
        {
            if (txt_table_name.Text == "")
            {
                btn_add_edit_table.Enabled = false;
                txt_table_name.BackColor = Color.Red;
            }
            else
            {
                btn_add_edit_table.Enabled = true;
                txt_table_name.BackColor = default(Color);
            }
        }
    }
}

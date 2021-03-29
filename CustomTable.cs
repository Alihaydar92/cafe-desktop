using Cafe.Dao;
using Cafe.POJO;
using System;
using System.Windows.Forms;

namespace Cafe
{
    public partial class CustomTable : UserControl
    {
        int tableID;
        public CustomTable()
        {
            InitializeComponent();

        }
        public void setTable(Table table)
        {
            lbl_table_name.Text = table.Name;
            tableID = table.Id;
        }

    }
}

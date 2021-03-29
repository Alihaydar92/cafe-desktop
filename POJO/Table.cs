using System;
using System.Drawing;

namespace Cafe.POJO
{
    public class Table
    {
        private int id;
        private string name;
        private string description;
        private DateTime insertDate;
        private Total total;
        private Waiter waiter;

        public Table()
        {
            this.Total = new Total();
            this.waiter = new Waiter();
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Waiter Waiter { get => waiter; set => waiter = value; }
        internal Total Total { get => total; set => total = value; }
        //public DateTime InsertDate { get => insertDate; set => insertDate = value; }
        public override string ToString()
        {
            return "Table{" +
                "id=" + id +
                ", name=" + name +
                ", description='" + description + '\'' +
                ", insertDate='" + insertDate + '\'' +
                ", total='" + Total + '\'' +
                ", waiter='" + Waiter + '\'' +
                '}';
        }
    }
}

using System;

namespace Cafe.POJO
{
    class TableDetails
    {
        private int id;
        private Table table;
        private FoodStuff foodStuff;
        private DateTime insertDate;
        private int foodQty;
        private float sum;
        private bool status;

        public int Id { get => id; set => id = value; }
        public Table Table { get => table; set => table = value; }
        public DateTime InsertDate { get => insertDate; set => insertDate = value; }

        internal FoodStuff FoodStuff { get => foodStuff; set => foodStuff = value; }
        public int FoodQty { get => foodQty; set => foodQty = value; }
        public float Sum { get => sum; set => sum = value; }
        public bool Status { get => status; set => status = value; }

        public TableDetails()
        {
            this.foodStuff = new FoodStuff();
            this.table = new Table();
        }
    }
}

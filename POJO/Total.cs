namespace Cafe.POJO
{
    class Total
    {
        private int id;
        //private Table table;
        private bool status;
        private int tableId; 

        //public Total()
        //{
        //    this.table = new Table();
        //}
        public int Id { get => id; set => id = value; }
        //public Table Table { get => table; set => table = value; }
        public bool Status { get => status; set => status = value; }
        public int TableId { get => tableId; set => tableId = value; }
    }
}

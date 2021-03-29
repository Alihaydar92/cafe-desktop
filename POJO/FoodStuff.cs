using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.POJO
{
   public class FoodStuff
    {
        private int id;
        private string name;
        private float price;
        private float cost;
        private Category category;
        private bool status;
        private string desc;

        public FoodStuff()
        
        {
            this.Category = new Category();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public Category Category { get => category; set => category = value; }
        public bool Status { get => status; set => status = value; }
        public float Cost { get => cost; set => cost = value; }
        public string Desc { get => desc; set => desc = value; }
    }
}

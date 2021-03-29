using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.POJO
{
   public  class ComboItem
    {
        private int id;
        private string name;

        public ComboItem(int c_id,string c_text)
        {
            id = c_id;
            name = c_text;
        }
        
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public override string ToString()
        {
            return name;
        }
    }
}

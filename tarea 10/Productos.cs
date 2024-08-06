using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_10
{
    public class Productos
    {
        public string ID  { get; set; }
        public string Name { get; set; }
        public double Price  { get; set; }

        public Productos(string iD, string name, double price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }
        
    }
}

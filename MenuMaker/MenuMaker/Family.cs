using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    internal class Family:List<Person>
    {
        Storage products { get; set; }
        public Family(Storage storage)
        {
            products = storage;
        }
        public List<List<Product>> MakeMenu()
        { 
            List<List<Product>> list = new List<List<Product>>();
            for (int i = 0; i < this.Count; i++)
            {
                list.Add(products.MakeMenu(this[i]));
            }
            return list;
        }
        public void ADD(Person p)
        {
            this.Add(p);
        }
    }
}

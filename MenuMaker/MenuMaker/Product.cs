using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    internal class Product
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        Category category { get; set; }
        public Product(string name, int weight, Category c)
        {
            Name = name;
            Weight = weight;
            category = c;
        }
        
    }
    public enum Category { isfruit,isvegetable}
}

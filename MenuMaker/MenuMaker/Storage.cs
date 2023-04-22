using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    internal class Storage:List<Product>
    {
        public Storage()
        {

        }
        public void ADD(Product c)
        {
            this.Add(c);
        }
        public List<Product> MakeMenu(Person p)
        {
            return this;
        }
        public void Delete(Product c)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].Name == c.Name)
                {
                    if (this[i].Weight > c.Weight)
                    {
                        this[i].Weight=this[i].Weight-c.Weight;
                    }
                    else
                    {
                        this.RemoveAt(i);
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaker
{
    internal class Person
    {
        int Age { get; set; }
        int Weight { get; set; }
        int Height { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        public Person(int age,int weight,int height,int level,string name)
        {
            Age = age;
            Weight = weight;
            Height = height;
            Level = level;
            Name = name;
        }
    }
}

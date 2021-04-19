using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Class_3
{
    class Cat
    {
        public string Name;
        public string Color;

        public Cat(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public void Meow()
        {
            WriteLine($"{Name} : 야옹야옹야옹야옹~~~~~~~");
        }
    }
}

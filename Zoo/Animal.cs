using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract int Legs { get; set; }

        public Animal(string name, int legs)
        {
            Name = name;
            Legs = legs;
        }

        public abstract void Eat();

        public abstract void Sleep();
        public abstract void Sound();



    }
}

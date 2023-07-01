using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Mammals : Animal
    {
        public override string Name { get; set; }
        public override int Legs { get; set; }

        public virtual bool HasFur { get; set; }
        public virtual bool Horns { get; set; } 
        public Mammals(string name, int legs ) : base(name, legs)
        {
        }
        public override void Eat()
        {
            Console.WriteLine($"The {Name} is eating");
        }

        public override void Sleep()
        {
            Console.WriteLine($"The {Name} is sleeping");
        }
        public override void Sound()
        {
            Console.WriteLine($"This mammals  {Name} is Sounding");
        }
        public virtual void Group()
        {
            Console.WriteLine($"This mammals {Name} is lives in Troop ");

        }
    }


}


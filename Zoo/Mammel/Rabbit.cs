using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Rabbit : Mammals, IAnimalBehavior
    {
        public override bool Horns { get; set; }

        public Rabbit(string name, int leg, bool hasFurs, bool horns) : base(name, leg)
        {

        }
        public override void Group()
        {
            Console.WriteLine($"This {Name} is lives in Troop ");

        }

        public bool EatMeat()
        {
            Console.WriteLine($"The {Name} is not eat meat");
            return false;

        }
    }
}

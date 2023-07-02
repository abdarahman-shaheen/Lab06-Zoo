using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Dair : Mammals, IAnimalBehavior
    {
        public override bool Horns { get; set; }
        public override bool HasFur { get; set; }


        public Dair(string name, int leg,bool hasFurs, bool horns) : base(name,leg) 
        {

            HasFur = hasFurs;
            Horns = horns;


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

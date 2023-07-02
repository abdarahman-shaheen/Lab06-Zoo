using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Snake : Reptile , IAnimal, IAnimalBehavior
    {
        public override bool Scales { get; set; }
        public override bool Fangs { get; set; }
            public int Age { get ; set ; }

        public Snake(string name,int leg, bool scales, bool fangs,int age) : base(name, leg)
        {
            Age = age;
            Scales = scales;
            Fangs = fangs;
        }
        public override void Swim()
        {
            Console.WriteLine($"The {Name} is not swimming");
        }
        public override void Sleep()
        {
            Console.WriteLine($"the {Name} is sleeping");
        }

        public void Run()
        {
            Console.WriteLine($"The {Name} is running");
        }

        public bool EatMeat()
        {
      
                Console.WriteLine($"The {Name} is eat meat");
            
         return true;
        }

    }
}
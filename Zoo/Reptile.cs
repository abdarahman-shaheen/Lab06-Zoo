using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
     public abstract class Reptile : Animal
    {
        public override string Name { get; set; }
        public override int Legs { get; set; }

        public virtual bool Scales { get; set; }
        public virtual bool Fangs { get; set; }


        public Reptile(string name,int leg):base(name,leg)
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
            Console.WriteLine($"The  {Name} is Sounding");
        }
        public virtual void Swim() {
            Console.WriteLine($"The  {Name} is Sounding");
                }



    }
}

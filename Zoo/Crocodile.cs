using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Crocodile : Reptile
    {
        public override bool Scales { get; set; }
        public override bool Fangs { get; set; }

        public Crocodile(string name, int leg, bool scales, bool fangs) : base(name, leg)
        {
            Scales = scales;
            Fangs = fangs;
        }
        public override void Swim()
        {
            Console.WriteLine("The Crocodile is swimming");
        }
    }
}

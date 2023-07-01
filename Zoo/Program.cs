using Zoo.Mammel;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this are some facts of mammals:");
            Mammals m1 = new Lion("lion", 4, true, true);
            Mammals m2 = new Rabbit("rabbit", 4, true, true);

            m1.Sleep();
            m1.Group();
            Console.WriteLine($" {m2.Name} do eating :");
            m2.Eat();

            Console.WriteLine(" ");
            Console.WriteLine("this are some facts of reptiles:");
            Reptile r1 = new Snake("snaks",0, true, true);
            Reptile r2 = new Crocodile("Crocodile", 4, true, true);

            r1.Sleep();
            r1.Swim();
            Console.WriteLine($" {r2.Name} do sound :");
            r2.Sound();
            Console.ReadLine();
        }

    }
}
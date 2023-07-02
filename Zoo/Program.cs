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

            Animal d1= new Dair("dair1",4,true,true);
            d1.Eat();
            d1.Sleep();

            Console.WriteLine(" ......");
            Console.WriteLine("this are some facts of reptiles:");
            Reptile r1 = new Snake("snaks",0, true, true,22);
            Reptile r2 = new Crocodile("Crocodile", 4, true, true,50);

            r1.Sleep();
            r1.Swim();
            Console.WriteLine($" {r2.Name} do sound :");
            r2.Sound();

            Console.WriteLine("Interface:");
            Snake s1 = new Snake("snak1", 0, true, true, 22);
            Lion l1 = new Lion("lion1", 4, true, true);
            Console.WriteLine(s1.Age);
            s1.Run();
            s1.EatMeat();
            l1.EatMeat();
            Console.ReadLine();

        }



        }
    }

using Zoo.Mammel;
using Zoo;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Lion()
        {
            Mammals m1 = new Lion("lion", 4, true, true);
            string result = m1.Name;
            Assert.Equal("lion", result);
        }

        [Fact]
        public void Rabbit()
        {
            Mammals m1 = new Rabbit("rabbit",4, true, true);
            string result = m1.Name;
            Assert.Equal("rabbit", result);
        }
        [Fact]
        public void Dair()
        {
            Mammals m1 = new Dair("dair",2, true, true);
            string result = m1.Name;
            Assert.Equal("dair", result);


        }

        
        [Fact]
        public void Snake()
        {
            Reptile r1 = new Snake("snake", 0, true, true);
            int result = r1.Legs;
            Assert.Equal(0,result);


        }
        [Fact]
        public void Crocodiles()
        {
            Reptile r1 = new Crocodile("Crocodile", 4, true, true);
            bool result = r1.Scales;
            Assert.True(result);
        }
    }
}
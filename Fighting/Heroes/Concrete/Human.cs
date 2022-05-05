using Fighting.Heroes.Abstract;

namespace Fighting.Heroes.Concrete
{
    public class Human : Hero
    {
        public Human(string name, int healthPoints) : base(name, healthPoints)
        {
            
        }

        public override string Exclaim() => "I'm a the best warrior";
    }
}
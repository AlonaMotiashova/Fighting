using Fighting.Heroes.Abstract;

namespace Fighting.Heroes.Concrete
{
    public class Dwarf : Hero
    {
        public Dwarf(string name, int healthPoints) : base(name, healthPoints)
        {

        }

        public override string Exclaim() => "You`re not stronger than my mountains, bastard!";
    }
}
using Fighting.Heroes.Abstract;

namespace Fighting.Heroes.Concrete
{
    public class Elf : Hero
    {
        public Elf(string name, int healthPoints) : base(name, healthPoints)
        {

        }

        public override string Exclaim() => "Slaaaaay, bitch!";
    }
}
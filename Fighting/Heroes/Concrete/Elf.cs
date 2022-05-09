using System;
using Fighting.Heroes.Abstract;

namespace Fighting.Heroes.Concrete
{
    public class Elf : CompetitiveHero
    {
        public Elf(string name, int healthPoints) : base(name, healthPoints)
        {

        }

        public override string Exclaim() => "Slaaaaay, bitch!";
        public override void TakePartInTournament()
        {
            Console.WriteLine($"I`m, {Name} has the strongest magic spelss in the world");
        }
    }
}
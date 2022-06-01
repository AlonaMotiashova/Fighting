using System;
using Fighting.Heroes.Abstract;

namespace Fighting.Heroes
{
    public class Human : CompetitiveHero
    {
        public Human(string name, int healthPoints) : base(name, healthPoints)
        {
            
        }

        public override string Exclaim() => "I'm a the best warrior";
        
        public override void TakePartInTournament()
        {
            Console.WriteLine($"I`m, {Name}, the greatest warrior in the world. I will definitely win");
        }
    }
}
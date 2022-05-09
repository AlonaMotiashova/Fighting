using System;
using Fighting.Heroes.Abstract;

namespace Fighting.FightHandlers
{
    public class CommonFightHandler
    {
        public static void Fight(Hero aggressor, Hero defender)
        {
            Console.WriteLine($"{aggressor.Name} has attacked {defender.Name}");
            var damage = aggressor.Attack();
            var resultOfDefense = defender.Defend(damage);
            if (resultOfDefense)
                Console.WriteLine($"{defender.Name} has defended successfully");
            else
            {
                Console.WriteLine($"{aggressor.Name} has won this battle");
                aggressor.Exclaim();
            }
        }
    }
}

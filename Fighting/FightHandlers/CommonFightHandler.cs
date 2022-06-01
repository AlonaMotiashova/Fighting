using Fighting.Heroes.Abstract;
using System;

namespace Fighting.FightHandlers;
public class CommonFightHandler
{
    public static void Fight(Hero aggressor, Hero defender)
    {
        Console.WriteLine($"{aggressor.Name} is going to attack {defender.Name}");
        var attack = aggressor.Attack();
        if (attack is not null)
        {
            Console.WriteLine($"{aggressor.Name} has hit using {attack.Value.Item2}");

            var resultOfDefense = defender.Defend(attack.Value.Item1);

            if (resultOfDefense)
                Console.WriteLine($"{defender.Name} has defended successfully");
            else
            {
                Console.WriteLine($"{aggressor.Name} has won this battle");
                aggressor.Exclaim();
            }
        }
        else
        {
            Console.WriteLine($"The warrior {aggressor.Name} is so poor that he doen't have any weapon. Shame on him");
        }

    }
}

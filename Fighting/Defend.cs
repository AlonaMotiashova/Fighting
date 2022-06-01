using Fighting.Constants;
using System;

namespace Fighting
{
    public class Defend
    {
        public void DefendAgainstEnemy(string shieldName, string defenderName)
        {
            if (shieldName == ShieldConstants.Magic)
            {
                Console.WriteLine($"{defenderName} protected themselves with a magic fire shield and fired the enemy`s ass a bit.");
            }
            else if (shieldName == ShieldConstants.Default)
            {
                Console.WriteLine($"{defenderName} protected themselves with a default shield.");
            }
            else if (shieldName == ShieldConstants.Mud)
            {
                Console.WriteLine($"Did {defenderName} really try to protect themselves with mud????");
            }
        }
    }
}

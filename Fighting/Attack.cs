using Fighting.Constants;
using System;

namespace Fighting
{
    public class Attack
    {
        public void AttackEnemy(string weaponName, string attackerName, string defenderName)
        {
            if (weaponName == WeaponConstants.Spell)
            {
                Console.WriteLine($"{attackerName} hit {defenderName} with a spell on diarrhea.");
            }
            else if (weaponName == WeaponConstants.FlockOfBirds)
            {
                Console.WriteLine($"{attackerName} attacked {defenderName} with a flock of birds.");
            }
            else if (weaponName == WeaponConstants.Knife)
            {
                Console.WriteLine($"{attackerName} cut the {defenderName} with a knife.");
            }
        }
    }
}

using Fighting.Constants;
using System;

namespace Fighting
{
    class Game
    {
        static void Main(string[] args)
        {
            var humanWeapon = new Weapon(WeaponConstants.Knife, WeaponConstants.KnifeDamage);
            var elfWeapon = new Weapon(WeaponConstants.FlockOfBirds, WeaponConstants.FlockOfBirdsDamage);
            var humanShield = new Shield(ShieldConstants.DefaultShield, ShieldConstants.DefaultShieldDefend);
            var elfShield = new Shield(ShieldConstants.FineShield, ShieldConstants.FineShieldDefend);

            //var human = new Human(humanWeapon, humanShield, "Human");
            Creature elf = new Elf(elfWeapon, elfShield, "Elf");
            elf = new ShortLivingElf(elf);
            Console.WriteLine("Elf name: "+ elf.Name);
            Console.WriteLine(elf.Exclaim());
            Console.WriteLine("Elf army Life Number: "+ elf.ArmyLifeNumber().ToString());
        }
    }
}

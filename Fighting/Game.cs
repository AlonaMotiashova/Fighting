using Fighting.Constants;
using System;

namespace Fighting
{
    class Game
    {
        static void Main(string[] args)
        {
            var humanWeapon = new Weapon(WeaponConstants.Knife, (int)WeaponDamageConstants.Knife);
            var elfWeapon = new Weapon(WeaponConstants.FlockOfBirds, (int)WeaponDamageConstants.FlockOfBirds);
            var humanShield = new Shield(ShieldConstants.Default, (int)ShieldDefendConstants.DefaultShield);
            var elfShield = new Shield(ShieldConstants.Fine, (int)ShieldDefendConstants.FineShield);

            var human = new Human(humanWeapon, humanShield, "Human");
            Creature elf = new Elf(elfWeapon, elfShield, "Elf");
            elf = new ShortLivingElf(elf);
            Console.WriteLine("Elf name: "+ elf.Name);
            Console.WriteLine(elf.Exclaim());
            Console.WriteLine("Elf army Life Number: "+ elf.ArmyLifeNumber().ToString());
        }
    }
}

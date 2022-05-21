using Fighting.Constants;
using System;

namespace Fighting
{
    class Game
    {
        static void Main(string[] args)
        {
            var humanWeapon = new Weapon(WeaponConstants.knife, WeaponConstants.knifeDamage);
            var elfWeapon = new Weapon(WeaponConstants.flockOfBirds, WeaponConstants.flockOfBirdsDamage);
            var humanShield = new Shield(ShieldConstants.defaultShield, ShieldConstants.defaultShieldDefend);
            var elfShield = new Shield(ShieldConstants.fineShield, ShieldConstants.fineShieldDefend);

            var human = new Human(humanWeapon, humanShield, "Human");
            var elf = new Elf(elfWeapon, elfShield, "Elf");
            var damage = human.Attack(human.Name);
            elf.Defend(damage, elf.Shield);

            var Dagger = new WeaponStore("Dagger", 10000, "Out Of Stock");
            var firstCreature = new Human("Human", Dagger);
            var secondCreature = new Elf("Elf", Dagger);
            var thirdCreature = new Dwarf("Dwarf", Dagger);
            Console.WriteLine("Dagger current state : " + Dagger.GetAvailability());
            Console.WriteLine();
            Dagger.SetAvailability("Available");
        }
    }
}

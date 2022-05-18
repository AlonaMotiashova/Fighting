using Fighting.Constants;
using System;

namespace Fighting
{
    class Program
    {
        static void Main(string[] args)
        {
            var humanWeapon = new Weapon(WeaponConstants.hammer, WeaponConstants.hammerDamage);
            var elfWeapon = new Weapon(WeaponConstants.flockOfBirds, WeaponConstants.flockOfBirdsDamage);
            var humanShield = new Shield(ShieldConstants.defaultShield, ShieldConstants.defaultShieldDefend);
            var elfShield = new Shield(ShieldConstants.fineShield, ShieldConstants.fineShieldDefend);

            var human = new Human(humanWeapon, humanShield, "Human");
            var elf = new Elf(elfWeapon, elfShield, "Elf");
            var damage = human.Attack(human.name);
            elf.Defend(damage, elf.shield);


            var Dagger = new Subject("Dagger", 10000, "Out Of Stock");
            var creature1 = new Human("Human", Dagger);
            var creature2 = new Elf("Elf", Dagger);
            var creature3 = new Dwarf("Dwarf", Dagger);
            Console.WriteLine("Dagger current state : " + Dagger.getAvailability());
            Console.WriteLine();
            // Now product is available
            Dagger.setAvailability("Available");
        }
    }
}

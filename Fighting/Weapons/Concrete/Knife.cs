using System;

namespace Fighting.Weapons.Concrete
{
    public class Knife : Weapons.Abstract.Weapon
    {
        public Knife(int damage, string weaponName) : base(damage, weaponName)
        {
        }

        public override int Harm()
        {
            Console.WriteLine("Knife is cutting");
            return Damage;
        }
    }
}

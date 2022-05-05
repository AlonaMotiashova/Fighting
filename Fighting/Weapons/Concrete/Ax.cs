using System;
using Fighting.Weapons.Abstract;

namespace Fighting.Weapons.Concrete
{
    internal class Ax : Weapon
    {
        public Ax(int damage, string weaponName) : base(damage, weaponName)
        {
        }

        public override int Harm()
        {
            Console.WriteLine("The ax is hacking");
            return Damage;
        }
    }
}

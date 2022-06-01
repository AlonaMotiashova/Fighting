using System;
using Fighting.Weapons.Abstract;

namespace Fighting.Weapons
{
    public class Ax : Weapon
    {
        private const string HarmPhrase = "The ax is hacking";

        public Ax(int damage, string weaponName) : base(damage, weaponName)
        {
        }

        public override int Harm()
        {
            Console.WriteLine(HarmPhrase);
            return Damage;
        }
    }
}

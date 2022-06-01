using System;
using Fighting.Weapons.Abstract;

namespace Fighting.Weapons
{
    public class Knife : Weapon
    {
        private const string HarmPhrase = "Knife is cutting";

        public Knife(int damage, string weaponName) : base(damage, weaponName)
        {
        }

        public override int Harm()
        {
            Console.WriteLine(HarmPhrase);
            return Damage;
        }
    }
}

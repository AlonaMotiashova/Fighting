using System;

namespace Fighting.Weapons
{
    public class SpellOfDiarrhea : Abstract.Weapon
    {
        private const string HarmPhrase = "The spell causes diarrhea in enemies";

        public SpellOfDiarrhea(int damage, string weaponName) : base(damage, weaponName)
        {
        }

        public override int Harm()
        {
            Console.WriteLine(HarmPhrase);
            return Damage;
        }
    }
}

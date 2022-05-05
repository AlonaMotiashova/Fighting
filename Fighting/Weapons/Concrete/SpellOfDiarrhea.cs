using System;

namespace Fighting.Weapons.Concrete
{
    public class SpellOfDiarrhea : Abstract.Weapon
    {
        public SpellOfDiarrhea(int damage, string weaponName) : base(damage, weaponName)
        {
        }

        public override int Harm()
        {
            Console.WriteLine("The spell causes diarrhea in enemies");
            return Damage;
        }
    }
}

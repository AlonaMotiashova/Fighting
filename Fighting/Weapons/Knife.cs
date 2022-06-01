using Fighting.Weapons.Abstract;

namespace Fighting.Weapons
{
    public class Knife : Weapon
    {
        private const string HarmPhrase = "The (name) is cutting";

        public Knife(int damage, string weaponName) : base(damage, weaponName)
        {
        }

        public override (int, string) Harm() =>
            (Damage, HarmPhrase.Replace("(name)", WeaponName));
    }
}

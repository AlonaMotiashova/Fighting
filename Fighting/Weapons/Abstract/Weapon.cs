namespace Fighting.Weapons.Abstract
{
    public abstract class Weapon
    {
        protected Weapon(int damage, string weaponName)
        {
            Damage = damage;
            WeaponName = weaponName;
        }

        public string WeaponName { get; private set; }
        public int Damage { get; private set; }
        
        public abstract int Harm();
    }
}
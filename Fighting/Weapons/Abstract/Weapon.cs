using System;

namespace Fighting.Weapons.Abstract
{
    public abstract class Weapon
    {
        protected Weapon(int damage, string weaponName)
        {
            Damage = damage;
            WeaponName = weaponName;
        }

        public string WeaponName { get; protected set; }
        public int Damage { get; protected set; }

        public abstract (int, string) Harm();
    }
}
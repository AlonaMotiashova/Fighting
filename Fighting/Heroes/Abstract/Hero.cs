using Fighting.Shields.Abstract;
using Fighting.Weapons.Abstract;

namespace Fighting.Heroes.Abstract
{
    public abstract class Hero
    {
        protected Hero(string name, int health, Weapon weapon, Shield shield) 
            : this(name, health)
        {
            Weapon = weapon;
            Shield = shield;
        }

        protected Hero(string name, int health)
        {
            Health = health;
            Name = name;
        }

        public int Health { get; protected set; }
        public string Name { get; private set; }
        public Weapon Weapon { get; set; }
        public Shield Shield { get; set; }

        /// <summary>
        /// Attack enemy with weapon
        /// </summary>
        /// <returns>The harm which you have done</returns>
        public virtual int Attack()
        {
            var damage = 0;

            if (Weapon is not null)
            {
                damage = Weapon.Harm();
            }

            return damage;
        }

        /// <summary>
        /// Defend from an enemy with a shield.
        /// </summary>
        /// <param name="damage">Damage from the enemy.</param>
        /// <returns>The info about protection success</returns>
        public virtual bool Defend(int damage)
        {
            var finalDamage = damage;

            if (Shield is not null)
                finalDamage = Shield.Protect(damage);

            var currentHealth = finalDamage <= 0 ? Health - finalDamage : Health;

            Health = currentHealth >= 0 ? currentHealth : 0;

            return Health > 0;
        }

        /// <summary>
        /// Exclaim when the enemy hits.
        /// </summary>
        /// <returns>The phrase your hero shouts</returns>
        public abstract string Exclaim();
    }
}

using System;

namespace Fighting
{
    public abstract class Creature
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public Weapon Weapon { get; set; }
        public Shield Shield { get; set; }

        public abstract int ArmyLifeNumber();

        public Creature(Weapon weapon, Shield shield, string name)
        {
            Weapon = weapon;
            Name = name;
            Shield = shield;
            Health = 100;
        }

        public Creature(string name)
        {
            Name = name;

        }

        public int Attack(string defenderName)
        {
            if (!string.IsNullOrEmpty(Weapon.Name))
            {
                Attack attack = new Attack();
                attack.AttackEnemy(Weapon.Name, Name, defenderName);
            }
            else
                Console.WriteLine($"Oh wait! {Name} has no weapon.");
            return Weapon.Strength;
        }

        public void Defend(int damage, Shield shield)
        {
            Defend defend = new Defend();
            defend.DefendAgainstEnemy(shield.Name, Name);
            Health = GetHealth(damage, shield.Strength);
        }

        public int GetHealth(int damage, int strength)
        {
            var overallDamage = damage - strength;
            var currentHealth = overallDamage < 0
                ? Health
                : Health - overallDamage;
            if (currentHealth <= 0)
                Health += ArmyLifeNumber();
            Console.WriteLine("Health:" + currentHealth.ToString());
            return Health = currentHealth >= 0
                ? currentHealth
                : 0;
        }

        public abstract string Exclaim();

        public void Update(string availabiliy)
        {
            Console.WriteLine("Hi " + Name + ", Weapon is now " + availabiliy + " on the warehouse");
        }
    }
}

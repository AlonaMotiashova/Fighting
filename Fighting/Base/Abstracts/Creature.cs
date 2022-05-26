using Fighting.Constants;
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

                if (Weapon.Name == WeaponConstants.Spell)
                {
                    Console.WriteLine($"{Name} hit {defenderName} with a spell on diarrhea.");
                }
                else if (Weapon.Name == WeaponConstants.FlockOfBirds)
                {
                    Console.WriteLine($"{Name} attacked {defenderName} with a flock of birds.");
                }
                else if (Weapon.Name == WeaponConstants.Knife)
                {
                    Console.WriteLine($"{Name} cut the {defenderName} with a knife.");
                }
            }
            else
                Console.WriteLine($"Oh wait! {Name} has no weapon.");
            return Weapon.Strength;
        }

        public void Defend(int damage, Shield shield)
        {
            if (shield.Name == ShieldConstants.MagicShield)
            {
                Console.WriteLine($"{Name} protected themselves with a magic fire shield and fired the enemy`s ass a bit.");
            }
            else if (shield.Name == ShieldConstants.DefaultShield)
            {
                Console.WriteLine($"{Name} protected themselves with a default shield.");
            }
            else if (shield.Name == ShieldConstants.Mud)
            {
                Console.WriteLine($"Did {Name} really try to protect themselves with mud????");
            }
            Health = GetHealth(damage, shield.Strength);
        }

        public int GetHealth(int damage, int strength)
        {
            var overallDamage = damage - strength;
            var currentHealth = overallDamage < 0
                ? Health
                : Health - overallDamage;
            System.Console.WriteLine("Health:" + currentHealth.ToString());
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

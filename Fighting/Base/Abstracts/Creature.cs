using Fighting.Constants;
using System;

namespace Fighting
{
    public abstract class Creature : IObserver
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public Weapon Weapon { get; set; }
        public Shield Shield { get; set; }

        public Creature(string userName, ISubject subject)
        {
            Name = userName;
            subject.RegisterObserver(this);
        }

        public Creature(Weapon weapon, Shield shield, string name)
        {
            Weapon = weapon;
            Name = name;
            Shield = shield;
            Health = 100;
        }

        public int Attack(string defenderName)
        {
            if (!string.IsNullOrEmpty(Weapon.Name))
            {

                if (Weapon.Name == WeaponConstants.spell)
                {
                    Console.WriteLine($"{Name} hit {defenderName} with a spell on diarrhea.");
                }
                else if (Weapon.Name == WeaponConstants.flockOfBirds)
                {
                    Console.WriteLine($"{Name} attacked {defenderName} with a flock of birds.");
                }
                else if (Weapon.Name == WeaponConstants.knife)
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
            if (shield.Name == ShieldConstants.magicShield)
            {
                Console.WriteLine($"{Name} protected themselves with a magic fire shield and fired the enemy`s ass a bit.");
            }
            else if (shield.Name == ShieldConstants.defaultShield)
            {
                Console.WriteLine($"{Name} protected themselves with a default shield.");
            }
            else if (shield.Name == ShieldConstants.mud)
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

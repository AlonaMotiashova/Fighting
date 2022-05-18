using Fighting.Constants;
using System;
using System.Collections.Generic;

namespace Fighting
{
    public abstract class Creature
    {
        public int Health { get; set; }

        public string name { get; set; }
        public Weapon weapon { get; set; }
        public Shield shield { get; set; }

        public int Attack(string defenderName)
        {
            if (!string.IsNullOrEmpty(weapon.Name)){

                if (weapon.Name == WeaponConstants.spell)
                {
                    Console.WriteLine($"{name} hit {defenderName} with a spell on diarrhea.");
                }
                else if (weapon.Name == WeaponConstants.flockOfBirds)
                {
                    Console.WriteLine($"{name} attacked {defenderName} with a flock of birds.");
                }
                else if (weapon.Name == WeaponConstants.knife)
                {
                    Console.WriteLine($"{name} cut the {defenderName} with a knife.");
                }

                //Defend(defenderName, weapon.Strength, shield);
            }
            else
                Console.WriteLine($"Oh wait! {name} has no weapon.");
            return weapon.Strength;
        }

        public void Defend(int damage, Shield shield)
        {
            if (shield.Name == ShieldConstants.magicShield)
            {
                Console.WriteLine($"{name} protected themselves with a magic fire shield and fired the enemy`s ass a bit.");
            }
            else if (shield.Name == ShieldConstants.defaultShield)
            {
                Console.WriteLine($"{name} protected themselves with a default shield.");
            }
            else if (shield.Name == ShieldConstants.mud)
            {
                Console.WriteLine($"Did {name} really try to protect themselves with mud????");
            }
            Health = GetHealth(damage, shield.Strength);
        }

        public int GetHealth(int damage, int strength)
        {
            var overallDamage = damage - strength;
            var currentHealth = overallDamage < 0
                ? Health
                : Health - overallDamage;
            System.Console.WriteLine("Health:"+ currentHealth.ToString());
            return Health = currentHealth >= 0
                ? currentHealth
                : 0;
        }

        public abstract string Exclaim();
    }
}

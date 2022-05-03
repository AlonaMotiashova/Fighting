using System;

namespace Fighting
{
    public class Human
    {
        private string _name;
        private string _weapon;
        private string _shield;

        public int Health { get; set; }

        public Human()
        {
            Health = 100;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName() => _name;

        public void SetWeapon(string weapon)
        {
            _weapon = weapon;
        }

        public string GetWeapon() => _weapon;

        public void SetShield(string shield)
        {
            _shield = shield;
        }

        public string GetShield() => _shield;

        /// <summary>
        /// Attack a dwarf with a weapon.
        /// </summary>
        public void Attack(Dwarf dwarf)
        {
            if (_weapon == "spell on diarrhea")
            {
                Console.WriteLine($"{_name} hit {dwarf.GetName()} with a spell on diarrhea.");
                dwarf.Defend(10);
            }
            else if (_weapon == "sword")
            {
                Console.WriteLine($"{_name} attacked {dwarf.GetName()} with a sword.");
                dwarf.Defend(5);
            }
            else if (_weapon == "knife")
            {
                Console.WriteLine($"{_name} cut the {dwarf.GetName()} with a knife.");
                dwarf.Defend(3);
            }
            else if (string.IsNullOrEmpty(_weapon))
                Console.WriteLine($"Oh wait! {_name} has no weapon.");
        }

        /// <summary>
        /// Attack a elf with a weapon.
        /// </summary>
        public void Attack(Elf elf)
        {
            if (_weapon == "spell on diarrhea")
            {
                Console.WriteLine($"{_name} hit {elf.GetName()} with a spell on diarrhea.");
                elf.Defend(10);
            }
            else if (_weapon == "sword")
            {
                Console.WriteLine($"{_name} attacked {elf.GetName()} with a sword.");
                elf.Defend(5);
            }
            else if (_weapon == "knife")
            {
                Console.WriteLine($"{_name} cut the {elf.GetName()} with a knife.");
                elf.Defend(3);
            }
            else if (string.IsNullOrEmpty(_weapon))
                Console.WriteLine($"Oh wait! {_name} has no weapon.");
        }

        /// <summary>
        /// Attack a human with a weapon.
        /// </summary>
        public void Attack(Human human)
        {
            if (_weapon == "spell on diarrhea")
            {
                Console.WriteLine($"{_name} hit {human.GetName()} with a spell on diarrhea.");
                human.Defend(10);
            }
            else if (_weapon == "sword")
            {
                Console.WriteLine($"{_name} attacked {human.GetName()} with a sword.");
                human.Defend(5);
            }
            else if (_weapon == "knife")
            {
                Console.WriteLine($"{_name} cut the {human.GetName()} with a knife.");
                human.Defend(3);
            }
            else if (string.IsNullOrEmpty(_weapon))
                Console.WriteLine($"Oh wait! {_name} has no weapon.");
        }

        /// <summary>
        /// Defend from an enemy with a shield.
        /// </summary>
        /// <param name="damage">Damage from the enemy.</param>
        public void Defend(int damage)
        {
            if (_shield == "magic fire shield")
            {
                Console.WriteLine($"{_name} protected themselves with a magic fire shield and fired the enemy`s ass a bit.");
                var overallDamage = damage - 10;
                var currentHealth = overallDamage < 0
                    ? Health - overallDamage
                    : Health;
                Health = currentHealth >= 0
                    ? currentHealth
                    : 0;
            }
            else if (_weapon == "default shield")
            {
                Console.WriteLine($"{_name} protected themselves with a default shield.");
                var overallDamage = damage - 5;
                var currentHealth = overallDamage < 0
                    ? Health - overallDamage
                    : Health;
                Health = currentHealth >= 0
                    ? currentHealth
                    : 0;
            }
            else if (_weapon == "mud")
            {
                Console.WriteLine($"Did {_name} really try to protect themselves with mud????");
                var overallDamage = damage - 0;
                var currentHealth = overallDamage < 0
                    ? Health - overallDamage
                    : Health;
                Health = currentHealth >= 0
                    ? currentHealth
                    : 0;
            }
        }

        /// <summary>
        /// Exclaim when the enemy hits.
        /// </summary>
        /// <returns></returns>
        public string Exclaim() => "!";
    }
}
using System;

namespace Fighting
{
    public class Dwarf
    {
        private string _name;
        private string _weapon;
        private string _shield;

        public int Health { get; set; }

        public Dwarf()
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
            if (_weapon == "hammer")
            {
                Console.WriteLine($"{_name} shred the {dwarf._name} with a hammer.");
                dwarf.Defend(10);
            }
            else if (_weapon == "pickaxe")
            {
                Console.WriteLine($"{_name} hit the {dwarf._name} with a pickaxe.");
                dwarf.Defend(5);
            }
            else if (_weapon == "knife")
            {
                Console.WriteLine($"{_name} cut the {dwarf._name} with a knife.");
                dwarf.Defend(3);
            }
            else if (string.IsNullOrEmpty(_weapon))
                Console.WriteLine($"Oh wait! {_name} has no weapon.");
        }

        /// <summary>
        /// Attack an elf with a weapon.
        /// </summary>
        public void Attack(Elf elf)
        {
            if (_weapon == "hammer")
            {
                Console.WriteLine($"{_name} shred the {elf.GetName()} with a hammer.");
                elf.Defend(10);
            }
            else if (_weapon == "pickaxe")
            {
                Console.WriteLine($"{_name} hit the {elf.GetName()} with a pickaxe.");
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
            if (_shield == "fine shield")
            {
                Console.WriteLine($"{_name} repulsed the attack with a fine shield. What a good move it was!");

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
            else if (_weapon == "shit and sticks")
            {
                Console.WriteLine($"{_name} chose shit and sticks to survive from the attack. Not the best choice.");

                var overallDamage = damage - 1;
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
        public string Exclaim() => "You`re not stronger than my mountains, bastard!";
    }
}
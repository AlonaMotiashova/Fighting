using Fighting.Constants;
using System;

namespace Fighting
{
    public class Dwarf : Creature, IObserver
    {
        public Dwarf(Weapon _weapon, Shield _shield, string _name)
        {
            weapon = _weapon;
            shield = _shield;
            name = _name;
            Health = 100;
        }

        /// <summary>
        /// Exclaim when the enemy hits.
        /// </summary>
        /// <returns></returns>
        public override string Exclaim() => ExclaimConstants.dwarfExclaim;

        public Dwarf(string userName, ISubject subject)
        {
            name = userName;
            subject.RegisterObserver(this);
        }

        public void update(string availabiliy)
        {
            Console.WriteLine("Hi " + name + ", Weapon is now " + availabiliy + " on the warehouse");
        }
    }
}
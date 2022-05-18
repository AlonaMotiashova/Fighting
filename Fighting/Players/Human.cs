using Fighting.Constants;
using System;

namespace Fighting
{
    public class Human : Creature, IObserver
    {
        public Human(Weapon _weapon, Shield _shield, string _name)
        {
            weapon = _weapon;
            shield = _shield;
            name = _name;
            Health = 100;
        }
       
        public Human(string userName, ISubject subject)
        {
            name = userName;
            subject.RegisterObserver(this);
        }

        /// <summary>
        /// Exclaim when the enemy hits.
        /// </summary>
        /// <returns></returns>
        public override string Exclaim() => ExclaimConstants.humanExclaim;

        public void update(string availabiliy)
        {
            Console.WriteLine("Hi " + name + ", Weapon is now " + availabiliy + " on the warehouse");
        }

    }
}
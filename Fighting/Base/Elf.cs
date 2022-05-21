using Fighting.Constants;
using System;

namespace Fighting
{
    public class Elf : Creature
    {
        public Elf(Weapon _weapon, Shield _shield, string _name)
            : base(_weapon, _shield, _name)
        {
        }

        public Elf(string userName, ISubject subject)
            : base(userName, subject)
        {
        }
        /// <summary>
        /// Exclaim when the enemy hits.
        /// </summary>
        /// <returns></returns>
        public override string Exclaim() => ExclaimConstants.elfExclaim;
    }
}
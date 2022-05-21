using Fighting.Constants;

namespace Fighting
{
    public class Dwarf : Creature
    {
        public Dwarf(Weapon _weapon, Shield _shield, string _name)
            : base(_weapon, _shield, _name)
        {
        }

        public Dwarf(string userName, ISubject subject)
            : base(userName, subject)
        {
        }
        /// <summary>
        /// Exclaim when the enemy hits.
        /// </summary>
        /// <returns></returns>
        public override string Exclaim() => ExclaimConstants.dwarfExclaim;
    }
}
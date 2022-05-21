using Fighting.Constants;

namespace Fighting
{
    public class Human : Creature, IObserver
    {
        public Human(Weapon _weapon, Shield _shield, string _name)
            : base(_weapon, _shield, _name)
        {
        }

        public Human(string userName, ISubject subject)
            : base(userName, subject)
        {
        }
        /// <summary>
        /// Exclaim when the enemy hits.
        /// </summary>
        /// <returns></returns>
        public override string Exclaim() => ExclaimConstants.humanExclaim;
    }
}
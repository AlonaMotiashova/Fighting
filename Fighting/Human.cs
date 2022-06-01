using Fighting.Constants;

namespace Fighting
{
    public class Human : Creature
    {
        public Human(Weapon _weapon, Shield _shield, string _name)
            : base(_weapon, _shield, _name)
        {
        }

        /// <summary>
        /// Exclaim when the enemy hits.
        /// </summary>
        /// <returns></returns>
        public override string Exclaim() => ExclaimConstants.Human;
        public override int ArmyLifeNumber() => (int)ArmyLifeNumberConstants.HumanArmy;
    }
}
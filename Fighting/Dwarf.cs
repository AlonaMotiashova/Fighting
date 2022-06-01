using Fighting.Constants;

namespace Fighting
{
    public class Dwarf : Creature
    {
        public Dwarf(Weapon _weapon, Shield _shield, string _name)
            : base(_weapon, _shield, _name)
        {
        }

        /// <summary>
        /// Exclaim when the enemy hits.
        /// </summary>
        /// <returns></returns>
        public override string Exclaim() => ExclaimConstants.Dwarf;
        public override int ArmyLifeNumber()=> (int)ArmyLifeNumberConstants.DwarfArmy;
    }
}
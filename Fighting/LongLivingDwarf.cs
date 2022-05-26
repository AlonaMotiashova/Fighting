using Fighting.Constants;

namespace Fighting
{
    public class LongLivingDwarf : CreatureDecorator
    {
        #region constants 
        private static int AdditionalLifeNumber = 1000;
        #endregion

        public LongLivingDwarf(Creature creature) : base("Long living " + creature.Name, creature)
        {

        }
        public override int ArmyLifeNumber()
        {
            return creature.ArmyLifeNumber() + AdditionalLifeNumber;
        }
        public override string Exclaim()
        {
            return ExclaimConstants.LongLivingdwarfExclaim;
        }
    }
}

using Fighting.Constants;

namespace Fighting
{
    public class ShortLivingElf : CreatureDecorator
    {
        #region constants 
        private static int AdditionalLifeNumber = 100;
        #endregion

        public ShortLivingElf(Creature creature) : base("Short living " + creature.Name, creature)
        {

        }
        public override int ArmyLifeNumber()
        {
            return creature.ArmyLifeNumber() < 1 ? 1 : creature.ArmyLifeNumber() - AdditionalLifeNumber;
        }
        public override string Exclaim()
        {
            return ExclaimConstants.ShortLivingElfExclaim;
        }
    }
}

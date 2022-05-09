using Fighting.Shields.Abstract;
using Fighting.Weapons.Abstract;

namespace Fighting.Heroes.Abstract
{
    public abstract class CompetitiveHero : Hero
    {
        protected CompetitiveHero(string name, int health, Weapon weapon, Shield shield) 
            : base(name, health, weapon, shield)
        {
        }

        protected CompetitiveHero(string name, int health) 
            : base(name, health)
        {
        }

        public abstract void TakePartInTournament();
    }
}

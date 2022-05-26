namespace Fighting
{
    public abstract class CreatureDecorator : Creature
    {
        protected Creature creature;
        public CreatureDecorator(string name, Creature creature) : base(name)
        {
            this.creature = creature;
        }
    }
}

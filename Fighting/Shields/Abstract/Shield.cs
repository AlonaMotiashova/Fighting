namespace Fighting.Shields.Abstract
{
    public abstract class Shield
    {
        protected Shield(string name, int damageResist)
        {
            ShieldName = name;
            DamageResist = damageResist;
        }

        public string ShieldName { get; private set; }
        public int DamageResist { get; private set; }

        public virtual int Protect(int damage)
        {
            var result = damage - DamageResist;
            return result > 0 ? result : 0;
        }
    }
}
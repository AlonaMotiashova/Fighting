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

        public abstract int Protect(int damage);
    }
}
namespace Fighting
{
    public abstract class Creature
    {
        public void Attack<T>(T type)
        {

        }

        public void Defend(int damage)
        {


        }

        //public int GetHealth(int damage, int value)
        //{
        //    var overallDamage = damage - value;
        //    var currentHealth = overallDamage < 0
        //        ? Health - overallDamage
        //        : Health;
        //    return Health = currentHealth >= 0
        //        ? currentHealth
        //        : 0;
        //}
    }
}

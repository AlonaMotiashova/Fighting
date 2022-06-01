namespace Fighting
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public Weapon(string name, int strength)
        {
            Name = name;
            Strength = strength;
        }
    }
}

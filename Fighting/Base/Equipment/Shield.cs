namespace Fighting
{
    public class Shield
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public Shield(string name, int strength)
        {
            Name = name;
            Strength = strength;
        }
    }
}

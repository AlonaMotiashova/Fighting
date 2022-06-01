using Fighting.Shields.Abstract;
using System;

namespace Fighting.Shields.Concrete
{
    public class WoodShield : Shield
    {
        private const string ProtectionPhrase = "A shield from old oak protects you";

        public WoodShield(string name, int damageResist) : base(name, damageResist)
        {
        }

        public override int Protect(int damage)
        {
            Console.WriteLine(ProtectionPhrase);
            return base.Protect(damage);
        }
    }
}

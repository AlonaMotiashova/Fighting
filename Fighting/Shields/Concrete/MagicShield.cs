using Fighting.Shields.Abstract;
using System;

namespace Fighting.Shields.Concrete
{
    public class MagicShield : Shield
    {
        private const string ProtectionPhrase = "Abra kadabra!!. Magic will protect you";

        public MagicShield(string name, int damageResist) : base(name, damageResist)
        {
        }

        public override int Protect(int damage)
        {
            Console.WriteLine(ProtectionPhrase);
            return base.Protect(damage);
        }
    }
}

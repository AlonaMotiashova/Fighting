using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public Weapon (string name, int strength){
            Name = name;
            Strength = strength;
        }
    }
}

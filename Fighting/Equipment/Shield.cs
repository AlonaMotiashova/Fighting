using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

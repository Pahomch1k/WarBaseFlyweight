using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Dz_13_WarBaseFlyweight
{
    class CombatUnits
    {
        public string Name { get; set; }

        public int Speed { get; set; }

        public int Power { get; set; } 

        public void Show(int x, int y)
        {
            WriteLine($"{Name} - x:{x}, y:{y}");
        }
    }
}

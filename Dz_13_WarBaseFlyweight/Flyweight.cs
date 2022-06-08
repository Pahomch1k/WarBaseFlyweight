using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_13_WarBaseFlyweight
{
    class Flyweight
    {
        private CombatUnits _sharedState;

        public Flyweight(CombatUnits Combatunits)
        {
            _sharedState = Combatunits;
        } 
    }
}

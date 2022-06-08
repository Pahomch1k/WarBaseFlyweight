using System;
using System.Collections.Generic;
using System.Linq;

namespace Dz_13_WarBaseFlyweight
{
    class Program
    {
        static void Main(string[] args)
        { 
            var factory = new FlyweightFactory(
                new CombatUnits { Name = "Пехота", Speed = 10, Power = 100 },
                new CombatUnits { Name = "Танки", Speed = 20, Power = 100 },
                new CombatUnits { Name = "Мечники", Speed = 30, Power = 100 },
                new CombatUnits { Name = "Снайпера", Speed = 40, Power = 100 },
                new CombatUnits { Name = "Артилерия", Speed = 50, Power = 100 }
            );
            factory.listFlyweights();

            addCarToPoliceDatabase(factory, new CombatUnits
            {
                Name = "Пехота",
                Speed = 10,
                Power = 100
            });

            addCarToPoliceDatabase(factory, new CombatUnits
            {
                Name = "Мото",
                Speed = 10,
                Power = 110
            });

            factory.listFlyweights(); 
        }

        public static void addCarToPoliceDatabase(FlyweightFactory factory, CombatUnits Combatunits)
        {
            Console.WriteLine("\nClient: Adding a CombatUnits to database.");

            var flyweight = factory.GetFlyweight(new CombatUnits
            {
                Name = Combatunits.Name,
                Speed = Combatunits.Speed,
                Power = Combatunits.Power
            }); 
        }
    }
}

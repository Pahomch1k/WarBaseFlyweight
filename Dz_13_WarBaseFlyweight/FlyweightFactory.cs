using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz_13_WarBaseFlyweight
{
    class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params CombatUnits[] args)
        {
            foreach (var elem in args) 
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), getKey(elem))); 
        }
         
        public string getKey(CombatUnits key)
        {
            var elements = new List<string>();

            elements.Add(key.Name); 
            elements.Add(key.Power.ToString());
            elements.Add(key.Speed.ToString()); 

            elements.Sort();

            return string.Join("_", elements);
        }
         
        public Flyweight GetFlyweight(CombatUnits sharedState)
        {
            string key = getKey(sharedState);

            if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else WriteLine("FlyweightFactory: Reusing existing flyweight."); 

            return flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void listFlyweights()
        {
            var count = flyweights.Count;
            WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights) 
                WriteLine(flyweight.Item2); 
        }
    }
}

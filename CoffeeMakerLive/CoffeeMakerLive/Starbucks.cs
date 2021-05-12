using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMakerLive
{
    public class StubStarbucks
    {
        public class Starbucks : IMakeACoffee
        {
            public bool CheckIngredientAvailability()
            {
                return true;
            }

            public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
            {
                return "";
            }
        }

    }
}
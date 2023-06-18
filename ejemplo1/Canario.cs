using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Canario : AnimalDomestico, Flyable
    {
        public string volar()
        {
            return "vuela como el viento...";
        }
    }
}

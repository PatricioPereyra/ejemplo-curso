using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Gato : AnimalDomestico
    {
        public override string comunicarse()
        {
            //Sonido que emiten los gatos
            return "miau, miau, miau...";
        }

    }
}

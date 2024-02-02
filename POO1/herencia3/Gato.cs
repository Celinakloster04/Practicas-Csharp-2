using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Gato : AnimalDomestico
    {
        public override string comunicarse()
        {
            return "Miau... miau...";
        }
    }
}

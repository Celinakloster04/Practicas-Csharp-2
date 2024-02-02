using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Auto : Vehiculo
    {
        public Auto() 
        { 
            Chasis = new Chasis();
        }
        public int Anio {  get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        // COMPOSICIÓN 
        public Chasis Chasis { get; set; }

        // AGREGACIÓN
        public Motor Motor { get; set; }
    }
}

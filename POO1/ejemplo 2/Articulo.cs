using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2
{
    internal class Articulo
    {
        public int CodigoArticulo { get; set; }
        public float Precio { get; set; }
        public int CodigoMarca
        {
            get { return CodigoMarca; }
            set
            {
                if (value > 0 && value < 11)
                {
                    CodigoMarca = value;
                }
            }
        }
    }
}

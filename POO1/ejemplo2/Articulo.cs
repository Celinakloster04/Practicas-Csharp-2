using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        public int CodigoArticulo { get; set; }
        public float Precio { get; set; }
        public int Marca
        {
            get {  return Marca; }

            set
            {
                if(value > 0 && value < 11)
                {
                    Marca = value;
                } else
                {
                    Marca = -1;
                }
            }
        }
    }
}

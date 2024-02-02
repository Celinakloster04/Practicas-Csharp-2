using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args, Articulo[] articulos)
        {
            Articulo[] articulos = new Articulo[10];

            for(int i=0; i<10;  i++)
            {
                Console.WriteLine("Ingrese los datos del articulo: ");
                Console.WriteLine("Codigo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 - 10): ");
                articulos[i].Marca = int.Parse(Console.ReadLine());
                Console.ReadKey();
            }
        }
    }
}

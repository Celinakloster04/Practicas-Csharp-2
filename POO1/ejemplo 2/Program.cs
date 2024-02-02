using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Articulo[] articulos = new Articulo[10];

            for(int x=0; x<10; x++)
            {
                Console.WriteLine("Ingrese los datos del articulo: ");
                Console.WriteLine("Codigo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 - 10): ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }
           */
            Ventas venta = new Ventas();

            Console.WriteLine("Ingrese los datos de la venta: ");
            Console.WriteLine("Codigo cliente (1 a 100): ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while(venta.CodigoCliente != 0)
            {
                Console.WriteLine("Codigo Articulo: ");
                venta.CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());


                Console.WriteLine("Ingrese los datos de la venta: ");
                Console.WriteLine("Codigo cliente (1 a 100): ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}

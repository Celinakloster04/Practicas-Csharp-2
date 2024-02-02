using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono tel1 = new Telefono("A23", "SAMSUNG");

            Console.WriteLine("Número telefónico: ");
            tel1.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Código operador (1 al 3): ");
            tel1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine("Modelo: " + tel1.Modelo);
            Console.WriteLine("Marca: " + tel1.Marca);
            Console.WriteLine("Número telefónico: " + tel1.NumeroTelefonico);
            Console.WriteLine("Código operador: " + tel1.CodigoOperador);

            Console.WriteLine(tel1.Llamar());

            Console.ReadKey();
        }
    }
}

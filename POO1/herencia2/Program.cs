using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehiculo > Auto > AutoDeportivo > AutoUrbano
            // Camioneta
            // Moto

            //Vehiculo v1 = new Vehiculo();
            //Camioneta c1 = new Camioneta();
            //Camioneta c2 = new Camioneta();
            //Camioneta c3 = new Camioneta();

            //c1.Color = "Blanco";
            //c2.Color = "Rojo";
            //c3.Color = "Negro";

            //List<Camioneta> listaCamioneta = new List<Camioneta>();
            //listaCamioneta.Add(c1);
            //listaCamioneta.Add(c2);
            //listaCamioneta.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es de: " + listaCamioneta.Count);
            //Console.WriteLine("El color es: " + listaCamioneta[1].Color);
            //Console.ReadKey();

            //foreach (Camioneta item in listaCamioneta)
            //{
            //    Console.WriteLine("Color: " + item.Color);
            //}

            Auto a1 = new Auto();
            a1.Motor = new Motor();

            Console.ReadKey();
        }
    }
}

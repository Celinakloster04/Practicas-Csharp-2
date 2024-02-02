using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona p1 = new Persona("PEPE");
            /*p1.Edad = 20;
            p1.Sueldo = 13000;
            p1.Nombre = "Celina";

            Console.WriteLine("La edad de la persona es de: " + p1.Edad);
            Console.WriteLine("El sueldo de la persona es de: " + p1.Sueldo);
            Console.WriteLine("El nombre de la persona es de: " + p1.Nombre);
            Console.ReadKey();
            */
            //Console.WriteLine(p1.saludar());

            Botella b1 = new Botella("Rojo", "Plastico");
            Console.WriteLine("Capacidad botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es de: " + b1.CantidadActual);

            b1.recargar(20); 
            Console.WriteLine("La cantidad actual es de: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("La cantidad actual es de: " + b1.CantidadActual);

            Console.ReadKey();
        }
    }
}

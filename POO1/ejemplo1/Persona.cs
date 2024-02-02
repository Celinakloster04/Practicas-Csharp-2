using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;   
        }
        // PROPIEDAD

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public float Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string saludar()
        {
            return "Hola soy... " + nombre;
        }

    }
}

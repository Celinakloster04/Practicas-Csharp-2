using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        public Botella(string color, string material)
        { 
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        // Sobrecarga del constructor
        public Botella() { }

        // DESTRUCTOR
        ~Botella() 
        {
            // La lógica...
        }

        // Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; } 
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }
        public string Material
        {
            get { return material; }
        }

        // PROPIEDAD
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}

        // MÉTODOS
        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
        }
    }
}

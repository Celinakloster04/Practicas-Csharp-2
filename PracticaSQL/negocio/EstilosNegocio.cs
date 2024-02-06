using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace negocio
{
    internal class EstilosNegocio
    {
        public List<Estilos> listar()
        {
            List<Estilos> lista = new List<Estilos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id, Descripcion From ESTILOS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Estilos aux = new Estilos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return listar();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}

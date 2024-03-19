using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Net;
using System.Diagnostics;

namespace negocio
{
    public class DiscosNegocio
    {
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, Artista, D.IdEstilo, E.Descripcion Estilo, D.IdTipoEdicion, T.Descripcion Edicion From DISCOS D, ESTILOS E, TIPOSEDICION T Where IdEstilo = E.Id and IdTipoEdicion = T.Id And D.Activo = 1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Artista = (string)datos.Lector["Artista"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];

                    //if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("UrlImagenTapa"))))
                    //    aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    aux.Estilo = new Estilos();
                    aux.Estilo.Id = (int)datos.Lector["Id"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];

                    aux.Edicion = new Edicion();
                    aux.Edicion.Id = (int)datos.Lector["Id"];
                    aux.Edicion.Descripcion = (string)datos.Lector["Edicion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Discos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into DISCOS (Artista, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion)values(@artista, @titulo, @fechaLanzamiento, @cantidadCanciones, @urlImagenTapa, @idEstilo, @idTipoEdicion)");

                datos.setearParametro("@artista", nuevo.Artista);
                datos.setearParametro("@titulo", nuevo.Titulo);
                datos.setearParametro("@fechaLanzamiento", nuevo.FechaLanzamiento);
                datos.setearParametro("@cantidadCanciones", nuevo.CantidadCanciones);
                datos.setearParametro("@urlImagenTapa", nuevo.UrlImagenTapa);
                datos.setearParametro("@idEstilo", nuevo.Estilo.Id);
                datos.setearParametro("@idTipoEdicion", nuevo.Edicion.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Discos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update DISCOS set Artista = @artista, Titulo = @titulo, FechaLanzamiento = @fechaLanzamiento, CantidadCanciones = @cantidadCanciones, UrlImagenTapa = @urlImagenTapa, IdEstilo = @idEstilo, IdTipoEdicion = @idTipoEdicion where Id = @id");

                datos.setearParametro("@artista", modificar.Artista);
                datos.setearParametro("@titulo", modificar.Titulo);
                datos.setearParametro("@fechaLanzamiento", modificar.FechaLanzamiento);
                datos.setearParametro("@cantidadCanciones", modificar.CantidadCanciones);
                datos.setearParametro("@urlImagenTapa", modificar.UrlImagenTapa);
                datos.setearParametro("@idEstilo", modificar.Estilo.Id);
                datos.setearParametro("@idTipoEdicion", modificar.Edicion.Id);
                datos.setearParametro("@id", modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from DISCOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Update DISCOS set Activo = 0 Where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Discos> filtrar(string campo, string criterio, string filtro)
        {
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, Artista, D.IdEstilo, E.Descripcion Estilo, D.IdTipoEdicion, T.Descripcion Edicion From DISCOS D, ESTILOS E, TIPOSEDICION T Where IdEstilo = E.Id And IdTipoEdicion = T.Id And D.Activo = 1 And ";

                switch (campo)
                {
                    case "Artista":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Artista like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "Artista like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Artista like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Estilo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "E.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "E.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "E.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Cant de Canciones":
                        switch (criterio)
                        {
                            case "Menor a":
                                consulta += "CantidadCanciones < " + filtro;
                                break;
                            case "Mayor a":
                                consulta += "CantidadCanciones > " + filtro;
                                break;
                            default:
                                consulta += "CantidadCanciones = " + filtro;
                                break;
                        }
                        break;
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Artista = (string)datos.Lector["Artista"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];

                    //if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("UrlImagenTapa"))))
                    //    aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    aux.Estilo = new Estilos();
                    aux.Estilo.Id = (int)datos.Lector["Id"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];

                    aux.Edicion = new Edicion();
                    aux.Edicion.Id = (int)datos.Lector["Id"];
                    aux.Edicion.Descripcion = (string)datos.Lector["Edicion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

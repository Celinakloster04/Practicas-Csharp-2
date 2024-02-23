using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Discos
    {
        public int Id { get; set; }
        public string Artista { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Canciones")]
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public Estilos Estilo { get; set; }
        public Edicion Edicion { get; set; }
    }
}

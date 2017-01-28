using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TareaRegistros.Entidades
{
    public class Peliculas
    {
        [Key]
        public int PeliculasId { get; set; }
        public string Estrenos { get; set; }
        public string Descripcion { get; set; }

    }
}

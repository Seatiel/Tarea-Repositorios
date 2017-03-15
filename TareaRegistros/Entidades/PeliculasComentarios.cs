using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TareaRegistros.Entidades
{
   public class PeliculasComentarios
    {
        [Key]
        public int ComentarioId { get; set; }
        public virtual  Usuarios Usuario{ get; set; }
        public string Comentario { get; set; }

        public PeliculasComentarios()
        {
            this.Usuario = null;
            this.Comentario = string.Empty;
        }
    }
}

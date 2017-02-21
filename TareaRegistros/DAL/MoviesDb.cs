using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TareaRegistros.Entidades;

namespace TareaRegistros.DAL
{
    public class MoviesDb : DbContext
    {
        public MoviesDb() : base("ConStr")
        {

        }

        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Peliculas> Pelicula { get; set; }
        public DbSet<Categorias> Categoria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Categorias>()
                 .HasMany(categoria => categoria.Peliculas)
                 .WithMany(pelicula => pelicula.Categorias)
                 .Map( peliculascategorias =>
                 {
                     peliculascategorias.MapLeftKey("PeliculaId");
                     peliculascategorias.MapRightKey("CategoriaId");
                     peliculascategorias.ToTable("PeliculasCategorias");
                 }
                );
        }
    }
}

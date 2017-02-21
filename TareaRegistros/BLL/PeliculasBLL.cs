﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TareaRegistros.DAL;
using TareaRegistros.Entidades;

namespace TareaRegistros.BLL
{
    public class PeliculasBLL
    {
        public static bool Guardar(Peliculas pelicula)
        {
            bool retorno = false;
            using (var db = new MoviesDb())
            {
                try
                {
                    db.Pelicula.Add(pelicula);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //throw;
                }
                return retorno;
            }
        }

        //public static bool Insertar(Peliculas pelicula)
        //{
        //    bool retorno = false;
        //    try
        //    {
        //        using (var db = new MovieDb())
        //        {
        //            if (Buscar(pelicula.UsuarioId) == null)
        //                db.Pelicula.Add(usuario);
        //            else
        //                db.Entry(pelicula).State = EntityState.Modified;

        //            db.SaveChanges();
        //        }
        //        retorno = true;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return retorno;
        //}

        public static bool Eliminar(Peliculas pelicula)
        {
            bool retorno = false;
            using (var db = new MoviesDb())
            {
                try
                {
                    db.Entry(pelicula).State = EntityState.Deleted;
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
        }



        public static Peliculas Buscar(int id)
        {
            var pelicula = new Peliculas();
            using (var db = new MoviesDb())
            {
                try
                {
                    pelicula = db.Pelicula.Find(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //throw;
                }
                return pelicula;
            }
        }

        public static List<Peliculas> GetList()
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var db = new MoviesDb())
            {
                try
                {
                    if (db.Pelicula.ToList().Count > 0)
                    {
                        lista = db.Pelicula.ToList();
                    }
                    else
                    {
                        lista = null;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Peliculas> GetListId(int peliculaId)
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var db = new MoviesDb())
            {
                try
                {
                    lista = db.Pelicula.Where(p => p.PeliculaId == peliculaId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }          
        }

        public static List<Peliculas> GetListDescripcion(string descripcion)
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var db = new MoviesDb())
            {
                try
                {
                    lista = db.Pelicula.Where(p => p.Descripcion == descripcion).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Peliculas> GetListFecha(DateTime desde, DateTime hasta)
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var db = new MoviesDb())
            {
                try
                {
                    lista = db.Pelicula.Where(p => p.Fecha >= desde.Date && p.Fecha <= hasta).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        

    }
}

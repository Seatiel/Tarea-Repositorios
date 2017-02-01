using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TareaRegistros.DAL;
using TareaRegistros.Entidades;

namespace TareaRegistros.BLL
{
    public class CategoriasBLL
    {
        public static bool Guardar(Categorias categoria)
        {
            bool retorno = false;
            using (var db = new RegistrosDb())
            {
                try
                {
                    db.Categoria.Add(categoria);
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

        public static bool Eliminar(Categorias categoria)
        {
            bool retorno = false;
            using (var db = new RegistrosDb())
            {
                try
                {
                    db.Entry(categoria).State = EntityState.Deleted;
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

        public static Categorias Buscar(int id)
        {
            var categoria = new Categorias();
            using (var db = new RegistrosDb())
            {
                try
                {
                    categoria = db.Categoria.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return categoria;
            }
        }

        public static List<Categorias> GetList()
        {
            List<Categorias> lista = new List<Categorias>();
            using (var db = new RegistrosDb())
            {
                try
                {
                    if (db.Categoria.ToList().Count > 0)
                    {
                        lista = db.Categoria.ToList();
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


    }
}

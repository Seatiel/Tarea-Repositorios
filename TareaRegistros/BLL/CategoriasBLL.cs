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
            //todo: es mejor retornar el mismo objeto guardado.
            bool retorno = false;
            using (var repositorio = new Repositorio<Categorias>())
            {
                //todo: validar que el nombre de categoria no exista

               retorno= repositorio.Guardar(categoria)!=null;
            }

            return retorno;

        //    bool retorno = false;
        //    using (var db = new RegistrosDb())
        //    {
        //        try
        //        {
        //            db.Categoria.Add(categoria);
        //            db.SaveChanges();
        //            retorno = true;
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        return retorno;
        //    }
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
                    lista = db.Categoria.ToList();
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

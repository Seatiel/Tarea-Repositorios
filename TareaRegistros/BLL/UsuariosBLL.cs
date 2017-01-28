﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TareaRegistros.DAL;
using TareaRegistros.Entidades;

namespace TareaRegistros.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool retorno = false;
            using (var db = new RegistrosDb())
            {
                try
                {
                    db.Usuario.Add(usuario);
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


        public static bool Eliminar(Usuarios usuario)
        {
            bool retorno = false;
            using (var db = new RegistrosDb())
            {
                try
                {                    
                    db.Entry(usuario).State = EntityState.Deleted;
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

        //public static void Eliminar(int id)
        //{
        //    var usuario = new Usuarios();
        //    using (var db = new RegistrosDb())
        //    {
        //        try
        //        {
        //            usuario = db.Usuario.Find(id);
        //            db.Usuario.Remove(usuario);
        //            db.SaveChanges();
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //    }
        //}

        public static Usuarios Buscar(int id)
        {
            var usuario = new Usuarios();
            using (var db = new RegistrosDb())
            {
                try
                {
                    usuario = db.Usuario.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
                return usuario;
            }
        }


    }
}

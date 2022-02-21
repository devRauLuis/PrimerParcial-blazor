using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Blazor.DAL;
using Blazor.Entidades;
namespace Blazor.BLL
{
    public class ProductosBLL
    {

        public static bool Existe(int id)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Productos.Any(p => p.ProductoId == id);

                }
                catch (System.Exception ex)
                {
                    throw;
                }

            }
        }

        public static bool Guardar(Productos producto)
        {

            try
            {
                return !Existe(producto.ProductoId) ? Insertar(producto) : Modificar(producto);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public static bool Insertar(Productos producto)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Productos.Add(producto);
                    return context.SaveChanges() > 0;
                }
                catch (System.Exception ex)
                {
                    throw;
                }
            }

        }

        public static bool Modificar(Productos producto)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Entry(producto).State = EntityState.Modified;
                    return context.SaveChanges() > 0;
                }
                catch (System.Exception ex)
                {
                    throw;
                }
            }
        }

        public static bool Eliminar(int id)
        {
            using (var context = new Context())
            {

                var producto = Buscar(id);

                if (producto is not null)
                {
                    try
                    {
                        context.Productos.Remove(producto);
                        return context.SaveChanges() > 0;
                    }
                    catch (System.Exception ex)
                    {
                        throw;
                    }
                }
                return false;
            }
        }

        public static Productos? Buscar(int id)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Productos.Find(id);

                }
                catch (System.Exception ex)
                {
                    throw;
                }
            }
        }

        public static List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
        {

            using (var context = new Context())
            {
                try
                {
                    return context.Productos.Where(criterio).ToList();
                }
                catch (System.Exception ex)
                {
                    throw;
                }
            }
        }
    }

}
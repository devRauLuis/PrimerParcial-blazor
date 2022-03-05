
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Blazor.DAL;
using Blazor.Entidades;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;


namespace Blazor.BLL;
public class ProductosBLL
{
    private ProductsContext _context;

    public ProductosBLL(ProductsContext context)
    {
        _context = context;
    }

    public bool Existe(int id)
    {
        try
        {
            return _context.Productos.Any(p => p.ProductoId == id);

        }
        catch (System.Exception ex)
        {
            throw;
        }


    }

    public bool Guardar(Productos producto)
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

    public bool Insertar(Productos producto)
    {
        try
        {
            _context.Productos.Add(producto);
            return _context.SaveChanges() > 0;
        }
        catch (System.Exception ex)
        {
            throw;
        }

    }

    public bool Modificar(Productos producto)
    {

        try
        {
            _context.Entry(producto).State = EntityState.Modified;
            return _context.SaveChanges() > 0;

        }
        catch (System.Exception ex)
        {
            throw;
        }


        //   using (var context = new ProductsContext())
        //             {
        //                 try
        //                 {
        //                     context.Entry(producto).State = EntityState.Modified;
        //                     return context.SaveChanges() > 0;

        //                     foreach (var detalle in producto.ProductoDetalles)
        //                     {
        //                         if (detalle.ProductoDetallesId != 0)
        //                         {
        //                             context.Entry(detalle).State = EntityState.Modified;
        //                         }
        //                         else
        //                         {
        //                             context.Entry(detalle).State = EntityState.Added;
        //                         }
        //                     }

        //                     var idsOfDetalles = producto.ProductoDetalles.Select(x => x.ProductoDetallesId).ToList();
        //                     var detallesToDelete = context
        //                         .ProductoDetalles
        //                         .Where(x => !idsOfDetalles.Contains(x.ProductoDetallesId) && x.ProductoId == producto.ProductoId)
        //                         .ToList();

        //                     context.RemoveRange(detallesToDelete);
        //                 }
        //                 catch (System.Exception ex)
        //                 {
        //                     throw;
        //                 }
        //             }
    }

    public bool Eliminar(int id)
    {
        var producto = Buscar(id);

        if (producto is not null)
        {
            try
            {
                _context.Productos.Remove(producto);
                return _context.SaveChanges() > 0;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
        return false;
    }

    public Productos? Buscar(int id)
    {

        try
        {
            return _context.Productos.Find(id);

        }
        catch (System.Exception ex)
        {
            throw;
        }

    }

    public List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
    {

        try
        {
            return _context.Productos.Where(criterio).ToList();
        }
        catch (System.Exception ex)
        {
            throw;
        }

    }
}


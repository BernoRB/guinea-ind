using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DacTienda.Data;
using DacTienda.Modelos;

namespace DacTienda.DataAccess
{
    public static class AbmProducto
    {
        private static DBTiendaContext db;

        public static void Insertar(Producto producto)
        {
            db = new DBTiendaContext();
            db.Productos.Add(producto);
            db.SaveChanges();
        }

        public static List<Producto> Listar()
        {
            db = new DBTiendaContext();
            List<Producto> lista = db.Productos.ToList();
            return lista;
        }
        
        public static List<Producto> ListarSexo(string sexo)
        {
            db = new DBTiendaContext();
   
            List<Producto> lista = (from p in db.Productos
                                    where p.Sexo == sexo
                                    select p).ToList();       
            return lista;
        }
        
        public static List<Producto> ListarEstacion(string estacion)
        {
            db = new DBTiendaContext();

            List<Producto> lista = (from p in db.Productos
                                    where p.Estacion == estacion
                                    select p).ToList();
            return lista;
        }

        public static List<Producto> ListarDoble(string sexo, string estacion)
        {
            db = new DBTiendaContext();

            List<Producto> lista = (from p in db.Productos
                                    where p.Sexo == sexo && p.Estacion == estacion
                                    select p).ToList();
            return lista;
        }        

        public static void BajarStock(int id, int cantidad)
        {
            db = new DBTiendaContext();

            var query = (from p in db.Productos
                        where p.Id == id
                        select p);

            foreach (Producto p in query)
            {
                p.CantidadStock -= cantidad;
            }

            db.SaveChanges();
        }

    }
}

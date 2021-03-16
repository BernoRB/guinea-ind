using DacTienda.Data;
using DacTienda.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DacTienda.DataAccess
{
    public static class abmVentas
    {
        private static DBTiendaContext db;

        public static void Insertar(Venta venta)
        {
            db = new DBTiendaContext();
            db.Ventas.Add(venta);
            db.SaveChanges();
        }

        public static List<Venta> Listar()
        {
            db = new DBTiendaContext();
            List<Venta> lista = db.Ventas.ToList();
            return lista;
        }

        public static Venta TraerVenta(int id)
        {
            db = new DBTiendaContext();

            Venta venta = (from p in db.Ventas
                           where p.Id == id
                           select p).FirstOrDefault();
            return venta;
        }

    }

}

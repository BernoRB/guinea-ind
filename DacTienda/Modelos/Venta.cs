using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DacTienda.Modelos
{
    public class Venta
    {
        public Venta() { }

        public Venta (DateTime fecha, int cantidad, int producto, string categ, double precio, string formapago, int cuotas, double porccuotas, double valorcuotas, double total)
        {
            FechaVenta = fecha;
            Cantidad = cantidad;
            Producto = producto;
            Categ = categ;
            Precio = precio;
            FormaPago = formapago;
            Cuotas = cuotas;
            PorcCuotas = porccuotas;
            ValorCuotas = valorcuotas;
            Total = total;
        }

        [Key]
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public int Cantidad { get; set; }
        public int Producto { get; set; }
        public string Categ { get; set; }
        public double Precio { get; set; }
        public string FormaPago { get; set; }
        public int Cuotas { get; set; }
        public double PorcCuotas { get; set; }
        public double ValorCuotas { get; set; }
        public double Total { get; set; }

    }

}

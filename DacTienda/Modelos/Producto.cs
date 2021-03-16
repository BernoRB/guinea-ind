using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DacTienda.Modelos
{
    [Table("Producto")]
    public class Producto
    {
        public Producto() { }

        public Producto(string pSexo, string paramCateg, string paramTela, string paramEstacion, int paramCantidadIn, int paramCantidadAct, int paramTalle, double paramCosto, double paramPrecio, string paramNotas)
        {
            Sexo = pSexo; //esto es VA NE y eso
            Categoria = paramCateg;
            Estacion = paramEstacion;
            Talle = paramTalle;
            PrecioVenta = paramPrecio;
            PrecioCosto = paramCosto;
            CantidadInicial = paramCantidadIn;
            CantidadStock = paramCantidadAct; //al insertar un producto nuevo, stock = inicial
            Tela = paramTela;
            Notas = paramNotas;

        }


        [Key]
        public int Id { get; set; }
        [Column("Tipo", TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Sexo { get; set; }
        public string Estacion { get; set; }
        public string Categoria { get; set; }
        public string Tela { get; set; }
        public int Talle { get; set; }
        public int CantidadInicial { get; set; }
        public int CantidadStock { get; set; }
        public double PrecioCosto { get; set; }
        public double PrecioVenta { get; set; }
        public string Notas { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DacTienda.Modelos;
using DacTienda.DataAccess;
using DacTienda.Data;
using System.Diagnostics;

namespace WindowsTienda
{
    public partial class VENDEDOR : Form
    {
        public VENDEDOR()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            /*
            //HARDCODEO UNAS VENTAS
            DBTiendaContext db;
            DacTienda.Modelos.Venta v1 = new DacTienda.Modelos.Venta(DateTime.Today, 1, "1","CAMPERA",600,"Tarjeta",3,0.2,120,720);
            DacTienda.Modelos.Venta v2 = new DacTienda.Modelos.Venta(DateTime.Today, 1, "1", "CAMISA", 600, "Tarjeta", 3, 0.2, 120, 720);
            DacTienda.Modelos.Venta v3 = new DacTienda.Modelos.Venta(DateTime.Today, 1, "1", "CAMISA", 600, "Tarjeta", 3, 0.2, 120, 720);
            DacTienda.Modelos.Venta v4 = new DacTienda.Modelos.Venta(DateTime.Today, 1, "1", "CAMISA", 600, "Tarjeta", 3, 0.2, 120, 720);
            DacTienda.Modelos.Venta v5 = new DacTienda.Modelos.Venta(DateTime.Today, 1, "1", "CAMISA", 600, "Tarjeta", 3, 0.2, 120, 720);
            db = new DBTiendaContext();
            db.Ventas.Add(v1);
            db.Ventas.Add(v2);
            db.Ventas.Add(v3);
            db.Ventas.Add(v4);
            db.Ventas.Add(v5);
            db.SaveChanges();
            */

            cbProducto.SelectedItem = null;
            cbCuotas.SelectedItem = null;
            cbFormaPago.SelectedItem = null;         
            
            cbFormaPago.DisplayMember = "Text"; cbFormaPago.ValueMember = "Value";
            cbFormaPago.Items.Add(new { Text = "Efectivo", Value = "Efectivo" });
            cbFormaPago.Items.Add(new { Text = "Tarjeta", Value = "Tarjeta" });            
            
            cbCuotas.DisplayMember = "Text"; cbCuotas.ValueMember = "Value";
            cbCuotas.Items.Add(new { Text = "1", Value = "1" });
            cbCuotas.Items.Add(new { Text = "3", Value = "3" });
            cbCuotas.Items.Add(new { Text = "6", Value = "6" });

            //Mostramos los productos en stock al iniciar
            List<DacTienda.Modelos.Producto> lista = AbmProducto.Listar();
            List<int> CodProductos = new List<int>();
            foreach (DacTienda.Modelos.Producto p in lista)
            {
                CodProductos.Add(p.Id);
            }
            cbProducto.DataSource = CodProductos;
            gridProductos.DataSource = lista;
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Now;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                int producto = Convert.ToInt32(cbProducto.Text);
                string categ = traerCateg();
                double precio = traerPrecio();
                string formapago = cbFormaPago.Text;
                int cuotas = Convert.ToInt32(cbCuotas.Text);
                double porccuotas = Convert.ToDouble(txtPorcCuotas.Text);
                double valorcuotas = Convert.ToDouble(txtValorCuotas.Text);
                double total = (precio + valorcuotas) * cantidad;

                Venta venta = new Venta(fecha, cantidad, producto, categ, precio, formapago, cuotas, porccuotas, valorcuotas, total);

                abmVentas.Insertar(venta);

                //Reiniciamos campos
                reiniciar();

                //Mensaje de exito
                MessageBox.Show("Venta cargada correctamente", "Guinea Ind");

                //Si se carga, muestra el recibo de la compra cargada y se pone ese ID en el txtbox para poder imprimirlo
                mostrarRecibo(venta.Id);
                tbIdRecibo.Text = venta.Id.ToString();

                //Bajamos el stock en sistema de ese producto
                AbmProducto.BajarStock(venta.Producto, venta.Cantidad);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Verifique los campos. Description: " + ex.Message, "Guinea Ind");
            }
        }

        private void btnCalcularTotal_Click_1(object sender, EventArgs e)
        {
            //Traemos si es tarjeta o efectivo y cantidad de cuotas si es tarjeta, para mostrar CFT de la Q de cuotas y costo total de las cuotas
            string formaPago = cbFormaPago.Text.ToString();
            double precio = traerPrecio();
            double precioTot = precio * Convert.ToInt32(txtCantidad.Text);
            if (formaPago == "Tarjeta")
            {
            int qCuotas = Convert.ToInt32(cbCuotas.Text);
                switch (qCuotas)
                {
                    case 1:
                        txtPorcCuotas.Text = "0.1";
                        break;
                    case 3:
                        txtPorcCuotas.Text = "0.15";
                        break;
                    case 6:
                        txtPorcCuotas.Text = "0.2";
                        break;
                    default:
                        txtPorcCuotas.Text = "0";
                        break;
                }
                txtValorCuotas.Text = (precioTot * Convert.ToDouble(txtPorcCuotas.Text)).ToString();
                txtTotal.Text = (Convert.ToDouble(txtValorCuotas.Text) + precioTot).ToString();
            }
            else
            {
                cbCuotas.Text = "0";
                txtPorcCuotas.Text = "0";
                txtValorCuotas.Text = "0";
                txtTotal.Text = precioTot.ToString();
            }
        }

        public string traerCateg()
        {
            //Hago que segun la selección de Producto me traiga el tipo
            int prodVenta = Convert.ToInt32(cbProducto.SelectedItem);
            List<DacTienda.Modelos.Producto> lista = AbmProducto.Listar();
            foreach (DacTienda.Modelos.Producto p in lista)
            {
                if (p.Id == prodVenta)
                {
                    return p.Categoria;
                }
            }
            return null;
        }

        public double traerPrecio()
        {
            //Trae el precio
            int prodVenta = Convert.ToInt32(cbProducto.SelectedItem);
            List<DacTienda.Modelos.Producto> lista = AbmProducto.Listar();
            foreach (DacTienda.Modelos.Producto p in lista)
            {
                if (p.Id == prodVenta)
                {
                    return p.PrecioVenta;
                }
            }
            return 0;
        }

        private void reiniciar()
        {
            //Reiniciamos los campos
            txtCantidad.Text = "Cantidad...";
            cbProducto.Text = "Producto...";
            cbFormaPago.Text = "Tarjeta o Efectivo...";
            cbCuotas.Text = "Cuotas...";
            txtPorcCuotas.Text = "CFT Cuotas (autocomp)";
            txtValorCuotas.Text = "Valor Cuotas (autocomp)";
            txtTotal.Text = "TOTAL";

        }

        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaPago.Text == "Efectivo")
            {
                cbCuotas.Enabled = false;
                txtPorcCuotas.Enabled = false;
                txtValorCuotas.Enabled = false;
            }
            else
            {
                cbCuotas.Enabled = true;
                txtPorcCuotas.Enabled = true;
                txtValorCuotas.Enabled = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seguridad seg = new Seguridad();
            seg.Show();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Al cambiar el producto, te muestra su precio unitario
            txtPrecioUnit.Text = traerPrecio().ToString();
        }

        private void btnTraerRecibo_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbIdRecibo.Text);
            mostrarRecibo(id);
        }

        private void mostrarRecibo(int id)
        {
            tbRecibo.Clear();
            Venta venta = abmVentas.TraerVenta(id);

            tbRecibo.SelectionFont = new Font("Courier New", 8);

            tbRecibo.SelectionAlignment = HorizontalAlignment.Center;
            tbRecibo.AppendText(Environment.NewLine + "GUINEA INDUMENTARIA");
            tbRecibo.AppendText(Environment.NewLine + "-----------------------------");
            tbRecibo.AppendText(Environment.NewLine + "ORDEN Nº " + venta.Id.ToString() + "   " + DateTime.Now.ToString());
            tbRecibo.AppendText(Environment.NewLine + "-----------------------------");
            tbRecibo.AppendText(Environment.NewLine + "QTY         ITEM        PREC");
            tbRecibo.AppendText(Environment.NewLine);
            tbRecibo.AppendText(Environment.NewLine + venta.Cantidad.ToString() + "                   " + venta.Categ + " ID" + venta.Producto + "                  $" + venta.Precio);
            tbRecibo.AppendText(Environment.NewLine);
            tbRecibo.AppendText(Environment.NewLine);
            tbRecibo.AppendText(Environment.NewLine + "Subtotal .................................... $" + (venta.Precio * venta.Cantidad));
            tbRecibo.AppendText(Environment.NewLine + "Costo Fin ................................... $" + (venta.ValorCuotas));
            tbRecibo.AppendText(Environment.NewLine + "Total ....................................... $" + venta.Total);
            tbRecibo.AppendText(Environment.NewLine);
            tbRecibo.AppendText(Environment.NewLine);
            tbRecibo.AppendText(Environment.NewLine + "Gracias por su compra");

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(
            @"C:\Users\berna\source\repos\Segundo Modulo de C, WEB API\TiendaInfantilMioFinal\prob imp\ReciboN"+tbIdRecibo.Text.ToString()+".txt",
            tbRecibo.Lines);
            Process.Start(@"C:\Users\berna\source\repos\Segundo Modulo de C, WEB API\TiendaInfantilMioFinal\prob imp\ReciboN"+tbIdRecibo.Text.ToString()+".txt");
        }

        private void btnListarProd_Click(object sender, EventArgs e)
        {
            List<DacTienda.Modelos.Producto> lista = AbmProducto.Listar();
            gridProductos.DataSource = lista;
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            List<Venta> lista = abmVentas.Listar();
            gridProductos.DataSource = lista;
        }
    }
}

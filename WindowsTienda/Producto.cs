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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsTienda
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = txtCodigoProducto.Text;
                string tipo = txtTipo.Text;
                string est = txtEstacion.Text;
                int talle = Convert.ToInt32(txtTalle.Text);
                double pefect = Convert.ToDouble(txtPrecioEfectivo.Text);
                double pcosto = Convert.ToDouble(txtPrecioCosto.Text);
                int qinicial = Convert.ToInt32(txtCantidad.Text);
                string tela = txtCaracteristica.Text;
                string notas = txtNotas.Text;

                DacTienda.Modelos.Producto producto = new DacTienda.Modelos.Producto(cod, tipo, tela, est, qinicial, qinicial, talle, pcosto, pefect, notas);

                AbmProducto.Insertar(producto);

                //Reiniciamos los campos
                reiniciar();

                //Mensaje de exito
                MessageBox.Show("Producto insertado correctamente", "Guinea Ind");

                //Re-listamos
                List<DacTienda.Modelos.Producto> lista = AbmProducto.Listar();
                gridProds.DataSource = lista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Verifique los campos. Description: " + ex.Message, "Guinea Ind");
            }
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            List<DacTienda.Modelos.Producto> lista = AbmProducto.Listar();
            gridProds.DataSource = lista;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DacTienda.Modelos.Producto> lista = AbmProducto.Listar();
            gridProds.DataSource = lista;

            List<string> sexo = new List<string>();
            sexo.Add("MASC");
            sexo.Add("FEM");
            sexo.Add("");
            cbSexo.DataSource = sexo;

            List<string> estacion = new List<string>();
            estacion.Add("INVIERNO");
            estacion.Add("VERANO");
            estacion.Add("");
            cbEstacion.DataSource = estacion;

            cbSexo.SelectedItem = "";
            cbEstacion.SelectedItem = "";
        }

        private void btnTraerFilt_Click(object sender, EventArgs e)
        {
            {

                //Me trae filtrado
                if (cbSexo.SelectedItem.ToString() != "" && cbEstacion.SelectedItem.ToString() == "") //solo filtro por sexo
                {
                    string listaSelec = cbSexo.SelectedItem.ToString();
                    List<DacTienda.Modelos.Producto> listaFilt = AbmProducto.ListarSexo(listaSelec);
                    gridProds.DataSource = listaFilt;
                }
                else
                    if (cbSexo.SelectedItem.ToString() == "" && cbEstacion.SelectedItem.ToString() != "") //filtro por estacion
                {
                    string listaSelec = cbEstacion.SelectedItem.ToString();
                    List<DacTienda.Modelos.Producto> listaFilt = AbmProducto.ListarEstacion(listaSelec);
                    gridProds.DataSource = listaFilt;
                }

                else
                    if (cbSexo.SelectedItem.ToString() != "" && cbEstacion.SelectedItem.ToString() != "") //filtro por sexo y estacion
                {
                    string listaSelec = cbSexo.SelectedItem.ToString();
                    string listaSelec2 = cbEstacion.SelectedItem.ToString();
                    List<DacTienda.Modelos.Producto> listaFilt = AbmProducto.ListarDoble(listaSelec, listaSelec2);
                    gridProds.DataSource = listaFilt;
                }
                else
                {
                    gridProds.DataSource = null;  //Si elegis algo que no hay, que no deje lo anterior, que te lo muestre vacío.   
                }

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seguridad seg = new Seguridad();
            seg.Show();
        }

        private void reiniciar()
        {
            //Reiniciamos los campos
            txtCodigoProducto.Text = "Masc/Fem";
            txtTipo.Text = "Categoria";
            txtEstacion.Text = "Estacion";
            txtTalle.Text = "Talle";
            txtPrecioCosto.Text = "Precio Costo";
            txtCantidad.Text = "Cantidad";
            txtCaracteristica.Text = "Tela";
            txtNotas.Text = "Notas";
        }
    }
}

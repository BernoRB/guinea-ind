using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DacTienda.Data;
using DacTienda.DataAccess;
using DacTienda.Modelos;


namespace WindowsTienda
{
    public partial class Seguridad : Form
    {

        public Seguridad()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            //Subo usuarios a la base de datos
            DBTiendaContext db;
            Roles u1 = new Roles("juan", "12345", "Admin");
            Roles u2 = new Roles("pedro", "12345", "Vendedor");
            //Subo unos productos asi la lista no esta vacia cuando ingresa un vendedor, para probarla mas facil
            DacTienda.Modelos.Producto p1 = new DacTienda.Modelos.Producto("MASC", "CAMPERA", "JEAN", "INVIERNO", 5, 5, 2, 500, 700, "AZUL");
            DacTienda.Modelos.Producto p2 = new DacTienda.Modelos.Producto("MASC", "PANTALON", "JEAN", "VERANO", 5, 5, 2, 500, 700, "AZUL");
            DacTienda.Modelos.Producto p3 = new DacTienda.Modelos.Producto("MASC", "CAMPERA", "POLY", "INVIERNO", 5, 5, 2, 500, 700, "AZUL");
            DacTienda.Modelos.Producto p4 = new DacTienda.Modelos.Producto("MASC", "PANTALON", "JEAN", "VERANO", 5, 5, 2, 500, 700, "AZUL");
            DacTienda.Modelos.Producto p5 = new DacTienda.Modelos.Producto("MASC", "CAMISA", "JEAN", "INVIERNO", 5, 5, 2, 500, 700, "AZUL");
            DacTienda.Modelos.Producto p6 = new DacTienda.Modelos.Producto("FEM", "REMERA", "POLY", "VERANO", 5, 5, 2, 500, 700, "AZUL");
            DacTienda.Modelos.Producto p7 = new DacTienda.Modelos.Producto("FEM", "ZAPATO", "JEAN", "INVIERNO", 5, 5, 2, 500, 700, "AZUL");
            DacTienda.Modelos.Producto p8 = new DacTienda.Modelos.Producto("FEM", "CAMPERA", "JEAN", "VERANO", 5, 5, 2, 500, 700, "AZUL");
            DacTienda.Modelos.Producto p9 = new DacTienda.Modelos.Producto("FEM", "PANTALON", "POLY", "INVIERNO", 5, 5, 2, 500, 700, "AZUL");
            DacTienda.Modelos.Producto p10 = new DacTienda.Modelos.Producto("FEM", "CAMISA", "JEAN", "VERANO", 5, 5, 2, 500, 700, "AZUL");
            db = new DBTiendaContext();
            db.Users.Add(u1); db.Users.Add(u2);
            db.Productos.Add(p1);
            db.Productos.Add(p2);
            db.Productos.Add(p3);
            db.Productos.Add(p4);
            db.Productos.Add(p5);
            db.Productos.Add(p6);
            db.Productos.Add(p7);
            db.Productos.Add(p8);
            db.Productos.Add(p9);
            db.Productos.Add(p10);
            db.SaveChanges(); 
            */
            
            




            //Traigo lo ingresado por el usuario
            string usuario = txtUser.Text;
            string contra = txtPass.Text;

            //Checkea si es admin o vendedor
            string rol = abmRoles.Login(usuario, contra);

            if (rol == "Vendedor")
            {
                this.Hide();
                VENDEDOR mv = new VENDEDOR();
                mv.Show();
            }
            else if (rol == "Admin")
            {
                this.Hide();
                Producto mp = new Producto();
                mp.Show();
            }
            else
                MessageBox.Show("Usuario o contraseña incorrecta","Guinea Ind");


        }

    }
}

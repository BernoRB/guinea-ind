using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DacTienda.Modelos
{
    public class Roles
    {
        public Roles() { }
        public Roles(string nombre, string pass, string rol) 
        {
            Name = nombre;
            Pwd = pass;
            URole = rol;
        }

        [Key]
        public string Name { get; set; }
        public string Pwd { get; set; }
        public string URole { get; set; }



    }
}

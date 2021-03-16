using DacTienda.Data;
using DacTienda.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DacTienda.DataAccess
{
    public static class abmRoles
    {
        private static DBTiendaContext db;
        public static string Login(string user, string pass)
        {
            db = new DBTiendaContext();

            //Traigo la contraseña del usuario que me pasaron
            Roles userDB = (from i in db.Users
                            where (i.Name == user && i.Pwd == pass)
                            select i).FirstOrDefault();

            //Si no existe el usuario ya devolvemos el error
            if (userDB == null)
            {
                return "error";
            }
            
            //Si existe el usuario, metemos su pwd en una variable
            string contraDB = userDB.Pwd;

            //La corroboro con la ingresada por el usuario
            if (contraDB == pass)
            {
                string rol = (from p in db.Users
                              where p.Name == user
                              select p.URole).FirstOrDefault();
                return rol;
            }  else 
            {
                return "error";
            }

        }
    }

}

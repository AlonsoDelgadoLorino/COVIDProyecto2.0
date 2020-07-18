using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace COVIDProyecto2._0.Models
{
    public class DAPersonalAdmin
    {
        public static bool LoginUsers(string user, string pass)
        {
            bool exito = true;
            try
            {
                using (PADataDataContext data = new PADataDataContext())
                {
                    exito = data.BOPersonalAdmin.Any(x => x.nombrePersonal == user && x.contraseña == pass);
                }
            }
            catch(Exception)
            {
                exito= false;
            }
            return exito;
        }

        public static BOPersonalAdmin GetUser(string user, string pass)
        {
            BOPersonalAdmin personal;
            try
            {
                using (PADataDataContext data = new PADataDataContext())
                {
                    personal = data.BOPersonalAdmin.Where(x => x.nombrePersonal == user && x.contraseña == pass).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                personal = null;
            }
            return personal;
        }

        public static int IdPersonalAdmin(string user, string pass)
        {
            int id = 0;
            try
            {
                using (PADataDataContext data = new PADataDataContext())
                {
                    BOPersonalAdmin personal = data.BOPersonalAdmin.Where( x=> x.nombrePersonal == user && x.contraseña == pass).FirstOrDefault();
                    id = personal.id_personal;
                }
            }
            catch (Exception)
            {
                id = 0;
            }
            return id;
        }
    }
}
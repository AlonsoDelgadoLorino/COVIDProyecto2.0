using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACovid
{
    public class LoginDA
    {
        public static bool LoginUsers(string user, string pass)
        {
            bool exito = true;
            try
            {
                using (var data = new CovidDBEntities())
                {
                    exito = data.PersonalAdministrativo.Any(x => x.Username == user && x.Passwd == pass);
                }
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }

        public static PersonalAdministrativo GetUser(string user, string pass)
        {
            PersonalAdministrativo personal;
            try
            {
                using (var data = new CovidDBEntities())
                {
                    data.Configuration.LazyLoadingEnabled = false;
                    personal = data.PersonalAdministrativo.Where(x => x.Username == user && x.Passwd == pass).FirstOrDefault();
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
                using (var data = new CovidDBEntities())
                {
                    PersonalAdministrativo personal = data.PersonalAdministrativo.Where(x => x.Username == user && x.Passwd == pass).FirstOrDefault();
                    id = personal.ID;
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

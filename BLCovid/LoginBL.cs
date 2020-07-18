using DACovid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCovid
{
    public class LoginBL
    {
        public static bool LoginUsers(string user, string pass)
        {
            return LoginDA.LoginUsers(user, pass);
        }
        public static PersonalAdministrativo GetUser(string user, string pass)
        {
            return LoginDA.GetUser(user, pass);
        }

        public static int IdPersonalAdmin(string user, string pass)
        {
            return LoginDA.IdPersonalAdmin(user, pass);
        }
    }
}

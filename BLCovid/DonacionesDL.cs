using DACovid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCovid
{
    public class DonacionesDL
    {
        public static List<Donacion> Listado()
        {
            return DonacionesDA.Listado();
        }

        public static Donacion Obtener(int ID)
        {
            return DonacionesDA.Obtener(ID);
        }

        public static bool Eliminar(int ID)
        {
            return DonacionesDA.Eliminar(ID);
        }

        public static bool Actualizar(Donacion donacion)
        {
            return DonacionesDA.Actualizar(donacion);
        }
    }
}

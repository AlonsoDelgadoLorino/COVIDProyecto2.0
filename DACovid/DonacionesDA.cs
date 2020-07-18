using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACovid
{
    public class DonacionesDA
    {
        public static List<Donacion> Listado()
        {
            using (var data = new CovidDBEntities())
            {
                return data.Donacion.ToList();
            }

        }

        public static Donacion Obtener(int ID)
        {
            using (var data = new CovidDBEntities())
            {
                data.Configuration.LazyLoadingEnabled = false;
                return data.Donacion.Where(x => x.ID == ID).FirstOrDefault();
            }
        }

        public static bool Eliminar(int ID)
        {
            bool exito = true;
            try
            {
                using (var data = new CovidDBEntities())
                {
                    Donacion donacion = data.Donacion.Where(x => x.ID == ID).FirstOrDefault();
                    data.Donacion.Remove(donacion);
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }

        public static bool Actualizar(Donacion donacion)
        {
            bool exito = true;
            try
            {
                using (var data = new CovidDBEntities())
                {
                    Donacion EstadoActual = data.Donacion.Where(x => x.ID == donacion.ID).FirstOrDefault();

                    EstadoActual.Estado = donacion.Estado;
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;

        }
    }
}

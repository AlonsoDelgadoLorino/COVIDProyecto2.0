using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACovid
{
    public class PersonaDA
    {
        public static List<PersonaTriaje> Listado()
        {
            using (var data = new CovidDBEntities())
            {
                return data.PersonaTriaje.ToList();
            }

        }

        public static PersonaTriaje Obtener(int personaCodigo)
        {
            using (var data = new CovidDBEntities())
            {
                data.Configuration.LazyLoadingEnabled = false;
                return data.PersonaTriaje.Where(x => x.ID == personaCodigo ).FirstOrDefault();
            }
        }

        public static bool Eliminar(int personaCodigo)
        {
            bool exito = true;
            try
            {
                using (var data = new CovidDBEntities())
                {
                    PersonaTriaje persona = data.PersonaTriaje.Where(x => x.ID == personaCodigo).FirstOrDefault();
                    data.PersonaTriaje.Remove(persona);
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }


        public static bool Registrar(PersonaTriaje persona)
        {
            bool exito = true;
            try
            {
                using (var data = new CovidDBEntities())
                {
                    data.PersonaTriaje.Add(persona);
                    data.SaveChanges();
                }

            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }

        public static bool Actualizar(PersonaTriaje persona)
        {
            bool exito = true;
            try
            {
                using (var data = new CovidDBEntities())
                {
                    PersonaTriaje personaActual = data.PersonaTriaje.Where(x => x.ID == persona.ID).FirstOrDefault();

                    personaActual.Nombres = persona.Nombres;
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

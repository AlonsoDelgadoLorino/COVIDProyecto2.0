using DACovid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLCovid
{
    public class PersonaBL
    {
        public static List<PersonaTriaje> Listado()
        {
            return PersonaDA.Listado();
        }

        public static PersonaTriaje Obtener(int personaCodigo)
        {
            return PersonaDA.Obtener(personaCodigo);
        }

        public static bool Eliminar(int personaCodigo)
        {
            return PersonaDA.Eliminar(personaCodigo);
        }

        public static bool Registrar(PersonaTriaje persona)
        {
            return PersonaDA.Registrar(persona);
        }

        public static bool Actualizar(PersonaTriaje director)
        {
            return PersonaDA.Actualizar(director);
        }
    }
}

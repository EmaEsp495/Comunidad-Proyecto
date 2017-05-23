using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad
{
    public class Local:Propiedad
    {
        string nombreComercial;
        string actividad;


        public string NombreComercial
        {
            get
            {
                return nombreComercial;
            }

            set
            {
                nombreComercial = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}
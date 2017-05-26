using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad
{
    public class Comunidad
    {
        private string idetificacion;
        private string nombreComunidad;
       
        private string poblacion;

        public string Idetificacion
        {
            get
            {
                return idetificacion;
            }

            set
            {
                idetificacion = value;
            }
        }

        public string NombreComunidad
        {
            get
            {
                return nombreComunidad;
            }

            set
            {
                nombreComunidad = value;
            }
        }

        public string Poblacion
        {
            get
            {
                return poblacion;
            }

            set
            {
                poblacion = value;
            }
        }
    }
}
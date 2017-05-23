using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad
{
    public class Gastos
    {
        private string indentificacion;
        private string nombre;
        private string tipodeReparto;

        public string Indentificacion
        {
            get
            {
                return indentificacion;
            }

            set
            {
                indentificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string TipodeReparto
        {
            get
            {
                return tipodeReparto;
            }

            set
            {
                tipodeReparto = value;
            }
        }
    }
}
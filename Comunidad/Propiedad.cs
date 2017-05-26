using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad
{
    public class Propiedad
    {
        private string tipo;
        private string codigo;
        string metros;
        string propietarios;
        List<string> gastos;

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Metros
        {
            get
            {
                return metros;
            }

            set
            {
                metros = value;
            }
        }

        public string Propietarios
        {
            get
            {
                return propietarios;
            }

            set
            {
                propietarios = value;
            }
        }

        public List<string> Gastos
        {
            get
            {
                return gastos;
            }

            set
            {
                gastos = value;
            }
        }
    }
}
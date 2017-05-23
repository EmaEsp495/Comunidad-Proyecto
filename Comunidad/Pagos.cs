using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad
{
    public class Pagos
    {
        private string idgasto;
        private string descripcion;
        private int importe;
        private string tipoDeZonadeReparto;

        public string Idgasto
        {
            get
            {
                return idgasto;
            }

            set
            {
                idgasto = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string TipoDeZonadeReparto
        {
            get
            {
                return tipoDeZonadeReparto;
            }

            set
            {
                tipoDeZonadeReparto = value;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Comunidad
{
    public partial class _Default : Page
    {
        List<Comunidad> Listcomunidad = new List<Comunidad>();
        List<Propiedad> Listpropiedad = new List<Propiedad>();
        List<Gastos> Listgastos = new List<Gastos>();
        List<Pagos> Listpagos = new List<Pagos>();
        List<Propietarios> listPropietarios = new List<Propietarios>();

        protected void Page_Load(object sender, EventArgs e)
        {
            string Archivo = "C:\\Users\\EmanuelE\\Desktop\\Comunidad\\Archivos de Texto\\Comunidad.txt";
            FileStream stream = new FileStream(Archivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                Comunidad comunidadTemp = new Comunidad();

                comunidadTemp.Idetificacion = leer.ReadLine();
                comunidadTemp.NombreComunidad = leer.ReadLine();
                comunidadTemp.Poblacion = leer.ReadLine();
                Listcomunidad.Add(comunidadTemp);
            }
            leer.Close();



            string Archivo1 = "C:\\Users\\EmanuelE\\Desktop\\Comunidad\\Archivos de Texto\\Gastos.txt";
            FileStream stream1 = new FileStream(Archivo1, FileMode.Open, FileAccess.Read);
            StreamReader leer1 = new StreamReader(stream1);
            while (leer1.Peek() > -1)
            {
                Gastos gastosTemp = new Gastos();

                gastosTemp.Indentificacion = leer1.ReadLine();
                gastosTemp.Nombre = leer1.ReadLine();
                gastosTemp.TipodeReparto = leer1.ReadLine();
                Listgastos.Add(gastosTemp);
            }
            leer1.Close();



            string Archivo2 = "C:\\Users\\EmanuelE\\Desktop\\Comunidad\\Archivos de Texto\\Propietarios.txt";
            FileStream stream2 = new FileStream(Archivo2, FileMode.Open, FileAccess.Read);
            StreamReader leer2 = new StreamReader(stream2);
            while (leer2.Peek() > -1)
            {
                Propietarios propietariosTemp = new Propietarios();

                propietariosTemp.Nombre = leer2.ReadLine();
                propietariosTemp.Nit = leer2.ReadLine();
                propietariosTemp.Email = leer2.ReadLine();
                listPropietarios.Add(propietariosTemp);
            }
            leer2.Close();


            string Archivo3 = "C:\\Users\\EmanuelE\\Desktop\\Comunidad\\Archivos de Texto\\Propiedades.txt";
            FileStream stream3 = new FileStream(Archivo3, FileMode.Open, FileAccess.Read);
            StreamReader leer3 = new StreamReader(stream3);
            while (leer3.Peek() > -1)
            {
                Propiedad propiedadTemp = new Propiedad();
                List<string> gastostmp = new List<string>();

                propiedadTemp.Tipo = leer3.ReadLine();
                propiedadTemp.Codigo = leer3.ReadLine();
                propiedadTemp.Metros = leer3.ReadLine();
                propiedadTemp.Propietarios = leer3.ReadLine();
                Listpropiedad.Add(propiedadTemp);
            }
            leer3.Close();




            string Archivo4 = "C:\\Users\\EmanuelE\\Desktop\\Comunidad\\Archivos de Texto\\Pagos.txt";
            FileStream stream4 = new FileStream(Archivo4, FileMode.Open, FileAccess.Read);
            StreamReader leer4 = new StreamReader(stream4);
            while (leer4.Peek() > -1)
            {
                Pagos pagosTemp = new Pagos();

                pagosTemp.Idgasto = leer4.ReadLine();
                pagosTemp.Descripcion = leer4.ReadLine();
                pagosTemp.Importe = Convert.ToInt16(leer4.ReadLine());
                pagosTemp.TipoDeZonadeReparto = leer4.ReadLine();

                Listpagos.Add(pagosTemp);
            }
            leer4.Close();

        }

        protected void bttAbrir_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = null;
            GridView2.DataBind();
            GridView2.DataSource = Listgastos;
            GridView2.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = null;
            GridView2.DataBind();
            GridView2.DataSource = Listcomunidad;
            GridView2.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = null;
            GridView2.DataBind();
            GridView2.DataSource = Listpropiedad;
            GridView2.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = null;
            GridView2.DataBind();
            GridView2.DataSource = Listpagos;
            GridView2.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
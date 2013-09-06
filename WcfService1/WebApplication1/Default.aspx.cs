using System;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            IService1 servicio = new Service1Client();

            var lista = servicio.ObtenerCategorias();

            GridView1.DataSource = lista;
            GridView1.DataBind();

        }
    }
}

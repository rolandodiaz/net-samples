using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sunat
{
    public partial class Multas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnver_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtruc.Text))
            {
                ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
                var listamultas = service.GetMultasPorRuc(txtruc.Text);
                dlmultas.DataSource = listamultas;
                dlmultas.DataBind();
            }
        }
    }
}
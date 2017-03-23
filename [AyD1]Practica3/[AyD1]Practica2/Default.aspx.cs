using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaControlador;

namespace _AyD1_Practica2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Class1.mensaje.Equals("")) {
                Label1.Text = Class1.mensaje;
                Class1.mensaje = "";
            }
        }
    }
}

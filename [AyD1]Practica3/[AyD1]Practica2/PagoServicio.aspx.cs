using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaControlador;

namespace _AyD1_Practica2
{
    public partial class PagoServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String msj=Class1.PagoServicios(int.Parse(TextBox_cuenta.Text),2,Decimal.Parse(TextBox_monto.Text)); 
            Class1.mensaje=msj;
            Server.Transfer("Default.aspx");
        }
    }
}
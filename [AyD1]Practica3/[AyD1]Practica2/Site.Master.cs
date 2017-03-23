using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaControlador;

namespace _AyD1_Practica2
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Class1.CURRENT_USER == null)
            {
                NavigationMenu.Visible = false;
                LinkButton1.Text = "Iniciar Sesión";
                //MainContent.Visible = false;
            }else{
                
                Label_logged.Text = "Usuario: " + Class1.CURRENT_USER.USERNAME + " \nCuenta: ";// +Class1.CURRENT_ACAUNT.NUMEROCUENTA;
                NavigationMenu.Visible = true;
                LinkButton1.Text = "Cerrar Sesión";
                //MainContent.Visible = false;
            }
            if (Class1.mensaje.Equals("")) {
                Encabezado.Text = Class1.mensaje;
                Class1.mensaje = "";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Class1.CURRENT_USER = null;
            Class1.CURRENT_ACAUNT = null;
            Server.Transfer("Login.aspx");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaControlador;

namespace _AyD1_Practica2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String resp=Class1.LogIn(Text_usuario.Text, Text_password.Text);
            if(resp.Equals("Sesión Iniciada.")){
                Server.Transfer("Default.aspx",true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Registro.aspx",true);
        }
    }
}
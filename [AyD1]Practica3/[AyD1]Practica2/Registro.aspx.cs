using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaControlador;
namespace _AyD1_Practica2
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button_registrar_Click(object sender, EventArgs e)
        {
            //Class1 c = new Class1();
            String mensaje=Class1.Registro(TextBox_nombre.Text, TextBox_usuario.Text, TextBox_email.Text, TextBox_password.Text);
            if (mensaje.Equals("Registro completado exitosamente."))
            {
                Class1.CrearCuenta(TextBox_usuario.Text);
                System.Diagnostics.Debug.Write(mensaje);
                Class1.mensaje = "Usuario Registrado Exitosamente.";
                Server.Transfer("Default.aspx", true);
            }
        }
    }
}
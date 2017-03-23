using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaControlador;
namespace _AyD1_Practica2
{
    public partial class BalanceGeneral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Class1.CURRENT_USER == null) return;
            CUENTA c = Class1.getCuenta(Class1.CURRENT_USER.USERNAME);
            if (c != null)
            {
                Label2.Text = "Cuenta: " + c.NUMEROCUENTA + " A nombre de: " + c.USERNAME + " Balance: Q." + c.BALANCE;
            }
            else {
                Label2.Text = "No se encontro cuenta";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaControlador
{
    public class Class1
    {
        public static USUARO CURRENT_USER=null;
        public static CUENTA CURRENT_ACAUNT = null;
        public static String mensaje="";
        static db_entityDataContext base_datos = new db_entityDataContext();
        public static bool p(bool b) {
            return b;
        }
        public static USUARO getUser(String username) {
            USUARO user = null;
                        
            var consulta = from x in base_datos.USUARO where x.USERNAME==username select x;
            foreach (USUARO u in consulta)
            {
                user = u;
            }
       
            return user;
        }
        public static string Registro(String nombre, String usuario, String correo, String pasword)
        {
            if (pasword == "" || correo == "" || nombre == "" || usuario == "")
                return "Completar campos.";
            if (getUser(usuario) != null)
                return "Usuario ya existe.";
            String s = "";
            USUARO u = new USUARO();
            u.CLAVE = pasword;
            u.EMAIL = correo;
            u.NOMBRECOMPLETO = nombre;
            u.USERNAME = usuario;
          
            
            try
            {
                base_datos.USUARO.InsertOnSubmit(u);
                base_datos.SubmitChanges();
                //s=CrearCuenta(usuario);
            }
            catch (Exception ex) {
                return "Catch registro "+ex.ToString()+"\n"+s+"\n";
            }
            return "Registro completado exitosamente.";
        }
        public static string LogIn(String username, String password)
        {
            if (username == "" || password == "")
                return "";
            USUARO u = Class1.getUser(username);
            if (u == null)
            {
                Class1.mensaje = "El usuario no existe";
                return "El usuario no existe";
            }
            else if (password.Equals(u.CLAVE))
            {
                Class1.CURRENT_USER = u;                
                Class1.CURRENT_ACAUNT = getCuenta(u.USERNAME);
                Class1.mensaje = "Sesión Iniciada.";
                return "Sesión Iniciada.";
            }
            else {
                return "Contraseña no concuerda.";
            }
            
        }
        public static string PagoServicios(int cuenta, int tipo, decimal monto)
        {
            if (cuenta<=0 || tipo<1 || monto<=0)
                return "Pago No Completado.";
            if (Class1.CURRENT_ACAUNT.BALANCE < monto)
                return "Fondos Insuficientes.";
            CUENTA destino = getCuenta(cuenta);
            if (destino == null)
                return "Cuenta destino no existe";
            CUENTA origen = getCuenta(Class1.CURRENT_ACAUNT.NUMEROCUENTA);
            if (destino == null)
                return "Cuenta origen no existe";
            origen.BALANCE-=monto;
            destino.BALANCE += monto;
            base_datos.SubmitChanges();
            //Class1.CURRENT_ACAUNT.BALANCE -= monto;
            return "Pago completado.";
        }
        public static string Transferir(int cuenta, double monto)
        {
            if (cuenta <=0 || monto<=0)
                return "";
            return "Transferrencia completa.";
        }
        public static string Consulta(int cuenta)
        {
            if (cuenta<=0)
                return "";
            return "Consulta completa";
        }
        public static string Debito(int cuenta, double monto, String descripcion)
        {
            if (cuenta<=0 || monto<=0)
                return "";
            return "";
        }
        public static string Credito(int cuenta, double monto, String descripcion)
        {
            if (cuenta<=0|| monto<=0)
                return "";
            return "";
        }
        public static string CrearCuenta(String Usuario)
        {
            
            CUENTA c = new CUENTA();
            c.BALANCE = 0M;
            c.TIPO = 1;
            c.USERNAME = Usuario;
            try
            {
                base_datos.CUENTA.InsertOnSubmit(c);
                base_datos.SubmitChanges();
            }
            catch (Exception ex)
            {
                return "Error en crear cuenta\n";
            }
            return "Registro de cuenta completado exitosamente.";
        }
        public static CUENTA getCuenta(String user) {
            CUENTA c = null;
            var consulta = from x in base_datos.CUENTA where x.USERNAME == user select x;
            foreach (CUENTA cu in consulta)
            {
                c = cu;
            }            
            return c;
        }
        public static CUENTA getCuenta(int numero)
        {
            CUENTA c = null;
            var consulta = from x in base_datos.CUENTA where x.NUMEROCUENTA==numero select x;
            foreach (CUENTA cu in consulta)
            {
                c = cu;
            }
            return c;
        }
    }
}

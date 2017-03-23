using CapaControlador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para Class1Test y se pretende que
    ///contenga todas las pruebas unitarias Class1Test.
    ///</summary>
    [TestClass()]
    public class Class1Test
    {


        /*private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion
        */

        /// <summary>
        ///Una prueba de Registro
        ///</summary>
        /*[TestMethod()]
        public void RegistroTest()
        {
            Class1 target = new Class1(); // TODO: Inicializar en un valor adecuado
            string nombre = "Esteban Palacios Kestler"; // TODO: Inicializar en un valor adecuado
            string usuario = "ekestler"; // TODO: Inicializar en un valor adecuado
            string correo = "ekes.sys@gmail.com"; // TODO: Inicializar en un valor adecuado
            string pasword = "1234"; // TODO: Inicializar en un valor adecuado
            string expected = "Registro completado exitosamente."; // TODO: Inicializar en un valor adecuado
            string actual;
            actual = target.Registro(nombre, usuario, correo, pasword);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
       */
        /*/// <summary>
        ///Una prueba de Constructor Class1
        ///</summary>
        [TestMethod()]
        public void Class1ConstructorTest()
        {
            Class1 target = new Class1();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        } */



        /// <summary>
        ///Una prueba de p
        ///</summary>
        [TestMethod()]
        public void pTest()
        {
            //Class1 target = new Class1(); // TODO: Inicializar en un valor adecuado
            bool b = false; // TODO: Inicializar en un valor adecuado
            bool expected = false; // TODO: Inicializar en un valor adecuado
            bool actual;
            //actual = target.p(b);
            actual = Class1.p(b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}

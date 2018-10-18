using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTest.Modelo;

namespace ReflectionUnitTest
{
    /// <summary>
    /// Descripción resumida de ReflectionInstanciaTest
    /// </summary>
    [TestClass]
    public class ReflectionInstanciaTest
    {
      
        [TestMethod]
        public void ObtenerPropiedadesInstancia()
        {
            var target = new Clase();
            var result = target.GetType().GetProperties();
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void ObtenerValorField()
        {
            var target = new Clase();
            target.CampoPublico = "valorCampoPublico";
            var result = target.GetType().GetField(nameof(Clase.CampoPublico)).GetValue(target);
            Assert.AreEqual("valorCampoPublico", result);
        }

        [TestMethod]
        public void ObtenerValorProperty()
        {
            var target = new Clase();
            target.PropiedadPublica= "PropiedadPublica";
            var result = target.GetType().GetProperty(nameof(Clase.PropiedadPublica)).GetValue(target);
            Assert.AreEqual("PropiedadPublica", result);
        }

        
        [TestMethod]
        public void EjecutarMetodo()
        {
            var target = new Clase();
            target.PropiedadPublica= "PropiedadPublica";
            var result = target.GetType().GetMethod(nameof(Clase.MetodoPublico));
          var resultMethod =  result.Invoke(target, new object[] {});
            Assert.AreEqual(nameof(Clase.MetodoPublico), resultMethod);
        }
    }



}

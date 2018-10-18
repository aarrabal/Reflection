using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTest.Modelo;

namespace ReflectionUnitTest
{
    [TestClass]
    public class ReflectionGetValues
    {

        [TestMethod]
        public void ObtenerValores()
        {
            var target = Activator.CreateInstance<Clase>();
            target.CampoPublico = "Hola";
            target.PropiedadPublica = "Adios";
            target.edad = 20;
            var valor = target.GetType().GetField(nameof(Clase.CampoPublico)).GetValue(target);
            var valor2 = target.GetType().GetProperty(nameof(Clase.PropiedadPublica))?.GetValue(target);
            var valor3 = target.GetType().GetField(nameof(Clase.edad)).GetValue(target);

            Assert.AreEqual(target.CampoPublico, valor);
            Assert.AreEqual(target.PropiedadPublica, valor2);
            Assert.AreEqual(target.edad, valor3);
        }



        [TestMethod]
        public void ObtenerValores1()
        {
            var target = Activator.CreateInstance<Clase>();
            target.CampoPublico = "Hola";
            target.PropiedadPublica = "Adios";
            target.edad = 20;
           var resultado = GetValorPropiedad("PropiedadPublica", target);
            
            Assert.AreEqual (target.PropiedadPublica, resultado);



        }

        [TestMethod]
        public void AsignarValores()
        {
            var target = Activator.CreateInstance<Clase>();
            var propiedad = typeof(Clase).GetProperty("PropiedadPublica");
           propiedad?.SetValue(target, "hola");
            Assert.AreEqual("hola", GetValorPropiedad("PropiedadPublica", target));




        }
        public object GetValorPropiedad(string campo, object item)
        {
            var properties = item.GetType().GetProperties();
            foreach (var property in properties)
            {
                var result = property.Name;
                if (result == campo)
                {
                  return property.GetValue(item);
                }
            }
            return null;
        }
    
}

}

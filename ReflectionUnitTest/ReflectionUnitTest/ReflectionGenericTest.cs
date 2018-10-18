using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTest.Modelo;

namespace ReflectionUnitTest
{
    /// <summary>
    /// Descripción resumida de ReflectionGenericTest
    /// </summary>
    [TestClass]
    public class ReflectionGenericTest
    {
        public ReflectionGenericTest()
        {
          
        }

    

        [TestMethod]
        public void TestMethod1()
        {
            var target = Activator.CreateInstance<ObjectClassReturn<GenericClass1>>();
            target.SetColeccion(new List<GenericClass1>());
            var properties = target.GetType().GetProperties();
            var methods = target.GetType().GetMethods();
            var totalProperties = properties.Count();

            Assert.AreEqual(1, totalProperties);
            Assert.AreEqual(7, methods.Count());
        }

           
        [TestMethod]
        public void EjecutarMetodo()
        {
            var target = Activator.CreateInstance<ObjectClassReturn<GenericClass1>>();
            target.SetColeccion(new List<GenericClass1>());
            var result = target.GetType().GetMethod("SetColeccion");
           var instance = new List<GenericClass1>();
                var resultMethod =  result.Invoke(target, new object[] {instance});
          Assert.IsNotNull(target.Coleccion);
        }
    }
}

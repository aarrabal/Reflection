using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EnsambladoExterno;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTest.Modelo;


namespace ReflectionUnitTest
{
    [TestClass]
    public class ReflectionPropertiesMethodsFieldsExternal
    {
        [TestMethod]
        public void Propiedades()
        {
            var target = typeof(Clase).GetProperties();
            foreach (var propertyInfo in target)
            {
                var result = propertyInfo.Name;
            }
            Assert.AreEqual(1, target.Count());
        }

        [TestMethod]
        public void PropiedadesGetFields()
        {
            var target = typeof(Clase1).GetFields();
            foreach (var propertyInfo in target)
            {
                var result = propertyInfo.Name;
            }
            Assert.AreEqual(1, target.Count());
        }
        
        [TestMethod]
        public void GetAllFields()
        {
            var target = typeof(Clase1).GetFields(BindingFlags.NonPublic |
                                                 BindingFlags.Instance);
            foreach (var propertyInfo in target)
            {
                var result = propertyInfo.Name;
            }
            Assert.AreEqual(7, target.Count());
        }
        
        [TestMethod]
        public void GetAllProperties()
        {
            var target = typeof(Clase1).GetProperties(BindingFlags.NonPublic |
                                                 BindingFlags.Instance);
            foreach (var propertyInfo in target)
            {
                var result = propertyInfo.Name;
            }
            Assert.AreEqual(3, target.Count());
        }
        
        [TestMethod]
        public void GetMethods()
        {
            var target = typeof(Clase1).GetMethods(BindingFlags.NonPublic |
                                                     BindingFlags.Instance);
            foreach (var propertyInfo in target)
            {
                var result = propertyInfo.Name;
            }
            Assert.AreEqual(11, target.Count());
        }

        [TestMethod]
        public void GetMethodsPublics()
        {
            var target = typeof(Clase1).GetMethods();
            foreach (var propertyInfo in target)
            {
        
                var result = propertyInfo.Name;
            }
            Assert.AreEqual(7, target.Count());
        }
    }
}

    


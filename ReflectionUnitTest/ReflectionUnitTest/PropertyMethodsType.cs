using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTest.Modelo;

namespace ReflectionUnitTest
{
    [TestClass]
    public class PropertyMethodsType
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
        public void PropiedadesGetField()
        {
            var target = typeof(Clase).GetFields();
            foreach (var propertyInfo in target)
            {
                var result = propertyInfo.Name;
            }

            Assert.AreEqual(1, target.Count());
        }

        [TestMethod]
        public void GetAllFields()
        {
            var target = typeof(Clase).GetFields(BindingFlags.NonPublic |
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
            var target = typeof(Clase).GetProperties(BindingFlags.NonPublic |
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
            var target = typeof(Clase).GetMethods(BindingFlags.NonPublic |
                                                  BindingFlags.Instance);
            foreach (var propertyInfo in target)
            {
                var result = propertyInfo.Name;
            }

            Assert.AreEqual(11, target.Count());
        }

        [TestMethod]
        public void GetMembers()
        {
            var target = typeof(Clase).GetMembers(BindingFlags.NonPublic |
                                                  BindingFlags.Instance);
            foreach (var propertyInfo in target)
            {
                var result = propertyInfo.Name;
            }

            Assert.AreEqual(21, target.Count());

        }
        
        
        [TestMethod]
        public void GetAttributes()
        {
            var target = typeof(Clase).GetCustomAttributes();
            var properties = typeof(Clase).GetMembers();
            foreach (var property in properties)
            {
                if (property.GetCustomAttributes().Any())
                {
                    var result = property.GetCustomAttributes();
                }
            }
        }
    }
}

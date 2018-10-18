using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTest.Modelo;

namespace ReflectionUnitTest
{
    [TestClass]
    public class EnsambladoTest
    {
        [TestMethod]
        public void LoadAssemblyByString()
        {
            var result = Assembly.Load(new AssemblyName("ReflectionUnitTest"));
            Assert.IsNotNull(result);
        }

  


        [TestClass]
        public class CreateInstanceTest
        {
            [TestMethod]
            public void ActivatorTest()
            {
                var result = Activator.CreateInstance(typeof(Clase));
                Assert.IsNotNull(result);
            }


            [TestMethod]
            public void ActivatorTypeTest()
            {
                var result = Activator.CreateInstance<Clase>();
                Assert.IsNotNull(result);
            }

            [TestMethod]
            public void ActivatorText()
            {
                var ensamblado = Assembly.GetExecutingAssembly();

                Type type = ensamblado.GetType("ReflectionUnitTest.Modelo.Clase");

                var result = Activator.CreateInstance(type);

                Assert.IsNotNull(result);
            }


            [TestMethod]
            public void ActivatorConstructorParameters()
            {
                var publicConstructor = typeof(Clase).GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                    null, new[] {typeof(int), typeof(string)}, null);
                var parameter = publicConstructor?.GetParameters().Count();
                Assert.AreEqual(2, parameter);
            }


            [TestMethod]
            public void ActivatorMultiConstructor()
            {
                var publicConstructor = typeof(Clase).GetConstructor(BindingFlags.Instance | BindingFlags.Public,
                    null, new[] {typeof(int), typeof(string)}, null);
                var publicConstructor2 = typeof(Clase).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic,
                    null, new[] {typeof(string), typeof(bool)}, null);
                var constructores = new ArrayList {publicConstructor, publicConstructor2};
                var numConstructores = constructores.Count;
                var cons = typeof(Clase).GetConstructors(BindingFlags.Instance | BindingFlags.Public);
                
                Assert.AreEqual(2, numConstructores);
                Assert.AreEqual(4, cons.Count());
            }

            [TestMethod]
            public void ActivatorSingleton()
            {
                var result = Activator.CreateInstance(typeof(Singleton), BindingFlags.NonPublic |
                                                                         BindingFlags.Instance, null, new object[] { },
                    CultureInfo.CurrentCulture);
                //var publicConstructor2 = typeof(Singleton).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
                //var result1 = Activator.CreateInstance(typeof(Singleton), publicConstructor2);
                var result2 = Activator.CreateInstance(typeof(Singleton), BindingFlags.NonPublic |
                                                                          BindingFlags.Instance, null, new object[] { },
                CultureInfo.CurrentCulture);
                Assert.IsNotNull(result);
                Assert.IsNotNull(result2);
            }
        }
    }
}
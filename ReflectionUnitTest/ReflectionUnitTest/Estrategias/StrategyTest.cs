using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReflectionUnitTest
{
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void TestSwitch()
        {
            var prueba = "default";
            var option = 1;
            switch (option)
            {
                case 1:
                    prueba = "Uno";
                    break;

                case 2:
                    prueba = "Dos";
                    break;

            }

            var dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Uno");
            dictionary.Add(2, "Dos");
            var result = dictionary[option];



            //Solid aproves 

            var diccionarioAprox1 = new Dictionary<TipoDeEntrada, ISalidaDictionary>();
            foreach (var tipo in HelperStrategy.GetSalidasDictionary())
            {
                var instance = Activator.CreateInstance(tipo) as ISalidaDictionary;
                diccionarioAprox1.Add(instance.tipoDeEntrada(), instance);

            }

            var result1 = diccionarioAprox1[TipoDeEntrada.Entrada2].GetTexto();

        }

        [TestMethod]
        public void TestIf()
        {
            var prueba = "default";
            var option = 1;
            switch (option)
            {
                case 1:
                    prueba = "Uno";
                    break;

                case 2:
                    prueba = "Dos";
                    break;

            }

            var dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Uno");
            dictionary.Add(2, "Dos");
            var result = dictionary[option];



            //Solid aproves 

            var diccionarioAprox1 = new Dictionary<TipoDeEntrada, ISalidaDictionary>();
            foreach (var tipo in HelperStrategy.GetSalidasDictionary())
            {
                var instance = Activator.CreateInstance(tipo) as ISalidaDictionary;
                diccionarioAprox1.Add(instance.tipoDeEntrada(), instance);

            }

            var result1 = diccionarioAprox1[TipoDeEntrada.Entrada2].GetTexto();

            if (option == 1) prueba = "uno";
            else if (option == 2) prueba = "dos";
           

            var dictionary2 = new Dictionary<Func<int, bool, string>, Action<int, bool, string>>();


        }
    }
}

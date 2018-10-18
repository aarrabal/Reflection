using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReflectionUnitTest
{
    /// <summary>
    /// Descripción resumida de ReflectionGenericos
    /// </summary>
    /// 
    /// 

    public interface IGenerico
    {

    }


    public class GenericClass1 : IGenerico
    {
        public string Campo { get; set; }
    }

    public class GenericClass2 : IGenerico
    {
        public string Campo { get; set; }
    }
    public class GenericClass3 : IGenerico
    {
        public string Campo { get; set; }
    }

    public class ObjectClassReturn<T> where T : IGenerico
    {
        public List<T> Coleccion { get; set; }

        public void SetColeccion(List<T> lista) 
        {
            Coleccion = lista;
        }
    }

    [TestClass]
    public class ReflectionGenericos
    {

        [TestMethod]
        public void TestMethod1()
        {
         var lista1 = new List<GenericClass1>();
         var lista2 = new List<GenericClass2>();
         var lista3 = new List<GenericClass3>();
        
            lista1.Add(new GenericClass1 {Campo = "campoPrueba1.1"});
            lista1.Add(new GenericClass1 {Campo = "campoPrueba1.2"});
            lista1.Add(new GenericClass1 {Campo = "campoPrueba1.3"});

            lista2.Add(new GenericClass2 {Campo = "campoPrueba2.1"});
            lista2.Add(new GenericClass2 {Campo = "campoPrueba2.2"});
            lista2.Add(new GenericClass2 {Campo = "campoPrueba2.3"});

            lista3.Add(new GenericClass3 {Campo = "campoPrueba3.1"});
            lista3.Add(new GenericClass3 {Campo = "campoPrueba3.2"});
            lista3.Add(new GenericClass3 {Campo = "campoPrueba3.3"});

        var instancia = new ObjectClassReturn<GenericClass1>();
            instancia.Coleccion = lista1;
        var instancia2 = new ObjectClassReturn<GenericClass2>();
            instancia2.Coleccion = lista2;
        var instancia3 = new ObjectClassReturn<GenericClass3>();
            instancia3.Coleccion = lista3;
        //var instanciaEnteros = new ObjectClassReturn<int>();
           Assert.AreEqual(lista1, instancia.Coleccion); 

        }
    }
}

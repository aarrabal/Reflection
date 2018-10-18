using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReflectionUnitTest
{
	/// <summary>
	/// Descripción resumida de Reflection
	/// </summary>
	[TestClass]
	public class GenericoCalcularColumna
	{

		[TestMethod]
		public void TestMethod1()
		{
			var triangulo = new Triangulo {Altura = 2, Base = 2};
            var circulo = new Circulo {Radio = 4};
            var cuadrado = new Cuadrado {Altura = 2, Base = 2};

            var instancia = new Columna<Triangulo>(2, triangulo);
            var instancia2 = new Columna<Circulo>(3, circulo);
            var instancia3 = new Columna<Cuadrado>(5, cuadrado);

		    
            Debug.WriteLine(instancia.CalcularVolumen());
		    Debug.WriteLine(instancia2.CalcularVolumen());
		    Debug.WriteLine(instancia3.CalcularVolumen());
            

		}
        
	}
}

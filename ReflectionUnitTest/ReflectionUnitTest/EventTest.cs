using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReflectionUnitTest
{
    /// <summary>
    /// Descripción resumida de EventTest
    /// </summary>
    [TestClass]
    public class EventTest
    {
        public EventTest()
        {
           
        }

        [TestMethod]
        public void TestMethod1()
        {
            var target = new Imprenta();
            target.Suscripcion += RecibirRevista;
            target.Publicacion(1);
            var target2 = new Imprenta();
            target2.Suscripcion += RecibirRevista;
            
            target2.Publicacion(2);

        }

        private void RecibirRevista(object sender, Revista e)
        {
            var numRevista = e.Entero;
        }
    }

    public class Imprenta
    {
        public Imprenta()
        {
            
        }

        public event EventHandler<Revista> Suscripcion;
     

        public void Publicacion(int entero)
        {
           if(Suscripcion!=null) Suscripcion.Invoke(this, new Revista() {Entero = entero, });
        }
    }

    

    public class Revista: EventArgs
    {
        public int Entero { get; set; }
        public DateTime Fecha{ get; set; }
    }
}

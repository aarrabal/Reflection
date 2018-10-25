using System;
using System.Text;
using System.Collections.Generic;
using EnsambladoExterno;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prism.Events;

namespace ReflectionUnitTest
{
    /// <summary>
    /// Descripción resumida de EventTest
    /// </summary>
    [TestClass]
    public class EventTestPropio
    {


        public EventTestPropio()
        {

        }


        //EventHandler = maneja el evento.
        //EventArgs = argumentos.
        [TestMethod]
        public void TestMethod1()
        {
            var target = new Empresa();

            //Nos suscribimos al evento,
            target.Suscripcion += RecibirJuego;
            target.EntregaJueog(1);
           

        }

       
        //Metodo que dispara el evento
        private void RecibirJuego(object sender, Juegos argumentos)
        {
            var NumeroJuego = argumentos.Entero;
        }
    }

    public class Empresa
    {
        public Empresa()
        {
        }
        //Declaracion del evento.
        public EventHandler<Juegos> Suscripcion;

        public void EntregaJueog(int entero)
        {
            if (Suscripcion != null)
            {
                Suscripcion.Invoke(this, new Juegos() { Entero = entero});
            }
        }
    }

    //Argumentos del evento
    public class Juegos : EventArgs
    {

        public int Entero { get; set; }
    }
}

     
    
    


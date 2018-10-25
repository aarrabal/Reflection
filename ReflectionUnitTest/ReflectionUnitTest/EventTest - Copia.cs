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
    public class EventTest2
    {
       
            
        public EventTest2()
        {
           
        }

        [TestMethod]
        public void TestMethod1()
        {
            var target = new EventAggregator();
            var clase1 = new ClaseUno(target);
           
            target.GetEvent<Evento>().Publish();
            target.GetEvent<Evento>().Unsubscribe(() => { });
            var clase2 = new ClaseDos(target);
        }

      
    }

    public class ClaseUno
    {
        public ClaseUno(EventAggregator eventAggregator)
        {
            var evento = eventAggregator.GetEvent<Evento>();
            evento.Subscribe(() => { });
            evento.Subscribe(Action);
            evento.Subscribe(delegate {  });
        }

        private void Action()
        {
           
        }
    }

    
    public class ClaseDos
    {
        public ClaseDos(EventAggregator eventAggregator)
        {
            var evento = eventAggregator.GetEvent<Evento>();
            evento.Subscribe(() => { });
            evento.Subscribe(Action);
            evento.Subscribe(delegate {  });
        }

        private void Action()
        {
           
        }
    }

    public class Evento : PubSubEvent
    {
    }
}

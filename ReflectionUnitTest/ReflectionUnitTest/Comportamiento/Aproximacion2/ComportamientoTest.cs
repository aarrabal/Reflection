using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReflectionUnitTest.Comportamiento.Aproximacion2
{
    /// <summary>
    /// Descripción resumida de ComportamientoTest
    /// </summary>
    [TestClass]
    public class ComportamientoTest
    {
        public ComportamientoTest()
        {
          
        }
        /// <summary>
        /// Como usuario administrador quiero:
        /// - Dar de alta una persona o agente en la cual se tienen que cumplir las siguientes reglas:
        /// 1. DNI: no puede ser nulo
        /// 2. El Dni debe ser autogenerado.
        /// 3. El tip del agente no puede ser nulo.
        /// 4. Debe comprobarse de que existe la persona o el agente antes de intentar guardarlo.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var target = new Persona();
            var targetAgente = new Agente();
            var validations = new Validations();
            var appRules = new AppRules();
            appRules.Add(target);
            
        }
    }

    public class AppRules
    {
        public void Add(Persona persona)
        {
           var validar = new Validations();
            validar.Validar(persona);
            var rep = new Repositorio();
            rep.FindExists(persona);
        }
        

    }

  

}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamarack.Pipeline;

namespace ReflectionUnitTest.Comportamiento.Aproximacion1
{
    /// <summary>
    /// Descripción resumida de ComportamientoTest
    /// </summary>
    [TestClass]
    public class ComportamientoTest2
    {
        public ComportamientoTest2()
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
            var chain = new Pipeline<Context, bool>();
            chain.Add(new Validations());
            chain.Add(new RepositoryChain());
            chain.Execute(new Context(new Persona()));

        }
    }
}

using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReflectionUnitTest.Modelo
{
    [TestClass]
    public class Clase
    {
        private string propiedadPrivada { get; set; }

        private int _campoPrivado;

        [XmlIgnore]
        public string PropiedadPublica { get; set; }
        internal string PropiedadInternal{ get; set; }

        public string CampoPublico;
        
        internal string campoInterno;
        public int edad;

        protected string CampoProtected;
        protected string PropiedadProtected { get; set; }

        private void MetodoPrivado() { }
        internal void MetodoInternal() { }

        protected void MetodoProtected(){}

        public string MetodoPublico()
        {
            return nameof(Clase.MetodoPublico);

        }

        public Clase()
        {
           
        }
        private Clase(string hola, bool siono) { }

        public Clase(string campoPublico)
        {
            this.CampoPublico = campoPublico;
        }

        public Clase(string campoPublic, string campoInterno)
        {
           
        }
        public Clase (int edad, string campoPublic)
        {
            
        }
    }
}
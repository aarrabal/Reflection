namespace EnsambladoExterno
{
    public class Clase1
    {
        private string propiedadPrivada { get; set; }

        private int _campoPrivado;

        public string PropiedadPublica { get; set; }
        internal string PropiedadInternal{ get; set; }

        public string CampoPublico;

        internal string campoInterno;

        protected string CampoProtected;
        protected string PropiedadProtected { get; set; }

        private void MetodoPrivado() { }
        internal void MetodoInternal() { }

        protected void MetodoProtected(){}

        public void MetodoPublico()
        {
        }

    }


}

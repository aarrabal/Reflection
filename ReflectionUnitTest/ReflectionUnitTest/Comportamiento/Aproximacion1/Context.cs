namespace ReflectionUnitTest.Comportamiento.Aproximacion1
{
    public class Context
    {
        public Persona persona { get; set; }
        public Repositorio repository { get; set; }

        public Context(Persona persona)
        {
            repository = new Repositorio();
            persona = new Persona();
        }
    }
}
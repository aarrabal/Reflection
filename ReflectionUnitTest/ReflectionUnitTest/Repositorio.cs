using ReflectionUnitTest.Comportamiento;

namespace ReflectionUnitTest
{
    public class Repositorio
    {
        public bool FindExists(Persona persona)
        {
            if (persona == null) return false;
            return true;
        }

        public void Add(Persona persona)
        {
           
        }
    }
}
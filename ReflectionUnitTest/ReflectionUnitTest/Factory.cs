using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionUnitTest.Comportamiento;

namespace ReflectionUnitTest
{
    public static class Factory
    {
        public static Persona CreatePersona()
        {
            return new Persona();
        }

        public static Persona CreatePersona(string nombre)
        {
            return new Persona(nombre);
        }
    }
}

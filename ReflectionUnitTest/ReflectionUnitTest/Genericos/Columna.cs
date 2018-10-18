using System.Dynamic;

namespace ReflectionUnitTest
{
    public class Columna<T> : IVolumen where T : IArea
    {
        public T Forma { get; set; }

        public double Altura { get; set; }

        public Columna(double altura, T forma)
        {
            this.Altura = altura;
            Forma = forma;
        }
        public double CalcularVolumen()
        {
            return Altura * Forma.CalcularArea();
        }
    }
}
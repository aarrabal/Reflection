namespace ReflectionUnitTest
{
    public class Triangulo : IArea
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return (Altura * Base)/2;
        }
    }
}
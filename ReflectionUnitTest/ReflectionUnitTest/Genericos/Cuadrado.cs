namespace ReflectionUnitTest
{
    public class Cuadrado: IArea
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double CalcularArea()
        {
            return Altura * Base;
        }
    }
}
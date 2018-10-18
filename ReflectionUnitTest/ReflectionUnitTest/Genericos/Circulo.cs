using System;

namespace ReflectionUnitTest
{
    public class Circulo: IArea
    {
        public double Radio { get; set; }
        public double CalcularArea()
        {
            return (Math.PI * Math.Pow(Radio, 2));
        }
    }
}
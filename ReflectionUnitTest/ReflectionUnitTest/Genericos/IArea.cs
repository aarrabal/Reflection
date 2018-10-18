using System.Runtime.InteropServices;
using System.Security.Policy;

namespace ReflectionUnitTest
{

    public interface IArea
    {

        double CalcularArea();
    }

    public interface IVolumen
    {
        double CalcularVolumen();
    }
}
namespace ReflectionUnitTest
{
    public class Salida2 : ISalidaDictionary
    {
        public TipoDeEntrada tipoDeEntrada()
        {
            return TipoDeEntrada.Entrada2;
        }

        public string GetTexto()
        {
            return "SalidaTipo2";
        }
    }
}
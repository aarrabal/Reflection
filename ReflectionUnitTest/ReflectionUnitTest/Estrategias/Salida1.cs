namespace ReflectionUnitTest
{
    public class Salida1 : ISalidaDictionary
    {
        public TipoDeEntrada tipoDeEntrada()
        {
            return TipoDeEntrada.Entrada1;
        }

        public string GetTexto()
        {
            return "SalidaTipo1";
        }
    }
}
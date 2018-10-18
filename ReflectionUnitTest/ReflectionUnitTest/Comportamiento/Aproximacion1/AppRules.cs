using Tamarack.Pipeline;

namespace ReflectionUnitTest.Comportamiento.Aproximacion1
{
    /// <summary>
    /// Dar de alta una persona cumpliendo reglas
    /// </summary>
    public class AppRules
    {
        public void Add(Persona persona)
        {
            var validar = new Validations();
            validar.Validar(persona);
            var rep = new Repositorio();
            rep.Add(persona);
        }

        public void Add2(Persona persona
        )
        {
            var chain = new Pipeline<Context, bool>();
            chain.Add(new Validations());
            chain.Add(new RepositoryChain());
            chain.Execute(new Context(persona));
        }

        public void Add3()
        {
            var persona = new Persona();
            var agente = new Agente();
            agente.Tip.Check();
             this.Valida()
                 .Add();

        }
    }

    public static class intExtension
    {
        public static bool Check(this int context)
        {
            return true;
        }
    }

    
    public static class AppRulesExtension
    {
        public static AppRules Valida(this AppRules context)
        {
            return context;
        }

        public static AppRules Add(this AppRules context)
        {

            return context;
        }
    }
}
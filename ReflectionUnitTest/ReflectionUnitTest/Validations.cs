using System;
using ReflectionUnitTest.Comportamiento;
using ReflectionUnitTest.Comportamiento.Aproximacion1;
using Tamarack.Pipeline;

namespace ReflectionUnitTest
{
    public interface IValidations
    {
        bool ValidarDni(Persona persona);
        bool ExisteEnRepositorio(Persona persona, Agente agent);
        bool ValidatTip(Agente agent);

    }

    public interface IValidationG<T> where T : Persona
    {
        bool ValidarDni(T persona);
        bool ExisteEnRepositorio(T persona);
        bool ValidatTip(T persona);

    }
    

    public class Validations : IValidationG<Persona>, IFilter<Context, bool>
    {
        private  Context _context;
        public bool Validar(Persona persona)
        {
            return ValidarDni(persona) && ExisteEnRepositorio(persona) && ValidatTip(persona);
        }


        public bool ValidarDni(Persona persona)
        {
            return persona.Dni != null && Helper.CheckDni(persona.Dni);
        }

        public bool ExisteEnRepositorio(Persona persona)
        {
            
           
            return _context.repository.FindExists(persona);
        }

        public bool ValidatTip(Persona persona)
        {
            var agente = persona as Agente;
            return agente?.Tip != null && Helper.CheckTip(agente.Tip);
        }

        public bool Execute(Context context, Func<Context, bool> executeNext)
        {
            Validar(context.persona);
            return executeNext(context);
        }
    }

    public static class Helper
    {
        public static bool CheckDni(IDocumentoIdentificacion personaDni)
        {
            return true;
        }
        public static bool CheckTip(int agenteTip)
        {
            return true;
        }
    }
}
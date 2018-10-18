using System;
using Tamarack.Pipeline;

namespace ReflectionUnitTest.Comportamiento.Aproximacion1
{
    public class RepositoryChain : IFilter<Context, bool>
    {
        public bool Execute(Context context, Func<Context, bool> executeNext)
        {
            context.repository.Add(context.persona);
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReflectionUnitTest
{
    public static class HelperStrategy
    {
        public static IEnumerable<Type> GetSalidasDictionary()
        {
 
            var type = typeof(ISalidaDictionary);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);
            return types;
        }
    }
}
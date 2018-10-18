using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionUnitTest.Modelo
{
    public class Singleton
    {
        private static Singleton _instance = null;
 
        private Singleton() {}

        public string Prueba { get; set; }

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();
 
            return _instance;
        }
    }
    
}

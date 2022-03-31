using System;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //var singleton = Singleton.singlenton.Instance;
            var log = Singleton.Log.Instance;
            log.Save("Hola mundo desde c# escribiendo en archivo de texto");
            log.Save("segunda linea escribiendo desde .net5");
        }
    }
}

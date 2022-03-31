using System;
using System.IO;

namespace Tools
{
    public sealed class Log
    {
        //sealed quiere decir no se puede heredar 
        private  static Log _instance = null;
        private string _path;
        private static object _protect = new object();



       public static Log GetInstance(string path)
        {

            /*
             *Esto nos protege de que se cree nuevas instancias nulas
             *lo cual sera asincrono y esperera que se cree el objeto 
             *actual y despues creara el siguiente,
             *tambien esto esta protegido para trabajar con hilos
             */
            lock(_protect){
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }
           
            return _instance;
        }

        private Log(string path) 
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }

    }
}

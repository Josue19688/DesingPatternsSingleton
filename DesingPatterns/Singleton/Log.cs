using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Singleton
{
    public class Log
    {
        //creamos el objeto que va ser de tipo privado no es accesible de otra
        //clase
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";

        /*Este metodo nos permitira obtener el objeto
         * mas no editarlo desde otra clase o archivo
         */
        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        /*Este constructor de tipo privado nos protegera 
         * de poder crear otros objetos de esta clase en otro lado
         */
        private Log() { }

        public void Save(string message)
        {
            /*Con el metodo file agregamos la ruta y el texto que queremos 
             escribir en el archivo
            y con enviroment.NewLIne agregamos un salto de linea*/
            File.AppendAllText(_path, message+Environment.NewLine);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Singleton
{
    public class singlenton
    {
        private readonly static singlenton _instance = new singlenton();

        public static singlenton Instance
        {
            get
            {
                return _instance;
            }
        }
        private singlenton() { }
    }
}

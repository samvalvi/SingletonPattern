using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Pattern
{
    public class Singleton
    {
        //Solo pude existir un objeto en toda la app.
        private readonly static Singleton _instace = new Singleton();

        public static Singleton Instance
        {
            get
            {
                return _instace;
            }
        }

        private Singleton()
        {

        }
    }
}

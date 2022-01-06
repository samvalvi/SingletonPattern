using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Pattern
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";
        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }
        //No permite crear otros obejtos de esta clase 
        private Log()
        {

        }

        public void Save(string msg)
        {
            File.AppendAllText(_path, msg + Environment.NewLine);
        }

    }
}

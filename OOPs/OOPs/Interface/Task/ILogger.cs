using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Interface.Task
{
    //7.Create a logging system that can log messages to different destinations.
    internal interface ILogger
    {
        void Log(string message);
    }

    public class FileClass: ILogger
    {
        public void Log(string message) 
        {
            Console.WriteLine(message);
        }
    }
    public class DocumentClass : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Email : ILogger
    { 
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

}

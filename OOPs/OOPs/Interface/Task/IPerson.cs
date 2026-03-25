using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Interface.Task
{
    internal interface IPerson
    {
        void PersonIntro(string name);
    }

    public class Manager:IPerson
    { 
        public void PersonIntro(string name) 
        {
            Console.WriteLine($"{name} is a Manager");
        }
    }

    public class HR:IPerson
    {
        public void PersonIntro(string name)
        {
            Console.WriteLine($"{name} is a HR");
        }
    }

    public class BackendDeveloper : IPerson
    {
        public void PersonIntro(string name)
        {
            Console.WriteLine($"{name} is a Backend Developer");
        }
    }

    public class FrontendDeveloper : IPerson
    {
        public void PersonIntro(string name)
        {
            Console.WriteLine($"{name} is a Frontend Developer");
        }
    }

}
